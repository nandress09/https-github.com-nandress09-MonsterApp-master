using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClass
{
    public class Seamonster : Monster
    {
        //To tell the seamonster to inherit from monster, we need "Seamonster: Monster" in the name of the class

        private bool _hasGills;
        private string _seaName;


        public bool IsEvil { get; set; }




        public string SeaName
        {
            get { return _seaName; }
            set { _seaName = value; }
        }
        
        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }
        


        //In order to speak to Monster class, IsHappy HAS to exist in seamonster. This class (seamonster) does NOT need to be abstract, we just need the abstract method made in the 
        //class we are inheriting from present
        public override bool IsHappy()
        {
            return true;
        }

        public override string Greeting()
        {
            //override string Greeting(): is needed if we want to create a custom greeting that is different from "string Greeting()"
            //New int Greeting(): can be utilized to avoid having to override the default Greeting() 

            return $"Hello! I am a Sea Monster! My name is {base.Name}";
            //in the update, "base." was made so that we no longer have to type it out. 
            //{name} would have worked perfectly fine here, due to we are pulling from Monster class already. 
        }


    }
}
