// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/subscription.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TiEventsy.SubscriptionGrpcService.Protos {
  public static partial class SubscriptionOperations
  {
    static readonly string __ServiceName = "subscription.SubscriptionOperations";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Protobuf.WellKnownTypes.Empty.Parser));
    static readonly grpc::Marshaller<global::TiEventsy.SubscriptionGrpcService.Protos.AccountId> __Marshaller_subscription_AccountId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TiEventsy.SubscriptionGrpcService.Protos.AccountId.Parser));
    static readonly grpc::Marshaller<global::TiEventsy.SubscriptionGrpcService.Protos.ListSubId> __Marshaller_subscription_ListSubId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TiEventsy.SubscriptionGrpcService.Protos.ListSubId.Parser));
    static readonly grpc::Marshaller<global::TiEventsy.SubscriptionGrpcService.Protos.SubId> __Marshaller_subscription_SubId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TiEventsy.SubscriptionGrpcService.Protos.SubId.Parser));

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_NewAccountSubscriptions = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewAccountSubscriptions",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.AccountId, global::TiEventsy.SubscriptionGrpcService.Protos.ListSubId> __Method_GetAccountSubscriptions = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.AccountId, global::TiEventsy.SubscriptionGrpcService.Protos.ListSubId>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountSubscriptions",
        __Marshaller_subscription_AccountId,
        __Marshaller_subscription_ListSubId);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::TiEventsy.SubscriptionGrpcService.Protos.AccountId> __Method_GetAccountId = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::TiEventsy.SubscriptionGrpcService.Protos.AccountId>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAccountId",
        __Marshaller_subscription_SubId,
        __Marshaller_subscription_AccountId);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty> __Method_NewSubscription = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewSubscription",
        __Marshaller_subscription_SubId,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSubscription = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSubscription",
        __Marshaller_subscription_SubId,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TiEventsy.SubscriptionGrpcService.Protos.SubscriptionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SubscriptionOperations</summary>
    [grpc::BindServiceMethod(typeof(SubscriptionOperations), "BindService")]
    public abstract partial class SubscriptionOperationsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> NewAccountSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TiEventsy.SubscriptionGrpcService.Protos.ListSubId> GetAccountSubscriptions(global::TiEventsy.SubscriptionGrpcService.Protos.AccountId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TiEventsy.SubscriptionGrpcService.Protos.AccountId> GetAccountId(global::TiEventsy.SubscriptionGrpcService.Protos.SubId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> NewSubscription(global::TiEventsy.SubscriptionGrpcService.Protos.SubId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSubscription(global::TiEventsy.SubscriptionGrpcService.Protos.SubId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SubscriptionOperationsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_NewAccountSubscriptions, serviceImpl.NewAccountSubscriptions)
          .AddMethod(__Method_GetAccountSubscriptions, serviceImpl.GetAccountSubscriptions)
          .AddMethod(__Method_GetAccountId, serviceImpl.GetAccountId)
          .AddMethod(__Method_NewSubscription, serviceImpl.NewSubscription)
          .AddMethod(__Method_DeleteSubscription, serviceImpl.DeleteSubscription).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SubscriptionOperationsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_NewAccountSubscriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.NewAccountSubscriptions));
      serviceBinder.AddMethod(__Method_GetAccountSubscriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Protos.AccountId, global::TiEventsy.SubscriptionGrpcService.Protos.ListSubId>(serviceImpl.GetAccountSubscriptions));
      serviceBinder.AddMethod(__Method_GetAccountId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::TiEventsy.SubscriptionGrpcService.Protos.AccountId>(serviceImpl.GetAccountId));
      serviceBinder.AddMethod(__Method_NewSubscription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.NewSubscription));
      serviceBinder.AddMethod(__Method_DeleteSubscription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSubscription));
    }

  }
}
#endregion
