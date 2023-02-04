// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/api/zksnark.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TronDotNet.Protocol {

  /// <summary>Holder for reflection information generated from Protos/api/zksnark.proto</summary>
  public static partial class ZksnarkReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/api/zksnark.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZksnarkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcm90b3MvYXBpL3prc25hcmsucHJvdG8SCHByb3RvY29sGhZQcm90b3Mv",
            "Y29yZS9Ucm9uLnByb3RvInEKDlprc25hcmtSZXF1ZXN0EioKC3RyYW5zYWN0",
            "aW9uGAEgASgLMhUucHJvdG9jb2wuVHJhbnNhY3Rpb24SDwoHc2lnaGFzaBgC",
            "IAEoDBIUCgx2YWx1ZUJhbGFuY2UYAyABKAMSDAoEdHhJZBgEIAEoCSJgCg9a",
            "a3NuYXJrUmVzcG9uc2USLAoEY29kZRgBIAEoDjIeLnByb3RvY29sLlprc25h",
            "cmtSZXNwb25zZS5Db2RlIh8KBENvZGUSCwoHU1VDQ0VTUxAAEgoKBkZBSUxF",
            "RBABMlkKC1Ryb25aa3NuYXJrEkoKEUNoZWNrWmtzbmFya1Byb29mEhgucHJv",
            "dG9jb2wuWmtzbmFya1JlcXVlc3QaGS5wcm90b2NvbC5aa3NuYXJrUmVzcG9u",
            "c2UiAEJAWihnaXRodWIuY29tL3Ryb25wcm90b2NvbC9ncnBjLWdhdGV3YXkv",
            "YXBpqgITVHJvbkRvdE5ldC5Qcm90b2NvbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TronDotNet.Protocol.TronReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TronDotNet.Protocol.ZksnarkRequest), global::TronDotNet.Protocol.ZksnarkRequest.Parser, new[]{ "Transaction", "Sighash", "ValueBalance", "TxId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TronDotNet.Protocol.ZksnarkResponse), global::TronDotNet.Protocol.ZksnarkResponse.Parser, new[]{ "Code" }, null, new[]{ typeof(global::TronDotNet.Protocol.ZksnarkResponse.Types.Code) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ZksnarkRequest : pb::IMessage<ZksnarkRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZksnarkRequest> _parser = new pb::MessageParser<ZksnarkRequest>(() => new ZksnarkRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ZksnarkRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TronDotNet.Protocol.ZksnarkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZksnarkRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZksnarkRequest(ZksnarkRequest other) : this() {
      transaction_ = other.transaction_ != null ? other.transaction_.Clone() : null;
      sighash_ = other.sighash_;
      valueBalance_ = other.valueBalance_;
      txId_ = other.txId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZksnarkRequest Clone() {
      return new ZksnarkRequest(this);
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 1;
    private global::TronDotNet.Protocol.Transaction transaction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::TronDotNet.Protocol.Transaction Transaction {
      get { return transaction_; }
      set {
        transaction_ = value;
      }
    }

    /// <summary>Field number for the "sighash" field.</summary>
    public const int SighashFieldNumber = 2;
    private pb::ByteString sighash_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Sighash {
      get { return sighash_; }
      set {
        sighash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "valueBalance" field.</summary>
    public const int ValueBalanceFieldNumber = 3;
    private long valueBalance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ValueBalance {
      get { return valueBalance_; }
      set {
        valueBalance_ = value;
      }
    }

    /// <summary>Field number for the "txId" field.</summary>
    public const int TxIdFieldNumber = 4;
    private string txId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TxId {
      get { return txId_; }
      set {
        txId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ZksnarkRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ZksnarkRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Transaction, other.Transaction)) return false;
      if (Sighash != other.Sighash) return false;
      if (ValueBalance != other.ValueBalance) return false;
      if (TxId != other.TxId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (transaction_ != null) hash ^= Transaction.GetHashCode();
      if (Sighash.Length != 0) hash ^= Sighash.GetHashCode();
      if (ValueBalance != 0L) hash ^= ValueBalance.GetHashCode();
      if (TxId.Length != 0) hash ^= TxId.GetHashCode();
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
      if (transaction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Transaction);
      }
      if (Sighash.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Sighash);
      }
      if (ValueBalance != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ValueBalance);
      }
      if (TxId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TxId);
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
      if (transaction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Transaction);
      }
      if (Sighash.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Sighash);
      }
      if (ValueBalance != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ValueBalance);
      }
      if (TxId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(TxId);
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
      if (transaction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transaction);
      }
      if (Sighash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Sighash);
      }
      if (ValueBalance != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ValueBalance);
      }
      if (TxId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TxId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ZksnarkRequest other) {
      if (other == null) {
        return;
      }
      if (other.transaction_ != null) {
        if (transaction_ == null) {
          Transaction = new global::TronDotNet.Protocol.Transaction();
        }
        Transaction.MergeFrom(other.Transaction);
      }
      if (other.Sighash.Length != 0) {
        Sighash = other.Sighash;
      }
      if (other.ValueBalance != 0L) {
        ValueBalance = other.ValueBalance;
      }
      if (other.TxId.Length != 0) {
        TxId = other.TxId;
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
            if (transaction_ == null) {
              Transaction = new global::TronDotNet.Protocol.Transaction();
            }
            input.ReadMessage(Transaction);
            break;
          }
          case 18: {
            Sighash = input.ReadBytes();
            break;
          }
          case 24: {
            ValueBalance = input.ReadInt64();
            break;
          }
          case 34: {
            TxId = input.ReadString();
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
            if (transaction_ == null) {
              Transaction = new global::TronDotNet.Protocol.Transaction();
            }
            input.ReadMessage(Transaction);
            break;
          }
          case 18: {
            Sighash = input.ReadBytes();
            break;
          }
          case 24: {
            ValueBalance = input.ReadInt64();
            break;
          }
          case 34: {
            TxId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ZksnarkResponse : pb::IMessage<ZksnarkResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZksnarkResponse> _parser = new pb::MessageParser<ZksnarkResponse>(() => new ZksnarkResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ZksnarkResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TronDotNet.Protocol.ZksnarkReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZksnarkResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZksnarkResponse(ZksnarkResponse other) : this() {
      code_ = other.code_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ZksnarkResponse Clone() {
      return new ZksnarkResponse(this);
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 1;
    private global::TronDotNet.Protocol.ZksnarkResponse.Types.Code code_ = global::TronDotNet.Protocol.ZksnarkResponse.Types.Code.Success;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::TronDotNet.Protocol.ZksnarkResponse.Types.Code Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ZksnarkResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ZksnarkResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Code != other.Code) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Code != global::TronDotNet.Protocol.ZksnarkResponse.Types.Code.Success) hash ^= Code.GetHashCode();
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
      if (Code != global::TronDotNet.Protocol.ZksnarkResponse.Types.Code.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
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
      if (Code != global::TronDotNet.Protocol.ZksnarkResponse.Types.Code.Success) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Code);
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
      if (Code != global::TronDotNet.Protocol.ZksnarkResponse.Types.Code.Success) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ZksnarkResponse other) {
      if (other == null) {
        return;
      }
      if (other.Code != global::TronDotNet.Protocol.ZksnarkResponse.Types.Code.Success) {
        Code = other.Code;
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
          case 8: {
            Code = (global::TronDotNet.Protocol.ZksnarkResponse.Types.Code) input.ReadEnum();
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
          case 8: {
            Code = (global::TronDotNet.Protocol.ZksnarkResponse.Types.Code) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ZksnarkResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Code {
        [pbr::OriginalName("SUCCESS")] Success = 0,
        [pbr::OriginalName("FAILED")] Failed = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
