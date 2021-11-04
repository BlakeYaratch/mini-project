using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project
{
    class Character_Blueprint
    {
        public string name;
        public int speed;
        public int dexterity;
        public int intelligence;
    }
    class Wizard : Character_Blueprint
    {
        public bool hasFireBall;
        public void woosh()
        {
            Console.WriteLine("WOOOSH!");
        }
    }
}
