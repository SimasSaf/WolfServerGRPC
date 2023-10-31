namespace Servers;

using System.Net;

using NLog;

public class Server
{
	Logger log = LogManager.GetCurrentClassLogger();

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

	public static void Main(string[] args)
    {
        var self = new Server();
        self.Run(args);
    }

    private void Run(string[] args)
    {
        ConfigureLogging();

        log.Info("Starting Server...");

        StartServer(args);
    }

	private void StartServer(string[] args)
    {
		//create web app builder
		var builder = WebApplication.CreateBuilder(args);

		//configure integrated server
		builder.WebHost.ConfigureKestrel(opts => {
			opts.Listen(IPAddress.Loopback, 5030);
		});


		//add support for GRPC services
		builder.Services.AddGrpc();

		//add the actual services
		builder.Services.AddSingleton(new WolfService());	

		//build the server
		var app = builder.Build();

		//turn on request routing
		app.UseRouting();

		//configure routes
		app.MapGrpcService<WolfService>();
		
		//run the server
		app.Run();
    }
}