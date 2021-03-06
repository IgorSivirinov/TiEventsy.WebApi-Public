// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/user.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TiEventsy.UserGrpcService.Requests.Protos {

  /// <summary>Holder for reflection information generated from Protos/user.proto</summary>
  public static partial class UserReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/user.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b3MvdXNlci5wcm90bxIEdXNlchobZ29vZ2xlL3Byb3RvYnVmL2Vt",
            "cHR5LnByb3RvIhQKBlVzZXJJZBIKCgJpZBgBIAEoCSJLCg5QdWJsaWNVc2Vy",
            "RGF0YRIMCgRuYW1lGAEgASgJEhEKCXVyaV9pbWFnZRgCIAEoCRIYChBteV90",
            "aW1ldGFibGVfaWRzGAMgAygJInwKD1ByaXZhdGVVc2VyRGF0YRIMCgRuYW1l",
            "GAEgASgJEg0KBWVtYWlsGAMgASgJEhEKCXVyaV9pbWFnZRgEIAEoCRIYChBt",
            "eV90aW1ldGFibGVfaWRzGAUgAygJEh8KF3RpbWV0YWJsZV9zdWJzY3JpcHRp",
            "b25zGAYgAygJMocCCg5Vc2VyT3BlcmF0aW9ucxI5CgdOZXdVc2VyEhYuZ29v",
            "Z2xlLnByb3RvYnVmLkVtcHR5GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5EjwK",
            "CkRlbGV0ZVVzZXISFi5nb29nbGUucHJvdG9idWYuRW1wdHkaFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkSNwoRR2V0UHVibGljVXNlckRhdGUSDC51c2VyLlVz",
            "ZXJJZBoULnVzZXIuUHVibGljVXNlckRhdGESQwoSR2V0UHJpdmF0ZVVzZXJE",
            "YXRlEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GhUudXNlci5Qcml2YXRlVXNl",
            "ckRhdGFCLKoCKVRpRXZlbnRzeS5Vc2VyR3JwY1NlcnZpY2UuUmVxdWVzdHMu",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TiEventsy.UserGrpcService.Requests.Protos.UserId), global::TiEventsy.UserGrpcService.Requests.Protos.UserId.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TiEventsy.UserGrpcService.Requests.Protos.PublicUserData), global::TiEventsy.UserGrpcService.Requests.Protos.PublicUserData.Parser, new[]{ "Name", "UriImage", "MyTimetableIds" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TiEventsy.UserGrpcService.Requests.Protos.PrivateUserData), global::TiEventsy.UserGrpcService.Requests.Protos.PrivateUserData.Parser, new[]{ "Name", "Email", "UriImage", "MyTimetableIds", "TimetableSubscriptions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserId : pb::IMessage<UserId>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserId> _parser = new pb::MessageParser<UserId>(() => new UserId());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TiEventsy.UserGrpcService.Requests.Protos.UserReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserId(UserId other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserId Clone() {
      return new UserId(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserId other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class PublicUserData : pb::IMessage<PublicUserData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PublicUserData> _parser = new pb::MessageParser<PublicUserData>(() => new PublicUserData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PublicUserData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TiEventsy.UserGrpcService.Requests.Protos.UserReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicUserData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicUserData(PublicUserData other) : this() {
      name_ = other.name_;
      uriImage_ = other.uriImage_;
      myTimetableIds_ = other.myTimetableIds_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublicUserData Clone() {
      return new PublicUserData(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uri_image" field.</summary>
    public const int UriImageFieldNumber = 2;
    private string uriImage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UriImage {
      get { return uriImage_; }
      set {
        uriImage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "my_timetable_ids" field.</summary>
    public const int MyTimetableIdsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_myTimetableIds_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> myTimetableIds_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> MyTimetableIds {
      get { return myTimetableIds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PublicUserData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PublicUserData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (UriImage != other.UriImage) return false;
      if(!myTimetableIds_.Equals(other.myTimetableIds_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (UriImage.Length != 0) hash ^= UriImage.GetHashCode();
      hash ^= myTimetableIds_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (UriImage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UriImage);
      }
      myTimetableIds_.WriteTo(output, _repeated_myTimetableIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (UriImage.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UriImage);
      }
      myTimetableIds_.WriteTo(ref output, _repeated_myTimetableIds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (UriImage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UriImage);
      }
      size += myTimetableIds_.CalculateSize(_repeated_myTimetableIds_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PublicUserData other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.UriImage.Length != 0) {
        UriImage = other.UriImage;
      }
      myTimetableIds_.Add(other.myTimetableIds_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            UriImage = input.ReadString();
            break;
          }
          case 26: {
            myTimetableIds_.AddEntriesFrom(input, _repeated_myTimetableIds_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            UriImage = input.ReadString();
            break;
          }
          case 26: {
            myTimetableIds_.AddEntriesFrom(ref input, _repeated_myTimetableIds_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class PrivateUserData : pb::IMessage<PrivateUserData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PrivateUserData> _parser = new pb::MessageParser<PrivateUserData>(() => new PrivateUserData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrivateUserData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TiEventsy.UserGrpcService.Requests.Protos.UserReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrivateUserData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrivateUserData(PrivateUserData other) : this() {
      name_ = other.name_;
      email_ = other.email_;
      uriImage_ = other.uriImage_;
      myTimetableIds_ = other.myTimetableIds_.Clone();
      timetableSubscriptions_ = other.timetableSubscriptions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrivateUserData Clone() {
      return new PrivateUserData(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uri_image" field.</summary>
    public const int UriImageFieldNumber = 4;
    private string uriImage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UriImage {
      get { return uriImage_; }
      set {
        uriImage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "my_timetable_ids" field.</summary>
    public const int MyTimetableIdsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_myTimetableIds_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> myTimetableIds_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> MyTimetableIds {
      get { return myTimetableIds_; }
    }

    /// <summary>Field number for the "timetable_subscriptions" field.</summary>
    public const int TimetableSubscriptionsFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_timetableSubscriptions_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> timetableSubscriptions_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> TimetableSubscriptions {
      get { return timetableSubscriptions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrivateUserData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrivateUserData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Email != other.Email) return false;
      if (UriImage != other.UriImage) return false;
      if(!myTimetableIds_.Equals(other.myTimetableIds_)) return false;
      if(!timetableSubscriptions_.Equals(other.timetableSubscriptions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (UriImage.Length != 0) hash ^= UriImage.GetHashCode();
      hash ^= myTimetableIds_.GetHashCode();
      hash ^= timetableSubscriptions_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (UriImage.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UriImage);
      }
      myTimetableIds_.WriteTo(output, _repeated_myTimetableIds_codec);
      timetableSubscriptions_.WriteTo(output, _repeated_timetableSubscriptions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (UriImage.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(UriImage);
      }
      myTimetableIds_.WriteTo(ref output, _repeated_myTimetableIds_codec);
      timetableSubscriptions_.WriteTo(ref output, _repeated_timetableSubscriptions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (UriImage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UriImage);
      }
      size += myTimetableIds_.CalculateSize(_repeated_myTimetableIds_codec);
      size += timetableSubscriptions_.CalculateSize(_repeated_timetableSubscriptions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrivateUserData other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.UriImage.Length != 0) {
        UriImage = other.UriImage;
      }
      myTimetableIds_.Add(other.myTimetableIds_);
      timetableSubscriptions_.Add(other.timetableSubscriptions_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            UriImage = input.ReadString();
            break;
          }
          case 42: {
            myTimetableIds_.AddEntriesFrom(input, _repeated_myTimetableIds_codec);
            break;
          }
          case 50: {
            timetableSubscriptions_.AddEntriesFrom(input, _repeated_timetableSubscriptions_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            UriImage = input.ReadString();
            break;
          }
          case 42: {
            myTimetableIds_.AddEntriesFrom(ref input, _repeated_myTimetableIds_codec);
            break;
          }
          case 50: {
            timetableSubscriptions_.AddEntriesFrom(ref input, _repeated_timetableSubscriptions_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
