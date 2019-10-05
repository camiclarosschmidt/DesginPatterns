using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmploye
{
    interface IEmployee
    {
        string Name { get; set; }
        int EmployeeId { get; set; }

        List<Subscription> Subscriptions { get; set; }

        float GetCost();

        int GetSubscriptionCount(SubscriptionType type);
    }
}
