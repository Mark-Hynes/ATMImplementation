using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsATM.Interfaces;

namespace WindowsATM.ConcreteCommands
{
    class ClearCommand : Command
    {
        private Reciever reciever;

        public ClearCommand(Reciever r)
        {
            this.reciever = r;
        }

        public void execute()
        {

            this.reciever.clear();
        }
    }
}
