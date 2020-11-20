

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
namespace Stock_management
{
    public partial class order : Form
    {
        Class1 obj = new Class1();
        SqlTransaction tran;
        SqlConnection con = new SqlConnection("database=stock;server=.;uid=sa;password=1234");
        SqlCommand com;

        SqlTransaction trans;
        public order()
        {
           
            InitializeComponent();
        
        }
      
        int quant;
        private void button10_Click(object sender, EventArgs e)
        {

            if (txtQuantity.Text != "")
            {
                
                
                    quant = Convert.ToInt32(txtQuantity.Text);

                    //  dataGridView1.DataSource=obj.show("select masala_a ,'"+quant+"' as Quantity, '"+quant+"' * 100 as TotalA , masala_b from tbl_masalaAdd "); // ye 100                      masala_a hai, jo ki ek burger m lagta hai
                    // ab isme chahe 2 value ho textQuantity ki ye multiply kar k dikha dega
                    //ab hume update karna hai jis se jo totalA m aaya hai usse masala_a m se minus karana hai


                    con.Open();
                    try
                    {
                        trans = con.BeginTransaction();
                        com = new SqlCommand("update tbl_masalaAdd set masala_a=  ( masala_a - '" + quant + "' * 100 ),masala_c= (masala_c - '" + quant + "' * 200) , masala_e= (masala_e - '" + quant + "' * 400 ),  masala_g= (masala_g - '" + quant + "' * 100) ,masala_i= (masala_i - '" + quant + "' * 200 ), masala_k =( masala_k - '" + quant + "' * 50) ", con, trans);
                        // masala add table m pura stock pada hai
                       // yaha pe sirf ek command m kam ban jayega. yaha jo integer values hai wo ek burger m dalne wala component hai
                        

                        
                        com.ExecuteNonQuery();

                        com = new SqlCommand("select *from tbl_masalaAdd", con, trans);
                        SqlDataReader dr= com.ExecuteReader();
                       DataTable dt = new DataTable();
                       dt.Load(dr);              
                                                          
                       double a = Convert.ToDouble(dt.Rows[0][0].ToString());
                       double c = Convert.ToDouble(dt.Rows[0][2].ToString());
                       double z = Convert.ToDouble(dt.Rows[0][4].ToString());
                       double g = Convert.ToDouble(dt.Rows[0][6].ToString());
                       double i = Convert.ToDouble(dt.Rows[0][8].ToString());
                       double k = Convert.ToDouble(dt.Rows[0][10].ToString());
                       if (a < -1 || c < -1 || z < -1 || g < -1 || i < -1 || k < -1)
                       {
                           trans.Rollback();
                           dataGridView2.DataSource = obj.show("select *from tbl_masalaAdd");
                     
                           MessageBox.Show(" Sufficient Amount of Material is Not Available for a McBurger", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                         
                       }
                       else
                       {
                        trans.Commit();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        MessageBox.Show("Updated", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.DataSource = obj.show("select *from tbl_masalaAdd");
                        com = new SqlCommand("insert into tbl_stockAllDetails ( masala_a,masala_c,masala_e,masala_g,masala_i,masala_k) values  (  - '" + quant + "' * 100 ,  - '" + quant + "' * 200 ,   - '" + quant + "' * 400 ,     - '" + quant + "' * 100 , - '" + quant + "' * 200 ,   - '" + quant + "' * 50,'"+Convert.ToDateTime(dateTimePicker2.Text)+"') ",con);
                        com.ExecuteNonQuery();
                           

                       }
                    }

                    catch (Exception ex)
                    {
                     
                       // MessageBox.Show("please Enter again");
                    }
                    con.Close();
                    //obj.query("select case when masala_a <=0 then '"+MessageBox.Show("not sufficient material available")+"'  else masala_a=  ( masala_a - '" + quant + "' * 100 ) end || masala_c= (masala_c - '" + quant + "' * 200) , masala_e= (masala_e - '" + quant + "' * 400 ),  masala_g= (masala_g - '" + quant + "' * 100) ,masala_i= (masala_i - '" + quant + "' * 200 ), masala_k =( masala_k - '" + quant + "' * 50)  ");


                
                //obj.query("update tbl_masalaAdd set masala_a=  ( masala_a - '" + quant + "' * 100 ),masala_c= (masala_c - '" + quant + "' * 200) , masala_e= (masala_e - '" + quant + "' * 400 ),  masala_g= (masala_g - '" + quant + "' * 100) ,masala_i= (masala_i - '" + quant + "' * 200 ), masala_k =( masala_k - '" + quant + "' * 50)  ");

                }
            
                // hum chahte hai ki agar database m koi value negative m hai to frontend m se koi item sale na ho, to humne pehle update ki command chalayi fir humne check kiya ki agar update hone k bad koi value negative m jati hai to rollbackk ho jaye otherwise commit



            else
            {
                MessageBox.Show("ENTER QUANTITY FIRST");
            }



            //quant = Convert.ToInt32(txtQuantity.Text);


            //if (txtQuantity.Text == "")
            //{
            //    MessageBox.Show("ENTER QUANTITY FIRST");
            //}
            //else
            //{
           

            //    if (txtQuantity.Text == "1")
            //    {
            //        double ans1 = a - 100;
            //        double ans2 = c - 150;
            //        double ans3 = z - 30;   // ye masale burger m lagte hai
            //        double ans4 = g - 100;
            //        double ans5 = i - 200;
            //        double ans6 = k - 350;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show(" Sufficient Amount of Material is Not Available", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-100','-150','-30','-100','-200','-350')");   // this command is for insert to show all entries



            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGER SOLD AND Quantity Deducted");
            //        }
            //    }
            //    if (txtQuantity.Text == "2")
            //    {
            //        double ans1 = a - 200;           //se
            //        double ans2 = c - 300;
            //        double ans3 = z - 60;   // ye masale burger m lagte hai
            //        double ans4 = g - 200;
            //        double ans5 = i - 400;
            //        double ans6 = k - 700;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show(" Sufficient Amount of Material is Not Available", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {

            //            dataGridView1.DataSource = obj.show("select masala_a , '" + quant + "' as quantity , '" + quant + "' * masala_a  as total from tbl_masalaAdd ");

            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-200','-300','-60','-200','-400','-700')");   // this command is for insert to show all entries


            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + "BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }

            //    if (txtQuantity.Text == "3")
            //    {
            //        double ans1 = a - 300;
            //        double ans2 = c - 450;
            //        double ans3 = z - 90;   // ye masale burger m lagte hai
            //        double ans4 = g - 300;
            //        double ans5 = i - 600;
            //        double ans6 = k - 1050;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show(" Sufficient Amount of Material is Not Available", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-300','-450','-90','-300','-600','-1050')");   // this command is for insert to show all entries

            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + "BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }


            //    if (txtQuantity.Text == "4")
            //    {
            //        double ans1 = a - 400;
            //        double ans2 = c - 600;
            //        double ans3 = z - 120;   // ye masale burger m lagte hai
            //        double ans4 = g - 400;
            //        double ans5 = i - 800;
            //        double ans6 = k - 1400;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-400','-600','-120','-400','-800','-1400')");   // this command is for insert to show all entries

            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + "BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }

            //    if (txtQuantity.Text == "5")
            //    {
            //        double ans1 = a - 500;
            //        double ans2 = c - 750;
            //        double ans3 = z - 150;   // ye masale burger m lagte hai
            //        double ans4 = g - 500;
            //        double ans5 = i - 1000;
            //        double ans6 = k - 1750;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-500','-750','-150','-500','-1000','-1750')");   // this command is for insert to show all entries

            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }

            //    if (txtQuantity.Text == "6")
            //    {
            //        double ans1 = a - 600;
            //        double ans2 = c - 900;
            //        double ans3 = z - 180;   // ye masale burger m lagte hai
            //        double ans4 = g - 600;
            //        double ans5 = i - 1200;
            //        double ans6 = k - 2100;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {

            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-600','-900','-180','-600','-1200','-2100')");   // this command is for insert to show all entries

            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }

            //    if (txtQuantity.Text == "7")
            //    {
            //        double ans1 = a - 700;
            //        double ans2 = c - 1050;
            //        double ans3 = z - 210;   // ye masale burger m lagte hai
            //        double ans4 = g - 700;
            //        double ans5 = i - 1400;
            //        double ans6 = k - 2350;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-700','-1050','-210','-700','-1400','-2350')");   // this command is for insert to show all entries

            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }

            //    if (txtQuantity.Text == "8")
            //    {
            //        double ans1 = a - 800;
            //        double ans2 = c - 2100;
            //        double ans3 = z - 240;   // ye masale burger m lagte hai
            //        double ans4 = g - 800;
            //        double ans5 = i - 1600;
            //        double ans6 = k - 2700;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-800','-2010','-240','-800','-1600','-2700')");   // this command is for insert to show all entries


            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }


            //    if (txtQuantity.Text == "9")
            //    {
            //        double ans1 = a - 900;
            //        double ans2 = c - 950;
            //        double ans3 = z - 270;   // ye masale burger m lagte hai
            //        double ans4 = g - 900;
            //        double ans5 = i - 1800;
            //        double ans6 = k - 3050;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-900','-950','-270','-900','-1800','-3050')");   // this command is for insert to show all entries


            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }


            //    if (txtQuantity.Text == "10")
            //    {
            //        double ans1 = a - 1000;
            //        double ans2 = c - 1500;
            //        double ans3 = z - 300;   // ye masale burger m lagte hai
            //        double ans4 = g - 1000;
            //        double ans5 = i - 2000;
            //        double ans6 = k - 3500;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-1000','-1500','-300','-1000','-2000','-3500')");   // this command is for insert to show all entries

            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }


            //    if (txtQuantity.Text == "20")
            //    {
            //        double ans1 = a - 2000;
            //        double ans2 = c - 3000;
            //        double ans3 = z - 600;   // ye masale burger m lagte hai
            //        double ans4 = g - 2000;
            //        double ans5 = i - 4000;
            //        double ans6 = k - 7000;
            //        if (ans1 < 0 || ans2 < 0 || ans3 < 0 || ans4 < 0 || ans5 < 0 || ans6 < 0)
            //        {
            //            MessageBox.Show("Sufficient Amount of Material is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //        }
            //        else
            //        {
            //            obj.query("insert into tbl_stockAlldetails   (masala_a , masala_c,masala_e,masala_g,masala_i,masala_k) values( '-2000','-3000','-600','-600','-2000','-7000')");   // this command is for insert to show all entries


            //            obj.query("update tbl_masalaAdd set masala_a='" + ans1 + "', masala_c='" + ans2 + "',masala_e='" + ans3 + "',masala_g='" + ans4 + "',masala_i='" + ans5 + "',masala_k='" + ans6 + "'");
            //            MessageBox.Show(txtQuantity.Text + " BURGERS SOLD AND Quantity Deducted");
            //        }
            //    }


              
              //  }
         
          //  dataGridView2.DataSource = obj.show("select *from tbl_masalaAdd");
            {    
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtQuantity.Text = txtQuantity.Text + "1";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "2";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "3";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "4";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "5";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "6";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "7";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "8";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "9";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "10";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "20";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + "30";

       
        }
       
    
        

        private void button22_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.Show();
            this.Hide();
        }

        private void order_Load(object sender, EventArgs e)
        {
            lblEnterDate.Visible = false;
            dateTimePicker1.Visible = false;
            lblAnd.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            btnSearch.Visible = false;

            dataGridView2.DataSource = obj.show("select *from tbl_masalaAdd");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            order o = new order();

            o.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            txtAfterClick.Text = "";
            txtAfterClick.Text = btnMoreThen.Text;
            btnSearch.Visible = true;
            textBox1.Visible = true;
            lblAnd.Visible = false;
            textBox2.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {


            txtAfterClick.Text = "";
            txtAfterClick.Text = btnLessThen.Text;
            textBox1.Visible = true;

            Thread.Sleep(1000);
            lblAnd.Visible = false;
            textBox2.Visible = false;
            btnSearch.Visible = true;

        }

        private void button26_Click(object sender, EventArgs e)
        {
            lblEnterDate.Visible = false;
            dateTimePicker1.Visible = false;
            txtAfterClick.Text = "";
            txtAfterClick.Text = btnBetween.Text;

            textBox2.Visible = true;


            lblAnd.Visible = true;
            textBox1.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAfterClick.Text == "More Then")
            {


                dataGridView2.DataSource = obj.show("select (case when masala_a>='" + textBox1.Text + "' then masala_a else 0 end) Masala_a,(case when masala_b>='" + textBox1.Text + "' then masala_b else 0 end) Masala_b,(case when masala_c>='" + textBox1.Text + "' then masala_c else 0 end) Masala_c,(case when masala_d>='" + textBox1.Text + "' then masala_d else 0 end) Masala_d,(case when masala_e>='" + textBox1.Text + "' then masala_e else 0 end) Masala_e,(case when masala_f>='" + textBox1.Text + "' then masala_f else 0 end)Masala_f,(case when masala_g>='" + textBox1.Text + "' then masala_g else 0 end)Masala_g,(case when masala_h>='" + textBox1.Text + "' then masala_h else 0 end)Masala_h,(case when masala_i>='" + textBox1.Text + "' then masala_i else 0 end) Masala_i,(case when masala_j>='" + textBox1.Text + "'then masala_j else 0 end) Masala_j,(case when masala_k>='" + textBox1.Text + "' then masala_k else 0 end)Masala_k,(case when masala_l>='" + textBox1.Text + "' then masala_l else 0 end) Masala_l from tbl_masalaAdd");

                // this command is useful when user wants to search that how much amount of material is available in the databse by entering amount in textbox1 only..if user enters 1000 this will show you the material which more then 1000grams 


            }
            if (txtAfterClick.Text == "Less Then")
            {



                dataGridView2.DataSource = obj.show("select (case when masala_a<='" + textBox1.Text + "' then masala_a else 0 end) Masala_a,(case when masala_b<='" + textBox1.Text + "' then masala_b else 0 end) Masala_b,(case when masala_c<='" + textBox1.Text + "' then masala_c else 0 end) Masala_c,(case when masala_d>='" + textBox1.Text + "' then masala_d else 0 end) Masala_d,(case when masala_e<='" + textBox1.Text + "' then masala_e else 0 end) Masala_e,(case when masala_f>='" + textBox1.Text + "' then masala_f else 0 end)Masala_f,(case when masala_g<='" + textBox1.Text + "' then masala_g else 0 end)Masala_g,(case when masala_h<='" + textBox1.Text + "' then masala_h else 0 end)Masala_h,(case when masala_i<='" + textBox1.Text + "' then masala_i else 0 end) Masala_i,(case when masala_j<='" + textBox1.Text + "'then masala_j else 0 end) Masala_j,(case when masala_k<='" + textBox1.Text + "' then masala_k else 0 end)Masala_k,(case when masala_l<='" + textBox1.Text + "' then masala_l else 0 end) Masala_l from tbl_masalaAdd");
            }
            if (txtAfterClick.Text == "Between")
            {
                dataGridView2.DataSource = obj.show("select (case when masala_a between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_a else 0  end) Masala_a, (case when masala_b between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_b else 0  end)Masala_b, (case when masala_c between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_c else 0  end)Masala_c, (case when masala_d between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_d else 0  end)Masala_d, (case when masala_e between '" + textBox1.Text + "' and '" + textBox2.Text + "' then masala_e else 0  end)Masala_e, (case when masala_f between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_f else 0 end)Masala_f, (case when masala_g between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_g else 0  end)Masala_g, (case when masala_h between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_h else 0 end)Masala_h, (case when masala_i between '" + textBox1.Text + "' and '" + textBox2.Text + "' then masala_i else 0  end) Masala_i, (case when masala_j between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_j else 0  end)Masala_j, (case when masala_k between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_k else 0  end)Masala_k, (case when masala_l between '" + textBox2.Text + "' and '" + textBox1.Text + "' then masala_l else 0  end)Masala_l from tbl_masalaAdd   ");
            }
            if (txtAfterClick.Text== "View Stock by Date")
            {
               dataGridView2.DataSource= obj.show("select *from tbl_stockAllDetails where dateofEntering = '"+Convert.ToDateTime( dateTimePicker1.Text)+"'");
            }
        }

        private void btnViewBYDATE_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            textBox1.Visible = false;
            textBox2.Visible = true;
            lblAnd.Visible = false;
            dateTimePicker1.Visible = true;
            btnSearch.Visible = true;
            txtAfterClick.Text = btnViewBYDATE.Text;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

      
    
      
    }
}














