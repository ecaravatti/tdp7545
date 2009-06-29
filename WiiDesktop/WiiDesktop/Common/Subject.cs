using System;
using System.Text;
using System.Collections;
using System.Threading;

namespace WiiDesktop.Common
{
    public abstract class Subject
    {
        private ArrayList observers = new ArrayList();
        private ArrayList pendingToRemove = new ArrayList();

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            pendingToRemove.Add(observer);
        }

        public void Notify()
        {
            foreach (Observer observer in pendingToRemove)
            {
                observers.Remove(observer);
            }

            foreach (Observer observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
