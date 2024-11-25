using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.EventArgs.Server;
using Exiled.Events.Handlers;
using Player = Exiled.Events.Handlers.Player;


namespace teslagate
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "fatal error 404";
        public override string Name => "better TeslaGate";
        public override string Prefix => "betterTeslaGate";
        public override Version Version => new Version(1, 0, 0);

        public EventHandlers EventHandler;

        
        public override void OnEnabled()
        {
            EventHandler = new EventHandlers();
            Player.TriggeringTesla += EventHandler.TriggeringTesla;
        }

        public override void OnDisabled()
        {
            // Don't forget, events must be disconnected and nullified on the disable method.
            Player.TriggeringTesla -= EventHandler.TriggeringTesla;
            EventHandler = null;

        }
        
        


    }
}