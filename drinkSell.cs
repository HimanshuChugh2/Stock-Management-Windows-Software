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
    public partial class drinkSell : Form
    {
        string all1, all2, all3, all4, all5, all6, all7, all8; // these variable will be used for showing all entries/ record all entries
        int len, chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8,a,b,c,d,z,f,g,h;
        string s1, s2, s3, s4, s5, s6, s7, s8;
         DataTable dt;
        int i;

        Class1 obj = new Class1();
        public drinkSell()
        {
            InitializeComponent();
            timer1.Start();
        }



        public void sum()
        {


            DataTable dtt = obj.show("select *from tbl_drinkAdd");
            int aa = Convert.ToInt32(dtt.Rows[0][0].ToString());  // database ki har value ko ek ek variable m rakhva liya
            int bb = Convert.ToInt32(dtt.Rows[0][1].ToString());
            int cc = Convert.ToInt32(dtt.Rows[0][2].ToString());
            int dd = Convert.ToInt32(dtt.Rows[0][3].ToString());
            int zz = Convert.ToInt32(dtt.Rows[0][4].ToString());
            int ff = Convert.ToInt32(dtt.Rows[0][5].ToString());
            int gg = Convert.ToInt32(dtt.Rows[0][6].ToString());
            int hh = Convert.ToInt32(dtt.Rows[0][7].ToString());
            lblMLa.Text = Convert.ToString(aa) + " ML" + "s";
            lblMLb.Text = Convert.ToString(bb) + " ML" + "s";
            lblMLc.Text = Convert.ToString(cc) + " ML" + "s";
            lblMLd.Text = Convert.ToString(dd) + " ML" + "s";
            lblMLe.Text = Convert.ToString(zz) + " ML" + "s";
            lblMLf.Text = Convert.ToString(ff) + " ML" + "s";
            lblMLg.Text = Convert.ToString(gg) + " ML" + "s";
            lblMLh.Text = Convert.ToString(hh) + " ML" + "s";

            int ans1 = aa / 750;  // is se bottles calculate hogi
            int ans2 = bb / 750;
            int ans3 = cc / 750;
            int ans4 = dd / 750;
            int ans5 = zz / 750;
            int ans6 = ff / 750;
            int ans7 = gg / 750;
            int ans8 = hh / 750;



            lblA.Text = Convert.ToString(ans1 + " Bottles of Brand A");
            lblB.Text = Convert.ToString(ans2 + " Bottles of Brand B");
            lblC.Text = Convert.ToString(ans3 + " Bottles of Brand C");
            lblD.Text = Convert.ToString(ans4 + " Bottles of Brand D");
            lblE.Text = Convert.ToString(ans5 + " Bottles of Brand E");
            lblF.Text = Convert.ToString(ans6 + " Bottles of Brand F");
            lblG.Text = Convert.ToString(ans7 + " Bottles of Brand G");
            lblH.Text = Convert.ToString(ans8 + " Bottles of Brand H");


            double Aans1 = Convert.ToDouble(aa) / 750 / 12;
            int Aans2 = (int)Aans1;  // Aans2 is the value of catron

            double Aans3 = Aans1 - (int)Aans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Aans3 > 0.1) // aans3 is the value of bottles 
            {
                s1 = Convert.ToString(Aans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s1 = "0";  // is se humne wo zero hata di


            lblCartonA.Text = Convert.ToString(Aans2) + " Carton of Brand A" + " and " + Convert.ToString(s1) + " Bottles";











            // code below is for second label   
            double Bans1 = Convert.ToDouble(bb) / 750 / 12;
            int Bans2 = (int)Bans1;

            double Bans3 = Bans1 - (int)Bans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Bans3 > 0.1)
            {
                s2 = Convert.ToString(Bans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s2 = "0";//Convert.ToString(Bans3).Substring"0";  // is se humne wo zero hata di


            lblcartonB.Text = Convert.ToString(Bans2) + " Carton of Brand B" + " and " + Convert.ToString(s2) + " Bottles";






            // code below is for third label


            double Cans1 = Convert.ToDouble(cc) / 750 / 12;
            int Cans2 = (int)Cans1;

            double Cans3 = Bans1 - (int)Cans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Cans3 > 0.1)
            {
                s3 = Convert.ToString(Cans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s3 = "0";  // is se humne wo zero hata di


            lblCartonC.Text = Convert.ToString(Cans2) + " Carton of Brand G" + " and " + Convert.ToString(s3) + " Bottles";



            // code for fourth label
            double Dans1 = Convert.ToDouble(dd) / 750 / 12;
            int Dans2 = (int)Dans1;

            double Dans3 = Dans1 - (int)Dans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Dans3 > 0.1)
            {
                s4 = Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s4 = "0";//Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonD.Text = Convert.ToString(Dans2) + " Carton of Brand D" + " and " + Convert.ToString(s4) + " Bottles";


            // code below is for fifth label

            double Eans1 = Convert.ToDouble(zz) / 750 / 12;
            int Eans2 = (int)Eans1;

            double Eans3 = Eans1 - (int)Eans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Eans3 > 0.1)
            {
                s5 = Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s5 = "0";//Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonE.Text = Convert.ToString(Eans2) + " Carton of Brand F" + " and " + Convert.ToString(s5) + " Bottles";








            // code below is for sixth label

            double Fans1 = Convert.ToDouble(ff) / 750 / 12;
            int Fans2 = (int)Fans1;

            double Fans3 = Fans1 - (int)Fans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Fans3 > 0.1)
            {
                s6 = Convert.ToString(Fans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s6 = "0"; //Convert.ToString(Fans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonF.Text = Convert.ToString(Fans2) + " Carton of Brand F" + " and " + Convert.ToString(s6) + " Bottles";





            // code below is for seventh label

            double Gans1 = Convert.ToDouble(gg) / 750 / 12;  // ML se carton m convert karne k bad jo value aayegi wo decimal m aayegi and we dont want that
            //string Gans2 = Convert.ToString(Gans1).Substring(1, 2);  // is se ml se carton m badal jayega par ye ek decimal m number dega hum chahte hai ki cartons k sath sath ye bhi dikhaye ki kitni     bottle padi hai like (7 cartons and 2 bottles)

            int Gans2 = (int)Gans1;

            double Gans3 = Gans1 - (int)Gans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Gans3 > 0.1)
            {
                s7 = Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s7 = "0";//Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonG.Text = Convert.ToString(Gans2) + " Carton of Brand G" + " and " + Convert.ToString(s7) + " Bottles";




            // code below is for eighth label

            double Hans1 = Convert.ToDouble(hh) / 750 / 12;
            int Hans2 = (int)Hans1;

            double Hans3 = Hans1 - (int)Hans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Hans3 > 0.1)
            {
                s8 = Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s8 = "0"; //Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonH.Text = Convert.ToString(Hans2) + " Carton of Brand H" + " and " + Convert.ToString(s8) + " Bottles";

            checkBox1.Checked = false;

             

            MessageBox.Show("Stock Refreshed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        
        
                chkBRANDa.Checked = false; chkBRANDb.Checked = false; chkBRANDc.Checked = false; chkBRANDd.Checked = false; chkBRANDe.Checked = false; chkBRANDf.Checked = false; chkBRANDg.Checked = false; chkBRANDh.Checked = false; checkBox1.Checked = false; txtQuantity.Text = "" ;

        
        }
        













        private void button5_Click(object sender, EventArgs e)
        {

            if (chkBRANDa.Checked == true || chkBRANDb.Checked == true || chkBRANDc.Checked == true || chkBRANDd.Checked == true || chkBRANDe.Checked == true || chkBRANDf.Checked == true || chkBRANDg.Checked == true || chkBRANDh.Checked == true)
            {

                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DataTable dt = obj.show("select *from tbl_drinkAdd");
                    a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    b = Convert.ToInt32(dt.Rows[0][1].ToString());
                    c = Convert.ToInt32(dt.Rows[0][2].ToString());
                    d = Convert.ToInt32(dt.Rows[0][3].ToString());
                    z = Convert.ToInt32(dt.Rows[0][4].ToString());
                    f = Convert.ToInt32(dt.Rows[0][5].ToString());
                    g = Convert.ToInt32(dt.Rows[0][6].ToString());
                    h = Convert.ToInt32(dt.Rows[0][7].ToString());


                    //if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || f <= 0 || g <= 0 || h <= 0)
                    //{
                    //    MessageBox.Show("Sufficient Amount of Drinks are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //}
                    //else
                    //{
                    if (chkBRANDa.Checked == true)  // agar checked true hai to stock m check kar lenge ki sufficient amount pada bhi hai ya nhi
                    {
                        int a1 = a - Convert.ToInt32(txtQuantity.Text) * 750; // yaha pe int value li hai kyuki agar chk1 ko match karvayege to usme se minus ho jayega fir agar minus hone k bad zero hua to chk1 minus m chala jayega

                        if (a1 <= 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink A is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk1 = a; // agar chota hai 0 se to pehle wala hi set kara diya
                        }
                        else
                        {
                            chk1 = a - Convert.ToInt32(txtQuantity.Text) * 750;
                            all1 = txtQuantity.Text + " bottle "; // this all1 variable is using here to record all entries
                        }
                    }


                    else
                    {
                        chk1 = a;
                    }







                    if (chkBRANDb.Checked == true)
                    {
                        int a1 = b - Convert.ToInt32(txtQuantity.Text) * 750;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drinks B is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk2 = b;
                        }
                        else
                        {
                            chk2 = b - Convert.ToInt32(txtQuantity.Text) * 750;
                            all2 = txtQuantity.Text + " bottle";

                        }
                    }

                    else
                    {
                        chk2 = b;
                    }



                    if (chkBRANDc.Checked == true)
                    {
                        int a1 = c - Convert.ToInt32(txtQuantity.Text) * 750;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink C is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk3 = c;
                        }
                        else
                        {
                            chk3 = c - Convert.ToInt32(txtQuantity.Text) * 750;
                            all3 = txtQuantity.Text + " bottle ";
                        }

                    }
                    else
                    {
                        chk3 = c;
                    }





                    if (chkBRANDd.Checked == true)
                    {
                        int a1 = d - Convert.ToInt32(txtQuantity.Text) * 750;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink D is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk4 = d;
                        }
                        else
                        {
                            chk4 = d - Convert.ToInt32(txtQuantity.Text) * 750;
                            all4 = txtQuantity.Text + " bottle";
                        }


                    }
                    else
                    {
                        chk4 = d;
                    }






                    if (chkBRANDe.Checked == true)
                    {
                        int a1 = z - Convert.ToInt32(txtQuantity.Text) * 750;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink E is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk5 = z;
                        }
                        else
                        {
                            chk5 = z - Convert.ToInt32(txtQuantity.Text) * 750;
                            all5 = txtQuantity.Text + " bottle ";
                        }

                    }
                    else
                    {
                        chk5 = z;
                    }



                    if (chkBRANDf.Checked == true)
                    {
                        int a1 = f - Convert.ToInt32(txtQuantity.Text) * 750;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink F is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk6 = f;
                        }
                        else
                        {
                            chk6 = f - Convert.ToInt32(txtQuantity.Text) * 750;
                            all6 = txtQuantity.Text + " bottle ";
                        }

                    }
                    else
                    {
                        chk6 = f;
                    }





                    if (chkBRANDg.Checked == true)
                    {
                        int a1 = g - Convert.ToInt32(txtQuantity.Text) * 750;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink G is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk7 = g;
                        }
                        else
                        {
                            chk7 = g - Convert.ToInt32(txtQuantity.Text) * 750;
                            all7 = txtQuantity.Text + " bottle ";
                        }

                    }
                    else
                    {

                        chk7 = g;
                    }





                    if (chkBRANDh.Checked == true)
                    {
                        int a1 = h - Convert.ToInt32(txtQuantity.Text) * 750;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink H is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk8 = h;
                        }
                        else
                        {
                            chk8 = b - Convert.ToInt32(txtQuantity.Text) * 750;
                            all8 = txtQuantity.Text + " bottle";
                        }

                    }
                    else
                    {
                        chk8 = h;
                    }





                    obj.transact("update tbl_drinkAdd set BRAND_A=('" + chk1 + "'), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'),BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'),BRAND_H=('" + chk8 + "')", ("insert into tbl_DrinkEntries values('" + all1
    + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" + all6 + "','" + all7 + "','" + all8 + "','SELL','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));
                     
 


                    sum();
 




                    dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");
                }
               
            }

            else
            {


                MessageBox.Show("Select Brand Name First", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           }

        private void button1_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 9;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 10;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = txtQuantity.Text + 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {

            string s = txtQuantity.Text;
            len = s.Length;
            if (len > 0)
            {
                txtQuantity.Text = s.Substring(0, len - 1);
            }
            else
            {
                MessageBox.Show("Nothing to Delete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                chkBRANDa.Checked = true; chkBRANDb.Checked = true; chkBRANDc.Checked = true; chkBRANDd.Checked = true; chkBRANDe.Checked = true; chkBRANDf.Checked = true; chkBRANDg.Checked = true; chkBRANDh.Checked = true;
            }
            else
            {
                chkBRANDa.Checked = false; chkBRANDb.Checked = false; chkBRANDc.Checked = false; chkBRANDd.Checked = false; chkBRANDe.Checked = false; chkBRANDf.Checked = false; chkBRANDg.Checked = false; chkBRANDh.Checked = false;
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            ///DataTable dt = obj.show("select *from tbl_drinkAdd");
            if (chkBRANDa.Checked == true || chkBRANDb.Checked == true || chkBRANDc.Checked == true || chkBRANDd.Checked == true || chkBRANDe.Checked == true || chkBRANDf.Checked == true || chkBRANDg.Checked == true || chkBRANDh.Checked == true)
            {



                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DataTable dt = obj.show("select *from tbl_drinkAdd");
                    a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    b = Convert.ToInt32(dt.Rows[0][1].ToString());
                    c = Convert.ToInt32(dt.Rows[0][2].ToString());
                    d = Convert.ToInt32(dt.Rows[0][3].ToString());
                    z = Convert.ToInt32(dt.Rows[0][4].ToString());
                    f = Convert.ToInt32(dt.Rows[0][5].ToString());
                    g = Convert.ToInt32(dt.Rows[0][6].ToString());
                    h = Convert.ToInt32(dt.Rows[0][7].ToString());


                    //if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || f <= 0 || g <= 0 || h <= 0)
                    //{
                    //    MessageBox.Show("Sufficient Amount of Drinks are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //}
                    //else
                    //{
                    if (chkBRANDa.Checked == true)  // agar checked true hai to stock m check kar lenge ki sufficient amount pada bhi hai ya nhi
                    {
                        int a1 = a - Convert.ToInt32(txtQuantity.Text) * 30; // yaha pe int value li hai kyuki agar chk1 ko match karvayege to usme se minus ho jayega fir agar minus hone k bad zero hua to chk1 minus m chala jayega

                        if (a1 < 0)  // match karavaaya ki sell hone k bad minus m to nahi ja rha stock
                        {
                            MessageBox.Show("Sufficient Amount of Drink A is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk1 = a; // agar chota hai 0 se to pehle wala hi set kara diya
                            
                        }
                        else
                        {
                            chk1 = a - Convert.ToInt32(txtQuantity.Text) * 30;
                            all1 = txtQuantity.Text + " Peg of " + button2.Text;
                             obj.query("insert into tbGridView values('" + chkBRANDa.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");


                            

                        }
                    }


                    else
                    {
                        chk1 = a;
                    }







                    if (chkBRANDb.Checked == true)
                    {
                        int a1 = b - Convert.ToInt32(txtQuantity.Text) * 30;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drinks B is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk2 = b;
                            }
                        else
                        {
                            chk2 = b - Convert.ToInt32(txtQuantity.Text) * 30;
                            all2 = txtQuantity.Text + " Peg of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDb.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                           
                        }
                    }

                    else
                    {
                        chk2 = b;
                    }



                    if (chkBRANDc.Checked == true)
                    {
                        int a1 = c - Convert.ToInt32(txtQuantity.Text) * 30;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink C is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk3 = c;
                         }
                        else
                        {
                            chk3 = c - Convert.ToInt32(txtQuantity.Text) * 30;
                            all3 = txtQuantity.Text + " Peg of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDc.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");
                           }

                    }
                    else
                    {
                        chk3 = c;
                    }





                    if (chkBRANDd.Checked == true)
                    {
                        int a1 = d - Convert.ToInt32(txtQuantity.Text) * 30;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink D is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk4 = d;
                            }
                        else
                        {
                            chk4 = d - Convert.ToInt32(txtQuantity.Text) * 30;
                            all4 = txtQuantity.Text + " Peg of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDd.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");
                             }


                    }
                    else
                    {
                        chk4 = d;
                    }






                    if (chkBRANDe.Checked == true)
                    {
                        int a1 = z - Convert.ToInt32(txtQuantity.Text) * 30;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink E is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk5 = z;
                           }
                        else
                        {
                            chk5 = z - Convert.ToInt32(txtQuantity.Text) * 30;
                            all5 = txtQuantity.Text + " Pegs of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDe.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");
                            }

                    }
                    else
                    {
                        chk5 = z;
                    }



                    if (chkBRANDf.Checked == true)
                    {
                        int a1 = f - Convert.ToInt32(txtQuantity.Text) * 30;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink F is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk6 = f;
                            }
                        else
                        {
                            chk6 = f - Convert.ToInt32(txtQuantity.Text) * 30;
                            all6 = txtQuantity.Text + " Peg of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDf.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");
                            
                        }

                    }
                    else
                    {
                        chk6 = f;
                    }





                    if (chkBRANDg.Checked == true)
                    {
                        int a1 = g - Convert.ToInt32(txtQuantity.Text) * 30;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink G is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk7 = g;
                            
                        }
                        else
                        {
                            chk7 = g - Convert.ToInt32(txtQuantity.Text) * 30;
                            all7 = txtQuantity.Text + " Peg of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDg.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");
                           
                        }

                    }
                    else
                    {

                        chk7 = g;
                    }





                    if (chkBRANDh.Checked == true)
                    {
                        int a1 = h - Convert.ToInt32(txtQuantity.Text) * 30;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink H is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk8 = h;
                           }
                        else
                        {
                            chk8 = h - Convert.ToInt32(txtQuantity.Text) * 30;
                            all8 = txtQuantity.Text + " Peg of " + button2.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDh.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }

                    }
                    else
                    {
                        chk8 = h;
                    }

                   
                    
                    dataGridView2.DataSource = obj.show("select *from tbGridview where cid='"+label3.Text+"' ");


                    obj.transact("update tbl_drinkAdd set BRAND_A=('" + chk1 + "'), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'),BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'),BRAND_H=('" + chk8 + "')", ("insert into tbl_DrinkEntries values('" + all1
    + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" + all6 + "','" + all7 + "','" + all8 + "','SELL','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));

                    





                    sum(); 









//           
                    dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");
            

                  //  MessageBox.Show("Stock Refreshed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                   




            }
            else
            {
                MessageBox.Show(" Select Brand name first ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
            }
            }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Goldenrod;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Goldenrod;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chkBRANDa.Checked == true || chkBRANDb.Checked == true || chkBRANDc.Checked == true || chkBRANDd.Checked == true || chkBRANDe.Checked == true || chkBRANDf.Checked == true || chkBRANDg.Checked == true || chkBRANDh.Checked == true)
            {

                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DataTable dt = obj.show("select *from tbl_drinkAdd");
                    a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    b = Convert.ToInt32(dt.Rows[0][1].ToString());
                    c = Convert.ToInt32(dt.Rows[0][2].ToString());
                    d = Convert.ToInt32(dt.Rows[0][3].ToString());
                    z = Convert.ToInt32(dt.Rows[0][4].ToString());
                    f = Convert.ToInt32(dt.Rows[0][5].ToString());
                    g = Convert.ToInt32(dt.Rows[0][6].ToString());
                    h = Convert.ToInt32(dt.Rows[0][7].ToString());


                    if (chkBRANDa.Checked == true)  // agar checked true hai to stock m check kar lenge ki sufficient amount pada bhi hai ya nhi
                    {
                        int a1 = a - Convert.ToInt32(txtQuantity.Text) * 60; // yaha pe int value li hai kyuki agar chk1 ko match karvayege to usme se minus ho jayega fir agar minus hone k bad zero hua to chk1 minus m chala jayega

                        if (a1 <= 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink A not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk1 = a; // agar chota hai 0 se to pehle wala hi set kara diya
                        }
                        else
                        {
                            chk1 = a - Convert.ToInt32(txtQuantity.Text) * 60;
                            all1 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDa.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }
                    }


                    else
                    {
                        chk1 = a;
                    }







                    if (chkBRANDb.Checked == true)
                    {
                        int a1 = b - Convert.ToInt32(txtQuantity.Text) * 60;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink  A is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk2 = b;
                        }
                        else
                        {
                            chk2 = b - Convert.ToInt32(txtQuantity.Text) * 60;
                            all2 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDb.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");


                        }
                    }

                    else
                    {
                        chk2 = b;
                    }



                    if (chkBRANDc.Checked == true)
                    {
                        int a1 = c - Convert.ToInt32(txtQuantity.Text) * 60;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink B is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk3 = c;
                        }
                        else
                        {
                            chk3 = c - Convert.ToInt32(txtQuantity.Text) * 60;
                            all3 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDc.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }

                    }
                    else
                    {
                        chk3 = c;
                    }





                    if (chkBRANDd.Checked == true)
                    {
                        int a1 = d - Convert.ToInt32(txtQuantity.Text) * 60;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink C is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk4 = d;
                        }
                        else
                        {
                            chk4 = d - Convert.ToInt32(txtQuantity.Text) * 60;
                            all4 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDd.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }


                    }
                    else
                    {
                        chk4 = d;
                    }






                    if (chkBRANDe.Checked == true)
                    {
                        int a1 = z - Convert.ToInt32(txtQuantity.Text) * 60;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink  E is  not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk5 = z;
                        }
                        else
                        {
                            chk5 = z - Convert.ToInt32(txtQuantity.Text) * 60;
                            all5 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDe.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }

                    }
                    else
                    {
                        chk5 = z;
                    }



                    if (chkBRANDf.Checked == true)
                    {
                        int a1 = f - Convert.ToInt32(txtQuantity.Text) * 60;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink  F is   not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk6 = f;
                        }
                        else
                        {
                            chk6 = f - Convert.ToInt32(txtQuantity.Text) * 60;
                            all6 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDf.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }

                    }
                    else
                    {
                        chk6 = f;
                    }





                    if (chkBRANDg.Checked == true)
                    {
                        int a1 = g - Convert.ToInt32(txtQuantity.Text) * 60;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink G is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk7 = g;
                        }
                        else
                        {
                            chk7 = g - Convert.ToInt32(txtQuantity.Text) * 60;
                            all7 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDg.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }

                    }
                    else
                    {

                        chk7 = g;
                    }





                    if (chkBRANDh.Checked == true)
                    {
                        int a1 = h - Convert.ToInt32(txtQuantity.Text) * 60;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink H is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk8 = h;
                        }
                        else
                        {
                            chk8 = b - Convert.ToInt32(txtQuantity.Text) * 60;
                            all8 = txtQuantity.Text + " Pegs of " + button3.Text;
                            obj.query("insert into tbGridView values('" + chkBRANDh.Text + "','" + txtQuantity.Text + "','" + label3.Text + "','30 ML')");

                        }

                    }
                    else
                    {
                        chk8 = h;
                    }


                    dataGridView2.DataSource = obj.show("select *from tbGridview where cid='" + label3.Text + "' ");



                    obj.transact("update tbl_drinkAdd set BRAND_A=('" + chk1 + "'), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'),BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'),BRAND_H=('" + chk8 + "')", ("insert into tbl_DrinkEntries values('" + all1
        + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" + all6 + "','" + all7 + "','" + all8 + "','SELL','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));







                    sum(); 


 





                    dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");
                }
            }
            else
            {
                MessageBox.Show("Select Brand Name First", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
            }
            chkBRANDa.Checked = false; chkBRANDb.Checked = false; chkBRANDc.Checked = false; chkBRANDd.Checked = false; chkBRANDe.Checked = false; chkBRANDf.Checked = false; chkBRANDg.Checked = false; chkBRANDh.Checked = false; checkBox1.Checked = false; txtQuantity.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (chkBRANDa.Checked == true || chkBRANDb.Checked == true || chkBRANDc.Checked == true || chkBRANDd.Checked == true || chkBRANDe.Checked == true || chkBRANDf.Checked == true || chkBRANDg.Checked == true || chkBRANDh.Checked == true)
            {


                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DataTable dt = obj.show("select *from tbl_drinkAdd");
                    a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    b = Convert.ToInt32(dt.Rows[0][1].ToString());
                    c = Convert.ToInt32(dt.Rows[0][2].ToString());
                    d = Convert.ToInt32(dt.Rows[0][3].ToString());
                    z = Convert.ToInt32(dt.Rows[0][4].ToString());
                    f = Convert.ToInt32(dt.Rows[0][5].ToString());
                    g = Convert.ToInt32(dt.Rows[0][6].ToString());
                    h = Convert.ToInt32(dt.Rows[0][7].ToString());


                    //if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || f <= 0 || g <= 0 || h <= 0)
                    //{
                    //    MessageBox.Show("Sufficient Amount of Drinks are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //}
                    //else
                    //{
                    if (chkBRANDa.Checked == true)  // agar checked true hai to stock m check kar lenge ki sufficient amount pada bhi hai ya nhi
                    {
                        int a1 = a - Convert.ToInt32(txtQuantity.Text) * 9000; // yaha pe int value li hai kyuki agar chk1 ko match karvayege to usme se minus ho jayega fir agar minus hone k bad zero hua to chk1 minus m chala jayega

                        if (a1 <= 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink A is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk1 = a; // agar chota hai 0 se to pehle wala hi set kara diya
                        }
                        else
                        {
                            chk1 = a - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all1 = txtQuantity.Text + " carton "; // this all1 variable is using here to record all entries
                        }
                    }


                    else
                    {
                        chk1 = a;
                    }







                    if (chkBRANDb.Checked == true)
                    {
                        int a1 = b - Convert.ToInt32(txtQuantity.Text) * 9000;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drinks B is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk2 = b;
                        }
                        else
                        {
                            chk2 = b - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all2 = txtQuantity.Text + " carton";

                        }
                    }

                    else
                    {
                        chk2 = b;
                    }



                    if (chkBRANDc.Checked == true)
                    {
                        int a1 = c - Convert.ToInt32(txtQuantity.Text) * 9000;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink C is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk3 = c;
                        }
                        else
                        {
                            chk3 = c - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all3 = txtQuantity.Text + " carton ";
                        }

                    }
                    else
                    {
                        chk3 = c;
                    }





                    if (chkBRANDd.Checked == true)
                    {
                        int a1 = d - Convert.ToInt32(txtQuantity.Text) * 9000;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink D is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk4 = d;
                        }
                        else
                        {
                            chk4 = d - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all4 = txtQuantity.Text + " carton ";
                        }


                    }
                    else
                    {
                        chk4 = d;
                    }






                    if (chkBRANDe.Checked == true)
                    {
                        int a1 = z - Convert.ToInt32(txtQuantity.Text) * 9000;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink E is not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk5 = z;
                        }
                        else
                        {
                            chk5 = z - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all5 = txtQuantity.Text + " carton";
                        }

                    }
                    else
                    {
                        chk5 = z;
                    }



                    if (chkBRANDf.Checked == true)
                    {
                        int a1 = f - Convert.ToInt32(txtQuantity.Text) * 9000;

                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink F is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk6 = f;
                        }
                        else
                        {
                            chk6 = f - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all6 = txtQuantity.Text + " carton ";
                        }

                    }
                    else
                    {
                        chk6 = f;
                    }





                    if (chkBRANDg.Checked == true)
                    {
                        int a1 = g - Convert.ToInt32(txtQuantity.Text) * 9000;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink G is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk7 = g;
                        }
                        else
                        {
                            chk7 = g - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all7 = txtQuantity.Text + " carton";
                        }

                    }
                    else
                    {

                        chk7 = g;
                    }





                    if (chkBRANDh.Checked == true)
                    {
                        int a1 = h - Convert.ToInt32(txtQuantity.Text) * 9000;
                        if (a1 < 0)
                        {
                            MessageBox.Show("Sufficient Amount of Drink H is are not in Stock", "Empty Stock", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            chk8 = h;
                        }
                        else
                        {
                            chk8 = h - Convert.ToInt32(txtQuantity.Text) * 9000;
                            all8 = txtQuantity.Text + " carton";
                        }

                    }
                    else
                    {
                        chk8 = h;
                    }





                    obj.transact("update tbl_drinkAdd set BRAND_A=('" + chk1 + "'), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'),BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'),BRAND_H=('" + chk8 + "')", ("insert into tbl_DrinkEntries values('" + all1
    + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" + all6 + "','" + all7 + "','" + all8 + "','SELL','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));







                    sum();









                     dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");
                     
                }
            }
            else
            {
                MessageBox.Show("Select Brand Name first", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            }
        private void button6_Click(object sender, EventArgs e)
        {
            drinkAdd d = new drinkAdd();
            d.Show(); this.Hide();
        }

        private void drinkSell_Load(object sender, EventArgs e)
        {




            //txtQuantity.Text = "Select Quantity";
            
          
  

            
            
            
            
            
            
            
            
            
            
            
            DateTime dt = DateTime.Now;
           // dateTimePicker1.Text = dt.ToString();
          
            
            dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");

            DataTable dtt = obj.show("select *from tbl_drinkAdd");
            int aa = Convert.ToInt32(dtt.Rows[0][0].ToString());  // database ki har value ko ek ek variable m rakhva liya
            int bb = Convert.ToInt32(dtt.Rows[0][1].ToString());
            int cc = Convert.ToInt32(dtt.Rows[0][2].ToString());
            int dd = Convert.ToInt32(dtt.Rows[0][3].ToString());
            int zz = Convert.ToInt32(dtt.Rows[0][4].ToString());
            int ff = Convert.ToInt32(dtt.Rows[0][5].ToString());
            int gg = Convert.ToInt32(dtt.Rows[0][6].ToString());
            int hh = Convert.ToInt32(dtt.Rows[0][7].ToString());
            lblMLa.Text = Convert.ToString(aa) + " ML" + "s";
            lblMLb.Text = Convert.ToString(bb) + " ML" + "s";
            lblMLc.Text = Convert.ToString(cc) + " ML" + "s";
            lblMLd.Text = Convert.ToString(dd) + " ML" + "s";
            lblMLe.Text = Convert.ToString(zz) + " ML" + "s";
            lblMLf.Text = Convert.ToString(ff) + " ML" + "s";
            lblMLg.Text = Convert.ToString(gg) + " ML" + "s";
            lblMLh.Text = Convert.ToString(hh) + " ML" + "s";

            int ans1 = aa / 750;  // is se bottles calculate hogi
            int ans2 = bb / 750;
            int ans3 = cc / 750;
            int ans4 = dd / 750;
            int ans5 = zz / 750;
            int ans6 = ff / 750;
            int ans7 = gg / 750;
            int ans8 = hh / 750;



            lblA.Text = Convert.ToString(ans1 + " Bottles of Brand A");
            lblB.Text = Convert.ToString(ans2 + " Bottles of Brand B");
            lblC.Text = Convert.ToString(ans3 + " Bottles of Brand C");
            lblD.Text = Convert.ToString(ans4 + " Bottles of Brand D");
            lblE.Text = Convert.ToString(ans5 + " Bottles of Brand E");
            lblF.Text = Convert.ToString(ans6 + " Bottles of Brand F");
            lblG.Text = Convert.ToString(ans7 + " Bottles of Brand G");
            lblH.Text = Convert.ToString(ans8 + " Bottles of Brand H");


            double Aans1 = Convert.ToDouble(aa) / 750 / 12;
            int Aans2 = (int)Aans1;  // Aans2 is the value of catron

            double Aans3 = Aans1 - (int)Aans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Aans3 > 0.1) // aans3 is the value of bottles 
            {
                s1 = Convert.ToString(Aans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s1 = "0";  // is se humne wo zero hata di


            lblCartonA.Text = Convert.ToString(Aans2) + " Carton of Brand A" + " and " + Convert.ToString(s1) + " Bottles";











            // code below is for second label   
            double Bans1 = Convert.ToDouble(bb) / 750 / 12;
            int Bans2 = (int)Bans1;

            double Bans3 = Bans1 - (int)Bans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Bans3 > 0.1)
            {
                s2 = Convert.ToString(Bans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s2 = "0";//Convert.ToString(Bans3).Substring"0";  // is se humne wo zero hata di


            lblcartonB.Text = Convert.ToString(Bans2) + " Carton of Brand B" + " and " + Convert.ToString(s2) + " Bottles";






            // code below is for third label


            double Cans1 = Convert.ToDouble(cc) / 750 / 12;
            int Cans2 = (int)Cans1;

            double Cans3 = Bans1 - (int)Cans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Cans3 > 0.1)
            {
                s3 = Convert.ToString(Cans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s3 = "0";  // is se humne wo zero hata di


            lblCartonC.Text = Convert.ToString(Cans2) + " Carton of Brand C" + " and " + Convert.ToString(s3) + " Bottles";



            // code for fourth label
            double Dans1 = Convert.ToDouble(dd) / 750 / 12;
            int Dans2 = (int)Dans1;

            double Dans3 = Dans1 - (int)Dans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Dans3 > 0.1)
            {
                s4 = Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s4 = "0";//Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonD.Text = Convert.ToString(Dans2) + " Carton of Brand D" + " and " + Convert.ToString(s4) + " Bottles";


            // code below is for fifth label

            double Eans1 = Convert.ToDouble(zz) / 750 / 12;
            int Eans2 = (int)Eans1;

            double Eans3 = Eans1 - (int)Eans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Eans3 > 0.1)
            {
                s5 = Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s5 = "0";//Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonE.Text = Convert.ToString(Eans2) + " Carton of Brand E" + " and " + Convert.ToString(s5) + " Bottles";








            // code below is for sixth label

            double Fans1 = Convert.ToDouble(ff) / 750 / 12;
            int Fans2 = (int)Fans1;

            double Fans3 = Fans1 - (int)Fans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Fans3 > 0.1)
            {
                s6 = Convert.ToString(Fans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s6 = "0"; //Convert.ToString(Fans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonF.Text = Convert.ToString(Fans2) + " Carton of Brand F" + " and " + Convert.ToString(s6) + " Bottles";





            // code below is for seventh label

            double Gans1 = Convert.ToDouble(gg) / 750 / 12;  // ML se carton m convert karne k bad jo value aayegi wo decimal m aayegi and we dont want that
            //string Gans2 = Convert.ToString(Gans1).Substring(1, 2);  // is se ml se carton m badal jayega par ye ek decimal m number dega hum chahte hai ki cartons k sath sath ye bhi dikhaye ki kitni     bottle padi hai like (7 cartons and 2 bottles)

            int Gans2 = (int)Gans1;

            double Gans3 = Gans1 - (int)Gans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Gans3 > 0.1)
            {
                s7 = Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s7 = "0";//Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonG.Text = Convert.ToString(Gans2) + " Carton of Brand G" + " and " + Convert.ToString(s7) + " Bottles";




            // code below is for eighth label

            double Hans1 = Convert.ToDouble(hh) / 750 / 12;
            int Hans2 = (int)Hans1;

            double Hans3 = Hans1 - (int)Hans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Hans3 > 0.1)
            {
                s8 = Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s8 = "0"; //Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di


            lblCartonH.Text = Convert.ToString(Hans2) + " Carton of Brand H" + " and " + Convert.ToString(s8) + " Bottles";

            checkBox1.Checked = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.SetBounds(10, 10, 70, 30);
            //int a = Convert.ToInt32(s) + 10;
            //string bc = Convert.ToString(a);
            //label1.Height = Convert.ToInt32(bc);
        
        }

        private void chkBRANDa_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDa.ForeColor = Color.White;
       
        }

        private void chkBRANDa_MouseHover(object sender, EventArgs e)
        {
            chkBRANDa.ForeColor = Color.Black;
       
        }

        private void chkBRANDb_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDb.ForeColor = Color.White;
        }

        private void chkBRANDb_MouseHover(object sender, EventArgs e)
        {
            chkBRANDb.ForeColor = Color.Black;
        }

        private void chkBRANDa_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDa.ForeColor = Color.Black;
        }

        private void chkBRANDb_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDb.ForeColor = Color.Black;
        }

        private void chkBRANDc_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDc.ForeColor = Color.White;
        }

        private void chkBRANDc_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void chkBRANDc_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDc.ForeColor = Color.Black;
        }

        private void chkBRANDd_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDd.ForeColor = Color.White;
        }

        private void chkBRANDd_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDd.ForeColor = Color.Black;
        }

        private void chkBRANDe_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDe.ForeColor = Color.White;
        }

        private void chkBRANDe_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDe.ForeColor = Color.Black;
        }

        private void chkBRANDf_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDf.ForeColor = Color.White;
        }

        private void chkBRANDf_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDf.ForeColor = Color.Black;
        }

        private void chkBRANDg_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDg.ForeColor = Color.White;
        }

        private void chkBRANDg_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDg.ForeColor = Color.Black;
        }

        private void chkBRANDh_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDh.ForeColor = Color.White;
        }

        private void chkBRANDh_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDh.ForeColor = Color.Black;
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.Black;
        }

        private void checkBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
           checkBox1.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drinkShow d = new drinkShow();
            d.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label2.Text = dt.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // ye dtp hatayege to command m se bhi change karna padega
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            for (int j = 0; j < 1;  j++)
            {
                i = i + 1;
             
                 dt= obj.show("select  *from tbGridView ");

             

               foreach (DataRow  dr in dt.Rows)
               {

                   //string abc = dr.ToString();
                   if (dr.Field<Int32>("cid") == i) 
                  
                   {


                       i = i + 1;
                       label3.Text = i.ToString();

                   
                   }
                   else
                   {
                       label3.Text = i.ToString();

                   }
                   

               }

            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
        //    if (txtQuantity.Text=="Select Quantity")
        //    {
        //        txtQuantity.Text = "";  // code for placeholder
        //    }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            //if (txtQuantity.Text=="")
            //{
            //    txtQuantity.Text = "Select Quantity";
            //}
        }

       

       

        
    }
}
