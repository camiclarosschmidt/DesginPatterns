using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmploye
{
    class Manager : IEmployee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public List<Subscription> Subscriptions { get; set; }

        public List<IEmployee> TeamMembers { get; set; }

        public float GetCost()
        {
            float subsCost = 0;
            if (Subscriptions != null)
            {
                subsCost = Subscriptions.Select((item => item.Cost)).Sum();
            }

            float membersCost = 0;
            if (TeamMembers != null)
            {
                membersCost = TeamMembers.Select(item => item.GetCost()).Sum();
            }

            return subsCost + membersCost;
        }

        public int GetSubscriptionCount(SubscriptionType type)
        {
            int subCount = 0;
            if (Subscriptions != null)
            {
                subCount = Subscriptions.Count(item => item.SubscriptionType == type);
            }

            int membersSubCount = 0;
            if (TeamMembers != null)
            {
                membersSubCount = TeamMembers.Select(item => item.GetSubscriptionCount(type)).Sum();
            }

            return subCount + membersSubCount;
        }
    }
}
