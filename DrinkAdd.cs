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
    public partial class drinkAdd : Form
    {
        string s1, s2, s3, s4, s5, s6, s8, s7;
        int chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8;
        string all1, all2, all3, all4, all5, all6, all7, all8; // these variable will be used for showing all entries/ record all entries
        int len;
        Class1 obj = new Class1();
        public drinkAdd()
        {
            InitializeComponent();
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
            txtQuantity.Text = txtQuantity.Text + "0";
        }

        private void btnCarton_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                if (chkBRANDa.Checked== true ||chkBRANDb.Checked== true ||chkBRANDc.Checked== true ||chkBRANDd.Checked== true ||chkBRANDe.Checked== true ||chkBRANDf.Checked== true ||chkBRANDg.Checked== true ||chkBRANDh.Checked== true)
	{
		 DataTable dt = obj.show("select *from tbl_drinkAdd ");
                int br_a = Convert.ToInt32(dt.Rows[0][0].ToString());
                int br_b = Convert.ToInt32(dt.Rows[0][1].ToString());
                int br_c = Convert.ToInt32(dt.Rows[0][2].ToString());
                int br_d = Convert.ToInt32(dt.Rows[0][3].ToString());
                int br_e = Convert.ToInt32(dt.Rows[0][4].ToString());
                int br_f = Convert.ToInt32(dt.Rows[0][5].ToString());
                int br_g = Convert.ToInt32(dt.Rows[0][6].ToString());
                int br_h = Convert.ToInt32(dt.Rows[0][7].ToString());
                if (chkBRANDa.Checked == true)
                {
                    chk1 = br_a + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all1 = txtQuantity.Text + " Catron";

                }
                else
                {
                    chk1 = br_a;
                    all1 = "null";
                }


                if (chkBRANDb.Checked == true)
                {
                    chk2 = br_b + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all2 = txtQuantity.Text + " Catron";
                }
                else
                {
                    chk2 = br_b;
                    all2 = "null";
                }

                if (chkBRANDc.Checked == true)
                {
                    chk3 = br_c + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all3 = txtQuantity.Text + " Catron";
                }
                else
                {
                    chk3 = br_c;
                    all3= "null";
                }


                if (chkBRANDd.Checked == true)
                {
                    chk4 = br_d + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all4 = txtQuantity.Text + " Catron";
                }
                else
                {
                    chk4 = br_d;
                    all4 = "null";
                }

                if (chkBRANDe.Checked == true)
                {
                    chk5 = br_e + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all5 = txtQuantity.Text + " Catron";
                }

                else
                {
                    chk5 = br_e;
                    all5 = "null";
                }

                if (chkBRANDf.Checked == true)
                {
                    chk6 = br_f + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all6 = txtQuantity.Text + " Catron";
                }
                else
                {
                    chk6 = br_f;
                    all6 = "null";
                }


                if (chkBRANDg.Checked == true)
                {
                    chk7 = br_g + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all7 = txtQuantity.Text + " Catron";
                }


                else
                {
                    chk7 = br_g;
                    all7 = "null";
                }


                if (chkBRANDh.Checked == true)
                {
                   
                    chk8 = br_h + Convert.ToInt32(txtQuantity.Text) * 9000;
                    all8 = txtQuantity.Text + " Catron";
                }

                else
                {
                    chk8 = br_h;

                    all8 = "null";
                }
                      

                obj.transact("update tbl_drinkAdd set BRAND_A= ( '" + chk1 + "' ), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'), BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'), BRAND_H=('" + chk8 + "'),dateOf_LastAdded=('" + Convert.ToDateTime(dateTimePicker1.Text) + "')", ("insert into tbl_DrinkEntries values('" + all1 + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" +all6 + "','" + all7 + "','" + all8 + "','insert','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));

                MessageBox.Show(txtQuantity.Text + " Carton" + " Has Been Added to Stock", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtQuantity.Text = "";
                chkBRANDa.Checked = false;
                chkBRANDb.Checked = false;
                chkBRANDc.Checked = false;
                chkBRANDd.Checked = false;
                chkBRANDe.Checked = false;
                chkBRANDf.Checked = false;
                chkBRANDg.Checked = false;
                chkBRANDh.Checked = false;

	}

                else
                {
                    MessageBox.Show("Enter Brand Name First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
  
            }
    
            
            else
            {
                MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
    //        dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");
            
            // below is the code copied from form load, this code is for putting updated values in the labels
            dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");
            DataTable dtt = obj.show("select *from tbl_drinkAdd");
            int a = Convert.ToInt32(dtt.Rows[0][0].ToString());  // database ki har value ko ek ek variable m rakhva liya
            int b = Convert.ToInt32(dtt.Rows[0][1].ToString());
            int c = Convert.ToInt32(dtt.Rows[0][2].ToString());
            int d = Convert.ToInt32(dtt.Rows[0][3].ToString());
            int z = Convert.ToInt32(dtt.Rows[0][4].ToString());
            int f = Convert.ToInt32(dtt.Rows[0][5].ToString());
            int g = Convert.ToInt32(dtt.Rows[0][6].ToString());
            int h = Convert.ToInt32(dtt.Rows[0][7].ToString());
            lblMLa.Text = Convert.ToString(a) + " ML"+"s";
            lblMLb.Text = Convert.ToString(b) + " ML"+"s";
            lblMLc.Text = Convert.ToString(c) + " ML"+"s";
            lblMLd.Text = Convert.ToString(d) + " ML"+"s";
            lblMLe.Text = Convert.ToString(z) + " ML"+"s";
            lblMLf.Text = Convert.ToString(f) + " ML"+"s";
            lblMLg.Text = Convert.ToString(g) + " ML"+"s";
            lblMLh.Text = Convert.ToString(h) + " ML"+"s";

            int ans1 = a / 750;  // is se bottles calculate hogi
            int ans2 = b / 750;
            int ans3 = c / 750;
            int ans4 = d / 750;
            int ans5 = z / 750;
            int ans6 = f / 750;
            int ans7 = g / 750;
            int ans8 = h / 750;



            lblA.Text = Convert.ToString(ans1 + " Bottles of Brand A");
            lblB.Text = Convert.ToString(ans2 + " Bottles of Brand B");
            lblC.Text = Convert.ToString(ans3 + " Bottles of Brand C");
            lblD.Text = Convert.ToString(ans4 + " Bottles of Brand D");
            lblE.Text = Convert.ToString(ans5 + " Bottles of Brand E");
            lblF.Text = Convert.ToString(ans6 + " Bottles of Brand F");
            lblG.Text = Convert.ToString(ans7 + " Bottles of Brand G");
            lblH.Text = Convert.ToString(ans8 + " Bottles of Brand H");


            // below is the code for converting to carton

            double Aans1 = Convert.ToDouble(a) / 750 / 12;
            int Aans2 = (int)Aans1;                  // Aans2 is the value of catron

            double Aans3 = Aans1 - (int)Aans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Aans3 > 0.1)                         // aans3 is the value of bottles 
            {
                s1 = Convert.ToString(Aans3).Substring(1, 2); // is se humne wo zero hata di
                // is wale is else ka fayda ye hai ki ye values kabhi minus m nahi jayegi
            }
            else

                s1 = "0"; // is se humne wo zero hata di


            lblCartonA.Text = Convert.ToString(Aans2) + " Carton of Brand A" + " and " + Convert.ToString(s1) + " Bottles";











            // code below is for second label   
            double Bans1 = Convert.ToDouble(b) / 750 / 12;
            int Bans2 = (int)Bans1;

            double Bans3 = Bans1 - (int)Bans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Bans3 > 0.1)
            {
                s2 = Convert.ToString(Bans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s2 = "0";


            lblcartonB.Text = Convert.ToString(Bans2) + " Carton of Brand B" + " and " + Convert.ToString(s2) + " Bottles";






            // code below is for third label


            double Cans1 = Convert.ToDouble(c) / 750 / 12;
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
            double Dans1 = Convert.ToDouble(d) / 750 / 12;
            int Dans2 = (int)Dans1;

            double Dans3 = Dans1 - (int)Dans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Dans3 > 0.1)
            {
                s4 = Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s4 = "0";


            lblCartonD.Text = Convert.ToString(Dans2) + " Carton of Brand D" + " and " + Convert.ToString(s4) + " Bottles";


            // code below is for fifth label

            double Eans1 = Convert.ToDouble(z) / 750 / 12;
            int Eans2 = (int)Eans1;

            double Eans3 = Eans1 - (int)Eans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Eans3 > 0.1)
            {
                s5 = Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s5 = "0";


            lblCartonE.Text = Convert.ToString(Eans2) + " Carton of Brand E" + " and " + Convert.ToString(s5) + " Bottles";








            // code below is for sixth label

            double Fans1 = Convert.ToDouble(f) / 750 / 12;
            int Fans2 = (int)Fans1;

            double Fans3 = Fans1 - (int)Fans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Fans3 > 0.1)
            {
                s6 = Convert.ToString(Fans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s6 = "0";

            lblCartonF.Text = Convert.ToString(Fans2) + " Carton of Brand F" + " and " + Convert.ToString(s6) + " Bottles";





            // code below is for seventh label

            double Gans1 = Convert.ToDouble(g) / 750 / 12;  // ML se carton m convert karne k bad jo value aayegi wo decimal m aayegi and we dont want that
            //string Gans2 = Convert.ToString(Gans1).Substring(1, 2);  // is se ml se carton m badal jayega par ye ek decimal m number dega hum chahte hai ki cartons k sath sath ye bhi dikhaye ki kitni     bottle padi hai like (7 cartons and 2 bottles)

            int Gans2 = (int)Gans1;

            double Gans3 = Gans1 - (int)Gans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Gans3 > 0.1)
            {
                s7 = Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s7 = "0";


            lblCartonG.Text = Convert.ToString(Gans2) + " Carton of Brand G" + " and " + Convert.ToString(s7) + " Bottles";




            // code below is for eighth label

            double Hans1 = Convert.ToDouble(h) / 750 / 12;
            int Hans2 = (int)Hans1;

            double Hans3 = Hans1 - (int)Hans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Hans3 > 0.1)
            {
                s8 = Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s8 = "0";


            lblCartonH.Text = Convert.ToString(Hans2) + " Carton of Brand H" + " and " + Convert.ToString(s8) + " Bottles";

            checkBox1.Checked = false;



            //lblCartonC.Text = Convert.ToString( subnum);
            //double pi = 3.1415926;           // This is your number
            //double subnum = pi - (int)pi;   // Subtract it from the whole number

        }

        private void btnBottle_Click(object sender, EventArgs e)
        {
            if (chkBRANDa.Checked == true || chkBRANDb.Checked == true || chkBRANDc.Checked == true || chkBRANDd.Checked == true || chkBRANDe.Checked == true || chkBRANDf.Checked == true || chkBRANDg.Checked == true || chkBRANDh.Checked == true)
            {
                if (txtQuantity.Text != "")
                {
                    DataTable dt = obj.show("select *from tbl_drinkAdd ");
                    int br_a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int br_b = Convert.ToInt32(dt.Rows[0][1].ToString());
                    int br_c = Convert.ToInt32(dt.Rows[0][2].ToString());
                    int br_d = Convert.ToInt32(dt.Rows[0][3].ToString());
                    int br_e = Convert.ToInt32(dt.Rows[0][4].ToString());
                    int br_f = Convert.ToInt32(dt.Rows[0][5].ToString());
                    int br_g = Convert.ToInt32(dt.Rows[0][6].ToString());
                    int br_h = Convert.ToInt32(dt.Rows[0][7].ToString());

                    if (chkBRANDa.Checked == true)
                    {
                        chk1 = br_a + Convert.ToInt32(txtQuantity.Text) * 750;
                        all1 = txtQuantity.Text + " Bottle";

                    }
                    else
                    {
                        chk1 = br_a;
                        all1 = "null";

                    }


                    if (chkBRANDb.Checked == true)
                    {
                        chk2 = br_b + Convert.ToInt32(txtQuantity.Text) * 750;
                        all2 = txtQuantity.Text + " Bottle";
                    }
                    else
                    {
                        chk2 = br_b;
                        all2 = "null";
                    }

                    if (chkBRANDc.Checked == true)
                    {
                        chk3 = br_c + Convert.ToInt32(txtQuantity.Text) * 750;
                        all3 = txtQuantity.Text + " Bottle";
                    }
                    else
                    {
                        chk3 = br_c;
                        all3 = "null";
                    }


                    if (chkBRANDd.Checked == true)
                    {
                        chk4 = br_d + Convert.ToInt32(txtQuantity.Text) * 750;
                        all4 = txtQuantity.Text + " Bottle";
                    }
                    else
                    {
                        chk4 = br_d;
                        all4 = "null";
                    }

                    if (chkBRANDe.Checked == true)
                    {
                        chk5 = br_e + Convert.ToInt32(txtQuantity.Text) * 750;
                        all5 = txtQuantity.Text + " Bottle";
                    }

                    else
                    {
                        chk5 = br_e;
                        all5 = "null";
                    }

                    if (chkBRANDf.Checked == true)
                    {
                        chk6 = br_f + Convert.ToInt32(txtQuantity.Text) * 750;
                        all6 = txtQuantity.Text + " Bottle";
                    }
                    else
                    {
                        chk6 = br_f;
                        all6 = "null";
                    }


                    if (chkBRANDg.Checked == true)
                    {
                        chk7 = br_g + Convert.ToInt32(txtQuantity.Text) * 750;
                        all7 = txtQuantity.Text + " Bottle";
                    }


                    else
                    {
                        chk7 = br_g;
                        all7 = "null";
                    }


                    if (chkBRANDh.Checked == true)
                    {
                        chk8 = br_h + Convert.ToInt32(txtQuantity.Text) * 750;
                        all8 = txtQuantity.Text + " Bottle";
                    }

                    else
                    {
                        chk8 = br_h;
                        all8 = "null";
                    }


                    obj.transact("update tbl_drinkAdd set BRAND_A= ( '" + chk1 + "' ), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'), BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'), BRAND_H=('" + chk8 + "'),dateOf_LastAdded=('" + Convert.ToDateTime(dateTimePicker1.Text) + "')", ("insert into tbl_DrinkEntries values('" + all1 + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" + all6 + "','" + all7 + "','" + all8 + "','insert','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));


                    if (Convert.ToInt32(txtQuantity.Text) > 1)
                    {
                        MessageBox.Show(txtQuantity.Text + " Bottles" + " Has Been Added to Stock", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(txtQuantity.Text + " Bottle" + " Has Been Added to Stock", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }// bottle or bottles 

                    txtQuantity.Text = "";
                    chkBRANDa.Checked = false;
                    chkBRANDb.Checked = false;
                    chkBRANDc.Checked = false;
                    chkBRANDd.Checked = false;
                    chkBRANDe.Checked = false;
                    chkBRANDf.Checked = false;
                    chkBRANDg.Checked = false;
                    chkBRANDh.Checked = false;
                    checkBox1.Checked = false;

                }
                else
                {
                    MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");



            }
            else
            {

                MessageBox.Show(" Select Brand Name First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            // above code is for updating below one is for showing results of that update
            DataTable dtt = obj.show("select *from tbl_drinkAdd");
            int a = Convert.ToInt32(dtt.Rows[0][0].ToString());  // database ki har value ko ek ek variable m rakhva liya
            int b = Convert.ToInt32(dtt.Rows[0][1].ToString());
            int c = Convert.ToInt32(dtt.Rows[0][2].ToString());
            int d = Convert.ToInt32(dtt.Rows[0][3].ToString());
            int z = Convert.ToInt32(dtt.Rows[0][4].ToString());
            int f = Convert.ToInt32(dtt.Rows[0][5].ToString());
            int g = Convert.ToInt32(dtt.Rows[0][6].ToString());
            int h = Convert.ToInt32(dtt.Rows[0][7].ToString());
            lblMLa.Text = Convert.ToString(a) + " ML"+"s";
            lblMLb.Text = Convert.ToString(b) + " ML"+"s";
            lblMLc.Text = Convert.ToString(c) + " ML"+"s";
            lblMLd.Text = Convert.ToString(d) + " ML"+"s";
            lblMLe.Text = Convert.ToString(z) + " ML"+"s";
            lblMLf.Text = Convert.ToString(f) + " ML"+"s";
            lblMLg.Text = Convert.ToString(g) + " ML"+"s";
            lblMLh.Text = Convert.ToString(h) + " ML"+"s";




            int ans1 = a / 750;  // is se bottles calculate hogi
            int ans2 = b / 750;
            int ans3 = c / 750;
            int ans4 = d / 750;
            int ans5 = z / 750;
            int ans6 = f / 750;
            int ans7 = g / 750;
            int ans8 = h / 750;
 

            lblA.Text = Convert.ToString(ans1 + " Bottles of Brand A");
            lblB.Text = Convert.ToString(ans2 + " Bottles of Brand B");
            lblC.Text = Convert.ToString(ans3 + " Bottles of Brand C");
            lblD.Text = Convert.ToString(ans4 + " Bottles of Brand D");
            lblE.Text = Convert.ToString(ans5 + " Bottles of Brand E");
            lblF.Text = Convert.ToString(ans6 + " Bottles of Brand F");
            lblG.Text = Convert.ToString(ans7 + " Bottles of Brand G");
            lblH.Text = Convert.ToString(ans8 + " Bottles of Brand H");




            double Aans1 = Convert.ToDouble(a) / 750 / 12;
            int Aans2 = (int)Aans1;  // Aans2 is the value of catron

            double Aans3 = Aans1 - (int)Aans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Aans3 > 0.1) // aans3 is the value of bottles 
            {
                s1 = Convert.ToString(Aans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s1 = "0"; 


            lblCartonA.Text = Convert.ToString(Aans2) + " Carton of Brand A" + " and " + Convert.ToString(s1) + " Bottles";



             



            // code below is for second label   
            double Bans1 = Convert.ToDouble(b) / 750 / 12;
            int Bans2 = (int)Bans1;

            double Bans3 = Bans1 - (int)Bans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Bans3 > 0.1)
            {
                s2 = Convert.ToString(Bans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s2 = "0"; 


            lblcartonB.Text = Convert.ToString(Bans2) + " Carton of Brand B" + " and " + Convert.ToString(s2) + " Bottles";






            // code below is for third label


            double Cans1 = Convert.ToDouble(c) / 750 / 12;
            int Cans2 = (int)Cans1;

            double Cans3 = Bans1 - (int)Cans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Cans3 > 0.1)
            {
                s3 = Convert.ToString(Cans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s3 = "0"; 


            lblCartonC.Text = Convert.ToString(Cans2) + " Carton of Brand C" + " and " + Convert.ToString(s3) + " Bottles";



            // code for fourth label
            double Dans1 = Convert.ToDouble(d) / 750 / 12;
            int Dans2 = (int)Dans1;

            double Dans3 = Dans1 - (int)Dans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Dans3 > 0.1)
            {
                s4 = Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s4 = "0"; 


            lblCartonD.Text = Convert.ToString(Dans2) + " Carton of Brand D" + " and " + Convert.ToString(s4) + " Bottles";


            // code below is for fifth label

            double Eans1 = Convert.ToDouble(z) / 750 / 12;
            int Eans2 = (int)Eans1;

            double Eans3 = Eans1 - (int)Eans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Eans3 > 0.1)
            {
                s5 = Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s5 = "0";; // is se humne wo zero hata di


            lblCartonE.Text = Convert.ToString(Eans2) + " Carton of Brand E" + " and " + Convert.ToString(s5) + " Bottles";








            // code below is for sixth label

            double Fans1 = Convert.ToDouble(f) / 750 / 12;
            int Fans2 = (int)Fans1;

            double Fans3 = Fans1 - (int)Fans1;        // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Fans3 > 0.1)
            {
                s6 = Convert.ToString(Fans3).Substring(1, 2);  // is se humne wo zero hata di

            }
            else

                s6 = "0"; 

            lblCartonF.Text = Convert.ToString(Fans2) + " Carton of Brand F" + " and " + Convert.ToString(s6) + " Bottles";





            // code below is for seventh label

            double Gans1 = Convert.ToDouble(g) / 750 / 12;  // ML se carton m convert karne k bad jo value aayegi wo decimal m aayegi and we dont want that
            //string Gans2 = Convert.ToString(Gans1).Substring(1, 2);  // is se ml se carton m badal jayega par ye ek decimal m number dega hum chahte hai ki cartons k sath sath ye bhi dikhaye ki kitni     bottle padi hai like (7 cartons and 2 bottles)

            int Gans2 = (int)Gans1;

            double Gans3 = Gans1 - (int)Gans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Gans3 > 0.1)
            {
                s7 = Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s7 = "0";  // is se humne wo zero hata di


            lblCartonG.Text = Convert.ToString(Gans2) + " Carton of Brand G" + " and " + Convert.ToString(s7) + " Bottles";




            // code below is for eighth label

            double Hans1 = Convert.ToDouble(h) / 750 / 12;
            int Hans2 = (int)Hans1;

            double Hans3 = Hans1 - (int)Hans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Hans3 > 0.1)
            {
                s8 = Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s8 = "0"; 

            lblCartonH.Text = Convert.ToString(Hans2) + " Carton of Brand H" + " and " + Convert.ToString(s8) + " Bottles";


             


            //lblCartonC.Text = Convert.ToString( subnum);
            //double pi = 3.1415926;           // This is your number
            //double subnum = pi - (int)pi;   // Subtract it from the whole number

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

        private void drinkAdd_Load(object sender, EventArgs e)
        {
            


            DataTable dtt = obj.show("select *from tbl_drinkAdd");
            int a = Convert.ToInt32(dtt.Rows[0][0].ToString());  // database ki har value ko ek ek variable m rakhva liya
            int b = Convert.ToInt32(dtt.Rows[0][1].ToString());
            int c = Convert.ToInt32(dtt.Rows[0][2].ToString());
            int d = Convert.ToInt32(dtt.Rows[0][3].ToString());
            int z = Convert.ToInt32(dtt.Rows[0][4].ToString());
            int f = Convert.ToInt32(dtt.Rows[0][5].ToString());
            int g = Convert.ToInt32(dtt.Rows[0][6].ToString());
            int h = Convert.ToInt32(dtt.Rows[0][7].ToString());
            lblMLa.Text = Convert.ToString(a) + " ML"+"s";
            lblMLb.Text = Convert.ToString(b) + " ML"+"s";
            lblMLc.Text = Convert.ToString(c) + " ML"+"s";
            lblMLd.Text = Convert.ToString(d) + " ML"+"s";
            lblMLe.Text = Convert.ToString(z) + " ML"+"s";
            lblMLf.Text = Convert.ToString(f) + " ML"+"s";
            lblMLg.Text = Convert.ToString(g) + " ML"+"s";
            lblMLh.Text = Convert.ToString(h) + " ML"+"s";




            int ans1 = a / 750;  // is se bottles calculate hogi
            int ans2 = b / 750;
            int ans3 = c / 750;
            int ans4 = d / 750;
            int ans5 = z / 750;
            int ans6 = f / 750;
            int ans7 = g / 750;
            int ans8 = h / 750;


            lblA.Text = Convert.ToString(ans1 + " Bottles of Brand A");
            lblB.Text = Convert.ToString(ans2 + " Bottles of Brand B");
            lblC.Text = Convert.ToString(ans3 + " Bottles of Brand C");
            lblD.Text = Convert.ToString(ans4 + " Bottles of Brand D");
            lblE.Text = Convert.ToString(ans5 + " Bottles of Brand E");
            lblF.Text = Convert.ToString(ans6 + " Bottles of Brand F");
            lblG.Text = Convert.ToString(ans7 + " Bottles of Brand G");
            lblH.Text = Convert.ToString(ans8 + " Bottles of Brand H");




            double Aans1 = Convert.ToDouble(a) / 750 / 12;
            int Aans2 = (int)Aans1;  // Aans2 is the value of catron

            double Aans3 = Aans1 - (int)Aans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Aans3 > 0.1) // aans3 is the value of bottles 
            {
                s1 = Convert.ToString(Aans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s1 = "0";


            lblCartonA.Text = Convert.ToString(Aans2) + " Carton of Brand A" + " and " + Convert.ToString(s1) + " Bottles";







            // code below is for second label   
            double Bans1 = Convert.ToDouble(b) / 750 / 12;
            int Bans2 = (int)Bans1;

            double Bans3 = Bans1 - (int)Bans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Bans3 > 0.1)
            {
                s2 = Convert.ToString(Bans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s2 = "0";


            lblcartonB.Text = Convert.ToString(Bans2) + " Carton of Brand B" + " and " + Convert.ToString(s2) + " Bottles";






            // code below is for third label


            double Cans1 = Convert.ToDouble(c) / 750 / 12;
            int Cans2 = (int)Cans1;

            double Cans3 = Bans1 - (int)Cans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Cans3 > 0.1)
            {
                s3 = Convert.ToString(Cans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s3 = "0";


            lblCartonC.Text = Convert.ToString(Cans2) + " Carton of Brand C" + " and " + Convert.ToString(s3) + " Bottles";



            // code for fourth label
            double Dans1 = Convert.ToDouble(d) / 750 / 12;
            int Dans2 = (int)Dans1;

            double Dans3 = Dans1 - (int)Dans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Dans3 > 0.1)
            {
                s4 = Convert.ToString(Dans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s4 = "0";


            lblCartonD.Text = Convert.ToString(Dans2) + " Carton of Brand D" + " and " + Convert.ToString(s4) + " Bottles";


            // code below is for fifth label

            double Eans1 = Convert.ToDouble(z) / 750 / 12;
            int Eans2 = (int)Eans1;

            double Eans3 = Eans1 - (int)Eans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Eans3 > 0.1)
            {
                s5 = Convert.ToString(Eans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s5 = "0"; ; // is se humne wo zero hata di


            lblCartonE.Text = Convert.ToString(Eans2) + " Carton of Brand E" + " and " + Convert.ToString(s5) + " Bottles";








            // code below is for sixth label

            double Fans1 = Convert.ToDouble(f) / 750 / 12;
            int Fans2 = (int)Fans1;

            double Fans3 = Fans1 - (int)Fans1;        // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Fans3 > 0.1)
            {
                s6 = Convert.ToString(Fans3).Substring(1, 2);  // is se humne wo zero hata di

            }
            else

                s6 = "0";

            lblCartonF.Text = Convert.ToString(Fans2) + " Carton of Brand F" + " and " + Convert.ToString(s6) + " Bottles";





            // code below is for seventh label

            double Gans1 = Convert.ToDouble(g) / 750 / 12;  // ML se carton m convert karne k bad jo value aayegi wo decimal m aayegi and we dont want that
            //string Gans2 = Convert.ToString(Gans1).Substring(1, 2);  // is se ml se carton m badal jayega par ye ek decimal m number dega hum chahte hai ki cartons k sath sath ye bhi dikhaye ki kitni     bottle padi hai like (7 cartons and 2 bottles)

            int Gans2 = (int)Gans1;

            double Gans3 = Gans1 - (int)Gans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Gans3 > 0.1)
            {
                s7 = Convert.ToString(Gans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s7 = "0";  // is se humne wo zero hata di


            lblCartonG.Text = Convert.ToString(Gans2) + " Carton of Brand G" + " and " + Convert.ToString(s7) + " Bottles";




            // code below is for eighth label

            double Hans1 = Convert.ToDouble(h) / 750 / 12;
            int Hans2 = (int)Hans1;

            double Hans3 = Hans1 - (int)Hans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Hans3 > 0.1)
            {
                s8 = Convert.ToString(Hans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s8 = "0";

            lblCartonH.Text = Convert.ToString(Hans2) + " Carton of Brand H" + " and " + Convert.ToString(s8) + " Bottles";


            //lblCartonC.Text = Convert.ToString( subnum);
            //double pi = 3.1415926;           // This is your number
            //double subnum = pi - (int)pi;   // Subtract it from the whole number

        }

        private void btnMLs_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                if (chkBRANDa.Checked == true || chkBRANDb.Checked == true || chkBRANDc.Checked == true || chkBRANDd.Checked == true || chkBRANDe.Checked == true || chkBRANDf.Checked == true || chkBRANDg.Checked == true || chkBRANDh.Checked == true)
                {
                    DataTable dt = obj.show("select *from tbl_drinkAdd ");
                    int br_a = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int br_b = Convert.ToInt32(dt.Rows[0][1].ToString());
                    int br_c = Convert.ToInt32(dt.Rows[0][2].ToString());
                    int br_d = Convert.ToInt32(dt.Rows[0][3].ToString());
                    int br_e = Convert.ToInt32(dt.Rows[0][4].ToString());
                    int br_f = Convert.ToInt32(dt.Rows[0][5].ToString());
                    int br_g = Convert.ToInt32(dt.Rows[0][6].ToString());
                    int br_h = Convert.ToInt32(dt.Rows[0][7].ToString());
                    if (chkBRANDa.Checked == true)
                    {
                        chk1 = br_a + Convert.ToInt32(txtQuantity.Text);
                        all1 = txtQuantity.Text + " ML"+"s";
                    }
                    else
                    {
                        chk1 = br_a;
                        all1 = "null";

                    }


                    if (chkBRANDb.Checked == true)
                    {
                        chk2 = br_b + Convert.ToInt32(txtQuantity.Text);
                        all2 = txtQuantity.Text + " ML"+"s";

                    }
                    else
                    {
                        chk2 = br_b;
                        all2 = "null";
                    }

                    if (chkBRANDc.Checked == true)
                    {
                        chk3 = br_c + Convert.ToInt32(txtQuantity.Text);
                        all3 = txtQuantity.Text + " ML"+"s";

                    }
                    else
                    {
                        chk3 = br_c;
                        all3 = "null";
                    }


                    if (chkBRANDd.Checked == true)
                    {
                        chk4 = br_d + Convert.ToInt32(txtQuantity.Text);
                        all4 = txtQuantity.Text + " ML"+"s";

                    }
                    else
                    {
                        chk4 = br_d;
                        all4 = "null";
                    }

                    if (chkBRANDe.Checked == true)
                    {
                        chk5 = br_e + Convert.ToInt32(txtQuantity.Text);
                        all5 = txtQuantity.Text + " ML"+"s";

                    }

                    else
                    {
                        chk5 = br_e;
                        all5 = "null";
                    }

                    if (chkBRANDf.Checked == true)
                    {
                        chk6 = br_f + Convert.ToInt32(txtQuantity.Text);
                        all6 = txtQuantity.Text + " ML"+"s";

                    }
                    else
                    {
                        chk6 = br_f;
                        all6 = "null";
                    }


                    if (chkBRANDg.Checked == true)
                    {
                        chk7 = br_g + Convert.ToInt32(txtQuantity.Text);
                        all7 = txtQuantity.Text + " ML"+"s";

                    }


                    else
                    {
                        chk7 = br_g;
                        all7 = "null";
                    }


                    if (chkBRANDh.Checked == true)
                    {
                        chk8 = br_h + Convert.ToInt32(txtQuantity.Text);
                        all8 = txtQuantity.Text + " ML"+"s";

                    }

                    else
                    {
                        chk8 = br_h;
                        all8 = "null";
                    }








                    obj.transact("update tbl_drinkAdd set BRAND_A= ( '" + chk1 + "' ), BRAND_B=('" + chk2 + "'),BRAND_C=('" + chk3 + "'),BRAND_D=('" + chk4 + "'),BRAND_E=('" + chk5 + "'), BRAND_F=('" + chk6 + "'),BRAND_G=('" + chk7 + "'), BRAND_H=('" + chk8 + "'),dateOf_LastAdded=('" + Convert.ToDateTime(dateTimePicker1.Text) + "')", ("insert into tbl_DrinkEntries values('" + all1 + "','" + all2 + "','" + all3 + "','" + all4 + "','" + all5 + "','" + all6 + "','" + all7 + "','" + all8 + "','insert','" + Convert.ToDateTime(dateTimePicker1.Text) + "')"));

                    MessageBox.Show(txtQuantity.Text + " MilliLitres" + " Has Been Added to Stock", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtQuantity.Text = "";
                    chkBRANDa.Checked = false;
                    chkBRANDb.Checked = false;
                    chkBRANDc.Checked = false;
                    chkBRANDd.Checked = false;
                    chkBRANDe.Checked = false;
                    chkBRANDf.Checked = false;
                    chkBRANDg.Checked = false;
                    chkBRANDh.Checked = false;
                }
                else
                {
                    MessageBox.Show("Enter Brand Name First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
  
            }
            else
            {
                MessageBox.Show("Enter Quantity First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            dataGridView1.DataSource = obj.show("select *from tbl_drinkAdd");

            DataTable dtt = obj.show("select *from tbl_drinkAdd");
            int a = Convert.ToInt32(dtt.Rows[0][0].ToString());  // database ki har value ko ek ek variable m rakhva liya
            int b = Convert.ToInt32(dtt.Rows[0][1].ToString());
            int c = Convert.ToInt32(dtt.Rows[0][2].ToString());
            int d = Convert.ToInt32(dtt.Rows[0][3].ToString());
            int z = Convert.ToInt32(dtt.Rows[0][4].ToString());
            int f = Convert.ToInt32(dtt.Rows[0][5].ToString());
            int g = Convert.ToInt32(dtt.Rows[0][6].ToString());
            int h = Convert.ToInt32(dtt.Rows[0][7].ToString());
            lblMLa.Text = Convert.ToString(a) + " ML"+"s";
            lblMLb.Text = Convert.ToString(b) + " ML"+"s";
            lblMLc.Text = Convert.ToString(c) + " ML"+"s";
            lblMLd.Text = Convert.ToString(d) + " ML"+"s";
            lblMLe.Text = Convert.ToString(z) + " ML"+"s";
            lblMLf.Text = Convert.ToString(f) + " ML"+"s";
            lblMLg.Text = Convert.ToString(g) + " ML"+"s";
            lblMLh.Text = Convert.ToString(h) + " ML"+"s";

            int ans1 = a / 750;  // is se bottles calculate hogi
            int ans2 = b / 750;
            int ans3 = c / 750;
            int ans4 = d / 750;
            int ans5 = z / 750;
            int ans6 = f / 750;
            int ans7 = g / 750;
            int ans8 = h / 750;



            lblA.Text = Convert.ToString(ans1 + " Bottles of Brand A");
            lblB.Text = Convert.ToString(ans2 + " Bottles of Brand B");
            lblC.Text = Convert.ToString(ans3 + " Bottles of Brand C");
            lblD.Text = Convert.ToString(ans4 + " Bottles of Brand D");
            lblE.Text = Convert.ToString(ans5 + " Bottles of Brand E");
            lblF.Text = Convert.ToString(ans6 + " Bottles of Brand F");
            lblG.Text = Convert.ToString(ans7 + " Bottles of Brand G");
            lblH.Text = Convert.ToString(ans8 + " Bottles of Brand H");


            double Aans1 = Convert.ToDouble(a) / 750 / 12;
            int Aans2 = (int)Aans1;  // Aans2 is the value of catron

            double Aans3 = Aans1 - (int)Aans1;       // is se sirf decimal wali digits aa jayegi par ek zero bhi aayegi sabse pehle

            if (Aans3 > 0.1) // aans3 is the value of bottles 
            {
                s1 = Convert.ToString(Aans3).Substring(1, 2); // is se humne wo zero hata di

            }
            else

                s1 =  "0";  // is se humne wo zero hata di


            lblCartonA.Text = Convert.ToString(Aans2) + " Carton of Brand A" + " and " + Convert.ToString(s1) + " Bottles";











            // code below is for second label   
            double Bans1 = Convert.ToDouble(b) / 750 / 12;
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


            double Cans1 = Convert.ToDouble(c) / 750 / 12;
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
            double Dans1 = Convert.ToDouble(d) / 750 / 12;
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

            double Eans1 = Convert.ToDouble(z) / 750 / 12;
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

            double Fans1 = Convert.ToDouble(f) / 750 / 12;
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

            double Gans1 = Convert.ToDouble(g) / 750 / 12;  // ML se carton m convert karne k bad jo value aayegi wo decimal m aayegi and we dont want that
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

            double Hans1 = Convert.ToDouble(h) / 750 / 12;
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



            //lblCartonC.Text = Convert.ToString( subnum);
            //double pi = 3.1415926;           // This is your number
            //double subnum = pi - (int)pi;   // Subtract it from the whole number

        }

        private void label2_Click(object sender, EventArgs e)
        {
            drinkAdd d = new drinkAdd();
            d.Show();
            this.Hide();
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

        private void lblcartonB_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            drinkSell d = new drinkSell();
            d.Show();
            this.Hide();
        }

        private void chkBRANDa_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDa.ForeColor = Color.White;
        }

        private void chkBRANDa_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDa.ForeColor = Color.Black;
        }

        private void chkBRANDb_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDb.ForeColor = Color.White;
        }

        private void chkBRANDb_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDb.ForeColor = Color.Black;
        }

        private void chkBRANDc_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDc.ForeColor = Color.White;
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

        private void chkBRANDf_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDf.ForeColor = Color.Black;
        }

        private void chkBRANDf_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDf.ForeColor = Color.White;
        }

        private void chkBRANDg_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDg.ForeColor = Color.Black;
        }

        private void chkBRANDg_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDg.ForeColor = Color.White;
        }

        private void chkBRANDh_MouseEnter(object sender, EventArgs e)
        {
            chkBRANDh.ForeColor = Color.White;
        }

        private void chkBRANDh_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDh.ForeColor = Color.Black;
        }

        private void chkBRANDc_MouseLeave(object sender, EventArgs e)
        {
            chkBRANDc.ForeColor = Color.Black;
        
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.Black;
        
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            checkBox1.ForeColor = Color.White;
           
        
        }
    }
}
