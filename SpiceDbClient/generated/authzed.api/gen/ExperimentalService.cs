// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authzed/api/v1/experimental_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Authzed.Api.V1 {

  /// <summary>Holder for reflection information generated from authzed/api/v1/experimental_service.proto</summary>
  public static partial class ExperimentalServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for authzed/api/v1/experimental_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExperimentalServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilhdXRoemVkL2FwaS92MS9leHBlcmltZW50YWxfc2VydmljZS5wcm90bxIO",
            "YXV0aHplZC5hcGkudjEaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8a",
            "F3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvGhlhdXRoemVkL2FwaS92MS9jb3Jl",
            "LnByb3RvGidhdXRoemVkL2FwaS92MS9wZXJtaXNzaW9uX3NlcnZpY2UucHJv",
            "dG8icwoeQnVsa0ltcG9ydFJlbGF0aW9uc2hpcHNSZXF1ZXN0ElEKDXJlbGF0",
            "aW9uc2hpcHMYASADKAsyHC5hdXRoemVkLmFwaS52MS5SZWxhdGlvbnNoaXBC",
            "DfpCCpIBByIFigECEAFSDXJlbGF0aW9uc2hpcHMiQAofQnVsa0ltcG9ydFJl",
            "bGF0aW9uc2hpcHNSZXNwb25zZRIdCgpudW1fbG9hZGVkGAEgASgEUgludW1M",
            "b2FkZWQi0wEKHkJ1bGtFeHBvcnRSZWxhdGlvbnNoaXBzUmVxdWVzdBI9Cgtj",
            "b25zaXN0ZW5jeRgBIAEoCzIbLmF1dGh6ZWQuYXBpLnYxLkNvbnNpc3RlbmN5",
            "Ugtjb25zaXN0ZW5jeRIxCg5vcHRpb25hbF9saW1pdBgCIAEoDUIK+kIHKgUY",
            "kE4oAFINb3B0aW9uYWxMaW1pdBI/Cg9vcHRpb25hbF9jdXJzb3IYAyABKAsy",
            "Fi5hdXRoemVkLmFwaS52MS5DdXJzb3JSDm9wdGlvbmFsQ3Vyc29yIq0BCh9C",
            "dWxrRXhwb3J0UmVsYXRpb25zaGlwc1Jlc3BvbnNlEkYKE2FmdGVyX3Jlc3Vs",
            "dF9jdXJzb3IYASABKAsyFi5hdXRoemVkLmFwaS52MS5DdXJzb3JSEWFmdGVy",
            "UmVzdWx0Q3Vyc29yEkIKDXJlbGF0aW9uc2hpcHMYAiADKAsyHC5hdXRoemVk",
            "LmFwaS52MS5SZWxhdGlvbnNoaXBSDXJlbGF0aW9uc2hpcHMy/wIKE0V4cGVy",
            "aW1lbnRhbFNlcnZpY2USsgEKF0J1bGtJbXBvcnRSZWxhdGlvbnNoaXBzEi4u",
            "YXV0aHplZC5hcGkudjEuQnVsa0ltcG9ydFJlbGF0aW9uc2hpcHNSZXF1ZXN0",
            "Gi8uYXV0aHplZC5hcGkudjEuQnVsa0ltcG9ydFJlbGF0aW9uc2hpcHNSZXNw",
            "b25zZSI0gtPkkwIuOgEqIikvdjEvZXhwZXJpbWVudGFsL3JlbGF0aW9uc2hp",
            "cHMvYnVsa2ltcG9ydCgBErIBChdCdWxrRXhwb3J0UmVsYXRpb25zaGlwcxIu",
            "LmF1dGh6ZWQuYXBpLnYxLkJ1bGtFeHBvcnRSZWxhdGlvbnNoaXBzUmVxdWVz",
            "dBovLmF1dGh6ZWQuYXBpLnYxLkJ1bGtFeHBvcnRSZWxhdGlvbnNoaXBzUmVz",
            "cG9uc2UiNILT5JMCLjoBKiIpL3YxL2V4cGVyaW1lbnRhbC9yZWxhdGlvbnNo",
            "aXBzL2J1bGtleHBvcnQwAUJIChJjb20uYXV0aHplZC5hcGkudjFaMmdpdGh1",
            "Yi5jb20vYXV0aHplZC9hdXRoemVkLWdvL3Byb3RvL2F1dGh6ZWQvYXBpL3Yx",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, global::Authzed.Api.V1.CoreReflection.Descriptor, global::Authzed.Api.V1.PermissionServiceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V1.BulkImportRelationshipsRequest), global::Authzed.Api.V1.BulkImportRelationshipsRequest.Parser, new[]{ "Relationships" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V1.BulkImportRelationshipsResponse), global::Authzed.Api.V1.BulkImportRelationshipsResponse.Parser, new[]{ "NumLoaded" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V1.BulkExportRelationshipsRequest), global::Authzed.Api.V1.BulkExportRelationshipsRequest.Parser, new[]{ "Consistency", "OptionalLimit", "OptionalCursor" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V1.BulkExportRelationshipsResponse), global::Authzed.Api.V1.BulkExportRelationshipsResponse.Parser, new[]{ "AfterResultCursor", "Relationships" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// BulkImportRelationshipsRequest represents one batch of the streaming
  /// BulkImportRelationships API. The maximum size is only limited by the backing
  /// datastore, and optimal size should be determined by the calling client
  /// experimentally.
  /// </summary>
  public sealed partial class BulkImportRelationshipsRequest : pb::IMessage<BulkImportRelationshipsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BulkImportRelationshipsRequest> _parser = new pb::MessageParser<BulkImportRelationshipsRequest>(() => new BulkImportRelationshipsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BulkImportRelationshipsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V1.ExperimentalServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkImportRelationshipsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkImportRelationshipsRequest(BulkImportRelationshipsRequest other) : this() {
      relationships_ = other.relationships_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkImportRelationshipsRequest Clone() {
      return new BulkImportRelationshipsRequest(this);
    }

    /// <summary>Field number for the "relationships" field.</summary>
    public const int RelationshipsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Authzed.Api.V1.Relationship> _repeated_relationships_codec
        = pb::FieldCodec.ForMessage(10, global::Authzed.Api.V1.Relationship.Parser);
    private readonly pbc::RepeatedField<global::Authzed.Api.V1.Relationship> relationships_ = new pbc::RepeatedField<global::Authzed.Api.V1.Relationship>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Authzed.Api.V1.Relationship> Relationships {
      get { return relationships_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BulkImportRelationshipsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BulkImportRelationshipsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!relationships_.Equals(other.relationships_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= relationships_.GetHashCode();
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
      relationships_.WriteTo(output, _repeated_relationships_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      relationships_.WriteTo(ref output, _repeated_relationships_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += relationships_.CalculateSize(_repeated_relationships_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BulkImportRelationshipsRequest other) {
      if (other == null) {
        return;
      }
      relationships_.Add(other.relationships_);
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
            relationships_.AddEntriesFrom(input, _repeated_relationships_codec);
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
            relationships_.AddEntriesFrom(ref input, _repeated_relationships_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// BulkImportRelationshipsResponse is returned on successful completion of the
  /// bulk load stream, and contains the total number of relationships loaded.
  /// </summary>
  public sealed partial class BulkImportRelationshipsResponse : pb::IMessage<BulkImportRelationshipsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BulkImportRelationshipsResponse> _parser = new pb::MessageParser<BulkImportRelationshipsResponse>(() => new BulkImportRelationshipsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BulkImportRelationshipsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V1.ExperimentalServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkImportRelationshipsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkImportRelationshipsResponse(BulkImportRelationshipsResponse other) : this() {
      numLoaded_ = other.numLoaded_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkImportRelationshipsResponse Clone() {
      return new BulkImportRelationshipsResponse(this);
    }

    /// <summary>Field number for the "num_loaded" field.</summary>
    public const int NumLoadedFieldNumber = 1;
    private ulong numLoaded_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong NumLoaded {
      get { return numLoaded_; }
      set {
        numLoaded_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BulkImportRelationshipsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BulkImportRelationshipsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NumLoaded != other.NumLoaded) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NumLoaded != 0UL) hash ^= NumLoaded.GetHashCode();
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
      if (NumLoaded != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(NumLoaded);
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
      if (NumLoaded != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(NumLoaded);
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
      if (NumLoaded != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NumLoaded);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BulkImportRelationshipsResponse other) {
      if (other == null) {
        return;
      }
      if (other.NumLoaded != 0UL) {
        NumLoaded = other.NumLoaded;
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
            NumLoaded = input.ReadUInt64();
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
            NumLoaded = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// BulkExportRelationshipsRequest represents a resumable request for
  /// all relationships from the server.
  /// </summary>
  public sealed partial class BulkExportRelationshipsRequest : pb::IMessage<BulkExportRelationshipsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BulkExportRelationshipsRequest> _parser = new pb::MessageParser<BulkExportRelationshipsRequest>(() => new BulkExportRelationshipsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BulkExportRelationshipsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V1.ExperimentalServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkExportRelationshipsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkExportRelationshipsRequest(BulkExportRelationshipsRequest other) : this() {
      consistency_ = other.consistency_ != null ? other.consistency_.Clone() : null;
      optionalLimit_ = other.optionalLimit_;
      optionalCursor_ = other.optionalCursor_ != null ? other.optionalCursor_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkExportRelationshipsRequest Clone() {
      return new BulkExportRelationshipsRequest(this);
    }

    /// <summary>Field number for the "consistency" field.</summary>
    public const int ConsistencyFieldNumber = 1;
    private global::Authzed.Api.V1.Consistency consistency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V1.Consistency Consistency {
      get { return consistency_; }
      set {
        consistency_ = value;
      }
    }

    /// <summary>Field number for the "optional_limit" field.</summary>
    public const int OptionalLimitFieldNumber = 2;
    private uint optionalLimit_;
    /// <summary>
    /// optional_limit, if non-zero, specifies the limit on the number of
    /// relationships the server can return in one page. By default, the server
    /// will pick a page size, and the server is free to choose a smaller size
    /// at will.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionalLimit {
      get { return optionalLimit_; }
      set {
        optionalLimit_ = value;
      }
    }

    /// <summary>Field number for the "optional_cursor" field.</summary>
    public const int OptionalCursorFieldNumber = 3;
    private global::Authzed.Api.V1.Cursor optionalCursor_;
    /// <summary>
    /// optional_cursor, if specified, indicates the cursor after which results
    /// should resume being returned. The cursor can be found on the
    /// BulkExportRelationshipsResponse object.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V1.Cursor OptionalCursor {
      get { return optionalCursor_; }
      set {
        optionalCursor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BulkExportRelationshipsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BulkExportRelationshipsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Consistency, other.Consistency)) return false;
      if (OptionalLimit != other.OptionalLimit) return false;
      if (!object.Equals(OptionalCursor, other.OptionalCursor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (consistency_ != null) hash ^= Consistency.GetHashCode();
      if (OptionalLimit != 0) hash ^= OptionalLimit.GetHashCode();
      if (optionalCursor_ != null) hash ^= OptionalCursor.GetHashCode();
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
      if (consistency_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Consistency);
      }
      if (OptionalLimit != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OptionalLimit);
      }
      if (optionalCursor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OptionalCursor);
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
      if (consistency_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Consistency);
      }
      if (OptionalLimit != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OptionalLimit);
      }
      if (optionalCursor_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OptionalCursor);
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
      if (consistency_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Consistency);
      }
      if (OptionalLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionalLimit);
      }
      if (optionalCursor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OptionalCursor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BulkExportRelationshipsRequest other) {
      if (other == null) {
        return;
      }
      if (other.consistency_ != null) {
        if (consistency_ == null) {
          Consistency = new global::Authzed.Api.V1.Consistency();
        }
        Consistency.MergeFrom(other.Consistency);
      }
      if (other.OptionalLimit != 0) {
        OptionalLimit = other.OptionalLimit;
      }
      if (other.optionalCursor_ != null) {
        if (optionalCursor_ == null) {
          OptionalCursor = new global::Authzed.Api.V1.Cursor();
        }
        OptionalCursor.MergeFrom(other.OptionalCursor);
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
            if (consistency_ == null) {
              Consistency = new global::Authzed.Api.V1.Consistency();
            }
            input.ReadMessage(Consistency);
            break;
          }
          case 16: {
            OptionalLimit = input.ReadUInt32();
            break;
          }
          case 26: {
            if (optionalCursor_ == null) {
              OptionalCursor = new global::Authzed.Api.V1.Cursor();
            }
            input.ReadMessage(OptionalCursor);
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
            if (consistency_ == null) {
              Consistency = new global::Authzed.Api.V1.Consistency();
            }
            input.ReadMessage(Consistency);
            break;
          }
          case 16: {
            OptionalLimit = input.ReadUInt32();
            break;
          }
          case 26: {
            if (optionalCursor_ == null) {
              OptionalCursor = new global::Authzed.Api.V1.Cursor();
            }
            input.ReadMessage(OptionalCursor);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// BulkExportRelationshipsResponse is one page in a stream of relationship
  /// groups that meet the criteria specified by the originating request. The
  /// server will continue to stream back relationship groups as quickly as it can
  /// until all relationships have been transmitted back.
  /// </summary>
  public sealed partial class BulkExportRelationshipsResponse : pb::IMessage<BulkExportRelationshipsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BulkExportRelationshipsResponse> _parser = new pb::MessageParser<BulkExportRelationshipsResponse>(() => new BulkExportRelationshipsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BulkExportRelationshipsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V1.ExperimentalServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkExportRelationshipsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkExportRelationshipsResponse(BulkExportRelationshipsResponse other) : this() {
      afterResultCursor_ = other.afterResultCursor_ != null ? other.afterResultCursor_.Clone() : null;
      relationships_ = other.relationships_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BulkExportRelationshipsResponse Clone() {
      return new BulkExportRelationshipsResponse(this);
    }

    /// <summary>Field number for the "after_result_cursor" field.</summary>
    public const int AfterResultCursorFieldNumber = 1;
    private global::Authzed.Api.V1.Cursor afterResultCursor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V1.Cursor AfterResultCursor {
      get { return afterResultCursor_; }
      set {
        afterResultCursor_ = value;
      }
    }

    /// <summary>Field number for the "relationships" field.</summary>
    public const int RelationshipsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Authzed.Api.V1.Relationship> _repeated_relationships_codec
        = pb::FieldCodec.ForMessage(18, global::Authzed.Api.V1.Relationship.Parser);
    private readonly pbc::RepeatedField<global::Authzed.Api.V1.Relationship> relationships_ = new pbc::RepeatedField<global::Authzed.Api.V1.Relationship>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Authzed.Api.V1.Relationship> Relationships {
      get { return relationships_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BulkExportRelationshipsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BulkExportRelationshipsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AfterResultCursor, other.AfterResultCursor)) return false;
      if(!relationships_.Equals(other.relationships_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (afterResultCursor_ != null) hash ^= AfterResultCursor.GetHashCode();
      hash ^= relationships_.GetHashCode();
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
      if (afterResultCursor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AfterResultCursor);
      }
      relationships_.WriteTo(output, _repeated_relationships_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (afterResultCursor_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AfterResultCursor);
      }
      relationships_.WriteTo(ref output, _repeated_relationships_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (afterResultCursor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AfterResultCursor);
      }
      size += relationships_.CalculateSize(_repeated_relationships_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BulkExportRelationshipsResponse other) {
      if (other == null) {
        return;
      }
      if (other.afterResultCursor_ != null) {
        if (afterResultCursor_ == null) {
          AfterResultCursor = new global::Authzed.Api.V1.Cursor();
        }
        AfterResultCursor.MergeFrom(other.AfterResultCursor);
      }
      relationships_.Add(other.relationships_);
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
            if (afterResultCursor_ == null) {
              AfterResultCursor = new global::Authzed.Api.V1.Cursor();
            }
            input.ReadMessage(AfterResultCursor);
            break;
          }
          case 18: {
            relationships_.AddEntriesFrom(input, _repeated_relationships_codec);
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
            if (afterResultCursor_ == null) {
              AfterResultCursor = new global::Authzed.Api.V1.Cursor();
            }
            input.ReadMessage(AfterResultCursor);
            break;
          }
          case 18: {
            relationships_.AddEntriesFrom(ref input, _repeated_relationships_codec);
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