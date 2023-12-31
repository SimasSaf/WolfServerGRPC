// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/service.proto
// </auto-generated>
// Original file comments:
// set the language version
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Services {
  /// <summary>
  ///this will translate into service and service client stubs
  /// </summary>
  public static partial class Wolf
  {
    static readonly string __ServiceName = "Services.Wolf";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Services.RabbitDesc> __Marshaller_Services_RabbitDesc = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Services.RabbitDesc.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Services.IntMsg> __Marshaller_Services_IntMsg = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Services.IntMsg.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Services.WaterDesc> __Marshaller_Services_WaterDesc = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Services.WaterDesc.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Services.Empty> __Marshaller_Services_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Services.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Services.BoolMsg> __Marshaller_Services_BoolMsg = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Services.BoolMsg.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Services.RabbitDesc, global::Services.IntMsg> __Method_EnterWolfArea = new grpc::Method<global::Services.RabbitDesc, global::Services.IntMsg>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EnterWolfArea",
        __Marshaller_Services_RabbitDesc,
        __Marshaller_Services_IntMsg);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Services.WaterDesc, global::Services.IntMsg> __Method_SpawnWaterNearWolf = new grpc::Method<global::Services.WaterDesc, global::Services.IntMsg>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SpawnWaterNearWolf",
        __Marshaller_Services_WaterDesc,
        __Marshaller_Services_IntMsg);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Services.RabbitDesc, global::Services.Empty> __Method_UpdateRabbitDistanceToWolf = new grpc::Method<global::Services.RabbitDesc, global::Services.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateRabbitDistanceToWolf",
        __Marshaller_Services_RabbitDesc,
        __Marshaller_Services_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Services.RabbitDesc, global::Services.BoolMsg> __Method_IsRabbitAlive = new grpc::Method<global::Services.RabbitDesc, global::Services.BoolMsg>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsRabbitAlive",
        __Marshaller_Services_RabbitDesc,
        __Marshaller_Services_BoolMsg);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Services.WaterDesc, global::Services.BoolMsg> __Method_IsWaterAlive = new grpc::Method<global::Services.WaterDesc, global::Services.BoolMsg>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsWaterAlive",
        __Marshaller_Services_WaterDesc,
        __Marshaller_Services_BoolMsg);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Services.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Wolf</summary>
    [grpc::BindServiceMethod(typeof(Wolf), "BindService")]
    public abstract partial class WolfBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Services.IntMsg> EnterWolfArea(global::Services.RabbitDesc request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Services.IntMsg> SpawnWaterNearWolf(global::Services.WaterDesc request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Services.Empty> UpdateRabbitDistanceToWolf(global::Services.RabbitDesc request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Services.BoolMsg> IsRabbitAlive(global::Services.RabbitDesc request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Services.BoolMsg> IsWaterAlive(global::Services.WaterDesc request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WolfBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_EnterWolfArea, serviceImpl.EnterWolfArea)
          .AddMethod(__Method_SpawnWaterNearWolf, serviceImpl.SpawnWaterNearWolf)
          .AddMethod(__Method_UpdateRabbitDistanceToWolf, serviceImpl.UpdateRabbitDistanceToWolf)
          .AddMethod(__Method_IsRabbitAlive, serviceImpl.IsRabbitAlive)
          .AddMethod(__Method_IsWaterAlive, serviceImpl.IsWaterAlive).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WolfBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_EnterWolfArea, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Services.RabbitDesc, global::Services.IntMsg>(serviceImpl.EnterWolfArea));
      serviceBinder.AddMethod(__Method_SpawnWaterNearWolf, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Services.WaterDesc, global::Services.IntMsg>(serviceImpl.SpawnWaterNearWolf));
      serviceBinder.AddMethod(__Method_UpdateRabbitDistanceToWolf, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Services.RabbitDesc, global::Services.Empty>(serviceImpl.UpdateRabbitDistanceToWolf));
      serviceBinder.AddMethod(__Method_IsRabbitAlive, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Services.RabbitDesc, global::Services.BoolMsg>(serviceImpl.IsRabbitAlive));
      serviceBinder.AddMethod(__Method_IsWaterAlive, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Services.WaterDesc, global::Services.BoolMsg>(serviceImpl.IsWaterAlive));
    }

  }
}
#endregion
