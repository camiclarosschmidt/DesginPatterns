using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmploye
{
    class Employee : IEmployee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public float GetCost()
        {
            if (Subscriptions == null)
            {
                return 0;
            }

            float cost = Subscriptions.Select((item => item.Cost)).Sum();
            return cost;
        }

        public int GetSubscriptionCount(SubscriptionType type)
        {
            if (Subscriptions == null)
            {
                return 0;
            }

            int count = Subscriptions.Count(item => item.SubscriptionType == type);
            return count;
        }
    }
}
