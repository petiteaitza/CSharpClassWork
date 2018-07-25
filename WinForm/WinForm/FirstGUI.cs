using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FirstGUI : Form
    {
        public FirstGUI()
        {
            InitializeComponent();
        }

        private void BTNEvents_MouseClick(object sender, MouseEventArgs e)
        {
            BTNEvents.BackColor = Color.Fuchsia;

        }

        private void BTNEvents_MouseUp(object sender, MouseEventArgs e)
        {
            BTNEvents.BackColor = Color.Aqua;

        }

        private void BTNEvents_MouseDown(object sender, MouseEventArgs e)
        {
            BTNEvents.BackColor = Color.Lime;
        }

        private void BTNEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# Programming in easy steps");
        }
    }
}
