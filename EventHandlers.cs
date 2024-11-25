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
            
            if (ev.Player.Role.Side == Side.Mtf)
            {
                
                ev.IsTriggerable = false;
            }
            if (ev.Player.Role.Side == Side.Tutorial)
            {
                
                ev.IsTriggerable = false;
            }

        }
        public void OnTriggerTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.IsTriggerable = false)
                return;
            {
                ev.Player.Broadcast(5, "Вы являетесь ролью обучения либо сотрудника фонда");
                

            }
        }
        public void OnTriggerTesla1(TriggeringTeslaEventArgs ev)
        {
            if (ev.IsTriggerable = false)
                return;
            {
                ev.Player.Broadcast(5, "Вы являетесь ролью обучения либо сотрудника фонда");
                

            }
        }
    }
}

