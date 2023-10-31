namespace Clients;

using NLog;
using Grpc.Net.Client;

using Services;

class Client
{
    private readonly WaterDesc water = new WaterDesc();

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
				var channel = GrpcChannel.ForAddress("http://127.0.0.1:5030");
				var wolf = new Wolf.WolfClient(channel);

                InitializeWater(wolf);

                while(true)
                {
                    while(wolf.IsWaterAlive(water).Value)
                    {
                        mLog.Info("~~~~~~~~~~~~~~~~~");
                        //Checks every 0.5s
                        Thread.Sleep(500);
                    }

                    mLog.Info("The water is empty");
                    Thread.Sleep(5000);
                    InitializeWater(wolf);
                }

            }
            catch (Exception err)
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

    private void InitializeWater(Wolf.WolfClient wolf)
    {
        water.Volume = rng.Next(0, 10);
        water.X = rng.Next(-50, 50);
        water.Y = rng.Next(-50, 50);
        water.WaterID = wolf.SpawnWaterNearWolf(water).Value;
    }
}