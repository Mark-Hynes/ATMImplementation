using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsATM.CustomPanels
{
    class PanelFactory
    {
        public ATMPanel getPanel(string identifier)
        {
            ATMPanel p = null;
            switch (identifier)
            {
                case "BALANCE":
                    {
                        break;
                    }
                case "DEPOSIT":
                    {
                        break;
                    }
                case "MAIN":
                    {
                        break;
                    }
                case "PIN":
                    {
                        break;
                    }
                case "PINRESET":
                    {
                        break;
                    }
                case "WITHDRAWAL":
                    {
                        break;
                    }
            }

            return p;
        }

    }
}
