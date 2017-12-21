using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium
{
	public partial class MainForm : Form
	{

		public MainForm()
		{
			InitializeComponent();
		}

        private void buttonHungerOn_Click(object sender, EventArgs e)
        {
            if (buttonHugerOn.Visible == true)
            {
                buttonHugerOn.Visible = false;
                buttonHungerOff.Visible = true;
            }
            else
            {
                buttonHugerOn.Visible = true;
                buttonHungerOff.Visible = false;
            }

        }

        private void buttonHungerOff_Click(object sender, EventArgs e)
        {
            if (buttonHungerOff.Visible == true)
            {
                buttonHungerOff.Visible = false;
                buttonHugerOn.Visible = true;
            }
            else
            {
                buttonHungerOff.Visible = true;
                buttonHugerOn.Visible = false;
            }
        }
    }
}
