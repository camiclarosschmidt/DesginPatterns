using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now let us create some Employees and assign some subscriptions to them
            IEmployee emp1 = new Employee { Name = "A", EmployeeId = 1, Subscriptions = new List<Subscription> { GetPluralSightSubscription(), GetLyndaSubscription(), GetMSDNSubscription(), GetTrainingSubscription() } };
            IEmployee emp2 = new Employee { Name = "B", EmployeeId = 2, Subscriptions = new List<Subscription> { GetPluralSightSubscription(), GetLyndaSubscription() } };
            IEmployee emp3 = new Employee { Name = "C", EmployeeId = 3, Subscriptions = new List<Subscription> { GetPluralSightSubscription() } };
            IEmployee emp4 = new Employee { Name = "D", EmployeeId = 4, Subscriptions = new List<Subscription> { GetPluralSightSubscription() } };
            IEmployee emp5 = new Employee { Name = "E", EmployeeId = 5, Subscriptions = new List<Subscription> { GetPluralSightSubscription() } };
            IEmployee emp6 = new Employee { Name = "F", EmployeeId = 6, Subscriptions = new List<Subscription> { GetPluralSightSubscription(), GetTrainingSubscription() } };
            IEmployee emp7 = new Employee { Name = "G", EmployeeId = 7, Subscriptions = new List<Subscription> { GetPluralSightSubscription() } };
            IEmployee emp8 = new Employee { Name = "H", EmployeeId = 8, Subscriptions = new List<Subscription> { GetPluralSightSubscription() } };
            IEmployee emp9 = new Employee { Name = "I", EmployeeId = 9, Subscriptions = new List<Subscription> { GetPluralSightSubscription() } };
            IEmployee emp10 = new Employee { Name = "J", EmployeeId = 10, Subscriptions = new List<Subscription> { GetPluralSightSubscription(), GetMSDNSubscription() } };

            // lets get cost details of single employee
            Console.WriteLine("Lets get cost details of single employee");
            PrintCostDetails(emp1);

            // Lets check cost details of list of employees
            List<IEmployee> employees = new List<IEmployee> { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };
            Console.WriteLine("Lets check cost details of list of employees");
            foreach (var item in employees)
            {
                PrintCostDetails(item);
            }


            // Now lets setup some managers
            IEmployee mng1 = new Manager
            {
                Name = "MA",
                EmployeeId = 11,
                Subscriptions = new List<Subscription>
            {
                GetPluralSightSubscription(),
                GetLyndaSubscription(),
                GetMSDNSubscription(),
                GetTrainingSubscription()
            },
                TeamMembers = new List<IEmployee>
            {
                emp1,
                emp2,
                emp3,
            }
            };

            IEmployee mng2 = new Manager
            {
                Name = "MB",
                EmployeeId = 13,
                Subscriptions = new List<Subscription>
            {
                GetPluralSightSubscription(),
            },
                TeamMembers = new List<IEmployee>
            {
                emp4,
                emp5,
                emp6,
            }
            };

            IEmployee mng3 = new Manager
            {
                Name = "MC",
                EmployeeId = 13,
                Subscriptions = new List<Subscription>
            {
                GetTrainingSubscription()
            },
                TeamMembers = new List<IEmployee>
            {
                emp7,
                emp8,
                emp9,
                emp10,
            }
            };


            // lets get cost details of single manager
            Console.WriteLine("Lets get cost details of single manager");
            PrintCostDetails(mng1);


            // Lets check cost details of list of employees
            Console.WriteLine("Lets check cost details of list of manager");
            foreach (var item in new List<IEmployee> { mng1, mng2, mng3 })
            {
                PrintCostDetails(item);
            }


            Console.ReadLine();
        }

        private static void PrintCostDetails(IEmployee item)
        {
            Console.WriteLine("Cost: {0}, Count Portal: {1}, Count Print: {2}, Count Training: {3}, Emp ID: {4}",
                item.GetCost(),
                item.GetSubscriptionCount(SubscriptionType.Portal),
                item.GetSubscriptionCount(SubscriptionType.Print),
                item.GetSubscriptionCount(SubscriptionType.Training),
                item.EmployeeId);
        }


        #region Subscriptions gets
        // This region has cummy methods to add subscritions to employees
        // This is just for demo, in real world applications should never have such code
        private static Subscription GetPluralSightSubscription()
        {
            Subscription sub = new Subscription
            {
                Name = "Pluralsight",
                SubscriptionType = SubscriptionType.Portal,
                Cost = 30
            };

            return sub;
        }

        private static Subscription GetLyndaSubscription()
        {
            Subscription sub = new Subscription
            {
                Name = "Lynda.com",
                SubscriptionType = SubscriptionType.Portal,
                Cost = 20
            };

            return sub;
        }

        private static Subscription GetMSDNSubscription()
        {
            Subscription sub = new Subscription
            {
                Name = "MSDN Magazine",
                SubscriptionType = SubscriptionType.Print,
                Cost = 10
            };

            return sub;
        }

        private static Subscription GetTrainingSubscription()
        {
            Subscription sub = new Subscription
            {
                Name = "Patterns Training",
                SubscriptionType = SubscriptionType.Training,
                Cost = 300
            };

            return sub;
        }

        #endregion

    }
}
