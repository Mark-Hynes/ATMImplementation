using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsATM.Interfaces;

namespace WindowsATM.CustomPanels
{
    public class ATMButton : Button, Subject , Invoker
    { 
        
        //ATMBUTTON NOW ACTS AS A SUBJECT -- WILL BE MADE TO INHERIT KEYPADSUBJECT INTERFACE
        private List<Observer> observerList;
        public ATMButton() { observerList = new List<Observer>(); }
            

        List<Observer> Subject.observerList
        {
            get
            {
                return this.observerList;
            }

            
        }



        //NOTIFIES ALL OBSERVERS(ATM PANELS) OF AND PASSESS ITSELF AS A PARAMETER 
        public void notifyObservers()
        {
            foreach (Observer i in this.observerList)
            {
                i.update(this);
            }

        }

        public void registerObserver(Observer e)
        {
            this.observerList.Add(e);
        }

        //ADDS AN OBSERVER TO THE SUBJECT
        //public void registerObserver(ATMPanel e) { this.observerList.Add(e); }

        public void unregisterObserver(Observer e)
        {
            this.observerList.Remove(e);
        }


        public void executeCommand(Command c)
        {
            c.execute();
        }
    }
    
    }
