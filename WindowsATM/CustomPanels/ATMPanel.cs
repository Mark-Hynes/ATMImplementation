using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsATM.Interfaces;

namespace WindowsATM.CustomPanels
{
    public class ATMPanel : Panel
    {
        //ATMPANEL IS ACTING AS AN OBSERVER OF KEYPAD BUTTONS(SUBJECTS) -- WILL MAKE THIS CLASS IMPLEMENT OBSERVER INTERFACE 
        List<KeypadSubject> subjectList;
        public ATMPanel() { subjectList = new List<KeypadSubject>(); }






        //WILL BE OVERRIDDEN IN EACH SUBCLASSED PANEL
        public virtual void update(ATMButton e) { }
        
    }
}