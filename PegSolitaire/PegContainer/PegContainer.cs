using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PegSolitaire.PegContainer
{
    public partial class PegContainer : UserControl
    {
        public PegContainer()
        {
            InitializeComponent();


            //b.CreateControl();

            
            var thing = this.Controls.Find("flowLayoutPanel1", false);
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            for(int i = 0; i < 5; i++)
            {
                RadioButton b = new RadioButton();
                //b.Text = "test" + i.ToString();
                this.Controls.Add(b);
                ((FlowLayoutPanel)thing[0]).Controls.Add(b);
            }

            Debug.WriteLine(thing[0]);
        }
    }
}
