using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Blog : ISubject
    {

        List<IObserver> observersList;
        private bool stateChange;

        public Blog()
        {
            this.observersList = new List<IObserver>();
            stateChange = false;
        }

        public void RegisterObserver(IObserver observer)
        {
            observersList.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            observersList.Remove(observer);
        }

        public void Notify()
        {

            if (stateChange)
            {
                foreach (var observer in observersList)
                {
                    observer.Notify();
                }
            }
        }

        public Object GetUpdate()
        {
            Object changedState = null;
            // should have logic to send the
            // state change to querying observer
            if (stateChange)
            {
                changedState = "Observer Design Pattern";
            }
            return changedState;
        }

        public void PostNewArticle()
        {
            stateChange = true;
            Notify();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {Blog blog = new Blog();
		User user1 = new User();
		User user2 = new User();
		blog.RegisterObserver(user1);
		blog.RegisterObserver(user2);
		user1.SetSubject(blog);
		user2.SetSubject(blog);
	
		Console.WriteLine(user1.GetArticle());		
		blog.PostNewArticle();
		Console.WriteLine(user1.GetArticle());
        }
    }
}
