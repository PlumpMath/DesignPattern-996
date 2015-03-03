using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer.Win
{
    public partial class frmCircle : Form, IObserver
    {
        public frmCircle()
        {
            InitializeComponent();
        }

        public void Notify(int counter)
        {
            Circle(counter);
        }

        private void Circle(int counter)
        {
            

            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.Cornsilk);
            Rectangle rectangle = new Rectangle(10*counter, 10*counter, counter*50, 50);
            graphics.DrawEllipse(Pens.Red, rectangle);
            
            
        }
    }
}
