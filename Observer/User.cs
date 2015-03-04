using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class User : IObserver
    {

        private String article;
        private ISubject blog;


        public void Notify()
        {
            Console.WriteLine("State change reported by Subject.");
            article = (String)blog.GetUpdate();
        }

        public String GetArticle()
        {
            return article;
        }


        public void SetSubject(ISubject subject)
        {
            this.blog = subject;
            article = "No New Article!";
        }
    }
}
