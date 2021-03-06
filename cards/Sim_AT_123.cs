using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_123 : SimTemplate //Chillmaw
    {

        //Taunt , Deathrattle: If you're holding a Dragon, deal 3 damage to all minions.


        public override void onDeathrattle(Playfield p, Minion m)
        {
            bool hasdragon = false;
            if (m.own)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.race == TAG_RACE.DRAGON) hasdragon = true;
                }
            }
            else
            {
                if (p.enemyAnzCards >= 2) hasdragon = true;
            }

            if (hasdragon)
            {
                p.allMinionsGetDamage(3);
            }


        }
       


    }

}