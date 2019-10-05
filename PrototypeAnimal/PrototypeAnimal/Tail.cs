using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAnimal
{
    public class Tail : ICloneable
    {
        public string Color { get; set; }

        public void Display()
        {
            Console.WriteLine("My tail is {0}", Color);
        }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
