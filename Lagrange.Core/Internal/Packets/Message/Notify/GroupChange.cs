using ProtoBuf;

namespace Lagrange.Core.Internal.Packets.Message.Notify;

#pragma warning disable CS8618

[ProtoContract]
internal class GroupChange
{
    [ProtoMember(1)] public uint GroupUin { get; set; }
    
    [ProtoMember(2)] public uint Flag { get; set; }
    
    [ProtoMember(3)] public string MemberUid { get; set; }
    
    [ProtoMember(4)] public uint Field4 { get; set; }
    
    [ProtoMember(5)] public string? OperatorUid { get; set; }
    
    [ProtoMember(6)] public uint Type { get; set; }
    
    [ProtoMember(7)] public byte[]? Field7 { get; set; }
}