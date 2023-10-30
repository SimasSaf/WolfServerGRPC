namespace Clients;

using RandomNameGeneratorLibrary;

using NLog;
using Grpc.Net.Client;

using Services;
using Grpc.Core;

class Client
{
    private readonly RabbitDesc rabbit = new RabbitDesc();
    private readonly Random rng = new Random();

    Logger mLog = LogManager.GetCurrentClassLogger();

	private void ConfigureLogging()
	{
		var config = new NLog.Config.LoggingConfiguration();

		var console =
			new NLog.Targets.ConsoleTarget("console")
			{
				Layout = @"${date:format=HH\:mm\:ss}|${level}| ${message} ${exception}"
			};
		config.AddTarget(console);
		config.AddRuleForAllLevels(console);

		LogManager.Configuration = config;
	}

   private void Run() 
{
    ConfigureLogging();

    while(true)
    {
        try
        {
            //connect to the server, get service proxy
            var channel = GrpcChannel.ForAddress("http://127.0.0.1:5000");
            var wolf = new Wolf.WolfClient(channel);

            if(wolf != null)
            {
                InitializeRabbit(wolf);
            }

            while(true)
            {
                mLog.Info(wolf.IsRabbitAlive(rabbit));
                while(wolf.IsRabbitAlive(rabbit).Value)
                {
                    rabbit.DistanceToWolf = rng.Next(1, 100);
                    wolf.UpdateRabbitDistanceToWolf(rabbit);
                    mLog.Info($"The Rabbit is {rabbit.DistanceToWolf}m away");
                    Thread.Sleep(3000);
                }

                mLog.Info("Rabbit has died RIP");
                Thread.Sleep(5000);
                InitializeRabbit(wolf);
            }
        }
        catch (RpcException rpcEx)
        {
            mLog.Error($"gRPC Error: {rpcEx.Status.Detail}");
            Thread.Sleep(3000);
        }
        catch(Exception err)
        {
            mLog.Error("Error has occured...", err);
            Thread.Sleep(3000);
        }
    }
}


    static void Main(string[] args)
	{
		var self = new Client();
		self.Run();
	}

    private void InitializeRabbit(Wolf.WolfClient wolf)
    {
        var personGenerator = new PersonNameGenerator();

        rabbit.RabbitName = personGenerator.GenerateRandomFirstAndLastName();
        rabbit.Weight = rng.Next(0, 10);
        rabbit.IsRabbitAlive = true;
        rabbit.DistanceToWolf = 1000;
        rabbit.RabbitID = wolf.EnterWolfArea(rabbit).Value;

        mLog.Info($"{rabbit.RabbitName} ({rabbit.Weight}) the Rabbit is born! #{rabbit.RabbitID}");
    }

    
}