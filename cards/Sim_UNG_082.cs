using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_UNG_082 : SimTemplate //Thunder Lizard
    {

        //Battlecry: If you played an_Elemental last turn, Adapt.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.anzOwnElementalsLastTurn > 0 && own.own) p.getBestAdapt(own);
        }

        public override void onAdaptChoice(Playfield p, bool ownplay, Minion target, CardDB.cardIDEnum choice)
        {
            List<Minion> temp = p.ownMinions;
            switch (choice)
            {
                case CardDB.cardIDEnum.UNG_999t3:  // 3attack
                    {
                        p.minionGetBuffed(target, 3, 0);
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t8://divine shield
                    {
                        target.divineshild = true;
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t13: //poisonous
                    {
                        target.poisonous = true;
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t14:// +1/+1
                    {
                        p.minionGetBuffed(target, 1, 1);
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t4:// 3hp
                    {
                        p.minionGetBuffed(target, 0, 3);
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t2://deathrattle 2 1/1 plants
                    {
                        target.livingspores++;
                        break;
                    }

                case CardDB.cardIDEnum.UNG_999t7: //windfury
                    {
                        p.minionGetWindfurry(target);
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t6: //taunt
                    {
                        target.taunt = true;
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t10://stealth
                    {
                        target.stealth = true;
                        break;
                    }
                case CardDB.cardIDEnum.UNG_999t5://can't be targeted
                    {
                        target.AdaptedCantBeTargetedBySpellsOrHeroPowers++;
                        break;
                    }
                default: break;
            }
        }

    }

}