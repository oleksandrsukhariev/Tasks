using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3PracticalTask.Interfaces;

namespace Chapter3PracticalTask.Classes
{
   public class Horse : Animals, IEatHay
    {
       public void EatSomeHay()
       {
           Console.WriteLine("Om nom nom, delicious!!");
       }
    }
}
