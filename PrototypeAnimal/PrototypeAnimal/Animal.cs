using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAnimal
{
    public class Animal : ICloneable
    {
        public Head AHead { get; set; }
        public List<Leg> Legs { get; set; }
        public Tail ATail { get; set; }
        public string Name { get; set; }

        public Animal()
        {
            AHead = new Head();
            Legs = new List<Leg>();
            ATail = new Tail();
        }

        //Constructor to implement the deep copy here
        public Animal(Animal aAnimal)
        {
            Name = aAnimal.Name;
            AHead = (Head)aAnimal.AHead.Clone();

            Legs = new List<Leg>();
            foreach (Leg aLeg in aAnimal.Legs)
            {
                Legs.Add((Leg)aLeg.Clone());
            }
            ATail = (Tail)aAnimal.ATail.Clone();
        }

        //Helper method to show the result from client
        public void Dispaly()
        {

            Console.WriteLine("I am a " + Name);
            AHead.Display();
            foreach (Leg aleg in Legs)
            {
                aleg.Display();
            }
            ATail.Display();
            Console.WriteLine();
        }

        #region ICloneable Members
        //call deep coy to perform clone process
        public object Clone()
        {
            return new Animal(this);
        }

        #endregion
    }
}
