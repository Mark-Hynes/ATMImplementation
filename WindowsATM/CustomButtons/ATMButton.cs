using System.Collections.Generic;
using System.Windows.Forms;
using WindowsATM.Interfaces;

namespace WindowsATM.CustomPanels
{
    public class ATMButton : Button
    { //ATMBUTTON NOW ACTS AS A SUBJECT -- WILL BE MADE TO INHERIT KEYPADSUBJECT INTERFACE
        List<ATMPanel> observerList;
        public ATMButton() { observerList = new List<ATMPanel>(); }



        //NOTIFIES ALL OBSERVERS(ATM PANELS) OF AND PASSESS ITSELF AS A PARAMETER 
        public void notifyObservers()
        {
            foreach (ATMPanel i in this.observerList)
            {
                i.update(this);
            }

        }
        //ADDS AN OBSERVER TO THE SUBJECT
        public void registerObserver(ATMPanel e) { this.observerList.Add(e); }

        //REMOVES AN OBSERVER FROM THE SUBJECT
        public void unregisterObserver(ATMPanel e)
        {
            for (int i = 0; i < observerList.Count; i++)
                this.observerList.Remove(e);
        }
    }
    
    }
