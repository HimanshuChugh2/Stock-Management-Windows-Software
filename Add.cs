using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_management
{
    public partial class Add : Form
    {
        DataTable dt;
            
        SqlTransaction tran;
        SqlConnection con = new SqlConnection("database=stock;server=.;uid=sa;password=1234");
        SqlCommand com;

       
        double ans1,ans2,ans3,ans4,ans5,ans6,ans7,ans8,ans9,ans10,ans11,ans12;
        Class1 obj = new Class1();
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //con.Open();
            //com = new SqlCommand("select *from tbl_masalaAdd", con);
            //SqlDataReader dr = com.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //con.Close();

        DataTable dt=obj.show("select *from tbl_masalaAdd");
           
           
            
            double a = Convert.ToDouble(dt.Rows[0][0].ToString());
            double b = Convert.ToDouble(dt.Rows[0][1].ToString());
            double c = Convert.ToDouble(dt.Rows[0][2].ToString());
            double d = Convert.ToDouble(dt.Rows[0][3].ToString());
            double z = Convert.ToDouble(dt.Rows[0][4].ToString());
            double f = Convert.ToDouble(dt.Rows[0][5].ToString());
            double g = Convert.ToDouble(dt.Rows[0][6].ToString());
            double h = Convert.ToDouble(dt.Rows[0][7].ToString());
            double i = Convert.ToDouble(dt.Rows[0][8].ToString());
            double j = Convert.ToDouble(dt.Rows[0][9].ToString());
            double k = Convert.ToDouble(dt.Rows[0][10].ToString());
            double l = Convert.ToDouble(dt.Rows[0][11].ToString());

            if (txtMasalaA.Text!="")
            {
                ans1 = a + (Convert.ToDouble(txtMasalaA.Text));
                
            }
            else
            {
                ans1 = Convert.ToDouble(dt.Rows[0][0].ToString());   // agar yaha pe else ki condition na lagaye to ans1 m kuch bhi  pada       nahi                                                                     milega jis se sab columns m zero save ho jayega
            }





            if (txtMasalaB.Text!="")
            {
                ans2 = b + Convert.ToDouble(txtMasalaB.Text);

            }
            else
            {
                ans2= Convert.ToDouble(dt.Rows[0][1].ToString());
         
            }




            if (txtMasalaC.Text != "")
            {
                ans3 = c + Convert.ToDouble(txtMasalaC.Text);

            }
            else
            {
            ans3=    Convert.ToDouble(dt.Rows[0][2].ToString());
                 
            }




            if (txtMasalaD.Text != "")
            {
                ans4 = d + Convert.ToDouble(txtMasalaD.Text);
           
            }

            else
            {
                ans4= Convert.ToDouble(dt.Rows[0][3].ToString());
            
            }






            if (txtMasalaE.Text != "")
            {
                ans5 = z + Convert.ToDouble(txtMasalaE.Text);
             
            }
            else
            {


            ans5= Convert.ToDouble(dt.Rows[0][4].ToString());

            }

         
        if (txtMasalaF.Text != "")
            {
                ans6 = f + Convert.ToDouble(txtMasalaF.Text);
         
            }
        else
        {
            ans6 = Convert.ToDouble(dt.Rows[0][5].ToString());
           
        }
            if (txtMasalaG.Text != "")
            {
                ans7 = g + Convert.ToDouble(txtMasalaG.Text);
          
            }

            else
            {
            ans7=         Convert.ToDouble(dt.Rows[0][6].ToString());
            
            }
            if (txtMasalaH.Text != "")
            {
                ans8 = h + Convert.ToDouble(txtMasalaH.Text);
           
            }
            else
            {
                ans8=Convert.ToDouble(dt.Rows[0][7].ToString());
          
            }



            if (txtMasalaI.Text != "")
            {
                ans9 = i + Convert.ToDouble(txtMasalaI.Text);
          
            }
            else
            {
                ans9 = Convert.ToDouble(dt.Rows[0][8].ToString());
        
            }



            if (txtMasalaJ.Text != "")
            {
                ans10 = j + Convert.ToDouble(txtMasalaJ.Text);

            }
            else 
            
            {

           ans10=     Convert.ToDouble(dt.Rows[0][9].ToString());
           
            }
          
            
            if (txtMasalaK.Text != "")
            {
                ans11 = k + Convert.ToDouble(txtMasalaK.Text);
           
            }
            else
            {
               ans11= Convert.ToDouble(dt.Rows[0][10].ToString());
           
            }



            if (txtMasalaL.Text != "")
            {
                ans12 = l + Convert.ToDouble(txtMasalaL.Text);
            
            }
            else
            {
           ans12=     Convert.ToDouble(dt.Rows[0][11].ToString());
           
            }




            obj.transact("update tbl_masalaAdd set masala_a='" + ans1 + "',masala_b='" + ans2 + "',masala_c='" + ans3 + "',masala_d='" + ans4 + "',masala_e='" + ans5 + "' ,masala_f='" + ans6 + "',masala_g='" + ans7 + "',masala_h='" + ans8 + "',masala_i='" + ans9 + "', masala_j='" + ans10 + "',masala_k='" + ans11 + "',masala_l='" + ans12 + "' ", "insert into tbl_stockAllDetails values('" + txtMasalaA.Text + "', '" + txtMasalaB.Text + "', '" + txtMasalaC.Text + "', '" + txtMasalaD.Text + "', '" + txtMasalaE.Text + "', '" + txtMasalaF.Text + "', '" + txtMasalaG.Text + "', '" + txtMasalaH.Text + "', '" + txtMasalaI.Text + "', '" + txtMasalaJ.Text + "', '" + txtMasalaK.Text + "', '" + txtMasalaL.Text + "', '"+Convert.ToDateTime(dateTimePicker1.Text)+"' )");
            
            
            
            
            //obj.transact("update tbl_masalaAdd set masala_a='" + ans1 + "',masala_b='" + ans2 + "',masala_c='" + ans3 + "',masala_d='" + ans4 + "',masala_e='" + ans5 + "' ,masala_f='" + ans6 + "',masala_g='" + ans7 + "',masala_h='" + ans8 + "',masala_i='" + ans9 + "', masala_j='" + ans10 + "',masala_k='" + ans11 + "',masala_l='" + ans12 + "' ", "insert into tbl_stockAllDetails values(" + "+'" + txtMasalaA.Text + "','+'+'" + txtMasalaB.Text + "','+'+'" + txtMasalaC.Text + "','+'+'" + txtMasalaD.Text + "','+'+'" + txtMasalaE.Text + "','+'+'" + txtMasalaF.Text + "','+'+'" + txtMasalaG.Text + "','+'+'" + txtMasalaH.Text + "','+'+'" + txtMasalaI.Text + "','+'+'" + txtMasalaJ.Text + "','+'+'" + txtMasalaK.Text + "','+'+'" + txtMasalaL.Text + "','+'+'" + Convert.ToDateTime(dateTimePicker1.Text) + "'");
              

                //com=new SqlCommand  ("update tbl_masalaAdd set masala_a=    '" + ans1 + "'  ,masala_b='" + ans2 + "'       ,      masala_c='" + ans3 + "'      ,     masala_d='" + ans4 + "'    ,     masala_e='" + ans5 + "'      ,     masala_f='" + ans6 + "'     ,     masala_g='" + ans7 + "'      ,     masala_h='" + ans8 + "'     ,     masala_i='" + ans9 + "'       ,     masala_j='" + ans10 + "'     ,     masala_k='" + ans11 + "'     ,     masala_l='" + ans12 + "'  ",con,tran);

              //  com.ExecuteNonQuery();
              //  com = new SqlCommand("insert into tbl_stockAllDetails values("+"+'" + txtMasalaA.Text + "','+'+'" + txtMasalaB.Text + "','+'+'" + txtMasalaC.Text + "','+'+'" + txtMasalaD.Text + "','+'+'" + txtMasalaE.Text + "','+'+'" + txtMasalaF.Text + "','+'+'" + txtMasalaG.Text + "','+'+'" + txtMasalaH.Text + "','+'+'" + txtMasalaI.Text + "','+'+'" + txtMasalaJ.Text + "','+'+'" + txtMasalaK.Text + "','+'+'" + txtMasalaL.Text + "','+'+'" + Convert.ToDateTime(dateTimePicker1.Text) + "')", con, tran);
              //com.ExecuteNonQuery();
              //tran.Commit();
        
              
              txtMasalaA.Text = "";
              txtMasalaB.Text = "";
              txtMasalaC.Text = "";
              txtMasalaD.Text = "";
              txtMasalaE.Text = "";
              txtMasalaF.Text = "";
              txtMasalaG.Text = "";
              txtMasalaH.Text = "";
              txtMasalaI.Text = "";
              txtMasalaJ.Text = "";
              txtMasalaK.Text = "";
              txtMasalaL.Text = "";
      dataGridView2.DataSource= obj.show("select *from tbl_masalaAdd");  
            // com=new SqlCommand  ("select *from tbl_masalaAdd",con);
              //SqlDataReader ddd = com.ExecuteReader();
              // dt = new DataTable();
              // dt.Load(ddd);
              // dataGridView2.DataSource = dt;
              //  con.Close();
            }
           // catch (Exception ex)
           // {
           //     //tran.Rollback();
            
           //     MessageBox.Show("Error");
                
           // }
           //}

        private void button2_Click(object sender, EventArgs e)
        {
            order o = new order();
            o.Show();
            this.Hide();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = obj.show("select *from tbl_masalaAdd");

        }

     

        private void txtMasalaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMasalaL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.Show();
            this.Hide();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            string s = label19.Height.ToString();
            int a = Convert.ToInt32(s) + 10;
            string b = Convert.ToString(a);
            label19.Height = Convert.ToInt32(b);
        }

       
    }
}
// Features 
//1= agar sql wali table m puri delete kara denge to kam nahi chalega, 0 pada hona jaruri hai
//2= agar sirf ek masala add karvana chahte hai to kara sakte hai
//3= sirf numeric keypad chalega
//3= jo bhi hum  jaha pe add karayege wo ek bar tblstockAllDetails table m ja k save ho jayega, future m dekhne k liye, agar kisi reason se add nahi hua to dono m se kisi bhi table m entry nahi hogi