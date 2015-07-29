using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3PracticalTask.Interfaces;

namespace Chapter3PracticalTask.Classes
{
   public class Dog : Animals,IUnderwaterBreathing
    {
       public void BreathUnderWater()
       {
           Console.WriteLine("Seriously!!!How??");
       }
    }
}
