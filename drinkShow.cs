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
    public partial class drinkShow : Form
    {
        
        DataTable dt;
        Class1 obj = new Class1();
        string get;
        public drinkShow()
        {
            InitializeComponent();
        }
         
        private void drinkShow_Load(object sender, EventArgs e)
        {

           get= Class1.usr;
           
           
            
            
            if (get=="salebydate")
           {
               lblAddedToday.Visible = false;
               lblAddedByDate.Visible = false;
               lblAddedStock.Visible = false;
              // lblSaleByDate.Visible = false;
               lblTodaySale.Visible = false;
           
                lblAllSale.Visible = false;
               lblMsg.Text = "";
               dt = obj.show("select BRAND_A from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_A");
               if (dt.Rows.Count == 0)
               {
                   // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_A");
                   DGV_brA.DataSource = "";
               }

               else
               {
                   DGV_brA.DataSource = dt;
               }



               dt = obj.show("select BRAND_B from tbl_drinkEntries where status ='sell'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_B");
               if (dt.Rows.Count == 0)
               {
                   // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_B");
                   DGV_brB.DataSource = "";
               }
               else
               {
                   DGV_brB.DataSource = dt;
               }

               dt = obj.show("select BRAND_C from tbl_drinkEntries where status ='sell'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_C");

               if (dt.Rows.Count == 0)
               {
                   //   MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_C");
                   DGV_brC.DataSource = "";
               }
               else
               {
                   DGV_brC.DataSource = dt;
               }




               dt = obj.show("select BRAND_D from tbl_drinkEntries where status ='sell'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_D");


               if (dt.Rows.Count == 0)
               {
                   //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_D");
                   DGV_brD.DataSource = "";
               }
               else
               {
                   DGV_brD.DataSource = dt;
               }


               dt = obj.show("select BRAND_E from tbl_drinkEntries where status ='sell'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_E");

               if (dt.Rows.Count == 0)
               {
                   //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text  +"of Brand_E");
                   DGV_brE.DataSource = "";
               }
               else
               {
                   DGV_brE.DataSource = dt;
               }



               dt = obj.show("select BRAND_F from tbl_drinkEntries where status ='sell'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_F");

               if (dt.Rows.Count == 0)
               {
                   // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_F");
                   DGV_brF.DataSource = "";
               }
               else
               {
                   DGV_brF.DataSource = dt;
               }

               dt = obj.show("select BRAND_G from tbl_drinkEntries where status ='sell'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_G");


               if (dt.Rows.Count == 0)
               {
                   // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_G");
                   DGV_brG.DataSource = "";
               }
               else
               {
                   DGV_brG.DataSource = dt;
               }


               dt = obj.show("select BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_H");


               if (dt.Rows.Count == 0)
               {
                   // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text+"of Brand_H");
                   DGV_brH.DataSource = "";
               }
               else
               {
                   DGV_brH.DataSource = dt;
               }


               if (DGV_brA.DataSource == "" && DGV_brB.DataSource == "" && DGV_brC.DataSource == "" && DGV_brD.DataSource == "" && DGV_brE.DataSource == "" && DGV_brF.DataSource == "" && DGV_brG.DataSource == "" && DGV_brH.DataSource == "")
               {
                   lblMsg.Text = "You Sold Nothing on " + dateTimePicker2.Text;
               }
            
           }
           else if(get=="allsale")
           {
               lblAddedToday.Visible = false;
              lblAddedByDate.Visible = false;
               lblAddedStock.Visible = false;
               lblSaleByDate.Visible = false;
               lblTodaySale.Visible = false; 
               lblMsg.Text = "";
               DGV_brA.DataSource = obj.show("select BRAND_A from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null'and BRAND_A!=''  order by BRAND_A");
               DGV_brB.DataSource = obj.show("select BRAND_B from tbl_drinkEntries where status ='sell'  and BRAND_B != 'null' and BRAND_B!='' order by BRAND_B");
               DGV_brC.DataSource = obj.show("select BRAND_C from tbl_drinkEntries where status ='sell'  and BRAND_C != 'null' and BRAND_C!='' order by BRAND_C ");
               DGV_brD.DataSource = obj.show("select BRAND_D from tbl_drinkEntries where status ='sell'  and BRAND_D != 'null' and BRAND_D!='' order by BRAND_D");
               DGV_brE.DataSource = obj.show("select BRAND_E from tbl_drinkEntries where status ='sell'  and BRAND_E != 'null' and BRAND_E!='' order by BRAND_E");
               DGV_brF.DataSource = obj.show("select BRAND_F from tbl_drinkEntries where status ='sell'  and BRAND_F != 'null' and BRAND_F!='' order by BRAND_F");
               DGV_brG.DataSource = obj.show("select BRAND_G from tbl_drinkEntries where status ='sell'  and BRAND_G != 'null' and BRAND_G!='' order by BRAND_G");
               DGV_brH.DataSource = obj.show("select BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_H != 'null' and BRAND_H!='' order by BRAND_H");

           }


            else if (get=="todaysale")
            {
                lblAddedByDate.Visible = false;
                lblAddedStock.Visible = false;
                lblSaleByDate.Visible = false;
                lblAddedToday.Visible = false;
              
                lblAllSale.Visible = false;

                lblMsg.Text = "";
                dt = obj.show("select BRAND_A from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_A");
                if (dt.Rows.Count == 0)
                {
                    // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_A");
                    DGV_brA.DataSource = "";
                }

                else
                {
                    DGV_brA.DataSource = dt;
                }



                dt = obj.show("select BRAND_B from tbl_drinkEntries where status ='sell'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_B");
                if (dt.Rows.Count == 0)
                {
                    // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_B");
                    DGV_brB.DataSource = "";
                }
                else
                {
                    DGV_brB.DataSource = dt;
                }

                dt = obj.show("select BRAND_C from tbl_drinkEntries where status ='sell'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_C");

                if (dt.Rows.Count == 0)
                {
                    //   MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_C");
                    DGV_brC.DataSource = "";
                }
                else
                {
                    DGV_brC.DataSource = dt;
                }




                dt = obj.show("select BRAND_D from tbl_drinkEntries where status ='sell'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_D");


                if (dt.Rows.Count == 0)
                {
                    //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_D");
                    DGV_brD.DataSource = "";
                }
                else
                {
                    DGV_brD.DataSource = dt;
                }


                dt = obj.show("select BRAND_E from tbl_drinkEntries where status ='sell'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_E");

                if (dt.Rows.Count == 0)
                {
                    //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text  +"of Brand_E");
                    DGV_brE.DataSource = "";
                }
                else
                {
                    DGV_brE.DataSource = dt;
                }



                dt = obj.show("select BRAND_F from tbl_drinkEntries where status ='sell'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_F");

                if (dt.Rows.Count == 0)
                {
                    // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_F");
                    DGV_brF.DataSource = "";
                }
                else
                {
                    DGV_brF.DataSource = dt;
                }

                dt = obj.show("select BRAND_G from tbl_drinkEntries where status ='sell'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_G");


                if (dt.Rows.Count == 0)
                {
                    // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_G");
                    DGV_brG.DataSource = "";
                }
                else
                {
                    DGV_brG.DataSource = dt;
                }


                dt = obj.show("select BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_H");


                if (dt.Rows.Count == 0)
                {
                    // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text+"of Brand_H");
                    DGV_brH.DataSource = "";
                }
                else
                {
                    DGV_brH.DataSource = dt;
                }


                if (DGV_brA.DataSource == "" && DGV_brB.DataSource == "" && DGV_brC.DataSource == "" && DGV_brD.DataSource == "" && DGV_brE.DataSource == "" && DGV_brF.DataSource == "" && DGV_brG.DataSource == "" && DGV_brH.DataSource == "")
                {
                    lblMsg.Text = "You Sold Nothing on " + dateTimePicker2.Text;
                }
            
            }


            else if (get=="addedbydate")
            {
                lblAddedStock.Visible = false;
                lblAllSale.Visible = false;
                lblSaleByDate.Visible = false;
                lblTodaySale.Visible = false;
                lblAddedToday.Visible = false;
               
            lblMsg.Text = "";
            dt = obj.show("select BRAND_A from tbl_drinkEntries where status ='insert'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_A");
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_A");
                DGV_brA.DataSource = "";
            }

            else
            {
                DGV_brA.DataSource = dt;
            }



            dt = obj.show("select BRAND_B from tbl_drinkEntries where status ='insert'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_B");
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_B");
                DGV_brB.DataSource = "";
            }
            else
            {
                DGV_brB.DataSource = dt;
            }

            dt = obj.show("select BRAND_C from tbl_drinkEntries where status ='insert'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_C");

            if (dt.Rows.Count == 0)
            {
                //   MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_C");
                DGV_brC.DataSource = "";
            }
            else
            {
                DGV_brC.DataSource = dt;
            }




            dt = obj.show("select BRAND_D from tbl_drinkEntries where status ='insert'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_D");


            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_D");
                DGV_brD.DataSource = "";
            }
            else
            {
                DGV_brD.DataSource = dt;
            }


            dt = obj.show("select BRAND_E from tbl_drinkEntries where status ='insert'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_E");

            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text  +"of Brand_E");
                DGV_brE.DataSource = "";
            }
            else
            {
                DGV_brE.DataSource = dt;
            }



            dt = obj.show("select BRAND_F from tbl_drinkEntries where status ='insert'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_F");

            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_F");
                DGV_brF.DataSource = "";
            }
            else
            {
                DGV_brF.DataSource = dt;
            }

            dt = obj.show("select BRAND_G from tbl_drinkEntries where status ='insert'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_G");


            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_G");
                DGV_brG.DataSource = "";
            }
            else
            {
                DGV_brG.DataSource = dt;
            }


            dt = obj.show("select BRAND_H from tbl_drinkEntries where status ='insert'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_H");


            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text+"of Brand_H");
                DGV_brH.DataSource = "";
            }
            else
            {
                DGV_brH.DataSource = dt;
            }


            if (DGV_brA.DataSource == "" && DGV_brB.DataSource == "" && DGV_brC.DataSource == "" && DGV_brD.DataSource == "" && DGV_brE.DataSource == "" && DGV_brF.DataSource == "" && DGV_brG.DataSource == "" && DGV_brH.DataSource == "")
            {
                lblMsg.Text = "You Added Nothing on " + dateTimePicker2.Text;
            }
            
            }


            else if (get=="showalladded")
            {
                lblTodaySale.Visible = false;
                lblSaleByDate.Visible = false;
                lblAllSale.Visible = false;
               // lblAddedStock.Visible =false;
                lblAddedByDate.Visible = false;
                lblAddedToday.Visible = false;
                DGV_brA.DataSource = obj.show("select BRAND_A from tbl_drinkEntries where status ='insert'  and BRAND_A != 'null'and BRAND_A!=''   order by BRAND_A");
                DGV_brB.DataSource = obj.show("select BRAND_B from tbl_drinkEntries where status ='insert'  and BRAND_B != 'null' and BRAND_B!=''   order by BRAND_A");
                DGV_brC.DataSource = obj.show("select BRAND_C from tbl_drinkEntries where status ='insert'  and BRAND_C != 'null' and BRAND_C!=''  order by BRAND_A ");
                DGV_brD.DataSource = obj.show("select BRAND_D from tbl_drinkEntries where status ='insert'  and BRAND_D != 'null' and BRAND_D!=''  order by BRAND_A");
                DGV_brE.DataSource = obj.show("select BRAND_E from tbl_drinkEntries where status ='insert'  and BRAND_E != 'null' and BRAND_E!=''   order by BRAND_A");
                DGV_brF.DataSource = obj.show("select BRAND_F from tbl_drinkEntries where status ='insert'  and BRAND_F != 'null' and BRAND_F!=''   order by BRAND_A");
                DGV_brG.DataSource = obj.show("select BRAND_G from tbl_drinkEntries where status ='insert'  and BRAND_G != 'null' and BRAND_G!=''   order by BRAND_A");
                DGV_brH.DataSource = obj.show("select BRAND_H from tbl_drinkEntries where status ='insert'  and BRAND_H != 'null' and BRAND_H!=''   order by BRAND_A");

            }







            else if (get=="addedtoday")
            {

                lblTodaySale.Visible = false;
                lblSaleByDate.Visible = false;
                lblAllSale.Visible = false;
                lblAddedStock.Visible = false;
                lblAddedByDate.Visible = false;
               
                
            lblMsg.Text = "";
            dt = obj.show("select BRAND_A from tbl_drinkEntries where status ='insert'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_A");
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_A");
                DGV_brA.DataSource = "";
            }

            else
            {
                DGV_brA.DataSource = dt;
            }



            dt = obj.show("select BRAND_B from tbl_drinkEntries where status ='insert'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_B");
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_B");
                DGV_brB.DataSource = "";
            }
            else
            {
                DGV_brB.DataSource = dt;
            }

            dt = obj.show("select BRAND_C from tbl_drinkEntries where status ='insert'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_C");

            if (dt.Rows.Count == 0)
            {
                //   MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_C");
                DGV_brC.DataSource = "";
            }
            else
            {
                DGV_brC.DataSource = dt;
            }




            dt = obj.show("select BRAND_D from tbl_drinkEntries where status ='insert'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_D");


            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_D");
                DGV_brD.DataSource = "";
            }
            else
            {
                DGV_brD.DataSource = dt;
            }


            dt = obj.show("select BRAND_E from tbl_drinkEntries where status ='insert'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_E");

            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text  +"of Brand_E");
                DGV_brE.DataSource = "";
            }
            else
            {
                DGV_brE.DataSource = dt;
            }



            dt = obj.show("select BRAND_F from tbl_drinkEntries where status ='insert'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_F");

            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_F");
                DGV_brF.DataSource = "";
            }
            else
            {
                DGV_brF.DataSource = dt;
            }

            dt = obj.show("select BRAND_G from tbl_drinkEntries where status ='insert'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_G");


            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_G");
                DGV_brG.DataSource = "";
            }
            else
            {
                DGV_brG.DataSource = dt;
            }


            dt = obj.show("select BRAND_H from tbl_drinkEntries where status ='insert'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_H");


            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text+"of Brand_H");
                DGV_brH.DataSource = "";
            }
            else
            {
                DGV_brH.DataSource = dt;
            }


            if (DGV_brA.DataSource == "" && DGV_brB.DataSource == "" && DGV_brC.DataSource == "" && DGV_brD.DataSource == "" && DGV_brE.DataSource == "" && DGV_brF.DataSource == "" && DGV_brG.DataSource == "" && DGV_brH.DataSource == "")
            {
                lblMsg.Text = "You Added Nothing on " + dateTimePicker2.Text;
            }
            
            }
            //DGV_brA.DataSource = obj.show("select BRAND_A from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brB.DataSource = obj.show("select BRAND_B from tbl_drinkEntries where status ='sell'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brC.DataSource = obj.show("select BRAND_C from tbl_drinkEntries where status ='sell'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "'order by BRAND_A ");
            //DGV_brD.DataSource = obj.show("select BRAND_D from tbl_drinkEntries where status ='sell'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brE.DataSource = obj.show("select BRAND_E from tbl_drinkEntries where status ='sell'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brF.DataSource = obj.show("select BRAND_F from tbl_drinkEntries where status ='sell'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "'order by BRAND_A");
            //DGV_brG.DataSource = obj.show("select BRAND_G from tbl_drinkEntries where status ='sell'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "'order by BRAND_A");
            //DGV_brH.DataSource = obj.show("select BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");

           
           //dt= obj.show(" select BRAND_A,BRAND_B,BRAND_C,BRAND_D,BRAND_E,BRAND_F,BRAND_G,BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null' and BRAND_B != 'null'and BRAND_C != 'null'and BRAND_D != 'null'and BRAND_E != 'null'and BRAND_F != 'null'and BRAND_G != 'null'and BRAND_H != 'null' and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A ");

             

         //dataGridView4.DataSource = obj.show("select BRAND_A,BRAND_B,BRAND_C,BRAND_D,BRAND_E,BRAND_F,BRAND_G,BRAND_H from tbl_drinkEntries where  dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A ");




             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drinkSell d = new drinkSell();
            d.Show();
            this.Hide();
        }

        private void DGV_brH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            dt = obj.show("select BRAND_A from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_A");
            if (dt.Rows.Count==0)
            {
               // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_A");
                DGV_brA.DataSource = "";
            }

            else
            {
                DGV_brA.DataSource = dt;
            }



            dt = obj.show("select BRAND_B from tbl_drinkEntries where status ='sell'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_B");
            if (dt.Rows.Count == 0)
            {
               // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_B");
                DGV_brB.DataSource = "";
            }
            else
            {
                DGV_brB.DataSource = dt;
            }

          dt = obj.show("select BRAND_C from tbl_drinkEntries where status ='sell'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_C");

          if (dt.Rows.Count == 0)
          {
           //   MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_C");
              DGV_brC.DataSource = "";
          }
          else
          {
              DGV_brC.DataSource = dt;
          }




            dt = obj.show("select BRAND_D from tbl_drinkEntries where status ='sell'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_D");


            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_D");
                DGV_brD.DataSource = "";
            }
            else
            {
                DGV_brD.DataSource = dt;
            }


            dt = obj.show("select BRAND_E from tbl_drinkEntries where status ='sell'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_E");

            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text  +"of Brand_E");
                DGV_brE.DataSource = "";
            }
            else
            {
                DGV_brE.DataSource = dt;
            }



           dt = obj.show("select BRAND_F from tbl_drinkEntries where status ='sell'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_F");

           if (dt.Rows.Count == 0)
           {
              // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_F");
               DGV_brF.DataSource = "";
           }
           else
           {
               DGV_brF.DataSource = dt;
           }

            dt = obj.show("select BRAND_G from tbl_drinkEntries where status ='sell'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_G");


            if (dt.Rows.Count == 0)
            {
               // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_G");
                DGV_brG.DataSource = "";
            }
            else
            {
                DGV_brG.DataSource = dt;
            }


            dt= obj.show("select BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_H");


            if (dt.Rows.Count == 0)
            {
               // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text+"of Brand_H");
                DGV_brH.DataSource = "";
            }
            else
            {
                DGV_brH.DataSource = dt;
            }


            if (DGV_brA.DataSource == "" && DGV_brB.DataSource == "" && DGV_brC.DataSource == "" && DGV_brD.DataSource == "" && DGV_brE.DataSource == "" && DGV_brF.DataSource == "" && DGV_brG.DataSource == "" && DGV_brH.DataSource == "")
            {
                lblMsg.Text = "You Sold Nothing on " +  dateTimePicker2.Text;
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //lblMsg.Text = "";
            //DGV_brA.DataSource = obj.show("select BRAND_A from tbl_drinkEntries where status ='sell'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brB.DataSource = obj.show("select BRAND_B from tbl_drinkEntries where status ='sell'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brC.DataSource = obj.show("select BRAND_C from tbl_drinkEntries where status ='sell'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "'order by BRAND_A ");
            //DGV_brD.DataSource = obj.show("select BRAND_D from tbl_drinkEntries where status ='sell'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brE.DataSource = obj.show("select BRAND_E from tbl_drinkEntries where status ='sell'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");
            //DGV_brF.DataSource = obj.show("select BRAND_F from tbl_drinkEntries where status ='sell'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "'order by BRAND_A");
            //DGV_brG.DataSource = obj.show("select BRAND_G from tbl_drinkEntries where status ='sell'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "'order by BRAND_A");
            //DGV_brH.DataSource = obj.show("select BRAND_H from tbl_drinkEntries where status ='sell'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker1.Text) + "' order by BRAND_A");

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            lblSaleByDate.ForeColor = System.Drawing.Color.SandyBrown ;
        }

       
        private void label13_MouseEnter(object sender, EventArgs e)
        {
            lblTodaySale.ForeColor = System.Drawing.Color.SandyBrown;
        
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            lblTodaySale.ForeColor = System.Drawing.Color.Black;
        
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            lblSaleByDate.ForeColor = System.Drawing.Color.Black;
        
        }

        private void label10_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";
     
                DGV_brA.DataSource = obj.show("select BRAND_A from tbl_drinkEntries where status ='insert'  and BRAND_A != 'null'and BRAND_A!=''   order by BRAND_A");
                DGV_brB.DataSource = obj.show("select BRAND_B from tbl_drinkEntries where status ='insert'  and BRAND_B != 'null' and BRAND_B!=''   order by BRAND_A");
                DGV_brC.DataSource = obj.show("select BRAND_C from tbl_drinkEntries where status ='insert'  and BRAND_C != 'null' and BRAND_C!=''  order by BRAND_A ");
                DGV_brD.DataSource = obj.show("select BRAND_D from tbl_drinkEntries where status ='insert'  and BRAND_D != 'null' and BRAND_D!=''  order by BRAND_A");
                DGV_brE.DataSource = obj.show("select BRAND_E from tbl_drinkEntries where status ='insert'  and BRAND_E != 'null' and BRAND_E!=''   order by BRAND_A");
                DGV_brF.DataSource = obj.show("select BRAND_F from tbl_drinkEntries where status ='insert'  and BRAND_F != 'null' and BRAND_F!=''   order by BRAND_A");
                DGV_brG.DataSource = obj.show("select BRAND_G from tbl_drinkEntries where status ='insert'  and BRAND_G != 'null' and BRAND_G!=''   order by BRAND_A");
                DGV_brH.DataSource = obj.show("select BRAND_H from tbl_drinkEntries where status ='insert'  and BRAND_H != 'null' and BRAND_H!=''   order by BRAND_A");

           
           
            
            
        }

        private void label10_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
            lblMsg.Text = "";
            dt = obj.show("select BRAND_A from tbl_drinkEntries where status ='insert'  and BRAND_A != 'null'and BRAND_A!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_A");
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_A");
                DGV_brA.DataSource = "";
            }

            else
            {
                DGV_brA.DataSource = dt;
            }



            dt = obj.show("select BRAND_B from tbl_drinkEntries where status ='insert'  and BRAND_B != 'null' and BRAND_B!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_B");
            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_B");
                DGV_brB.DataSource = "";
            }
            else
            {
                DGV_brB.DataSource = dt;
            }

            dt = obj.show("select BRAND_C from tbl_drinkEntries where status ='insert'  and BRAND_C != 'null' and BRAND_C!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_C");

            if (dt.Rows.Count == 0)
            {
                //   MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_C");
                DGV_brC.DataSource = "";
            }
            else
            {
                DGV_brC.DataSource = dt;
            }




            dt = obj.show("select BRAND_D from tbl_drinkEntries where status ='insert'  and BRAND_D != 'null' and BRAND_D!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_D");


            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_D");
                DGV_brD.DataSource = "";
            }
            else
            {
                DGV_brD.DataSource = dt;
            }


            dt = obj.show("select BRAND_E from tbl_drinkEntries where status ='insert'  and BRAND_E != 'null' and BRAND_E!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_E");

            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text  +"of Brand_E");
                DGV_brE.DataSource = "";
            }
            else
            {
                DGV_brE.DataSource = dt;
            }



            dt = obj.show("select BRAND_F from tbl_drinkEntries where status ='insert'  and BRAND_F != 'null' and BRAND_F!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_F");

            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_F");
                DGV_brF.DataSource = "";
            }
            else
            {
                DGV_brF.DataSource = dt;
            }

            dt = obj.show("select BRAND_G from tbl_drinkEntries where status ='insert'  and BRAND_G != 'null' and BRAND_G!=''  and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "'order by BRAND_G");


            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text + "of Brand_G");
                DGV_brG.DataSource = "";
            }
            else
            {
                DGV_brG.DataSource = dt;
            }


            dt = obj.show("select BRAND_H from tbl_drinkEntries where status ='insert'  and BRAND_H != 'null' and BRAND_H!='' and dateOf_LastAdded='" + Convert.ToDateTime(dateTimePicker2.Text) + "' order by BRAND_H");


            if (dt.Rows.Count == 0)
            {
                // MessageBox.Show("You have not sold anything on " + dateTimePicker2.Text+"of Brand_H");
                DGV_brH.DataSource = "";
            }
            else
            {
                DGV_brH.DataSource = dt;
            }


            if (DGV_brA.DataSource == "" && DGV_brB.DataSource == "" && DGV_brC.DataSource == "" && DGV_brD.DataSource == "" && DGV_brE.DataSource == "" && DGV_brF.DataSource == "" && DGV_brG.DataSource == "" && DGV_brH.DataSource == "")
            {
                lblMsg.Text = "You Added Nothing on " + dateTimePicker2.Text;
            }
            
        }

        private void label10_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            lblAddedStock.ForeColor = Color.SandyBrown;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            lblAddedStock.ForeColor = Color.Black;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            lblAddedByDate.ForeColor = Color.SandyBrown;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            lblAddedByDate.ForeColor = Color.Black;
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
