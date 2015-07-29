using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter3PracticalTask.Classes;

namespace Chapter3PracticalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fill collection
            Dog firstDog = new Dog(){CreatureId = 1};
            Horse firstHorse = new Horse() { CreatureId = 2 };
            Dog secondDog = new Dog() { CreatureId = 3 };
            Crucian firstCrucian = new Crucian() { CreatureId = 4 };
            Roach firstRoach = new Roach() { CreatureId = 5 };
            Crucian secondCrucian = new Crucian() {CreatureId = 6};
            Horse secondHorse = new Horse() {CreatureId = 7};
            #endregion

            List<LivingCreatures> listOfCreatures = new List<LivingCreatures>() {firstDog,firstHorse,secondDog,firstCrucian,firstRoach,secondCrucian,secondHorse};

            Console.WriteLine("Amount of creatures in collection is:{0}\nAmount of legs is:{1}\n",listOfCreatures.Count,AmountOfLegs(listOfCreatures));
            UnderwaterBreathingCreaturesId(listOfCreatures);
            Console.ReadLine();

        }

        /// <summary>
        /// Summ of legs in collection
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static int AmountOfLegs(List<LivingCreatures> list)
        {
            int amount = 0;
            foreach (var animal in list)
            {
                if (animal is Animals)
                {
                    amount += 4;
                }
            }
            return amount;
        }

        /// <summary>
        /// Show creatures id`s if they can breath underwater
        /// </summary>
        /// <param name="list"></param>
        static void UnderwaterBreathingCreaturesId(List<LivingCreatures> list)
        {
            foreach (var creature in list)
            {
                if (creature.GetType() == typeof(Crucian) | creature.GetType() == typeof(Roach) | creature.GetType() == typeof(Dog))
                {
                    Console.WriteLine("{0} can breath underwater and got ID: {1}",creature.GetType().Name,creature.CreatureId);
                }
            }
        }
    }
}
