// Copyright 2016 Google Inc. Все права защищены.
//
// Лицензируется по лицензии Apache, версия 2.0 («Лицензия»);
// вы не можете использовать этот файл, кроме как в соответствии с Лицензией.
// Вы можете получить копию Лицензии на
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Если это не предусмотрено действующим законодательством или не согласовано в письменной форме, программное обеспечение
// распространяется по лицензии, распространяется на основе «AS IS»,
// БЕЗ ГАРАНТИЙ ИЛИ УСЛОВИЙ ЛЮБОГО ВИДА, явных или подразумеваемых.
// См. Лицензию на конкретном языке, определяющем разрешения и
// ограничения по лицензии.

// Сгенерировано ProtoGen, Version = 2.4.1.473, Culture = neutral, PublicKeyToken = 55f7125234beb589. НЕ ИЗМЕНЯТЬ!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;

/// @cond
namespace proto {

  namespace Proto {

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public static partial class PhoneEvent {

      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      #endregion
      #region Extensions
      internal static readonly object Descriptor;
      static PhoneEvent() {
        Descriptor = null;
      }
      #endregion

    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class PhoneEvent : pb::GeneratedMessageLite<PhoneEvent, PhoneEvent.Builder> {
    private PhoneEvent() { }
    private static readonly PhoneEvent defaultInstance = new PhoneEvent().MakeReadOnly();
    private static readonly string[] _phoneEventFieldNames = new string[] { "accelerometer_event", "depth_map_event", "gyroscope_event", "key_event", "motion_event", "orientation_event", "type" };
    private static readonly uint[] _phoneEventFieldTags = new uint[] { 34, 42, 26, 58, 18, 50, 8 };
    public static PhoneEvent DefaultInstance {
      get { return defaultInstance; }
    }

    public override PhoneEvent DefaultInstanceForType {
      get { return DefaultInstance; }
    }

    protected override PhoneEvent ThisMessage {
      get { return this; }
    }

    #region Nested types
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public static class Types {
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public enum Type {
        MOTION = 1,
        GYROSCOPE = 2,
        ACCELEROMETER = 3,
        DEPTH_MAP = 4,
        ORIENTATION = 5,
        KEY = 6,
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public sealed partial class MotionEvent : pb::GeneratedMessageLite<MotionEvent, MotionEvent.Builder> {
        private MotionEvent() { }
        private static readonly MotionEvent defaultInstance = new MotionEvent().MakeReadOnly();
        private static readonly string[] _motionEventFieldNames = new string[] { "action", "pointers", "timestamp" };
        private static readonly uint[] _motionEventFieldTags = new uint[] { 16, 26, 8 };
        public static MotionEvent DefaultInstance {
          get { return defaultInstance; }
        }

        public override MotionEvent DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override MotionEvent ThisMessage {
          get { return this; }
        }

        #region Nested types
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public static class Types {
          [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
          [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
          [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
          public sealed partial class Pointer : pb::GeneratedMessageLite<Pointer, Pointer.Builder> {
            private Pointer() { }
            private static readonly Pointer defaultInstance = new Pointer().MakeReadOnly();
            private static readonly string[] _pointerFieldNames = new string[] { "id", "normalized_x", "normalized_y" };
            private static readonly uint[] _pointerFieldTags = new uint[] { 8, 21, 29 };
            public static Pointer DefaultInstance {
              get { return defaultInstance; }
            }

            public override Pointer DefaultInstanceForType {
              get { return DefaultInstance; }
            }

            protected override Pointer ThisMessage {
              get { return this; }
            }

            public const int IdFieldNumber = 1;
            private bool hasId;
            private int id_;
            public bool HasId {
              get { return hasId; }
            }
            public int Id {
              get { return id_; }
            }

            public const int NormalizedXFieldNumber = 2;
            private bool hasNormalizedX;
            private float normalizedX_;
            public bool HasNormalizedX {
              get { return hasNormalizedX; }
            }
            public float NormalizedX {
              get { return normalizedX_; }
            }

            public const int NormalizedYFieldNumber = 3;
            private bool hasNormalizedY;
            private float normalizedY_;
            public bool HasNormalizedY {
              get { return hasNormalizedY; }
            }
            public float NormalizedY {
              get { return normalizedY_; }
            }

            public override bool IsInitialized {
              get {
                return true;
              }
            }

            public override void WriteTo(pb::ICodedOutputStream output) {
              string[] field_names = _pointerFieldNames;
              if (hasId) {
                output.WriteInt32(1, field_names[0], Id);
              }
              if (hasNormalizedX) {
                output.WriteFloat(2, field_names[1], NormalizedX);
              }
              if (hasNormalizedY) {
                output.WriteFloat(3, field_names[2], NormalizedY);
              }
            }

            private int memoizedSerializedSize = -1;
            public override int SerializedSize {
              get {
                int size = memoizedSerializedSize;
                if (size != -1) return size;

                size = 0;
                if (hasId) {
                  size += pb::CodedOutputStream.ComputeInt32Size(1, Id);
                }
                if (hasNormalizedX) {
                  size += pb::CodedOutputStream.ComputeFloatSize(2, NormalizedX);
                }
                if (hasNormalizedY) {
                  size += pb::CodedOutputStream.ComputeFloatSize(3, NormalizedY);
                }
                memoizedSerializedSize = size;
                return size;
              }
            }

            #region Lite runtime methods
            public override int GetHashCode() {
              int hash = GetType().GetHashCode();
              if (hasId) hash ^= id_.GetHashCode();
              if (hasNormalizedX) hash ^= normalizedX_.GetHashCode();
              if (hasNormalizedY) hash ^= normalizedY_.GetHashCode();
              return hash;
            }

            public override bool Equals(object obj) {
              Pointer other = obj as Pointer;
              if (other == null) return false;
              if (hasId != other.hasId || (hasId && !id_.Equals(other.id_))) return false;
              if (hasNormalizedX != other.hasNormalizedX || (hasNormalizedX && !normalizedX_.Equals(other.normalizedX_))) return false;
              if (hasNormalizedY != other.hasNormalizedY || (hasNormalizedY && !normalizedY_.Equals(other.normalizedY_))) return false;
              return true;
            }

            public override void PrintTo(global::System.IO.TextWriter writer) {
              PrintField("id", hasId, id_, writer);
              PrintField("normalized_x", hasNormalizedX, normalizedX_, writer);
              PrintField("normalized_y", hasNormalizedY, normalizedY_, writer);
            }
            #endregion

            public static Pointer ParseFrom(pb::ByteString data) {
              return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
            }
            public static Pointer ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
              return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
            }
            public static Pointer ParseFrom(byte[] data) {
              return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
            }
            public static Pointer ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
              return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
            }
            public static Pointer ParseFrom(global::System.IO.Stream input) {
              return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
            }
            public static Pointer ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
              return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
            }
            public static Pointer ParseDelimitedFrom(global::System.IO.Stream input) {
              return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
            }
            public static Pointer ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
              return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
            }
            public static Pointer ParseFrom(pb::ICodedInputStream input) {
              return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
            }
            public static Pointer ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
              return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
            }
            private Pointer MakeReadOnly() {
              return this;
            }

            public static Builder CreateBuilder() { return new Builder(); }
            public override Builder ToBuilder() { return CreateBuilder(this); }
            public override Builder CreateBuilderForType() { return new Builder(); }
            public static Builder CreateBuilder(Pointer prototype) {
              return new Builder(prototype);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
            public sealed partial class Builder : pb::GeneratedBuilderLite<Pointer, Builder> {
              protected override Builder ThisBuilder {
                get { return this; }
              }
              public Builder() {
                result = DefaultInstance;
                resultIsReadOnly = true;
              }
              internal Builder(Pointer cloneFrom) {
                result = cloneFrom;
                resultIsReadOnly = true;
              }

              private bool resultIsReadOnly;
              private Pointer result;

              private Pointer PrepareBuilder() {
                if (resultIsReadOnly) {
                  Pointer original = result;
                  result = new Pointer();
                  resultIsReadOnly = false;
                  MergeFrom(original);
                }
                return result;
              }

              public override bool IsInitialized {
                get { return result.IsInitialized; }
              }

              protected override Pointer MessageBeingBuilt {
                get { return PrepareBuilder(); }
              }

              public override Builder Clear() {
                result = DefaultInstance;
                resultIsReadOnly = true;
                return this;
              }

              public override Builder Clone() {
                if (resultIsReadOnly) {
                  return new Builder(result);
                } else {
                  return new Builder().MergeFrom(result);
                }
              }

              public override Pointer DefaultInstanceForType {
                get { return global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer.DefaultInstance; }
              }

              public override Pointer BuildPartial() {
                if (resultIsReadOnly) {
                  return result;
                }
                resultIsReadOnly = true;
                return result.MakeReadOnly();
              }

              public override Builder MergeFrom(pb::IMessageLite other) {
                if (other is Pointer) {
                  return MergeFrom((Pointer) other);
                } else {
                  base.MergeFrom(other);
                  return this;
                }
              }

              public override Builder MergeFrom(Pointer other) {
                if (other == global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer.DefaultInstance) return this;
                PrepareBuilder();
                if (other.HasId) {
                  Id = other.Id;
                }
                if (other.HasNormalizedX) {
                  NormalizedX = other.NormalizedX;
                }
                if (other.HasNormalizedY) {
                  NormalizedY = other.NormalizedY;
                }
                return this;
              }

              public override Builder MergeFrom(pb::ICodedInputStream input) {
                return MergeFrom(input, pb::ExtensionRegistry.Empty);
              }

              public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
                PrepareBuilder();
                uint tag;
                string field_name;
                while (input.ReadTag(out tag, out field_name)) {
                  if(tag == 0 && field_name != null) {
                    int field_ordinal = global::System.Array.BinarySearch(_pointerFieldNames, field_name, global::System.StringComparer.Ordinal);
                    if(field_ordinal >= 0)
                      tag = _pointerFieldTags[field_ordinal];
                    else {
                      ParseUnknownField(input, extensionRegistry, tag, field_name);
                      continue;
                    }
                  }
                  switch (tag) {
                    case 0: {
                      throw pb::InvalidProtocolBufferException.InvalidTag();
                    }
                    default: {
                      if (pb::WireFormat.IsEndGroupTag(tag)) {
                        return this;
                      }
                      ParseUnknownField(input, extensionRegistry, tag, field_name);
                      break;
                    }
                    case 8: {
                      result.hasId = input.ReadInt32(ref result.id_);
                      break;
                    }
                    case 21: {
                      result.hasNormalizedX = input.ReadFloat(ref result.normalizedX_);
                      break;
                    }
                    case 29: {
                      result.hasNormalizedY = input.ReadFloat(ref result.normalizedY_);
                      break;
                    }
                  }
                }

                return this;
              }


              public bool HasId {
                get { return result.hasId; }
              }
              public int Id {
                get { return result.Id; }
                set { SetId(value); }
              }
              public Builder SetId(int value) {
                PrepareBuilder();
                result.hasId = true;
                result.id_ = value;
                return this;
              }
              public Builder ClearId() {
                PrepareBuilder();
                result.hasId = false;
                result.id_ = 0;
                return this;
              }

              public bool HasNormalizedX {
                get { return result.hasNormalizedX; }
              }
              public float NormalizedX {
                get { return result.NormalizedX; }
                set { SetNormalizedX(value); }
              }
              public Builder SetNormalizedX(float value) {
                PrepareBuilder();
                result.hasNormalizedX = true;
                result.normalizedX_ = value;
                return this;
              }
              public Builder ClearNormalizedX() {
                PrepareBuilder();
                result.hasNormalizedX = false;
                result.normalizedX_ = 0F;
                return this;
              }

              public bool HasNormalizedY {
                get { return result.hasNormalizedY; }
              }
              public float NormalizedY {
                get { return result.NormalizedY; }
                set { SetNormalizedY(value); }
              }
              public Builder SetNormalizedY(float value) {
                PrepareBuilder();
                result.hasNormalizedY = true;
                result.normalizedY_ = value;
                return this;
              }
              public Builder ClearNormalizedY() {
                PrepareBuilder();
                result.hasNormalizedY = false;
                result.normalizedY_ = 0F;
                return this;
              }
            }
            static Pointer() {
              object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
            }
          }

        }
        #endregion

        public const int TimestampFieldNumber = 1;
        private bool hasTimestamp;
        private long timestamp_;
        public bool HasTimestamp {
          get { return hasTimestamp; }
        }
        public long Timestamp {
          get { return timestamp_; }
        }

        public const int ActionFieldNumber = 2;
        private bool hasAction;
        private int action_;
        public bool HasAction {
          get { return hasAction; }
        }
        public int Action {
          get { return action_; }
        }

        public const int PointersFieldNumber = 3;
        private pbc::PopsicleList<global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer> pointers_ = new pbc::PopsicleList<global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer>();
        public scg::IList<global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer> PointersList {
          get { return pointers_; }
        }
        public int PointersCount {
          get { return pointers_.Count; }
        }
        public global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer GetPointers(int index) {
          return pointers_[index];
        }

        public override bool IsInitialized {
          get {
            return true;
          }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          string[] field_names = _motionEventFieldNames;
          if (hasTimestamp) {
            output.WriteInt64(1, field_names[2], Timestamp);
          }
          if (hasAction) {
            output.WriteInt32(2, field_names[0], Action);
          }
          if (pointers_.Count > 0) {
            output.WriteMessageArray(3, field_names[1], pointers_);
          }
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;

            size = 0;
            if (hasTimestamp) {
              size += pb::CodedOutputStream.ComputeInt64Size(1, Timestamp);
            }
            if (hasAction) {
              size += pb::CodedOutputStream.ComputeInt32Size(2, Action);
            }
            foreach (global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer element in PointersList) {
              size += pb::CodedOutputStream.ComputeMessageSize(3, element);
            }
            memoizedSerializedSize = size;
            return size;
          }
        }

        #region Lite runtime methods
        public override int GetHashCode() {
          int hash = GetType().GetHashCode();
          if (hasTimestamp) hash ^= timestamp_.GetHashCode();
          if (hasAction) hash ^= action_.GetHashCode();
          foreach(global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer i in pointers_)
            hash ^= i.GetHashCode();
          return hash;
        }

        public override bool Equals(object obj) {
          MotionEvent other = obj as MotionEvent;
          if (other == null) return false;
          if (hasTimestamp != other.hasTimestamp || (hasTimestamp && !timestamp_.Equals(other.timestamp_))) return false;
          if (hasAction != other.hasAction || (hasAction && !action_.Equals(other.action_))) return false;
          if(pointers_.Count != other.pointers_.Count) return false;
          for(int ix=0; ix < pointers_.Count; ix++)
            if(!pointers_[ix].Equals(other.pointers_[ix])) return false;
          return true;
        }

        public override void PrintTo(global::System.IO.TextWriter writer) {
          PrintField("timestamp", hasTimestamp, timestamp_, writer);
          PrintField("action", hasAction, action_, writer);
          PrintField("pointers", pointers_, writer);
        }
        #endregion

        public static MotionEvent ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static MotionEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static MotionEvent ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static MotionEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static MotionEvent ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static MotionEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static MotionEvent ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static MotionEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static MotionEvent ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static MotionEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private MotionEvent MakeReadOnly() {
          pointers_.MakeReadOnly();
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(MotionEvent prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public sealed partial class Builder : pb::GeneratedBuilderLite<MotionEvent, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(MotionEvent cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private MotionEvent result;

          private MotionEvent PrepareBuilder() {
            if (resultIsReadOnly) {
              MotionEvent original = result;
              result = new MotionEvent();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override MotionEvent MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override MotionEvent DefaultInstanceForType {
            get { return global::proto.PhoneEvent.Types.MotionEvent.DefaultInstance; }
          }

          public override MotionEvent BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessageLite other) {
            if (other is MotionEvent) {
              return MergeFrom((MotionEvent) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(MotionEvent other) {
            if (other == global::proto.PhoneEvent.Types.MotionEvent.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasTimestamp) {
              Timestamp = other.Timestamp;
            }
            if (other.HasAction) {
              Action = other.Action;
            }
            if (other.pointers_.Count != 0) {
              result.pointers_.Add(other.pointers_);
            }
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_motionEventFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _motionEventFieldTags[field_ordinal];
                else {
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    return this;
                  }
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasTimestamp = input.ReadInt64(ref result.timestamp_);
                  break;
                }
                case 16: {
                  result.hasAction = input.ReadInt32(ref result.action_);
                  break;
                }
                case 26: {
                  input.ReadMessageArray(tag, field_name, result.pointers_, global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer.DefaultInstance, extensionRegistry);
                  break;
                }
              }
            }

            return this;
          }


          public bool HasTimestamp {
            get { return result.hasTimestamp; }
          }
          public long Timestamp {
            get { return result.Timestamp; }
            set { SetTimestamp(value); }
          }
          public Builder SetTimestamp(long value) {
            PrepareBuilder();
            result.hasTimestamp = true;
            result.timestamp_ = value;
            return this;
          }
          public Builder ClearTimestamp() {
            PrepareBuilder();
            result.hasTimestamp = false;
            result.timestamp_ = 0L;
            return this;
          }

          public bool HasAction {
            get { return result.hasAction; }
          }
          public int Action {
            get { return result.Action; }
            set { SetAction(value); }
          }
          public Builder SetAction(int value) {
            PrepareBuilder();
            result.hasAction = true;
            result.action_ = value;
            return this;
          }
          public Builder ClearAction() {
            PrepareBuilder();
            result.hasAction = false;
            result.action_ = 0;
            return this;
          }

          public pbc::IPopsicleList<global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer> PointersList {
            get { return PrepareBuilder().pointers_; }
          }
          public int PointersCount {
            get { return result.PointersCount; }
          }
          public global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer GetPointers(int index) {
            return result.GetPointers(index);
          }
          public Builder SetPointers(int index, global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.pointers_[index] = value;
            return this;
          }
          public Builder SetPointers(int index, global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.pointers_[index] = builderForValue.Build();
            return this;
          }
          public Builder AddPointers(global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer value) {
            pb::ThrowHelper.ThrowIfNull(value, "value");
            PrepareBuilder();
            result.pointers_.Add(value);
            return this;
          }
          public Builder AddPointers(global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer.Builder builderForValue) {
            pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
            PrepareBuilder();
            result.pointers_.Add(builderForValue.Build());
            return this;
          }
          public Builder AddRangePointers(scg::IEnumerable<global::proto.PhoneEvent.Types.MotionEvent.Types.Pointer> values) {
            PrepareBuilder();
            result.pointers_.Add(values);
            return this;
          }
          public Builder ClearPointers() {
            PrepareBuilder();
            result.pointers_.Clear();
            return this;
          }
        }
        static MotionEvent() {
          object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public sealed partial class GyroscopeEvent : pb::GeneratedMessageLite<GyroscopeEvent, GyroscopeEvent.Builder> {
        private GyroscopeEvent() { }
        private static readonly GyroscopeEvent defaultInstance = new GyroscopeEvent().MakeReadOnly();
        private static readonly string[] _gyroscopeEventFieldNames = new string[] { "timestamp", "x", "y", "z" };
        private static readonly uint[] _gyroscopeEventFieldTags = new uint[] { 8, 21, 29, 37 };
        public static GyroscopeEvent DefaultInstance {
          get { return defaultInstance; }
        }

        public override GyroscopeEvent DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override GyroscopeEvent ThisMessage {
          get { return this; }
        }

        public const int TimestampFieldNumber = 1;
        private bool hasTimestamp;
        private long timestamp_;
        public bool HasTimestamp {
          get { return hasTimestamp; }
        }
        public long Timestamp {
          get { return timestamp_; }
        }

        public const int XFieldNumber = 2;
        private bool hasX;
        private float x_;
        public bool HasX {
          get { return hasX; }
        }
        public float X {
          get { return x_; }
        }

        public const int YFieldNumber = 3;
        private bool hasY;
        private float y_;
        public bool HasY {
          get { return hasY; }
        }
        public float Y {
          get { return y_; }
        }

        public const int ZFieldNumber = 4;
        private bool hasZ;
        private float z_;
        public bool HasZ {
          get { return hasZ; }
        }
        public float Z {
          get { return z_; }
        }

        public override bool IsInitialized {
          get {
            return true;
          }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          string[] field_names = _gyroscopeEventFieldNames;
          if (hasTimestamp) {
            output.WriteInt64(1, field_names[0], Timestamp);
          }
          if (hasX) {
            output.WriteFloat(2, field_names[1], X);
          }
          if (hasY) {
            output.WriteFloat(3, field_names[2], Y);
          }
          if (hasZ) {
            output.WriteFloat(4, field_names[3], Z);
          }
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;

            size = 0;
            if (hasTimestamp) {
              size += pb::CodedOutputStream.ComputeInt64Size(1, Timestamp);
            }
            if (hasX) {
              size += pb::CodedOutputStream.ComputeFloatSize(2, X);
            }
            if (hasY) {
              size += pb::CodedOutputStream.ComputeFloatSize(3, Y);
            }
            if (hasZ) {
              size += pb::CodedOutputStream.ComputeFloatSize(4, Z);
            }
            memoizedSerializedSize = size;
            return size;
          }
        }

        #region Lite runtime methods
        public override int GetHashCode() {
          int hash = GetType().GetHashCode();
          if (hasTimestamp) hash ^= timestamp_.GetHashCode();
          if (hasX) hash ^= x_.GetHashCode();
          if (hasY) hash ^= y_.GetHashCode();
          if (hasZ) hash ^= z_.GetHashCode();
          return hash;
        }

        public override bool Equals(object obj) {
          GyroscopeEvent other = obj as GyroscopeEvent;
          if (other == null) return false;
          if (hasTimestamp != other.hasTimestamp || (hasTimestamp && !timestamp_.Equals(other.timestamp_))) return false;
          if (hasX != other.hasX || (hasX && !x_.Equals(other.x_))) return false;
          if (hasY != other.hasY || (hasY && !y_.Equals(other.y_))) return false;
          if (hasZ != other.hasZ || (hasZ && !z_.Equals(other.z_))) return false;
          return true;
        }

        public override void PrintTo(global::System.IO.TextWriter writer) {
          PrintField("timestamp", hasTimestamp, timestamp_, writer);
          PrintField("x", hasX, x_, writer);
          PrintField("y", hasY, y_, writer);
          PrintField("z", hasZ, z_, writer);
        }
        #endregion

        public static GyroscopeEvent ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static GyroscopeEvent ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static GyroscopeEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static GyroscopeEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private GyroscopeEvent MakeReadOnly() {
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(GyroscopeEvent prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public sealed partial class Builder : pb::GeneratedBuilderLite<GyroscopeEvent, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(GyroscopeEvent cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private GyroscopeEvent result;

          private GyroscopeEvent PrepareBuilder() {
            if (resultIsReadOnly) {
              GyroscopeEvent original = result;
              result = new GyroscopeEvent();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override GyroscopeEvent MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override GyroscopeEvent DefaultInstanceForType {
            get { return global::proto.PhoneEvent.Types.GyroscopeEvent.DefaultInstance; }
          }

          public override GyroscopeEvent BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessageLite other) {
            if (other is GyroscopeEvent) {
              return MergeFrom((GyroscopeEvent) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(GyroscopeEvent other) {
            if (other == global::proto.PhoneEvent.Types.GyroscopeEvent.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasTimestamp) {
              Timestamp = other.Timestamp;
            }
            if (other.HasX) {
              X = other.X;
            }
            if (other.HasY) {
              Y = other.Y;
            }
            if (other.HasZ) {
              Z = other.Z;
            }
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_gyroscopeEventFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _gyroscopeEventFieldTags[field_ordinal];
                else {
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    return this;
                  }
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasTimestamp = input.ReadInt64(ref result.timestamp_);
                  break;
                }
                case 21: {
                  result.hasX = input.ReadFloat(ref result.x_);
                  break;
                }
                case 29: {
                  result.hasY = input.ReadFloat(ref result.y_);
                  break;
                }
                case 37: {
                  result.hasZ = input.ReadFloat(ref result.z_);
                  break;
                }
              }
            }

            return this;
          }


          public bool HasTimestamp {
            get { return result.hasTimestamp; }
          }
          public long Timestamp {
            get { return result.Timestamp; }
            set { SetTimestamp(value); }
          }
          public Builder SetTimestamp(long value) {
            PrepareBuilder();
            result.hasTimestamp = true;
            result.timestamp_ = value;
            return this;
          }
          public Builder ClearTimestamp() {
            PrepareBuilder();
            result.hasTimestamp = false;
            result.timestamp_ = 0L;
            return this;
          }

          public bool HasX {
            get { return result.hasX; }
          }
          public float X {
            get { return result.X; }
            set { SetX(value); }
          }
          public Builder SetX(float value) {
            PrepareBuilder();
            result.hasX = true;
            result.x_ = value;
            return this;
          }
          public Builder ClearX() {
            PrepareBuilder();
            result.hasX = false;
            result.x_ = 0F;
            return this;
          }

          public bool HasY {
            get { return result.hasY; }
          }
          public float Y {
            get { return result.Y; }
            set { SetY(value); }
          }
          public Builder SetY(float value) {
            PrepareBuilder();
            result.hasY = true;
            result.y_ = value;
            return this;
          }
          public Builder ClearY() {
            PrepareBuilder();
            result.hasY = false;
            result.y_ = 0F;
            return this;
          }

          public bool HasZ {
            get { return result.hasZ; }
          }
          public float Z {
            get { return result.Z; }
            set { SetZ(value); }
          }
          public Builder SetZ(float value) {
            PrepareBuilder();
            result.hasZ = true;
            result.z_ = value;
            return this;
          }
          public Builder ClearZ() {
            PrepareBuilder();
            result.hasZ = false;
            result.z_ = 0F;
            return this;
          }
        }
        static GyroscopeEvent() {
          object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public sealed partial class AccelerometerEvent : pb::GeneratedMessageLite<AccelerometerEvent, AccelerometerEvent.Builder> {
        private AccelerometerEvent() { }
        private static readonly AccelerometerEvent defaultInstance = new AccelerometerEvent().MakeReadOnly();
        private static readonly string[] _accelerometerEventFieldNames = new string[] { "timestamp", "x", "y", "z" };
        private static readonly uint[] _accelerometerEventFieldTags = new uint[] { 8, 21, 29, 37 };
        public static AccelerometerEvent DefaultInstance {
          get { return defaultInstance; }
        }

        public override AccelerometerEvent DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override AccelerometerEvent ThisMessage {
          get { return this; }
        }

        public const int TimestampFieldNumber = 1;
        private bool hasTimestamp;
        private long timestamp_;
        public bool HasTimestamp {
          get { return hasTimestamp; }
        }
        public long Timestamp {
          get { return timestamp_; }
        }

        public const int XFieldNumber = 2;
        private bool hasX;
        private float x_;
        public bool HasX {
          get { return hasX; }
        }
        public float X {
          get { return x_; }
        }

        public const int YFieldNumber = 3;
        private bool hasY;
        private float y_;
        public bool HasY {
          get { return hasY; }
        }
        public float Y {
          get { return y_; }
        }

        public const int ZFieldNumber = 4;
        private bool hasZ;
        private float z_;
        public bool HasZ {
          get { return hasZ; }
        }
        public float Z {
          get { return z_; }
        }

        public override bool IsInitialized {
          get {
            return true;
          }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          string[] field_names = _accelerometerEventFieldNames;
          if (hasTimestamp) {
            output.WriteInt64(1, field_names[0], Timestamp);
          }
          if (hasX) {
            output.WriteFloat(2, field_names[1], X);
          }
          if (hasY) {
            output.WriteFloat(3, field_names[2], Y);
          }
          if (hasZ) {
            output.WriteFloat(4, field_names[3], Z);
          }
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;

            size = 0;
            if (hasTimestamp) {
              size += pb::CodedOutputStream.ComputeInt64Size(1, Timestamp);
            }
            if (hasX) {
              size += pb::CodedOutputStream.ComputeFloatSize(2, X);
            }
            if (hasY) {
              size += pb::CodedOutputStream.ComputeFloatSize(3, Y);
            }
            if (hasZ) {
              size += pb::CodedOutputStream.ComputeFloatSize(4, Z);
            }
            memoizedSerializedSize = size;
            return size;
          }
        }

        #region Lite runtime methods
        public override int GetHashCode() {
          int hash = GetType().GetHashCode();
          if (hasTimestamp) hash ^= timestamp_.GetHashCode();
          if (hasX) hash ^= x_.GetHashCode();
          if (hasY) hash ^= y_.GetHashCode();
          if (hasZ) hash ^= z_.GetHashCode();
          return hash;
        }

        public override bool Equals(object obj) {
          AccelerometerEvent other = obj as AccelerometerEvent;
          if (other == null) return false;
          if (hasTimestamp != other.hasTimestamp || (hasTimestamp && !timestamp_.Equals(other.timestamp_))) return false;
          if (hasX != other.hasX || (hasX && !x_.Equals(other.x_))) return false;
          if (hasY != other.hasY || (hasY && !y_.Equals(other.y_))) return false;
          if (hasZ != other.hasZ || (hasZ && !z_.Equals(other.z_))) return false;
          return true;
        }

        public override void PrintTo(global::System.IO.TextWriter writer) {
          PrintField("timestamp", hasTimestamp, timestamp_, writer);
          PrintField("x", hasX, x_, writer);
          PrintField("y", hasY, y_, writer);
          PrintField("z", hasZ, z_, writer);
        }
        #endregion

        public static AccelerometerEvent ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static AccelerometerEvent ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static AccelerometerEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static AccelerometerEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private AccelerometerEvent MakeReadOnly() {
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(AccelerometerEvent prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public sealed partial class Builder : pb::GeneratedBuilderLite<AccelerometerEvent, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(AccelerometerEvent cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private AccelerometerEvent result;

          private AccelerometerEvent PrepareBuilder() {
            if (resultIsReadOnly) {
              AccelerometerEvent original = result;
              result = new AccelerometerEvent();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override AccelerometerEvent MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override AccelerometerEvent DefaultInstanceForType {
            get { return global::proto.PhoneEvent.Types.AccelerometerEvent.DefaultInstance; }
          }

          public override AccelerometerEvent BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessageLite other) {
            if (other is AccelerometerEvent) {
              return MergeFrom((AccelerometerEvent) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(AccelerometerEvent other) {
            if (other == global::proto.PhoneEvent.Types.AccelerometerEvent.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasTimestamp) {
              Timestamp = other.Timestamp;
            }
            if (other.HasX) {
              X = other.X;
            }
            if (other.HasY) {
              Y = other.Y;
            }
            if (other.HasZ) {
              Z = other.Z;
            }
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_accelerometerEventFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _accelerometerEventFieldTags[field_ordinal];
                else {
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    return this;
                  }
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasTimestamp = input.ReadInt64(ref result.timestamp_);
                  break;
                }
                case 21: {
                  result.hasX = input.ReadFloat(ref result.x_);
                  break;
                }
                case 29: {
                  result.hasY = input.ReadFloat(ref result.y_);
                  break;
                }
                case 37: {
                  result.hasZ = input.ReadFloat(ref result.z_);
                  break;
                }
              }
            }

            return this;
          }


          public bool HasTimestamp {
            get { return result.hasTimestamp; }
          }
          public long Timestamp {
            get { return result.Timestamp; }
            set { SetTimestamp(value); }
          }
          public Builder SetTimestamp(long value) {
            PrepareBuilder();
            result.hasTimestamp = true;
            result.timestamp_ = value;
            return this;
          }
          public Builder ClearTimestamp() {
            PrepareBuilder();
            result.hasTimestamp = false;
            result.timestamp_ = 0L;
            return this;
          }

          public bool HasX {
            get { return result.hasX; }
          }
          public float X {
            get { return result.X; }
            set { SetX(value); }
          }
          public Builder SetX(float value) {
            PrepareBuilder();
            result.hasX = true;
            result.x_ = value;
            return this;
          }
          public Builder ClearX() {
            PrepareBuilder();
            result.hasX = false;
            result.x_ = 0F;
            return this;
          }

          public bool HasY {
            get { return result.hasY; }
          }
          public float Y {
            get { return result.Y; }
            set { SetY(value); }
          }
          public Builder SetY(float value) {
            PrepareBuilder();
            result.hasY = true;
            result.y_ = value;
            return this;
          }
          public Builder ClearY() {
            PrepareBuilder();
            result.hasY = false;
            result.y_ = 0F;
            return this;
          }

          public bool HasZ {
            get { return result.hasZ; }
          }
          public float Z {
            get { return result.Z; }
            set { SetZ(value); }
          }
          public Builder SetZ(float value) {
            PrepareBuilder();
            result.hasZ = true;
            result.z_ = value;
            return this;
          }
          public Builder ClearZ() {
            PrepareBuilder();
            result.hasZ = false;
            result.z_ = 0F;
            return this;
          }
        }
        static AccelerometerEvent() {
          object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public sealed partial class DepthMapEvent : pb::GeneratedMessageLite<DepthMapEvent, DepthMapEvent.Builder> {
        private DepthMapEvent() { }
        private static readonly DepthMapEvent defaultInstance = new DepthMapEvent().MakeReadOnly();
        private static readonly string[] _depthMapEventFieldNames = new string[] { "height", "timestamp", "width", "z_distances" };
        private static readonly uint[] _depthMapEventFieldTags = new uint[] { 24, 8, 16, 34 };
        public static DepthMapEvent DefaultInstance {
          get { return defaultInstance; }
        }

        public override DepthMapEvent DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override DepthMapEvent ThisMessage {
          get { return this; }
        }

        public const int TimestampFieldNumber = 1;
        private bool hasTimestamp;
        private long timestamp_;
        public bool HasTimestamp {
          get { return hasTimestamp; }
        }
        public long Timestamp {
          get { return timestamp_; }
        }

        public const int WidthFieldNumber = 2;
        private bool hasWidth;
        private int width_;
        public bool HasWidth {
          get { return hasWidth; }
        }
        public int Width {
          get { return width_; }
        }

        public const int HeightFieldNumber = 3;
        private bool hasHeight;
        private int height_;
        public bool HasHeight {
          get { return hasHeight; }
        }
        public int Height {
          get { return height_; }
        }

        public const int ZDistancesFieldNumber = 4;
        private int zDistancesMemoizedSerializedSize;
        private pbc::PopsicleList<float> zDistances_ = new pbc::PopsicleList<float>();
        public scg::IList<float> ZDistancesList {
          get { return pbc::Lists.AsReadOnly(zDistances_); }
        }
        public int ZDistancesCount {
          get { return zDistances_.Count; }
        }
        public float GetZDistances(int index) {
          return zDistances_[index];
        }

        public override bool IsInitialized {
          get {
            return true;
          }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          string[] field_names = _depthMapEventFieldNames;
          if (hasTimestamp) {
            output.WriteInt64(1, field_names[1], Timestamp);
          }
          if (hasWidth) {
            output.WriteInt32(2, field_names[2], Width);
          }
          if (hasHeight) {
            output.WriteInt32(3, field_names[0], Height);
          }
          if (zDistances_.Count > 0) {
            output.WritePackedFloatArray(4, field_names[3], zDistancesMemoizedSerializedSize, zDistances_);
          }
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;

            size = 0;
            if (hasTimestamp) {
              size += pb::CodedOutputStream.ComputeInt64Size(1, Timestamp);
            }
            if (hasWidth) {
              size += pb::CodedOutputStream.ComputeInt32Size(2, Width);
            }
            if (hasHeight) {
              size += pb::CodedOutputStream.ComputeInt32Size(3, Height);
            }
            {
              int dataSize = 0;
              dataSize = 4 * zDistances_.Count;
              size += dataSize;
              if (zDistances_.Count != 0) {
                size += 1 + pb::CodedOutputStream.ComputeInt32SizeNoTag(dataSize);
              }
              zDistancesMemoizedSerializedSize = dataSize;
            }
            memoizedSerializedSize = size;
            return size;
          }
        }

        #region Lite runtime methods
        public override int GetHashCode() {
          int hash = GetType().GetHashCode();
          if (hasTimestamp) hash ^= timestamp_.GetHashCode();
          if (hasWidth) hash ^= width_.GetHashCode();
          if (hasHeight) hash ^= height_.GetHashCode();
          foreach(float i in zDistances_)
            hash ^= i.GetHashCode();
          return hash;
        }

        public override bool Equals(object obj) {
          DepthMapEvent other = obj as DepthMapEvent;
          if (other == null) return false;
          if (hasTimestamp != other.hasTimestamp || (hasTimestamp && !timestamp_.Equals(other.timestamp_))) return false;
          if (hasWidth != other.hasWidth || (hasWidth && !width_.Equals(other.width_))) return false;
          if (hasHeight != other.hasHeight || (hasHeight && !height_.Equals(other.height_))) return false;
          if(zDistances_.Count != other.zDistances_.Count) return false;
          for(int ix=0; ix < zDistances_.Count; ix++)
            if(!zDistances_[ix].Equals(other.zDistances_[ix])) return false;
          return true;
        }

        public override void PrintTo(global::System.IO.TextWriter writer) {
          PrintField("timestamp", hasTimestamp, timestamp_, writer);
          PrintField("width", hasWidth, width_, writer);
          PrintField("height", hasHeight, height_, writer);
          PrintField("z_distances", zDistances_, writer);
        }
        #endregion

        public static DepthMapEvent ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static DepthMapEvent ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static DepthMapEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static DepthMapEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private DepthMapEvent MakeReadOnly() {
          zDistances_.MakeReadOnly();
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(DepthMapEvent prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public sealed partial class Builder : pb::GeneratedBuilderLite<DepthMapEvent, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(DepthMapEvent cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private DepthMapEvent result;

          private DepthMapEvent PrepareBuilder() {
            if (resultIsReadOnly) {
              DepthMapEvent original = result;
              result = new DepthMapEvent();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override DepthMapEvent MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override DepthMapEvent DefaultInstanceForType {
            get { return global::proto.PhoneEvent.Types.DepthMapEvent.DefaultInstance; }
          }

          public override DepthMapEvent BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessageLite other) {
            if (other is DepthMapEvent) {
              return MergeFrom((DepthMapEvent) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(DepthMapEvent other) {
            if (other == global::proto.PhoneEvent.Types.DepthMapEvent.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasTimestamp) {
              Timestamp = other.Timestamp;
            }
            if (other.HasWidth) {
              Width = other.Width;
            }
            if (other.HasHeight) {
              Height = other.Height;
            }
            if (other.zDistances_.Count != 0) {
              result.zDistances_.Add(other.zDistances_);
            }
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_depthMapEventFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _depthMapEventFieldTags[field_ordinal];
                else {
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    return this;
                  }
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasTimestamp = input.ReadInt64(ref result.timestamp_);
                  break;
                }
                case 16: {
                  result.hasWidth = input.ReadInt32(ref result.width_);
                  break;
                }
                case 24: {
                  result.hasHeight = input.ReadInt32(ref result.height_);
                  break;
                }
                case 34:
                case 37: {
                  input.ReadFloatArray(tag, field_name, result.zDistances_);
                  break;
                }
              }
            }

            return this;
          }


          public bool HasTimestamp {
            get { return result.hasTimestamp; }
          }
          public long Timestamp {
            get { return result.Timestamp; }
            set { SetTimestamp(value); }
          }
          public Builder SetTimestamp(long value) {
            PrepareBuilder();
            result.hasTimestamp = true;
            result.timestamp_ = value;
            return this;
          }
          public Builder ClearTimestamp() {
            PrepareBuilder();
            result.hasTimestamp = false;
            result.timestamp_ = 0L;
            return this;
          }

          public bool HasWidth {
            get { return result.hasWidth; }
          }
          public int Width {
            get { return result.Width; }
            set { SetWidth(value); }
          }
          public Builder SetWidth(int value) {
            PrepareBuilder();
            result.hasWidth = true;
            result.width_ = value;
            return this;
          }
          public Builder ClearWidth() {
            PrepareBuilder();
            result.hasWidth = false;
            result.width_ = 0;
            return this;
          }

          public bool HasHeight {
            get { return result.hasHeight; }
          }
          public int Height {
            get { return result.Height; }
            set { SetHeight(value); }
          }
          public Builder SetHeight(int value) {
            PrepareBuilder();
            result.hasHeight = true;
            result.height_ = value;
            return this;
          }
          public Builder ClearHeight() {
            PrepareBuilder();
            result.hasHeight = false;
            result.height_ = 0;
            return this;
          }

          public pbc::IPopsicleList<float> ZDistancesList {
            get { return PrepareBuilder().zDistances_; }
          }
          public int ZDistancesCount {
            get { return result.ZDistancesCount; }
          }
          public float GetZDistances(int index) {
            return result.GetZDistances(index);
          }
          public Builder SetZDistances(int index, float value) {
            PrepareBuilder();
            result.zDistances_[index] = value;
            return this;
          }
          public Builder AddZDistances(float value) {
            PrepareBuilder();
            result.zDistances_.Add(value);
            return this;
          }
          public Builder AddRangeZDistances(scg::IEnumerable<float> values) {
            PrepareBuilder();
            result.zDistances_.Add(values);
            return this;
          }
          public Builder ClearZDistances() {
            PrepareBuilder();
            result.zDistances_.Clear();
            return this;
          }
        }
        static DepthMapEvent() {
          object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public sealed partial class OrientationEvent : pb::GeneratedMessageLite<OrientationEvent, OrientationEvent.Builder> {
        private OrientationEvent() { }
        private static readonly OrientationEvent defaultInstance = new OrientationEvent().MakeReadOnly();
        private static readonly string[] _orientationEventFieldNames = new string[] { "timestamp", "w", "x", "y", "z" };
        private static readonly uint[] _orientationEventFieldTags = new uint[] { 8, 45, 21, 29, 37 };
        public static OrientationEvent DefaultInstance {
          get { return defaultInstance; }
        }

        public override OrientationEvent DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override OrientationEvent ThisMessage {
          get { return this; }
        }

        public const int TimestampFieldNumber = 1;
        private bool hasTimestamp;
        private long timestamp_;
        public bool HasTimestamp {
          get { return hasTimestamp; }
        }
        public long Timestamp {
          get { return timestamp_; }
        }

        public const int XFieldNumber = 2;
        private bool hasX;
        private float x_;
        public bool HasX {
          get { return hasX; }
        }
        public float X {
          get { return x_; }
        }

        public const int YFieldNumber = 3;
        private bool hasY;
        private float y_;
        public bool HasY {
          get { return hasY; }
        }
        public float Y {
          get { return y_; }
        }

        public const int ZFieldNumber = 4;
        private bool hasZ;
        private float z_;
        public bool HasZ {
          get { return hasZ; }
        }
        public float Z {
          get { return z_; }
        }

        public const int WFieldNumber = 5;
        private bool hasW;
        private float w_;
        public bool HasW {
          get { return hasW; }
        }
        public float W {
          get { return w_; }
        }

        public override bool IsInitialized {
          get {
            return true;
          }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          string[] field_names = _orientationEventFieldNames;
          if (hasTimestamp) {
            output.WriteInt64(1, field_names[0], Timestamp);
          }
          if (hasX) {
            output.WriteFloat(2, field_names[2], X);
          }
          if (hasY) {
            output.WriteFloat(3, field_names[3], Y);
          }
          if (hasZ) {
            output.WriteFloat(4, field_names[4], Z);
          }
          if (hasW) {
            output.WriteFloat(5, field_names[1], W);
          }
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;

            size = 0;
            if (hasTimestamp) {
              size += pb::CodedOutputStream.ComputeInt64Size(1, Timestamp);
            }
            if (hasX) {
              size += pb::CodedOutputStream.ComputeFloatSize(2, X);
            }
            if (hasY) {
              size += pb::CodedOutputStream.ComputeFloatSize(3, Y);
            }
            if (hasZ) {
              size += pb::CodedOutputStream.ComputeFloatSize(4, Z);
            }
            if (hasW) {
              size += pb::CodedOutputStream.ComputeFloatSize(5, W);
            }
            memoizedSerializedSize = size;
            return size;
          }
        }

        #region Lite runtime methods
        public override int GetHashCode() {
          int hash = GetType().GetHashCode();
          if (hasTimestamp) hash ^= timestamp_.GetHashCode();
          if (hasX) hash ^= x_.GetHashCode();
          if (hasY) hash ^= y_.GetHashCode();
          if (hasZ) hash ^= z_.GetHashCode();
          if (hasW) hash ^= w_.GetHashCode();
          return hash;
        }

        public override bool Equals(object obj) {
          OrientationEvent other = obj as OrientationEvent;
          if (other == null) return false;
          if (hasTimestamp != other.hasTimestamp || (hasTimestamp && !timestamp_.Equals(other.timestamp_))) return false;
          if (hasX != other.hasX || (hasX && !x_.Equals(other.x_))) return false;
          if (hasY != other.hasY || (hasY && !y_.Equals(other.y_))) return false;
          if (hasZ != other.hasZ || (hasZ && !z_.Equals(other.z_))) return false;
          if (hasW != other.hasW || (hasW && !w_.Equals(other.w_))) return false;
          return true;
        }

        public override void PrintTo(global::System.IO.TextWriter writer) {
          PrintField("timestamp", hasTimestamp, timestamp_, writer);
          PrintField("x", hasX, x_, writer);
          PrintField("y", hasY, y_, writer);
          PrintField("z", hasZ, z_, writer);
          PrintField("w", hasW, w_, writer);
        }
        #endregion

        public static OrientationEvent ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static OrientationEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static OrientationEvent ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static OrientationEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static OrientationEvent ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static OrientationEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static OrientationEvent ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static OrientationEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static OrientationEvent ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static OrientationEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private OrientationEvent MakeReadOnly() {
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(OrientationEvent prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public sealed partial class Builder : pb::GeneratedBuilderLite<OrientationEvent, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(OrientationEvent cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private OrientationEvent result;

          private OrientationEvent PrepareBuilder() {
            if (resultIsReadOnly) {
              OrientationEvent original = result;
              result = new OrientationEvent();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override OrientationEvent MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override OrientationEvent DefaultInstanceForType {
            get { return global::proto.PhoneEvent.Types.OrientationEvent.DefaultInstance; }
          }

          public override OrientationEvent BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessageLite other) {
            if (other is OrientationEvent) {
              return MergeFrom((OrientationEvent) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(OrientationEvent other) {
            if (other == global::proto.PhoneEvent.Types.OrientationEvent.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasTimestamp) {
              Timestamp = other.Timestamp;
            }
            if (other.HasX) {
              X = other.X;
            }
            if (other.HasY) {
              Y = other.Y;
            }
            if (other.HasZ) {
              Z = other.Z;
            }
            if (other.HasW) {
              W = other.W;
            }
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_orientationEventFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _orientationEventFieldTags[field_ordinal];
                else {
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    return this;
                  }
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasTimestamp = input.ReadInt64(ref result.timestamp_);
                  break;
                }
                case 21: {
                  result.hasX = input.ReadFloat(ref result.x_);
                  break;
                }
                case 29: {
                  result.hasY = input.ReadFloat(ref result.y_);
                  break;
                }
                case 37: {
                  result.hasZ = input.ReadFloat(ref result.z_);
                  break;
                }
                case 45: {
                  result.hasW = input.ReadFloat(ref result.w_);
                  break;
                }
              }
            }

            return this;
          }


          public bool HasTimestamp {
            get { return result.hasTimestamp; }
          }
          public long Timestamp {
            get { return result.Timestamp; }
            set { SetTimestamp(value); }
          }
          public Builder SetTimestamp(long value) {
            PrepareBuilder();
            result.hasTimestamp = true;
            result.timestamp_ = value;
            return this;
          }
          public Builder ClearTimestamp() {
            PrepareBuilder();
            result.hasTimestamp = false;
            result.timestamp_ = 0L;
            return this;
          }

          public bool HasX {
            get { return result.hasX; }
          }
          public float X {
            get { return result.X; }
            set { SetX(value); }
          }
          public Builder SetX(float value) {
            PrepareBuilder();
            result.hasX = true;
            result.x_ = value;
            return this;
          }
          public Builder ClearX() {
            PrepareBuilder();
            result.hasX = false;
            result.x_ = 0F;
            return this;
          }

          public bool HasY {
            get { return result.hasY; }
          }
          public float Y {
            get { return result.Y; }
            set { SetY(value); }
          }
          public Builder SetY(float value) {
            PrepareBuilder();
            result.hasY = true;
            result.y_ = value;
            return this;
          }
          public Builder ClearY() {
            PrepareBuilder();
            result.hasY = false;
            result.y_ = 0F;
            return this;
          }

          public bool HasZ {
            get { return result.hasZ; }
          }
          public float Z {
            get { return result.Z; }
            set { SetZ(value); }
          }
          public Builder SetZ(float value) {
            PrepareBuilder();
            result.hasZ = true;
            result.z_ = value;
            return this;
          }
          public Builder ClearZ() {
            PrepareBuilder();
            result.hasZ = false;
            result.z_ = 0F;
            return this;
          }

          public bool HasW {
            get { return result.hasW; }
          }
          public float W {
            get { return result.W; }
            set { SetW(value); }
          }
          public Builder SetW(float value) {
            PrepareBuilder();
            result.hasW = true;
            result.w_ = value;
            return this;
          }
          public Builder ClearW() {
            PrepareBuilder();
            result.hasW = false;
            result.w_ = 0F;
            return this;
          }
        }
        static OrientationEvent() {
          object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
        }
      }

      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
      [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
      public sealed partial class KeyEvent : pb::GeneratedMessageLite<KeyEvent, KeyEvent.Builder> {
        private KeyEvent() { }
        private static readonly KeyEvent defaultInstance = new KeyEvent().MakeReadOnly();
        private static readonly string[] _keyEventFieldNames = new string[] { "action", "code" };
        private static readonly uint[] _keyEventFieldTags = new uint[] { 8, 16 };
        public static KeyEvent DefaultInstance {
          get { return defaultInstance; }
        }

        public override KeyEvent DefaultInstanceForType {
          get { return DefaultInstance; }
        }

        protected override KeyEvent ThisMessage {
          get { return this; }
        }

        public const int ActionFieldNumber = 1;
        private bool hasAction;
        private int action_;
        public bool HasAction {
          get { return hasAction; }
        }
        public int Action {
          get { return action_; }
        }

        public const int CodeFieldNumber = 2;
        private bool hasCode;
        private int code_;
        public bool HasCode {
          get { return hasCode; }
        }
        public int Code {
          get { return code_; }
        }

        public override bool IsInitialized {
          get {
            return true;
          }
        }

        public override void WriteTo(pb::ICodedOutputStream output) {
          string[] field_names = _keyEventFieldNames;
          if (hasAction) {
            output.WriteInt32(1, field_names[0], Action);
          }
          if (hasCode) {
            output.WriteInt32(2, field_names[1], Code);
          }
        }

        private int memoizedSerializedSize = -1;
        public override int SerializedSize {
          get {
            int size = memoizedSerializedSize;
            if (size != -1) return size;

            size = 0;
            if (hasAction) {
              size += pb::CodedOutputStream.ComputeInt32Size(1, Action);
            }
            if (hasCode) {
              size += pb::CodedOutputStream.ComputeInt32Size(2, Code);
            }
            memoizedSerializedSize = size;
            return size;
          }
        }

        #region Lite runtime methods
        public override int GetHashCode() {
          int hash = GetType().GetHashCode();
          if (hasAction) hash ^= action_.GetHashCode();
          if (hasCode) hash ^= code_.GetHashCode();
          return hash;
        }

        public override bool Equals(object obj) {
          KeyEvent other = obj as KeyEvent;
          if (other == null) return false;
          if (hasAction != other.hasAction || (hasAction && !action_.Equals(other.action_))) return false;
          if (hasCode != other.hasCode || (hasCode && !code_.Equals(other.code_))) return false;
          return true;
        }

        public override void PrintTo(global::System.IO.TextWriter writer) {
          PrintField("action", hasAction, action_, writer);
          PrintField("code", hasCode, code_, writer);
        }
        #endregion

        public static KeyEvent ParseFrom(pb::ByteString data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static KeyEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static KeyEvent ParseFrom(byte[] data) {
          return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
        }
        public static KeyEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
        }
        public static KeyEvent ParseFrom(global::System.IO.Stream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static KeyEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        public static KeyEvent ParseDelimitedFrom(global::System.IO.Stream input) {
          return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }
        public static KeyEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
          return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }
        public static KeyEvent ParseFrom(pb::ICodedInputStream input) {
          return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
        }
        public static KeyEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
        }
        private KeyEvent MakeReadOnly() {
          return this;
        }

        public static Builder CreateBuilder() { return new Builder(); }
        public override Builder ToBuilder() { return CreateBuilder(this); }
        public override Builder CreateBuilderForType() { return new Builder(); }
        public static Builder CreateBuilder(KeyEvent prototype) {
          return new Builder(prototype);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
        public sealed partial class Builder : pb::GeneratedBuilderLite<KeyEvent, Builder> {
          protected override Builder ThisBuilder {
            get { return this; }
          }
          public Builder() {
            result = DefaultInstance;
            resultIsReadOnly = true;
          }
          internal Builder(KeyEvent cloneFrom) {
            result = cloneFrom;
            resultIsReadOnly = true;
          }

          private bool resultIsReadOnly;
          private KeyEvent result;

          private KeyEvent PrepareBuilder() {
            if (resultIsReadOnly) {
              KeyEvent original = result;
              result = new KeyEvent();
              resultIsReadOnly = false;
              MergeFrom(original);
            }
            return result;
          }

          public override bool IsInitialized {
            get { return result.IsInitialized; }
          }

          protected override KeyEvent MessageBeingBuilt {
            get { return PrepareBuilder(); }
          }

          public override Builder Clear() {
            result = DefaultInstance;
            resultIsReadOnly = true;
            return this;
          }

          public override Builder Clone() {
            if (resultIsReadOnly) {
              return new Builder(result);
            } else {
              return new Builder().MergeFrom(result);
            }
          }

          public override KeyEvent DefaultInstanceForType {
            get { return global::proto.PhoneEvent.Types.KeyEvent.DefaultInstance; }
          }

          public override KeyEvent BuildPartial() {
            if (resultIsReadOnly) {
              return result;
            }
            resultIsReadOnly = true;
            return result.MakeReadOnly();
          }

          public override Builder MergeFrom(pb::IMessageLite other) {
            if (other is KeyEvent) {
              return MergeFrom((KeyEvent) other);
            } else {
              base.MergeFrom(other);
              return this;
            }
          }

          public override Builder MergeFrom(KeyEvent other) {
            if (other == global::proto.PhoneEvent.Types.KeyEvent.DefaultInstance) return this;
            PrepareBuilder();
            if (other.HasAction) {
              Action = other.Action;
            }
            if (other.HasCode) {
              Code = other.Code;
            }
            return this;
          }

          public override Builder MergeFrom(pb::ICodedInputStream input) {
            return MergeFrom(input, pb::ExtensionRegistry.Empty);
          }

          public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
            PrepareBuilder();
            uint tag;
            string field_name;
            while (input.ReadTag(out tag, out field_name)) {
              if(tag == 0 && field_name != null) {
                int field_ordinal = global::System.Array.BinarySearch(_keyEventFieldNames, field_name, global::System.StringComparer.Ordinal);
                if(field_ordinal >= 0)
                  tag = _keyEventFieldTags[field_ordinal];
                else {
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  continue;
                }
              }
              switch (tag) {
                case 0: {
                  throw pb::InvalidProtocolBufferException.InvalidTag();
                }
                default: {
                  if (pb::WireFormat.IsEndGroupTag(tag)) {
                    return this;
                  }
                  ParseUnknownField(input, extensionRegistry, tag, field_name);
                  break;
                }
                case 8: {
                  result.hasAction = input.ReadInt32(ref result.action_);
                  break;
                }
                case 16: {
                  result.hasCode = input.ReadInt32(ref result.code_);
                  break;
                }
              }
            }

            return this;
          }


          public bool HasAction {
            get { return result.hasAction; }
          }
          public int Action {
            get { return result.Action; }
            set { SetAction(value); }
          }
          public Builder SetAction(int value) {
            PrepareBuilder();
            result.hasAction = true;
            result.action_ = value;
            return this;
          }
          public Builder ClearAction() {
            PrepareBuilder();
            result.hasAction = false;
            result.action_ = 0;
            return this;
          }

          public bool HasCode {
            get { return result.hasCode; }
          }
          public int Code {
            get { return result.Code; }
            set { SetCode(value); }
          }
          public Builder SetCode(int value) {
            PrepareBuilder();
            result.hasCode = true;
            result.code_ = value;
            return this;
          }
          public Builder ClearCode() {
            PrepareBuilder();
            result.hasCode = false;
            result.code_ = 0;
            return this;
          }
        }
        static KeyEvent() {
          object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
        }
      }

    }
    #endregion

    public const int TypeFieldNumber = 1;
    private bool hasType;
    private global::proto.PhoneEvent.Types.Type type_ = global::proto.PhoneEvent.Types.Type.MOTION;
    public bool HasType {
      get { return hasType; }
    }
    public global::proto.PhoneEvent.Types.Type Type {
      get { return type_; }
    }

    public const int MotionEventFieldNumber = 2;
    private bool hasMotionEvent;
    private global::proto.PhoneEvent.Types.MotionEvent motionEvent_;
    public bool HasMotionEvent {
      get { return hasMotionEvent; }
    }
    public global::proto.PhoneEvent.Types.MotionEvent MotionEvent {
      get { return motionEvent_ ?? global::proto.PhoneEvent.Types.MotionEvent.DefaultInstance; }
    }

    public const int GyroscopeEventFieldNumber = 3;
    private bool hasGyroscopeEvent;
    private global::proto.PhoneEvent.Types.GyroscopeEvent gyroscopeEvent_;
    public bool HasGyroscopeEvent {
      get { return hasGyroscopeEvent; }
    }
    public global::proto.PhoneEvent.Types.GyroscopeEvent GyroscopeEvent {
      get { return gyroscopeEvent_ ?? global::proto.PhoneEvent.Types.GyroscopeEvent.DefaultInstance; }
    }

    public const int AccelerometerEventFieldNumber = 4;
    private bool hasAccelerometerEvent;
    private global::proto.PhoneEvent.Types.AccelerometerEvent accelerometerEvent_;
    public bool HasAccelerometerEvent {
      get { return hasAccelerometerEvent; }
    }
    public global::proto.PhoneEvent.Types.AccelerometerEvent AccelerometerEvent {
      get { return accelerometerEvent_ ?? global::proto.PhoneEvent.Types.AccelerometerEvent.DefaultInstance; }
    }

    public const int DepthMapEventFieldNumber = 5;
    private bool hasDepthMapEvent;
    private global::proto.PhoneEvent.Types.DepthMapEvent depthMapEvent_;
    public bool HasDepthMapEvent {
      get { return hasDepthMapEvent; }
    }
    public global::proto.PhoneEvent.Types.DepthMapEvent DepthMapEvent {
      get { return depthMapEvent_ ?? global::proto.PhoneEvent.Types.DepthMapEvent.DefaultInstance; }
    }

    public const int OrientationEventFieldNumber = 6;
    private bool hasOrientationEvent;
    private global::proto.PhoneEvent.Types.OrientationEvent orientationEvent_;
    public bool HasOrientationEvent {
      get { return hasOrientationEvent; }
    }
    public global::proto.PhoneEvent.Types.OrientationEvent OrientationEvent {
      get { return orientationEvent_ ?? global::proto.PhoneEvent.Types.OrientationEvent.DefaultInstance; }
    }

    public const int KeyEventFieldNumber = 7;
    private bool hasKeyEvent;
    private global::proto.PhoneEvent.Types.KeyEvent keyEvent_;
    public bool HasKeyEvent {
      get { return hasKeyEvent; }
    }
    public global::proto.PhoneEvent.Types.KeyEvent KeyEvent {
      get { return keyEvent_ ?? global::proto.PhoneEvent.Types.KeyEvent.DefaultInstance; }
    }

    public override bool IsInitialized {
      get {
        return true;
      }
    }

    public override void WriteTo(pb::ICodedOutputStream output) {
      string[] field_names = _phoneEventFieldNames;
      if (hasType) {
        output.WriteEnum(1, field_names[6], (int) Type, Type);
      }
      if (hasMotionEvent) {
        output.WriteMessage(2, field_names[4], MotionEvent);
      }
      if (hasGyroscopeEvent) {
        output.WriteMessage(3, field_names[2], GyroscopeEvent);
      }
      if (hasAccelerometerEvent) {
        output.WriteMessage(4, field_names[0], AccelerometerEvent);
      }
      if (hasDepthMapEvent) {
        output.WriteMessage(5, field_names[1], DepthMapEvent);
      }
      if (hasOrientationEvent) {
        output.WriteMessage(6, field_names[5], OrientationEvent);
      }
      if (hasKeyEvent) {
        output.WriteMessage(7, field_names[3], KeyEvent);
      }
    }

    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;

        size = 0;
        if (hasType) {
          size += pb::CodedOutputStream.ComputeEnumSize(1, (int) Type);
        }
        if (hasMotionEvent) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, MotionEvent);
        }
        if (hasGyroscopeEvent) {
          size += pb::CodedOutputStream.ComputeMessageSize(3, GyroscopeEvent);
        }
        if (hasAccelerometerEvent) {
          size += pb::CodedOutputStream.ComputeMessageSize(4, AccelerometerEvent);
        }
        if (hasDepthMapEvent) {
          size += pb::CodedOutputStream.ComputeMessageSize(5, DepthMapEvent);
        }
        if (hasOrientationEvent) {
          size += pb::CodedOutputStream.ComputeMessageSize(6, OrientationEvent);
        }
        if (hasKeyEvent) {
          size += pb::CodedOutputStream.ComputeMessageSize(7, KeyEvent);
        }
        memoizedSerializedSize = size;
        return size;
      }
    }

    #region Lite runtime methods
    public override int GetHashCode() {
      int hash = GetType().GetHashCode();
      if (hasType) hash ^= type_.GetHashCode();
      if (hasMotionEvent) hash ^= motionEvent_.GetHashCode();
      if (hasGyroscopeEvent) hash ^= gyroscopeEvent_.GetHashCode();
      if (hasAccelerometerEvent) hash ^= accelerometerEvent_.GetHashCode();
      if (hasDepthMapEvent) hash ^= depthMapEvent_.GetHashCode();
      if (hasOrientationEvent) hash ^= orientationEvent_.GetHashCode();
      if (hasKeyEvent) hash ^= keyEvent_.GetHashCode();
      return hash;
    }

    public override bool Equals(object obj) {
      PhoneEvent other = obj as PhoneEvent;
      if (other == null) return false;
      if (hasType != other.hasType || (hasType && !type_.Equals(other.type_))) return false;
      if (hasMotionEvent != other.hasMotionEvent || (hasMotionEvent && !motionEvent_.Equals(other.motionEvent_))) return false;
      if (hasGyroscopeEvent != other.hasGyroscopeEvent || (hasGyroscopeEvent && !gyroscopeEvent_.Equals(other.gyroscopeEvent_))) return false;
      if (hasAccelerometerEvent != other.hasAccelerometerEvent || (hasAccelerometerEvent && !accelerometerEvent_.Equals(other.accelerometerEvent_))) return false;
      if (hasDepthMapEvent != other.hasDepthMapEvent || (hasDepthMapEvent && !depthMapEvent_.Equals(other.depthMapEvent_))) return false;
      if (hasOrientationEvent != other.hasOrientationEvent || (hasOrientationEvent && !orientationEvent_.Equals(other.orientationEvent_))) return false;
      if (hasKeyEvent != other.hasKeyEvent || (hasKeyEvent && !keyEvent_.Equals(other.keyEvent_))) return false;
      return true;
    }

    public override void PrintTo(global::System.IO.TextWriter writer) {
      PrintField("type", hasType, type_, writer);
      PrintField("motion_event", hasMotionEvent, motionEvent_, writer);
      PrintField("gyroscope_event", hasGyroscopeEvent, gyroscopeEvent_, writer);
      PrintField("accelerometer_event", hasAccelerometerEvent, accelerometerEvent_, writer);
      PrintField("depth_map_event", hasDepthMapEvent, depthMapEvent_, writer);
      PrintField("orientation_event", hasOrientationEvent, orientationEvent_, writer);
      PrintField("key_event", hasKeyEvent, keyEvent_, writer);
    }
    #endregion

    public static PhoneEvent ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static PhoneEvent ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static PhoneEvent ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static PhoneEvent ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static PhoneEvent ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static PhoneEvent ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static PhoneEvent ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static PhoneEvent ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static PhoneEvent ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static PhoneEvent ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private PhoneEvent MakeReadOnly() {
      return this;
    }

    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(PhoneEvent prototype) {
      return new Builder(prototype);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilderLite<PhoneEvent, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(PhoneEvent cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }

      private bool resultIsReadOnly;
      private PhoneEvent result;

      private PhoneEvent PrepareBuilder() {
        if (resultIsReadOnly) {
          PhoneEvent original = result;
          result = new PhoneEvent();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }

      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }

      protected override PhoneEvent MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }

      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }

      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }

      public override PhoneEvent DefaultInstanceForType {
        get { return global::proto.PhoneEvent.DefaultInstance; }
      }

      public override PhoneEvent BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }

      public override Builder MergeFrom(pb::IMessageLite other) {
        if (other is PhoneEvent) {
          return MergeFrom((PhoneEvent) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }

      public override Builder MergeFrom(PhoneEvent other) {
        if (other == global::proto.PhoneEvent.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasType) {
          Type = other.Type;
        }
        if (other.HasMotionEvent) {
          MergeMotionEvent(other.MotionEvent);
        }
        if (other.HasGyroscopeEvent) {
          MergeGyroscopeEvent(other.GyroscopeEvent);
        }
        if (other.HasAccelerometerEvent) {
          MergeAccelerometerEvent(other.AccelerometerEvent);
        }
        if (other.HasDepthMapEvent) {
          MergeDepthMapEvent(other.DepthMapEvent);
        }
        if (other.HasOrientationEvent) {
          MergeOrientationEvent(other.OrientationEvent);
        }
        if (other.HasKeyEvent) {
          MergeKeyEvent(other.KeyEvent);
        }
        return this;
      }

      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }

      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_phoneEventFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _phoneEventFieldTags[field_ordinal];
            else {
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                return this;
              }
              ParseUnknownField(input, extensionRegistry, tag, field_name);
              break;
            }
            case 8: {
              object unknown;
              if(input.ReadEnum(ref result.type_, out unknown)) {
                result.hasType = true;
              } else if(unknown is int) {
              }
              break;
            }
            case 18: {
              global::proto.PhoneEvent.Types.MotionEvent.Builder subBuilder = global::proto.PhoneEvent.Types.MotionEvent.CreateBuilder();
              if (result.hasMotionEvent) {
                subBuilder.MergeFrom(MotionEvent);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              MotionEvent = subBuilder.BuildPartial();
              break;
            }
            case 26: {
              global::proto.PhoneEvent.Types.GyroscopeEvent.Builder subBuilder = global::proto.PhoneEvent.Types.GyroscopeEvent.CreateBuilder();
              if (result.hasGyroscopeEvent) {
                subBuilder.MergeFrom(GyroscopeEvent);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              GyroscopeEvent = subBuilder.BuildPartial();
              break;
            }
            case 34: {
              global::proto.PhoneEvent.Types.AccelerometerEvent.Builder subBuilder = global::proto.PhoneEvent.Types.AccelerometerEvent.CreateBuilder();
              if (result.hasAccelerometerEvent) {
                subBuilder.MergeFrom(AccelerometerEvent);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              AccelerometerEvent = subBuilder.BuildPartial();
              break;
            }
            case 42: {
              global::proto.PhoneEvent.Types.DepthMapEvent.Builder subBuilder = global::proto.PhoneEvent.Types.DepthMapEvent.CreateBuilder();
              if (result.hasDepthMapEvent) {
                subBuilder.MergeFrom(DepthMapEvent);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              DepthMapEvent = subBuilder.BuildPartial();
              break;
            }
            case 50: {
              global::proto.PhoneEvent.Types.OrientationEvent.Builder subBuilder = global::proto.PhoneEvent.Types.OrientationEvent.CreateBuilder();
              if (result.hasOrientationEvent) {
                subBuilder.MergeFrom(OrientationEvent);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              OrientationEvent = subBuilder.BuildPartial();
              break;
            }
            case 58: {
              global::proto.PhoneEvent.Types.KeyEvent.Builder subBuilder = global::proto.PhoneEvent.Types.KeyEvent.CreateBuilder();
              if (result.hasKeyEvent) {
                subBuilder.MergeFrom(KeyEvent);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              KeyEvent = subBuilder.BuildPartial();
              break;
            }
          }
        }

        return this;
      }


      public bool HasType {
       get { return result.hasType; }
      }
      public global::proto.PhoneEvent.Types.Type Type {
        get { return result.Type; }
        set { SetType(value); }
      }
      public Builder SetType(global::proto.PhoneEvent.Types.Type value) {
        PrepareBuilder();
        result.hasType = true;
        result.type_ = value;
        return this;
      }
      public Builder ClearType() {
        PrepareBuilder();
        result.hasType = false;
        result.type_ = global::proto.PhoneEvent.Types.Type.MOTION;
        return this;
      }

      public bool HasMotionEvent {
       get { return result.hasMotionEvent; }
      }
      public global::proto.PhoneEvent.Types.MotionEvent MotionEvent {
        get { return result.MotionEvent; }
        set { SetMotionEvent(value); }
      }
      public Builder SetMotionEvent(global::proto.PhoneEvent.Types.MotionEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasMotionEvent = true;
        result.motionEvent_ = value;
        return this;
      }
      public Builder SetMotionEvent(global::proto.PhoneEvent.Types.MotionEvent.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasMotionEvent = true;
        result.motionEvent_ = builderForValue.Build();
        return this;
      }
      public Builder MergeMotionEvent(global::proto.PhoneEvent.Types.MotionEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasMotionEvent &&
            result.motionEvent_ != global::proto.PhoneEvent.Types.MotionEvent.DefaultInstance) {
            result.motionEvent_ = global::proto.PhoneEvent.Types.MotionEvent.CreateBuilder(result.motionEvent_).MergeFrom(value).BuildPartial();
        } else {
          result.motionEvent_ = value;
        }
        result.hasMotionEvent = true;
        return this;
      }
      public Builder ClearMotionEvent() {
        PrepareBuilder();
        result.hasMotionEvent = false;
        result.motionEvent_ = null;
        return this;
      }

      public bool HasGyroscopeEvent {
       get { return result.hasGyroscopeEvent; }
      }
      public global::proto.PhoneEvent.Types.GyroscopeEvent GyroscopeEvent {
        get { return result.GyroscopeEvent; }
        set { SetGyroscopeEvent(value); }
      }
      public Builder SetGyroscopeEvent(global::proto.PhoneEvent.Types.GyroscopeEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasGyroscopeEvent = true;
        result.gyroscopeEvent_ = value;
        return this;
      }
      public Builder SetGyroscopeEvent(global::proto.PhoneEvent.Types.GyroscopeEvent.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasGyroscopeEvent = true;
        result.gyroscopeEvent_ = builderForValue.Build();
        return this;
      }
      public Builder MergeGyroscopeEvent(global::proto.PhoneEvent.Types.GyroscopeEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasGyroscopeEvent &&
            result.gyroscopeEvent_ != global::proto.PhoneEvent.Types.GyroscopeEvent.DefaultInstance) {
            result.gyroscopeEvent_ = global::proto.PhoneEvent.Types.GyroscopeEvent.CreateBuilder(result.gyroscopeEvent_).MergeFrom(value).BuildPartial();
        } else {
          result.gyroscopeEvent_ = value;
        }
        result.hasGyroscopeEvent = true;
        return this;
      }
      public Builder ClearGyroscopeEvent() {
        PrepareBuilder();
        result.hasGyroscopeEvent = false;
        result.gyroscopeEvent_ = null;
        return this;
      }

      public bool HasAccelerometerEvent {
       get { return result.hasAccelerometerEvent; }
      }
      public global::proto.PhoneEvent.Types.AccelerometerEvent AccelerometerEvent {
        get { return result.AccelerometerEvent; }
        set { SetAccelerometerEvent(value); }
      }
      public Builder SetAccelerometerEvent(global::proto.PhoneEvent.Types.AccelerometerEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasAccelerometerEvent = true;
        result.accelerometerEvent_ = value;
        return this;
      }
      public Builder SetAccelerometerEvent(global::proto.PhoneEvent.Types.AccelerometerEvent.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasAccelerometerEvent = true;
        result.accelerometerEvent_ = builderForValue.Build();
        return this;
      }
      public Builder MergeAccelerometerEvent(global::proto.PhoneEvent.Types.AccelerometerEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasAccelerometerEvent &&
            result.accelerometerEvent_ != global::proto.PhoneEvent.Types.AccelerometerEvent.DefaultInstance) {
            result.accelerometerEvent_ = global::proto.PhoneEvent.Types.AccelerometerEvent.CreateBuilder(result.accelerometerEvent_).MergeFrom(value).BuildPartial();
        } else {
          result.accelerometerEvent_ = value;
        }
        result.hasAccelerometerEvent = true;
        return this;
      }
      public Builder ClearAccelerometerEvent() {
        PrepareBuilder();
        result.hasAccelerometerEvent = false;
        result.accelerometerEvent_ = null;
        return this;
      }

      public bool HasDepthMapEvent {
       get { return result.hasDepthMapEvent; }
      }
      public global::proto.PhoneEvent.Types.DepthMapEvent DepthMapEvent {
        get { return result.DepthMapEvent; }
        set { SetDepthMapEvent(value); }
      }
      public Builder SetDepthMapEvent(global::proto.PhoneEvent.Types.DepthMapEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasDepthMapEvent = true;
        result.depthMapEvent_ = value;
        return this;
      }
      public Builder SetDepthMapEvent(global::proto.PhoneEvent.Types.DepthMapEvent.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasDepthMapEvent = true;
        result.depthMapEvent_ = builderForValue.Build();
        return this;
      }
      public Builder MergeDepthMapEvent(global::proto.PhoneEvent.Types.DepthMapEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasDepthMapEvent &&
            result.depthMapEvent_ != global::proto.PhoneEvent.Types.DepthMapEvent.DefaultInstance) {
            result.depthMapEvent_ = global::proto.PhoneEvent.Types.DepthMapEvent.CreateBuilder(result.depthMapEvent_).MergeFrom(value).BuildPartial();
        } else {
          result.depthMapEvent_ = value;
        }
        result.hasDepthMapEvent = true;
        return this;
      }
      public Builder ClearDepthMapEvent() {
        PrepareBuilder();
        result.hasDepthMapEvent = false;
        result.depthMapEvent_ = null;
        return this;
      }

      public bool HasOrientationEvent {
       get { return result.hasOrientationEvent; }
      }
      public global::proto.PhoneEvent.Types.OrientationEvent OrientationEvent {
        get { return result.OrientationEvent; }
        set { SetOrientationEvent(value); }
      }
      public Builder SetOrientationEvent(global::proto.PhoneEvent.Types.OrientationEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasOrientationEvent = true;
        result.orientationEvent_ = value;
        return this;
      }
      public Builder SetOrientationEvent(global::proto.PhoneEvent.Types.OrientationEvent.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasOrientationEvent = true;
        result.orientationEvent_ = builderForValue.Build();
        return this;
      }
      public Builder MergeOrientationEvent(global::proto.PhoneEvent.Types.OrientationEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasOrientationEvent &&
            result.orientationEvent_ != global::proto.PhoneEvent.Types.OrientationEvent.DefaultInstance) {
            result.orientationEvent_ = global::proto.PhoneEvent.Types.OrientationEvent.CreateBuilder(result.orientationEvent_).MergeFrom(value).BuildPartial();
        } else {
          result.orientationEvent_ = value;
        }
        result.hasOrientationEvent = true;
        return this;
      }
      public Builder ClearOrientationEvent() {
        PrepareBuilder();
        result.hasOrientationEvent = false;
        result.orientationEvent_ = null;
        return this;
      }

      public bool HasKeyEvent {
       get { return result.hasKeyEvent; }
      }
      public global::proto.PhoneEvent.Types.KeyEvent KeyEvent {
        get { return result.KeyEvent; }
        set { SetKeyEvent(value); }
      }
      public Builder SetKeyEvent(global::proto.PhoneEvent.Types.KeyEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasKeyEvent = true;
        result.keyEvent_ = value;
        return this;
      }
      public Builder SetKeyEvent(global::proto.PhoneEvent.Types.KeyEvent.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        PrepareBuilder();
        result.hasKeyEvent = true;
        result.keyEvent_ = builderForValue.Build();
        return this;
      }
      public Builder MergeKeyEvent(global::proto.PhoneEvent.Types.KeyEvent value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        if (result.hasKeyEvent &&
            result.keyEvent_ != global::proto.PhoneEvent.Types.KeyEvent.DefaultInstance) {
            result.keyEvent_ = global::proto.PhoneEvent.Types.KeyEvent.CreateBuilder(result.keyEvent_).MergeFrom(value).BuildPartial();
        } else {
          result.keyEvent_ = value;
        }
        result.hasKeyEvent = true;
        return this;
      }
      public Builder ClearKeyEvent() {
        PrepareBuilder();
        result.hasKeyEvent = false;
        result.keyEvent_ = null;
        return this;
      }
    }
    static PhoneEvent() {
      object.ReferenceEquals(global::proto.Proto.PhoneEvent.Descriptor, null);
    }
  }

  #endregion

}
/// @endcond

#endregion Designer generated code
