// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGDuelExtra.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGDuelExtra.proto</summary>
  public static partial class GCGDuelExtraReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGDuelExtra.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGDuelExtraReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHQ0dEdWVsRXh0cmEucHJvdG8aFkdDR0NoYWxsZW5nZURhdGEucHJvdG8i",
            "8QEKDEdDR0R1ZWxFeHRyYRIUCgxjYXJkX2lkX2xpc3QYASADKA0SEAoIZmll",
            "bGRfaWQYAiABKA0SFAoMY2FyZF9iYWNrX2lkGAMgASgNEjUKDWNhcmRfZmFj",
            "ZV9tYXAYBCADKAsyHi5HQ0dEdWVsRXh0cmEuQ2FyZEZhY2VNYXBFbnRyeRIp",
            "Cg5jaGFsbGVuZ2VfbGlzdBgFIAMoCzIRLkdDR0NoYWxsZW5nZURhdGESDQoF",
            "c2NvcmUYBiABKA0aMgoQQ2FyZEZhY2VNYXBFbnRyeRILCgNrZXkYASABKA0S",
            "DQoFdmFsdWUYAiABKA06AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGChallengeDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGDuelExtra), global::Weedwacker.Shared.Network.Proto.GCGDuelExtra.Parser, new[]{ "CardIdList", "FieldId", "CardBackId", "CardFaceMap", "ChallengeList", "Score" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGDuelExtra : pb::IMessage<GCGDuelExtra>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGDuelExtra> _parser = new pb::MessageParser<GCGDuelExtra>(() => new GCGDuelExtra());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGDuelExtra> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGDuelExtraReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuelExtra() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuelExtra(GCGDuelExtra other) : this() {
      cardIdList_ = other.cardIdList_.Clone();
      fieldId_ = other.fieldId_;
      cardBackId_ = other.cardBackId_;
      cardFaceMap_ = other.cardFaceMap_.Clone();
      challengeList_ = other.challengeList_.Clone();
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuelExtra Clone() {
      return new GCGDuelExtra(this);
    }

    /// <summary>Field number for the "card_id_list" field.</summary>
    public const int CardIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_cardIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> cardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardIdList {
      get { return cardIdList_; }
    }

    /// <summary>Field number for the "field_id" field.</summary>
    public const int FieldIdFieldNumber = 2;
    private uint fieldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FieldId {
      get { return fieldId_; }
      set {
        fieldId_ = value;
      }
    }

    /// <summary>Field number for the "card_back_id" field.</summary>
    public const int CardBackIdFieldNumber = 3;
    private uint cardBackId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardBackId {
      get { return cardBackId_; }
      set {
        cardBackId_ = value;
      }
    }

    /// <summary>Field number for the "card_face_map" field.</summary>
    public const int CardFaceMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, uint>.Codec _map_cardFaceMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
    private readonly pbc::MapField<uint, uint> cardFaceMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> CardFaceMap {
      get { return cardFaceMap_; }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGChallengeData> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.GCGChallengeData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGChallengeData> challengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGChallengeData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGChallengeData> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 6;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGDuelExtra);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGDuelExtra other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cardIdList_.Equals(other.cardIdList_)) return false;
      if (FieldId != other.FieldId) return false;
      if (CardBackId != other.CardBackId) return false;
      if (!CardFaceMap.Equals(other.CardFaceMap)) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if (Score != other.Score) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cardIdList_.GetHashCode();
      if (FieldId != 0) hash ^= FieldId.GetHashCode();
      if (CardBackId != 0) hash ^= CardBackId.GetHashCode();
      hash ^= CardFaceMap.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
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
      cardIdList_.WriteTo(output, _repeated_cardIdList_codec);
      if (FieldId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FieldId);
      }
      if (CardBackId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CardBackId);
      }
      cardFaceMap_.WriteTo(output, _map_cardFaceMap_codec);
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      if (Score != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Score);
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
      cardIdList_.WriteTo(ref output, _repeated_cardIdList_codec);
      if (FieldId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FieldId);
      }
      if (CardBackId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CardBackId);
      }
      cardFaceMap_.WriteTo(ref output, _map_cardFaceMap_codec);
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      if (Score != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Score);
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
      size += cardIdList_.CalculateSize(_repeated_cardIdList_codec);
      if (FieldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FieldId);
      }
      if (CardBackId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardBackId);
      }
      size += cardFaceMap_.CalculateSize(_map_cardFaceMap_codec);
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGDuelExtra other) {
      if (other == null) {
        return;
      }
      cardIdList_.Add(other.cardIdList_);
      if (other.FieldId != 0) {
        FieldId = other.FieldId;
      }
      if (other.CardBackId != 0) {
        CardBackId = other.CardBackId;
      }
      cardFaceMap_.Add(other.cardFaceMap_);
      challengeList_.Add(other.challengeList_);
      if (other.Score != 0) {
        Score = other.Score;
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
          case 10:
          case 8: {
            cardIdList_.AddEntriesFrom(input, _repeated_cardIdList_codec);
            break;
          }
          case 16: {
            FieldId = input.ReadUInt32();
            break;
          }
          case 24: {
            CardBackId = input.ReadUInt32();
            break;
          }
          case 34: {
            cardFaceMap_.AddEntriesFrom(input, _map_cardFaceMap_codec);
            break;
          }
          case 42: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 48: {
            Score = input.ReadUInt32();
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
          case 10:
          case 8: {
            cardIdList_.AddEntriesFrom(ref input, _repeated_cardIdList_codec);
            break;
          }
          case 16: {
            FieldId = input.ReadUInt32();
            break;
          }
          case 24: {
            CardBackId = input.ReadUInt32();
            break;
          }
          case 34: {
            cardFaceMap_.AddEntriesFrom(ref input, _map_cardFaceMap_codec);
            break;
          }
          case 42: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 48: {
            Score = input.ReadUInt32();
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
