//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: player.proto
namespace FirSanguo
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerBase")]
  public partial class PlayerBase : global::ProtoBuf.IExtensible
  {
    public PlayerBase() {}
    
    private ulong _playerid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong playerid
    {
      get { return _playerid; }
      set { _playerid = value; }
    }
    private string _nickname;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private string _role;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"role", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string role
    {
      get { return _role; }
      set { _role = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerDispaly")]
  public partial class PlayerDispaly : global::ProtoBuf.IExtensible
  {
    public PlayerDispaly() {}
    
    private FirSanguo.PlayerBase _playerbase;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerbase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public FirSanguo.PlayerBase playerbase
    {
      get { return _playerbase; }
      set { _playerbase = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlayerCore")]
  public partial class PlayerCore : global::ProtoBuf.IExtensible
  {
    public PlayerCore() {}
    
    private FirSanguo.PlayerBase _playerbase;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerbase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public FirSanguo.PlayerBase playerbase
    {
      get { return _playerbase; }
      set { _playerbase = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}