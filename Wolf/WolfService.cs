namespace Servers;

using Grpc.Core;

using Services;

public class WolfService : Services.Wolf.WolfBase
{
    //singleton call to wolfLogic
    private readonly WolfLogic wolfLogic = new WolfLogic();

    public override Task<IntMsg> EnterWolfArea(Services.RabbitDesc input, ServerCallContext context )
    {
        var rabbit =
            new RabbitDesc {
                RabbitID = input.RabbitID,
                RabbitName = input.RabbitName,
                Weight = input.Weight,
                DistanceToWolf = input.DistanceToWolf,
                IsRabbitAlive = input.IsRabbitAlive
            };

            var logicResult = wolfLogic.EnterWolfArea(rabbit);

            var result = new IntMsg { Value = logicResult };

        return Task.FromResult(result);
    }

    public override Task<IntMsg> SpawnWaterNearWolf(WaterDesc input, ServerCallContext context)
    {
        var water =
            new WaterDesc {
                WaterID = input.WaterID,
                Volume = input.Volume,
                X = input.X,
                Y = input.Y
            };

        var LogicResult = wolfLogic.SpawnWaterNearWolf(water);

        var result = new IntMsg { Value = LogicResult };

        return Task.FromResult(result);
    }

    public override Task<Empty> UpdateRabbitDistanceToWolf(RabbitDesc input, ServerCallContext context)
    {
        var result = new Empty {};

        return Task.FromResult(result);
    }

    public override Task<BoolMsg> IsRabbitAlive(RabbitDesc input, ServerCallContext context)
    {
         var rabbit =
            new RabbitDesc {
                RabbitID = input.RabbitID,
                RabbitName = input.RabbitName,
                Weight = input.Weight,
                DistanceToWolf = input.DistanceToWolf,
                IsRabbitAlive = input.IsRabbitAlive
            };

            var logicResult = wolfLogic.IsRabbitAlive(rabbit);

            var result = new BoolMsg { Value = logicResult };

        return Task.FromResult(result);
    }

    public override Task<BoolMsg> IsWaterAlive(WaterDesc input, ServerCallContext context)
    {
        var water =
            new WaterDesc {
                WaterID = input.WaterID,
                Volume = input.Volume,
                X = input.X,
                Y = input.Y
            };

        var LogicResult = wolfLogic.IsWaterAlive(water);

        var result = new BoolMsg { Value = LogicResult };

        return Task.FromResult(result);
    }
}