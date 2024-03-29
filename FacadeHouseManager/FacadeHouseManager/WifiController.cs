﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeHouseManager
{
    class WifiController
    {
        bool isSwitchedOn = false;

        public bool IsSwitchedOn
        {
            get
            {
                return isSwitchedOn;
            }
            set
            {
                isSwitchedOn = value;
                DisplayStatus();
            }
        }

        private void DisplayStatus()
        {
            string status = (isSwitchedOn == true) ? "ON" : "OFF";
            Console.WriteLine("WiFi Switched {0}", status);
        }
    }
}
