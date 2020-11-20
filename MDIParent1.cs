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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        Class1 obj = new Class1();
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
 

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drinkAdd a = new drinkAdd();
            a.Show();
           // this.Hide();
            a.MdiParent = this;
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drinkSell d = new drinkSell();
            d.Show();
            //this.Hide();
            d.MdiParent = this;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void addedStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Class1.usr = "sale";
            //drinkShow ds = new drinkShow();
            //ds.Show();
            //ds.MdiParent = this;
        }

        private void addedToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

            menuStrip1.BackColor = Color.Goldenrod;

           
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.Black;
        }

        private void sEESALEBYDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.usr = "salebydate";
            drinkShow ds = new drinkShow();
            ds.Show();
            ds.MdiParent = this;
        }

        private void aLLSALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.usr = "allsale";
            drinkShow ds = new drinkShow();
            ds.Show();
            ds.MdiParent = this;
        }

        private void todaysSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.usr = "todaysale";
            drinkShow ds = new drinkShow();
            ds.Show();
            ds.MdiParent = this;
        }

        private void addedTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.usr = "addedtoday";
            drinkShow ds = new drinkShow();
            ds.Show();
            ds.MdiParent = this;
        }

        private void sEEBYDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.usr = "addedbydate";
            drinkShow ds = new drinkShow();
            ds.Show();
            ds.MdiParent = this;
        }

        private void jUSTSHOEMEALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class1.usr = "showalladded";
            drinkShow ds = new drinkShow();
            ds.Show();
            ds.MdiParent = this;
        }
    }
}
