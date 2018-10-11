using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vp_lab_6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void potentiometer_ChangeValuePotentiometer(object sender, EventArgs e)
        {
            textBoxValue.Text = ((Potentiometer.Potentiometer)sender).Value.ToString();
        }
    }
}
