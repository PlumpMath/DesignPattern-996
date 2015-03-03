using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{

    public abstract class BaseReport
    {
        public void GenerateReport()
        {
            Header();
            Body();
            Footer();
        }

        protected virtual void Footer()
        {
            Console.WriteLine("Default Footer");
        }

        protected virtual void Body()
        {
            Console.WriteLine("Default Body");
        }

        protected virtual void Header()
        {
            Console.WriteLine("Default Header");
        }
    }
    public class HtmlReport : BaseReport
    {
        protected override void Header()
        {
            Console.WriteLine("Html Header");
        }
        protected override void Footer()
        {
            Console.WriteLine("Html Foooter");
        }
        protected override void Body()
        {
            Console.WriteLine("Html Body");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseReport report = new HtmlReport();
            report.GenerateReport();
        }
    }
}
