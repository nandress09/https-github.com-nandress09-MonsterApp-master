using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClass
{
     public interface IBattle
    {

        //public Monster.MonsterAction MonsterBattleResponse() is not needed because all interfaces are public
        Monster.MonsterAction MonsterBattleResponse();

    }
}
