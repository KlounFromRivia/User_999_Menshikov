using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Techno.UI
{
    public partial class AddCommentForm : Form
    {
        public string Message { get; set; }
        public AddCommentForm()
        {
            InitializeComponent();
            lblFio.Text = CurrectUser.User.UserFIO;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Message = textBox1.Text;
            btnSave.Enabled = !string.IsNullOrEmpty(textBox1.Text);
        }
    }
}
