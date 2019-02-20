using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClass
{
     public interface IBattle
    {

        //call to Monster class, and then summon the enum we need from that class


        //public Monster.MonsterAction MonsterBattleResponse() is not needed because all interfaces are public
        Monster.MonsterAction MonsterBattleResponse();

    }
}
