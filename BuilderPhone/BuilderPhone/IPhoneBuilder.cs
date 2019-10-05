using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPhone
{
    // This is the "Builder" class
    interface IPhoneBuilder
    {
        void BuildScreen();
        void BuildBattery();
        void BuildOS();
        void BuildStylus();
        MobilePhone Phone { get; }
    }
}
