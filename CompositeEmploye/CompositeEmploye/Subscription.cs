using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmploye
{
    enum SubscriptionType
    {
        Print,
        Portal,
        Training
    }

    class Subscription
    {
        public SubscriptionType SubscriptionType { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
    }
}
