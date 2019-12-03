// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: simple.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Stream {

  /// <summary>Holder for reflection information generated from simple.proto</summary>
  public static partial class SimpleReflection {

    #region Descriptor
    /// <summary>File descriptor for simple.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SimpleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxzaW1wbGUucHJvdG8SBnN0cmVhbSKLAwoHUGFja2FnZRqFAQoFRnJhbWUS",
            "JwoEVHlwZRgBIAEoDjIZLnN0cmVhbS5QYWNrYWdlLkZyYW1lVHlwZRIPCgd2",
            "ZXJzaW9uGAIgASgNEg4KBmNtZF9pZBgDIAEoDRIPCgd1c2VyX2lkGAQgASgE",
            "EhAKCHJlc2VydmVkGAUgASgNEg8KB01lc3NhZ2UYBiABKAwi9wEKCUZyYW1l",
            "VHlwZRIRCg1MZWFndWVNZXNzYWdlEAASDwoLUHVzaE1lc3NhZ2UQARITCg9V",
            "bmlvbk9wc01lc3NhZ2UQAhIRCg1Tb2NpYWxNZXNzYWdlEAQSEQoNUG9pbnRz",
            "TWVzc2FnZRAIEgsKB01hdGNoVlMQEBIPCgtHb3Nub3dmbGFrZRAgEhIKDlRp",
            "bWVvdXRTZXJ2aWNlEEASEQoMUm9ib3RTZXJ2aWNlEIABEg8KCkNwc1NlcnZp",
            "Y2UQgAISEQoMQWdlbnRTZXJ2aWNlEIAEEhAKC0Zhc3RNZXNzYWdlEIAIEhAK",
            "C0hvdGVsU2VydmVyEIAQYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Stream.Package), global::Stream.Package.Parser, null, null, new[]{ typeof(global::Stream.Package.Types.FrameType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Stream.Package.Types.Frame), global::Stream.Package.Types.Frame.Parser, new[]{ "Type", "Version", "CmdId", "UserId", "Reserved", "Message" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Package : pb::IMessage<Package> {
    private static readonly pb::MessageParser<Package> _parser = new pb::MessageParser<Package>(() => new Package());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Package> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Stream.SimpleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Package() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Package(Package other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Package Clone() {
      return new Package(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Package);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Package other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Package other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Package message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum FrameType {
        [pbr::OriginalName("LeagueMessage")] LeagueMessage = 0,
        [pbr::OriginalName("PushMessage")] PushMessage = 1,
        /// <summary>
        /// 联运
        /// </summary>
        [pbr::OriginalName("UnionOpsMessage")] UnionOpsMessage = 2,
        /// <summary>
        /// 社交
        /// </summary>
        [pbr::OriginalName("SocialMessage")] SocialMessage = 4,
        /// <summary>
        /// 积分
        /// </summary>
        [pbr::OriginalName("PointsMessage")] PointsMessage = 8,
        /// <summary>
        /// matchvs
        /// </summary>
        [pbr::OriginalName("MatchVS")] MatchVs = 16,
        /// <summary>
        /// 全局ID生成器
        /// </summary>
        [pbr::OriginalName("Gosnowflake")] Gosnowflake = 32,
        /// <summary>
        /// 超时服务
        /// </summary>
        [pbr::OriginalName("TimeoutService")] TimeoutService = 64,
        /// <summary>
        /// 机器人服务
        /// </summary>
        [pbr::OriginalName("RobotService")] RobotService = 128,
        /// <summary>
        ///cpserver
        /// </summary>
        [pbr::OriginalName("CpsService")] CpsService = 256,
        /// <summary>
        ///agent
        /// </summary>
        [pbr::OriginalName("AgentService")] AgentService = 512,
        /// <summary>
        ///快速请求，不接收应答消息
        /// </summary>
        [pbr::OriginalName("FastMessage")] FastMessage = 1024,
        /// <summary>
        ///hotel服
        /// </summary>
        [pbr::OriginalName("HotelServer")] HotelServer = 2048,
      }

      public sealed partial class Frame : pb::IMessage<Frame> {
        private static readonly pb::MessageParser<Frame> _parser = new pb::MessageParser<Frame>(() => new Frame());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Frame> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Stream.Package.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Frame() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Frame(Frame other) : this() {
          type_ = other.type_;
          version_ = other.version_;
          cmdId_ = other.cmdId_;
          userId_ = other.userId_;
          reserved_ = other.reserved_;
          message_ = other.message_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Frame Clone() {
          return new Frame(this);
        }

        /// <summary>Field number for the "Type" field.</summary>
        public const int TypeFieldNumber = 1;
        private global::Stream.Package.Types.FrameType type_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Stream.Package.Types.FrameType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        /// <summary>Field number for the "version" field.</summary>
        public const int VersionFieldNumber = 2;
        private uint version_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Version {
          get { return version_; }
          set {
            version_ = value;
          }
        }

        /// <summary>Field number for the "cmd_id" field.</summary>
        public const int CmdIdFieldNumber = 3;
        private uint cmdId_;
        /// <summary>
        /// TODO cmdID
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint CmdId {
          get { return cmdId_; }
          set {
            cmdId_ = value;
          }
        }

        /// <summary>Field number for the "user_id" field.</summary>
        public const int UserIdFieldNumber = 4;
        private ulong userId_;
        /// <summary>
        /// TODO userID
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ulong UserId {
          get { return userId_; }
          set {
            userId_ = value;
          }
        }

        /// <summary>Field number for the "reserved" field.</summary>
        public const int ReservedFieldNumber = 5;
        private uint reserved_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint Reserved {
          get { return reserved_; }
          set {
            reserved_ = value;
          }
        }

        /// <summary>Field number for the "Message" field.</summary>
        public const int MessageFieldNumber = 6;
        private pb::ByteString message_ = pb::ByteString.Empty;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString Message {
          get { return message_; }
          set {
            message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Frame);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Frame other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Type != other.Type) return false;
          if (Version != other.Version) return false;
          if (CmdId != other.CmdId) return false;
          if (UserId != other.UserId) return false;
          if (Reserved != other.Reserved) return false;
          if (Message != other.Message) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Type != 0) hash ^= Type.GetHashCode();
          if (Version != 0) hash ^= Version.GetHashCode();
          if (CmdId != 0) hash ^= CmdId.GetHashCode();
          if (UserId != 0UL) hash ^= UserId.GetHashCode();
          if (Reserved != 0) hash ^= Reserved.GetHashCode();
          if (Message.Length != 0) hash ^= Message.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Type != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Type);
          }
          if (Version != 0) {
            output.WriteRawTag(16);
            output.WriteUInt32(Version);
          }
          if (CmdId != 0) {
            output.WriteRawTag(24);
            output.WriteUInt32(CmdId);
          }
          if (UserId != 0UL) {
            output.WriteRawTag(32);
            output.WriteUInt64(UserId);
          }
          if (Reserved != 0) {
            output.WriteRawTag(40);
            output.WriteUInt32(Reserved);
          }
          if (Message.Length != 0) {
            output.WriteRawTag(50);
            output.WriteBytes(Message);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Type != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (Version != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
          }
          if (CmdId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CmdId);
          }
          if (UserId != 0UL) {
            size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UserId);
          }
          if (Reserved != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Reserved);
          }
          if (Message.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeBytesSize(Message);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Frame other) {
          if (other == null) {
            return;
          }
          if (other.Type != 0) {
            Type = other.Type;
          }
          if (other.Version != 0) {
            Version = other.Version;
          }
          if (other.CmdId != 0) {
            CmdId = other.CmdId;
          }
          if (other.UserId != 0UL) {
            UserId = other.UserId;
          }
          if (other.Reserved != 0) {
            Reserved = other.Reserved;
          }
          if (other.Message.Length != 0) {
            Message = other.Message;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                type_ = (global::Stream.Package.Types.FrameType) input.ReadEnum();
                break;
              }
              case 16: {
                Version = input.ReadUInt32();
                break;
              }
              case 24: {
                CmdId = input.ReadUInt32();
                break;
              }
              case 32: {
                UserId = input.ReadUInt64();
                break;
              }
              case 40: {
                Reserved = input.ReadUInt32();
                break;
              }
              case 50: {
                Message = input.ReadBytes();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
