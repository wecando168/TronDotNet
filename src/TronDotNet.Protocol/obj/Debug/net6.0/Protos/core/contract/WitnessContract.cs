// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/core/contract/witness_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TronDotNet.Protocol {

  /// <summary>Holder for reflection information generated from Protos/core/contract/witness_contract.proto</summary>
  public static partial class WitnessContractReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/core/contract/witness_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WitnessContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQcm90b3MvY29yZS9jb250cmFjdC93aXRuZXNzX2NvbnRyYWN0LnByb3Rv",
            "Eghwcm90b2NvbCI7ChVXaXRuZXNzQ3JlYXRlQ29udHJhY3QSFQoNb3duZXJf",
            "YWRkcmVzcxgBIAEoDBILCgN1cmwYAiABKAwiQgoVV2l0bmVzc1VwZGF0ZUNv",
            "bnRyYWN0EhUKDW93bmVyX2FkZHJlc3MYASABKAwSEgoKdXBkYXRlX3VybBgM",
            "IAEoDCKiAQoTVm90ZVdpdG5lc3NDb250cmFjdBIVCg1vd25lcl9hZGRyZXNz",
            "GAEgASgMEjEKBXZvdGVzGAIgAygLMiIucHJvdG9jb2wuVm90ZVdpdG5lc3ND",
            "b250cmFjdC5Wb3RlEg8KB3N1cHBvcnQYAyABKAgaMAoEVm90ZRIUCgx2b3Rl",
            "X2FkZHJlc3MYASABKAwSEgoKdm90ZV9jb3VudBgCIAEoA0JBWilnaXRodWIu",
            "Y29tL3Ryb25wcm90b2NvbC9ncnBjLWdhdGV3YXkvY29yZaoCE1Ryb25Eb3RO",
            "ZXQuUHJvdG9jb2xiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TronDotNet.Protocol.WitnessCreateContract), global::TronDotNet.Protocol.WitnessCreateContract.Parser, new[]{ "OwnerAddress", "Url" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TronDotNet.Protocol.WitnessUpdateContract), global::TronDotNet.Protocol.WitnessUpdateContract.Parser, new[]{ "OwnerAddress", "UpdateUrl" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TronDotNet.Protocol.VoteWitnessContract), global::TronDotNet.Protocol.VoteWitnessContract.Parser, new[]{ "OwnerAddress", "Votes", "Support" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote), global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote.Parser, new[]{ "VoteAddress", "VoteCount" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WitnessCreateContract : pb::IMessage<WitnessCreateContract>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WitnessCreateContract> _parser = new pb::MessageParser<WitnessCreateContract>(() => new WitnessCreateContract());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WitnessCreateContract> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TronDotNet.Protocol.WitnessContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WitnessCreateContract() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WitnessCreateContract(WitnessCreateContract other) : this() {
      ownerAddress_ = other.ownerAddress_;
      url_ = other.url_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WitnessCreateContract Clone() {
      return new WitnessCreateContract(this);
    }

    /// <summary>Field number for the "owner_address" field.</summary>
    public const int OwnerAddressFieldNumber = 1;
    private pb::ByteString ownerAddress_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString OwnerAddress {
      get { return ownerAddress_; }
      set {
        ownerAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 2;
    private pb::ByteString url_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WitnessCreateContract);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WitnessCreateContract other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerAddress != other.OwnerAddress) return false;
      if (Url != other.Url) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerAddress.Length != 0) hash ^= OwnerAddress.GetHashCode();
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      if (Url.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Url);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OwnerAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OwnerAddress);
      }
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Url);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WitnessCreateContract other) {
      if (other == null) {
        return;
      }
      if (other.OwnerAddress.Length != 0) {
        OwnerAddress = other.OwnerAddress;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 18: {
            Url = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 18: {
            Url = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class WitnessUpdateContract : pb::IMessage<WitnessUpdateContract>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WitnessUpdateContract> _parser = new pb::MessageParser<WitnessUpdateContract>(() => new WitnessUpdateContract());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WitnessUpdateContract> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TronDotNet.Protocol.WitnessContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WitnessUpdateContract() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WitnessUpdateContract(WitnessUpdateContract other) : this() {
      ownerAddress_ = other.ownerAddress_;
      updateUrl_ = other.updateUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WitnessUpdateContract Clone() {
      return new WitnessUpdateContract(this);
    }

    /// <summary>Field number for the "owner_address" field.</summary>
    public const int OwnerAddressFieldNumber = 1;
    private pb::ByteString ownerAddress_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString OwnerAddress {
      get { return ownerAddress_; }
      set {
        ownerAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "update_url" field.</summary>
    public const int UpdateUrlFieldNumber = 12;
    private pb::ByteString updateUrl_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString UpdateUrl {
      get { return updateUrl_; }
      set {
        updateUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WitnessUpdateContract);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WitnessUpdateContract other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerAddress != other.OwnerAddress) return false;
      if (UpdateUrl != other.UpdateUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerAddress.Length != 0) hash ^= OwnerAddress.GetHashCode();
      if (UpdateUrl.Length != 0) hash ^= UpdateUrl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      if (UpdateUrl.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(UpdateUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      if (UpdateUrl.Length != 0) {
        output.WriteRawTag(98);
        output.WriteBytes(UpdateUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OwnerAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OwnerAddress);
      }
      if (UpdateUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(UpdateUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WitnessUpdateContract other) {
      if (other == null) {
        return;
      }
      if (other.OwnerAddress.Length != 0) {
        OwnerAddress = other.OwnerAddress;
      }
      if (other.UpdateUrl.Length != 0) {
        UpdateUrl = other.UpdateUrl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 98: {
            UpdateUrl = input.ReadBytes();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 98: {
            UpdateUrl = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class VoteWitnessContract : pb::IMessage<VoteWitnessContract>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VoteWitnessContract> _parser = new pb::MessageParser<VoteWitnessContract>(() => new VoteWitnessContract());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VoteWitnessContract> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TronDotNet.Protocol.WitnessContractReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VoteWitnessContract() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VoteWitnessContract(VoteWitnessContract other) : this() {
      ownerAddress_ = other.ownerAddress_;
      votes_ = other.votes_.Clone();
      support_ = other.support_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VoteWitnessContract Clone() {
      return new VoteWitnessContract(this);
    }

    /// <summary>Field number for the "owner_address" field.</summary>
    public const int OwnerAddressFieldNumber = 1;
    private pb::ByteString ownerAddress_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString OwnerAddress {
      get { return ownerAddress_; }
      set {
        ownerAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "votes" field.</summary>
    public const int VotesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote> _repeated_votes_codec
        = pb::FieldCodec.ForMessage(18, global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote.Parser);
    private readonly pbc::RepeatedField<global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote> votes_ = new pbc::RepeatedField<global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::TronDotNet.Protocol.VoteWitnessContract.Types.Vote> Votes {
      get { return votes_; }
    }

    /// <summary>Field number for the "support" field.</summary>
    public const int SupportFieldNumber = 3;
    private bool support_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Support {
      get { return support_; }
      set {
        support_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VoteWitnessContract);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VoteWitnessContract other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerAddress != other.OwnerAddress) return false;
      if(!votes_.Equals(other.votes_)) return false;
      if (Support != other.Support) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerAddress.Length != 0) hash ^= OwnerAddress.GetHashCode();
      hash ^= votes_.GetHashCode();
      if (Support != false) hash ^= Support.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      votes_.WriteTo(output, _repeated_votes_codec);
      if (Support != false) {
        output.WriteRawTag(24);
        output.WriteBool(Support);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OwnerAddress.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(OwnerAddress);
      }
      votes_.WriteTo(ref output, _repeated_votes_codec);
      if (Support != false) {
        output.WriteRawTag(24);
        output.WriteBool(Support);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OwnerAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(OwnerAddress);
      }
      size += votes_.CalculateSize(_repeated_votes_codec);
      if (Support != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VoteWitnessContract other) {
      if (other == null) {
        return;
      }
      if (other.OwnerAddress.Length != 0) {
        OwnerAddress = other.OwnerAddress;
      }
      votes_.Add(other.votes_);
      if (other.Support != false) {
        Support = other.Support;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 18: {
            votes_.AddEntriesFrom(input, _repeated_votes_codec);
            break;
          }
          case 24: {
            Support = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            OwnerAddress = input.ReadBytes();
            break;
          }
          case 18: {
            votes_.AddEntriesFrom(ref input, _repeated_votes_codec);
            break;
          }
          case 24: {
            Support = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the VoteWitnessContract message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class Vote : pb::IMessage<Vote>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Vote> _parser = new pb::MessageParser<Vote>(() => new Vote());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Vote> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::TronDotNet.Protocol.VoteWitnessContract.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Vote() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Vote(Vote other) : this() {
          voteAddress_ = other.voteAddress_;
          voteCount_ = other.voteCount_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Vote Clone() {
          return new Vote(this);
        }

        /// <summary>Field number for the "vote_address" field.</summary>
        public const int VoteAddressFieldNumber = 1;
        private pb::ByteString voteAddress_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pb::ByteString VoteAddress {
          get { return voteAddress_; }
          set {
            voteAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "vote_count" field.</summary>
        public const int VoteCountFieldNumber = 2;
        private long voteCount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long VoteCount {
          get { return voteCount_; }
          set {
            voteCount_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Vote);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Vote other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (VoteAddress != other.VoteAddress) return false;
          if (VoteCount != other.VoteCount) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (VoteAddress.Length != 0) hash ^= VoteAddress.GetHashCode();
          if (VoteCount != 0L) hash ^= VoteCount.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (VoteAddress.Length != 0) {
            output.WriteRawTag(10);
            output.WriteBytes(VoteAddress);
          }
          if (VoteCount != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(VoteCount);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (VoteAddress.Length != 0) {
            output.WriteRawTag(10);
            output.WriteBytes(VoteAddress);
          }
          if (VoteCount != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(VoteCount);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (VoteAddress.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(VoteAddress);
          }
          if (VoteCount != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(VoteCount);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Vote other) {
          if (other == null) {
            return;
          }
          if (other.VoteAddress.Length != 0) {
            VoteAddress = other.VoteAddress;
          }
          if (other.VoteCount != 0L) {
            VoteCount = other.VoteCount;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
                VoteAddress = input.ReadBytes();
                break;
              }
              case 16: {
                VoteCount = input.ReadInt64();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 10: {
                VoteAddress = input.ReadBytes();
                break;
              }
              case 16: {
                VoteCount = input.ReadInt64();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
