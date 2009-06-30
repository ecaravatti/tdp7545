using System;
using System.Text;
using System.Collections;
using System.Threading;

namespace WiiDesktop.Common
{
    public abstract class Subject
    {
        private ArrayList observers = new ArrayList();
        private ArrayList pendingTasks = new ArrayList();

        public void AddObserver(Observer observer)
        {
            pendingTasks.Add(new Task(TaskType.ADD, observer));
        }

        public void RemoveObserver(Observer observer)
        {
            pendingTasks.Add(new Task(TaskType.REMOVE, observer));
        }

        public void Notify()
        {
            if (pendingTasks.Count > 0)
            {
                foreach (Task task in pendingTasks)
                {
                    if (task.Type.Equals(TaskType.ADD))
                    {
                        observers.Add(task.Observer);
                    }
                    else if (task.Type.Equals(TaskType.REMOVE))
                    {
                        observers.Remove(task.Observer);
                    }
                }

                pendingTasks.Clear();
            }

            foreach (Observer observer in observers)
            {
                observer.Update(this);
            }
        }
    }

    enum TaskType
    {
        ADD,
        REMOVE
    }

    class Task
    {
        private TaskType type;
        private Observer observer;

        public Task(TaskType type, Observer observer)
        {
            this.type = type;
            this.observer = observer;
        }

        public TaskType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public Observer Observer
        {
            get
            {
                return observer;
            }
            set
            {
                observer = value;
            }
        }
    }
}
