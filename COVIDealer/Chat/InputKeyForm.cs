using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class InputKeyForm : Form
    {
        string apiKey;
        public InputKeyForm(ref string apiKey)
        {
            InitializeComponent();
            this.apiKey = apiKey;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (InputBox.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập API Key của OpenAI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                apiKey = InputBox.Text;
            }
        }
    }
}
