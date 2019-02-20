using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClass
{
    public abstract class Monster
    {

        //abstract HAS to be here due to method IsHappy at the bottom of this page, refer to later notes

        //Gives actions to the different monsters in the program
        public enum MonsterAction {Attack, Defend, Retreat }


        private int _id;
        private string _name;
        private int _age;
        private bool _isActive;
        

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //constructers (note:type ct tab tab to create a new one)
        public Monster()
        {

        }
        public Monster(int id, string name)
        {
            //this is where we keep the drawer to hold id and name for the monster
            _id = id;
            _name = name;
        }


        public virtual string Greeting()
        {
            //This is where we store the greeting for the program
            //this class is an OPTION class to use because it is called a VIRTUAL public string, or it may also be a default class implemented into the program
            return $"Hello! My name is {_name}.";
        }

        public abstract bool IsHappy();
        
            //when something is made ABSTRACT: we are telling the derived methods that this MUST exist. the "monster" NEEDS to determine whether it is or not happy..
            //in order for this abstract to be acceptable, it HAS to be inside of an abstract class!

        


    }
}
