using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorPlugin
{
    public partial class SensorControl : UserControl
    {
        public SensorControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           panel1.Visible= (
               panel1.Visible==true ? false:true
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = (
               panel2.Visible == true ? false : true
                );
        }

       
    }
}
