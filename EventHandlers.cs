using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;

namespace teslagate
{
    public class EventHandlers
    {
        public void TriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            // Disable the event for foundation personnel players.
            // This can be accomplished by checking the player's side.
            if (ev.Player.Role.Side == Side.Mtf)
            {
                // Disable the tesla trigger by setting ev.IsTriggerable to false.
                // Players who have a MTF ranking will no longer trigger tesla gates.
                ev.IsTriggerable = false;
            }
        }
    }
}