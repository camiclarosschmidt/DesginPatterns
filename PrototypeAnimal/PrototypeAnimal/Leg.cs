using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAnimal
{
    public class Leg : ICloneable
    {
        public string Side { get; set; }
        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine("This is my {0} {1} ", Side, Name);
        }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion
    }
}
