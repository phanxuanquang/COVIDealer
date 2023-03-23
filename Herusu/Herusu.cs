using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herusu
{
    public partial class Herusu : Form
    {
        public Herusu()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            ChatSpace.Text += InputTextBox.Text + "\n";
            InputTextBox.Text = String.Empty;
        }
    }
}
