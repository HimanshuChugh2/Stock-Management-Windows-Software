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
    public partial class demo : Form
    {
        Class1 c = new Class1();
        public demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.query("insert into demo3 values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')");
        }
    }
}
