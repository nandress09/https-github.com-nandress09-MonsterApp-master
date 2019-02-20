 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClass
{
    public class SpaceMonster : Monster, IBattle
    {
        private bool _hasSpaceship;



        public bool HasSpaceship
        {
            get { return _hasSpaceship; }
            set { _hasSpaceship = value; }
        }

        public override string Greeting()
        {
            //override string Greeting(): is needed if we want to create a custom greeting that is different from "string Greeting()"
            //New int Greeting(): can be utilized to avoid having to override the default Greeting() 
        
            return $"Hello! I am a Space Monster! My name is {base.Name}";
            //in the update, "base." was made so that we no longer have to type it out. 
            //{name} would have worked perfectly fine here, due to we are pulling from Monster class already. 
        }


        //Don't forget to implement the IsHappy abstract from Monster
        public override bool IsHappy()
        {
            if (_hasSpaceship)
            {
                return true;

            }
            else
            {
                return false;
            }
            // this does the same thing as the if/else statement
           // return _hasSpaceship ? true : false;
        }

        // when we pull from IBattle interface, this is needed
        public MonsterAction MonsterBattleResponse()
        {
            //we want to make it so that the monster randomly retreats
            Random randomNumber = new Random();
            int actionProbability = randomNumber.Next(0,101);

      
            //set up the probability 
            if (actionProbability >= 66)
            {
               return MonsterAction.Attack;
            }
            else if (actionProbability >=25)
            {
                return MonsterAction.Defend;
            }
            else
            {
                return MonsterAction.Retreat;
            }
            

        }
    }
}
