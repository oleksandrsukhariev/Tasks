using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3PracticalTask.Interfaces;

namespace Chapter3PracticalTask.Classes
{
   public class Crucian : Fishes,IEatHay
    {
        public void EatSomeHay()
        {
            Console.WriteLine("No idea where i can see some hay!!");
        }
    }
}
