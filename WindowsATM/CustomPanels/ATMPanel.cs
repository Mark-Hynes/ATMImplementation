using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsATM.Interfaces;

namespace WindowsATM.CustomPanels
{
    public class ATMPanel : Panel , Observer , Subject, Reciever
 
    {
        //ATMPANEL IS ACTING AS AN OBSERVER OF KEYPAD BUTTONS(SUBJECTS) -- WILL MAKE THIS CLASS IMPLEMENT OBSERVER INTERFACE 
        private List<Subject> subjectList;
        private List<Observer> observerList;
        public ATMPanel() { subjectList = new List<Subject>(); observerList = new List<Observer>(); }

         List<Observer> Subject.observerList
        {
            get
            {
                return this.observerList;
            }
        }

        List<Subject> Observer.subjectList
        {
            get
            {
                return this.subjectList;
            }

           
        }

        public void notifyObservers()
        {
            foreach (Observer e in this.observerList)
            {
                e.update(this);
            }
        }

        public void registerObserver(Observer e)
        {
            this.observerList.Add(e);
        }

        public void unregisterObserver(Observer e)
        {
            this.observerList.Remove(e);
        }

        public void update()
        {
         
        }

        public virtual void update(Subject e)
        {
            
        }

        public void action()
        {
            throw new NotImplementedException();
        }
        public virtual void cancel() { }
        public virtual void clear() { }
        public virtual void enter() { }
    }
}