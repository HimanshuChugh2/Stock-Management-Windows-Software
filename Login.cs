using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock_management
{
    public partial class Login : Form
    {
        Class1 obj = new Class1();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="system"&&textBox2.Text=="1234")
            {
                MDIParent1 m = new MDIParent1();
                
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong id/password","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
        }
    }
}
