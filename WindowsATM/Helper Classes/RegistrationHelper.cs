using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsATM.Interfaces;

namespace WindowsATM.Helper_Classes
{
    class RegistrationHelper
    {
        public RegistrationHelper()
        { }
        public void registerObserverToSubject(Observer e, Subject i)
        {
            i.registerObserver(e);
        }
    }
}
