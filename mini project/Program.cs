using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Character_Blueprint char1 = new Character_Blueprint();
            char1.name = "Steven";
            char1.speed = 4;
            char1.dexterity = 3;
            char1.intelligence = 10;
            Console.WriteLine($"The first character you have made has the name of {char1.name}. His stats are as follows: Speed:{char1.speed}   Dexterity:{char1.dexterity}    Intelligence:{char1.intelligence}");

            Character_Blueprint char2 = new Character_Blueprint();
            char2.name = "Bob";
            char2.speed = 8;
            char2.dexterity = 5;
            char2.intelligence = 1;
            Console.WriteLine($"The second character you have made has the name of {char2.name}. His stats are as follows: Speed:{char2.speed}   Dexterity:{char2.dexterity}    Intelligence:{char2.intelligence}");

            Character_Blueprint char3 = new Character_Blueprint();
            char3.name = "Kyle";
            char3.speed = 10;
            char3.dexterity = 10;
            char3.intelligence = 0;
            Console.WriteLine($"The third character you have made has the name of {char3.name}. His stats are as follows: Speed:{char3.speed}   Dexterity:{char3.dexterity}    Intelligence:{char3.intelligence}");

            Character_Blueprint char4 = new Character_Blueprint();
            char4.name = "Karen";
            char4.speed = 1;
            char4.dexterity = 1;
            char4.intelligence = 1;
            Console.WriteLine($"The fourth character you have made has the name of {char4.name}. His stats are as follows: Speed:{char4.speed}   Dexterity:{char4.dexterity}    Intelligence:{char4.intelligence}");

            Wizard char5 = new Wizard();
            char5.name = "Cool Wizard";
            char5.speed = 7;
            char5.dexterity = 6;
            char5.intelligence = 10;
            char5.hasFireBall = true;
            Console.WriteLine($"The fith character you have made has the name of {char5.name}. His stats are as follows: Speed:{char5.speed}   Dexterity:{char5.dexterity}    Intelligence:{char5.intelligence}. Has Fireball? {char5.hasFireBall}.");
            char5.woosh();
            
            Console.ReadKey();
        }
    }
}
