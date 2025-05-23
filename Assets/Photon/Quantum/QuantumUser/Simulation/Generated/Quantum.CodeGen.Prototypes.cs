// <auto-generated>
// This code was auto-generated by a tool, every time
// the tool executes this code will be reset.
//
// If you need to extend the classes generated to add
// fields or methods to them, please create partial
// declarations in another file.
// </auto-generated>
#pragma warning disable 0109
#pragma warning disable 1591


namespace Quantum.Prototypes {
  using Photon.Deterministic;
  using Quantum;
  using Quantum.Core;
  using Quantum.Collections;
  using Quantum.Inspector;
  using Quantum.Physics2D;
  using Quantum.Physics3D;
  using Byte = System.Byte;
  using SByte = System.SByte;
  using Int16 = System.Int16;
  using UInt16 = System.UInt16;
  using Int32 = System.Int32;
  using UInt32 = System.UInt32;
  using Int64 = System.Int64;
  using UInt64 = System.UInt64;
  using Boolean = System.Boolean;
  using String = System.String;
  using Object = System.Object;
  using FlagsAttribute = System.FlagsAttribute;
  using SerializableAttribute = System.SerializableAttribute;
  using MethodImplAttribute = System.Runtime.CompilerServices.MethodImplAttribute;
  using MethodImplOptions = System.Runtime.CompilerServices.MethodImplOptions;
  using FieldOffsetAttribute = System.Runtime.InteropServices.FieldOffsetAttribute;
  using StructLayoutAttribute = System.Runtime.InteropServices.StructLayoutAttribute;
  using LayoutKind = System.Runtime.InteropServices.LayoutKind;
  #if QUANTUM_UNITY //;
  using TooltipAttribute = UnityEngine.TooltipAttribute;
  using HeaderAttribute = UnityEngine.HeaderAttribute;
  using SpaceAttribute = UnityEngine.SpaceAttribute;
  using RangeAttribute = UnityEngine.RangeAttribute;
  using HideInInspectorAttribute = UnityEngine.HideInInspector;
  using PreserveAttribute = UnityEngine.Scripting.PreserveAttribute;
  using FormerlySerializedAsAttribute = UnityEngine.Serialization.FormerlySerializedAsAttribute;
  using MovedFromAttribute = UnityEngine.Scripting.APIUpdating.MovedFromAttribute;
  using CreateAssetMenu = UnityEngine.CreateAssetMenuAttribute;
  using RuntimeInitializeOnLoadMethodAttribute = UnityEngine.RuntimeInitializeOnLoadMethodAttribute;
  #endif //;
  
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.AsteroidsAsteroid))]
  public unsafe partial class AsteroidsAsteroidPrototype : ComponentPrototype<Quantum.AsteroidsAsteroid> {
    public AssetRef<EntityPrototype> ChildAsteroid;
    partial void MaterializeUser(Frame frame, ref Quantum.AsteroidsAsteroid result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.AsteroidsAsteroid component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.AsteroidsAsteroid result, in PrototypeMaterializationContext context = default) {
        result.ChildAsteroid = this.ChildAsteroid;
        MaterializeUser(frame, ref result, in context);
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.AsteroidsPlayerLink))]
  public unsafe partial class AsteroidsPlayerLinkPrototype : ComponentPrototype<Quantum.AsteroidsPlayerLink> {
    public PlayerRef PlayerRef;
    partial void MaterializeUser(Frame frame, ref Quantum.AsteroidsPlayerLink result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.AsteroidsPlayerLink component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.AsteroidsPlayerLink result, in PrototypeMaterializationContext context = default) {
        result.PlayerRef = this.PlayerRef;
        MaterializeUser(frame, ref result, in context);
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.AsteroidsProjectile))]
  public unsafe class AsteroidsProjectilePrototype : ComponentPrototype<Quantum.AsteroidsProjectile> {
    public FP TTL;
    public MapEntityId Owner;
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.AsteroidsProjectile component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.AsteroidsProjectile result, in PrototypeMaterializationContext context = default) {
        result.TTL = this.TTL;
        PrototypeValidator.FindMapEntity(this.Owner, in context, out result.Owner);
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.AsteroidsShip))]
  public unsafe partial class AsteroidsShipPrototype : ComponentPrototype<Quantum.AsteroidsShip> {
    public FP AmmoCount;
    public FP FireInterval;
    public Int32 Score;
    partial void MaterializeUser(Frame frame, ref Quantum.AsteroidsShip result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.AsteroidsShip component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.AsteroidsShip result, in PrototypeMaterializationContext context = default) {
        result.AmmoCount = this.AmmoCount;
        result.FireInterval = this.FireInterval;
        result.Score = this.Score;
        MaterializeUser(frame, ref result, in context);
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.AsteroidsShipRespawn))]
  public unsafe partial class AsteroidsShipRespawnPrototype : ComponentPrototype<Quantum.AsteroidsShipRespawn> {
    public FP RespawnTimer;
    partial void MaterializeUser(Frame frame, ref Quantum.AsteroidsShipRespawn result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.AsteroidsShipRespawn component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.AsteroidsShipRespawn result, in PrototypeMaterializationContext context = default) {
        result.RespawnTimer = this.RespawnTimer;
        MaterializeUser(frame, ref result, in context);
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.BulletInfo))]
  public unsafe class BulletInfoPrototype : ComponentPrototype<Quantum.BulletInfo> {
    public FPVector2 Direction;
    public MapEntityId Owner;
    public Quantum.QEnum32<PlayerFacing> Facing;
    public FP Speed;
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.BulletInfo component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.BulletInfo result, in PrototypeMaterializationContext context = default) {
        result.Direction = this.Direction;
        PrototypeValidator.FindMapEntity(this.Owner, in context, out result.Owner);
        result.Facing = this.Facing;
        result.Speed = this.Speed;
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.Input))]
  public unsafe partial class InputPrototype : StructPrototype {
    public Button Left;
    public Button Right;
    public Button Up;
    public Button Fire;
    public FPVector2 Direction;
    public Button Attack;
    public Button SpawnBullet;
    partial void MaterializeUser(Frame frame, ref Quantum.Input result, in PrototypeMaterializationContext context);
    public void Materialize(Frame frame, ref Quantum.Input result, in PrototypeMaterializationContext context = default) {
        result.Left = this.Left;
        result.Right = this.Right;
        result.Up = this.Up;
        result.Fire = this.Fire;
        result.Direction = this.Direction;
        result.Attack = this.Attack;
        result.SpawnBullet = this.SpawnBullet;
        MaterializeUser(frame, ref result, in context);
    }
  }
  [System.SerializableAttribute()]
  [Quantum.Prototypes.Prototype(typeof(Quantum.PlayerInfo))]
  public unsafe partial class PlayerInfoPrototype : ComponentPrototype<Quantum.PlayerInfo> {
    public PlayerRef PlayerRef;
    public FP Damage;
    public FP Health;
    public FP Speed;
    public AssetRef<EntityPrototype> Bullet;
    public Quantum.QEnum32<PlayerFacing> Facing;
    partial void MaterializeUser(Frame frame, ref Quantum.PlayerInfo result, in PrototypeMaterializationContext context);
    public override Boolean AddToEntity(FrameBase f, EntityRef entity, in PrototypeMaterializationContext context) {
        Quantum.PlayerInfo component = default;
        Materialize((Frame)f, ref component, in context);
        return f.Set(entity, component) == SetResult.ComponentAdded;
    }
    public void Materialize(Frame frame, ref Quantum.PlayerInfo result, in PrototypeMaterializationContext context = default) {
        result.PlayerRef = this.PlayerRef;
        result.Damage = this.Damage;
        result.Health = this.Health;
        result.Speed = this.Speed;
        result.Bullet = this.Bullet;
        result.Facing = this.Facing;
        MaterializeUser(frame, ref result, in context);
    }
  }
}
#pragma warning restore 0109
#pragma warning restore 1591
