using System;
using Exiled.Events.EventArgs;
using MEC;

namespace PeanutInfection
{
    public class EventHandlers
    {
        public void OnDying(DyingEventArgs ev)
        {
            Timing.CallDelayed(Main.singleton.Config.Delay, () =>
            {
                if (ev.Killer.Role == RoleType.Scp173)
                {
                    ev.Target.SetRole(RoleType.Scp173);
                    
                    if (Main.singleton.Config.Enablebc)
                    {
                        ev.Target.Broadcast(5, Main.singleton.Config.Broadcast);
                    }
                }
            });
        }
    }
}
