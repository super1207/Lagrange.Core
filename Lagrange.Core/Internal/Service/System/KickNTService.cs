using Lagrange.Core.Common;
using Lagrange.Core.Internal.Event.Protocol;
using Lagrange.Core.Internal.Event.Protocol.System;
using Lagrange.Core.Internal.Packets.System;
using ProtoBuf;

namespace Lagrange.Core.Internal.Service.System;

// ReSharper disable once InconsistentNaming

[EventSubscribe(typeof(KickNTEvent))]
[Service("trpc.qq_new_tech.status_svc.StatusService.KickNT")]
internal class KickNTService : BaseService<KickNTEvent>
{
    protected override bool Parse(byte[] input, BotKeystore keystore, BotAppInfo appInfo, BotDeviceInfo device, 
        out KickNTEvent output, out List<ProtocolEvent>? extraEvents)
    {
        var response = Serializer.Deserialize<ServiceKickNTResponse>(input.AsSpan());
        output = KickNTEvent.Create(response.Tips, response.Title);
        
        extraEvents = null;
        return true;
    }
}