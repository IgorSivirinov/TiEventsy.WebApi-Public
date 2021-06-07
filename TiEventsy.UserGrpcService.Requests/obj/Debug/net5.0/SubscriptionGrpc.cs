// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: subscription.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TiEventsy.SubscriptionGrpcService.Requests.Protos {
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
    static readonly grpc::Marshaller<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId> __Marshaller_subscription_UserId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId.Parser));
    static readonly grpc::Marshaller<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId> __Marshaller_subscription_ListSubId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId.Parser));
    static readonly grpc::Marshaller<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId> __Marshaller_subscription_SubId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId.Parser));

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_NewUserSubscriptions = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewUserSubscriptions",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId> __Method_GetUserSubscriptions = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserSubscriptions",
        __Marshaller_subscription_UserId,
        __Marshaller_subscription_ListSubId);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId> __Method_GetUserId = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetUserId",
        __Marshaller_subscription_SubId,
        __Marshaller_subscription_UserId);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty> __Method_NewSubscription = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "NewSubscription",
        __Marshaller_subscription_SubId,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSubscription = new grpc::Method<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSubscription",
        __Marshaller_subscription_SubId,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubscriptionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SubscriptionOperations</summary>
    [grpc::BindServiceMethod(typeof(SubscriptionOperations), "BindService")]
    public abstract partial class SubscriptionOperationsBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> NewUserSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId> GetUserSubscriptions(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId> GetUserId(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> NewSubscription(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSubscription(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SubscriptionOperations</summary>
    public partial class SubscriptionOperationsClient : grpc::ClientBase<SubscriptionOperationsClient>
    {
      /// <summary>Creates a new client for SubscriptionOperations</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SubscriptionOperationsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SubscriptionOperations that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SubscriptionOperationsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SubscriptionOperationsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SubscriptionOperationsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty NewUserSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NewUserSubscriptions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty NewUserSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NewUserSubscriptions, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> NewUserSubscriptionsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NewUserSubscriptionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> NewUserSubscriptionsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NewUserSubscriptions, null, options, request);
      }
      public virtual global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId GetUserSubscriptions(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserSubscriptions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId GetUserSubscriptions(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserSubscriptions, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId> GetUserSubscriptionsAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserSubscriptionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId> GetUserSubscriptionsAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserSubscriptions, null, options, request);
      }
      public virtual global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId GetUserId(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId GetUserId(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserId, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId> GetUserIdAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetUserIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId> GetUserIdAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserId, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty NewSubscription(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NewSubscription(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty NewSubscription(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_NewSubscription, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> NewSubscriptionAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return NewSubscriptionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> NewSubscriptionAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_NewSubscription, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteSubscription(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSubscription(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteSubscription(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteSubscription, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSubscriptionAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSubscriptionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSubscriptionAsync(global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteSubscription, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SubscriptionOperationsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SubscriptionOperationsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SubscriptionOperationsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_NewUserSubscriptions, serviceImpl.NewUserSubscriptions)
          .AddMethod(__Method_GetUserSubscriptions, serviceImpl.GetUserSubscriptions)
          .AddMethod(__Method_GetUserId, serviceImpl.GetUserId)
          .AddMethod(__Method_NewSubscription, serviceImpl.NewSubscription)
          .AddMethod(__Method_DeleteSubscription, serviceImpl.DeleteSubscription).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SubscriptionOperationsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_NewUserSubscriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.NewUserSubscriptions));
      serviceBinder.AddMethod(__Method_GetUserSubscriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.ListSubId>(serviceImpl.GetUserSubscriptions));
      serviceBinder.AddMethod(__Method_GetUserId, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::TiEventsy.SubscriptionGrpcService.Requests.Protos.UserId>(serviceImpl.GetUserId));
      serviceBinder.AddMethod(__Method_NewSubscription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.NewSubscription));
      serviceBinder.AddMethod(__Method_DeleteSubscription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TiEventsy.SubscriptionGrpcService.Requests.Protos.SubId, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSubscription));
    }

  }
}
#endregion