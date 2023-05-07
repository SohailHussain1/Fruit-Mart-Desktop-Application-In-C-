using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace fruit_mart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label52.Text = "..";
            label56.Text = "";
            label54.Text = "..";
            int appleH = 200;
            int appleL = 150;
            int applef=0;
            int applep = 0;

            int orangeH = 300;
            int orangeL = 200;
            int orangef=0;
            int orangep = 0;

            int mangoH = 150;
            int mangoL = 120;
            int mangof=0;
            int mangop = 0;

            int peachH = 250;
            int peachL = 200;
            int peachf=0;
            int peachp = 0;

            int pineappleH = 1000;
            int pineappleL = 200;
            int pineapplef = 0;
            int pineapplep = 0;

            int strawberriesH = 90;
            int strawberriesL = 60;
            int strawberriesf = 0;
            int strawberriesp = 0;

            int totalproduct = 0;
            int totalprice = 0;
            int bag = 20;
            if (!(checkBox1.Checked) && !(checkBox2.Checked) && !(checkBox3.Checked) && !(checkBox4.Checked) && !(checkBox5.Checked) && !(checkBox6.Checked))
            {
                MessageBox.Show("Please Enter the data first", "Eroor", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (comboBox1.Text == "High")
                {
                    if(comboBox2.Text == "1kg")
                    {
                        applef = appleH * 1;
                        applep = 1;
                    }
                    else if(comboBox2.Text == "3kg")
                    {
                        applef = appleH * 3;
                        applep = 3;
                    }
                    else if (comboBox2.Text == "5kg")
                    {
                        applef = appleH * 5;
                        applep = 5;
                    }
                    else { }
                   
                   
                }
                else if (comboBox1.Text == "Medium")
                {
                    if (comboBox2.Text == "1kg")
                    {
                        applef = appleL * 1;
                        applep = 1;
                    }
                    else if (comboBox2.Text == "3kg")
                    {
                        applef = appleL * 3;
                        applep = 3;
                    }
                    else if(comboBox2.Text == "5kg")
                    {
                        applef = appleL * 5;
                        applep = 5;
                    }
                    else  {}
                }
                else { }

                if (comboBox4.Text == "High")
                {
                    if (comboBox3.Text == "1kg")
                    {
                        orangef = orangeH * 1;
                        orangep = 1;
                    }
                    else if (comboBox3.Text == "3kg")
                    {
                        orangef = orangeH * 3;
                        orangep = 3;
                    }
                    else if (comboBox3.Text == "5kg")
                    {
                        orangef = orangeH * 5;
                        orangep = 5;
                    }
                    else { }
                    

                }
                else if (comboBox4.Text == "Medium")
                {
                    if (comboBox3.Text == "1kg")
                    {
                        orangef = orangeL * 1;
                        orangep = 1;
                    }
                    else if (comboBox3.Text == "3kg")
                    {
                        orangef = orangeL * 3;
                        orangep = 3;
                    }
                    else if (comboBox3.Text == "5kg")
                    {
                        orangef = orangeL * 5;
                        orangep = 5;
                    }
                    else { }

                }
                else { }

                if (comboBox8.Text == "High")
                {
                    if (comboBox7.Text == "1kg")
                    {
                        mangof = mangoH * 1;
                        mangop = 1;
                    }
                    else if (comboBox7.Text == "3kg")
                    {
                        mangof = mangoH * 3;
                        mangop = 3;
                    }
                    else if (comboBox7.Text == "5kg")
                    {
                        mangof = mangoH * 5;
                        mangop = 5;
                    }
                    else { }


                }
                else if (comboBox8.Text == "Medium")
                {
                    if (comboBox7.Text == "1kg")
                    {
                        mangof = mangoL * 1;
                        mangop = 1;
                    }
                    else if (comboBox7.Text == "3kg")
                    {
                        mangof = mangoL * 3;
                        mangop = 3;
                    }
                    else if (comboBox7.Text == "5kg")
                    {
                        mangof = mangoL * 5;
                        mangop = 5;
                    }
                    else { }
                }
                else { }

                if (comboBox6.Text == "High")
                {
                    if (comboBox5.Text == "1kg")
                    {
                        peachf = peachH * 1;
                        peachp = 1;
                    }
                    else if (comboBox5.Text == "3kg")
                    {
                        peachf = peachH * 3;
                        peachp = 3;
                    }
                    else if (comboBox5.Text == "5kg")
                    {
                        peachf = peachH * 5;
                        peachp = 5;
                    }
                    else { }


                }
                else if (comboBox6.Text == "Medium")
                {
                    if (comboBox5.Text == "1kg")
                    {
                        peachf = peachL * 1;
                        peachp = 1;
                    }
                    else if (comboBox5.Text == "3kg")
                    {
                        peachf = peachL * 3;
                        peachp = 3;
                    }
                    else if (comboBox5.Text == "5kg")
                    {
                        peachf = peachL * 5;
                        peachp = 5;
                    }
                    else { }
                }
                else { }

                if (comboBox12.Text == "High")
                {
                    if (comboBox11.Text == "1kg")
                    {
                        pineapplef = pineappleH * 1;
                        pineapplep = 1;
                    }
                    else if (comboBox11.Text == "3kg")
                    {
                        pineapplef = pineappleH * 3;
                        pineapplep = 3;
                    }
                    else if(comboBox11.Text == "5kg")
                    {
                        peachf = peachH * 5;
                        pineapplep = 5;
                    }
                    else { }


                }
                else if (comboBox12.Text == "Medium")
                {
                    if (comboBox11.Text == "1kg")
                    {
                        pineapplef = pineappleL * 1;
                        pineapplep = 1;
                    }
                    else if (comboBox11.Text == "3kg")
                    {
                        pineapplef = pineappleL * 3;
                        pineapplep = 3;
                    }
                    else if (comboBox11.Text == "5kg")
                    {
                        pineapplef = pineappleL * 5;
                        pineapplep = 5;
                    }
                    else { }
                }
                else { }

                if (comboBox10.Text == "High")
                {
                    if (comboBox9.Text == "1kg")
                    {
                        strawberriesf = strawberriesH * 1;
                        strawberriesp = 1;
                    }
                    else if (comboBox9.Text == "3kg")
                    {
                        strawberriesf = strawberriesH * 3;
                        strawberriesp = 3;
                    }
                    else if (comboBox9.Text == "5kg")
                    {
                        strawberriesf = strawberriesH * 5;
                        strawberriesp = 5;
                    }
                    else { }


                }
                else if (comboBox10.Text == "Medium")
                {
                    if (comboBox9.Text == "1kg")
                    {
                        strawberriesf = strawberriesL * 1;
                        strawberriesp = 1;
                    }
                    else if (comboBox9.Text == "3kg")
                    {
                        strawberriesf = strawberriesL * 3;
                        strawberriesp = 3;
                    }
                    else if (comboBox9.Text == "5kg")
                    {
                        strawberriesf = strawberriesL * 5;
                        strawberriesp = 5;
                    }
                    else { }
                }
                else { }


                if ((checkBox1.Checked))
                {
                    label41.Text = (applep + " kg").ToString();
                    label47.Text = (applef + " Rs").ToString();
                }
                else
                {
                    label41.Text = "Null";
                    label47.Text = "Null";
                }
                if ((checkBox2.Checked))
                {
                    label40.Text = (orangep + " kg").ToString();
                    label46.Text = (orangef + " Rs").ToString();
                }
                else
                {
                    label40.Text = "Null";
                    label46.Text = "Null";
                }
                if ((checkBox4.Checked))
                {
                    label39.Text = (mangop + " kg").ToString();
                    label45.Text = (mangof + " Rs").ToString();
                }
                else
                {
                    label39.Text = "Null";
                    label45.Text = "Null";
                }
                if ((checkBox3.Checked))
                {
                    label38.Text = (peachp + " kg").ToString();
                    label44.Text = (peachf + " Rs").ToString();
                }
                else
                {
                    label38.Text = "Null";
                    label44.Text = "Null";
                }
                if ((checkBox6.Checked))
                {
                    label37.Text = (pineapplep+" kg").ToString();
                    label43.Text = (pineapplef+" Rs").ToString();
                }
                else
                {
                    label37.Text = "Null";
                    label43.Text = "Null";
                }

                if ((checkBox5.Checked))
                {
                    label36.Text = (strawberriesp + " kg").ToString();
                    label42.Text = (strawberriesf + " Rs").ToString();
                }
                else
                {
                    label36.Text = "Null";
                    label42.Text = "Null";
                }

                totalproduct = applep + orangep + mangop + strawberriesp + peachp + pineapplep;
            
                if(radioButton1.Checked)
                {
                    totalprice = applef + mangof + orangef + strawberriesf + peachf + pineapplef+20;
                    label56.Text = "(20Rs added For bag)";
                }
                else
                {
                    totalprice = applef + mangof + orangef + strawberriesf + peachf + pineapplef;
                }
                DateTime today = DateTime.Now;
                label29.Text = today.ToString();
                label52.Text = (totalproduct+" kg").ToString();
                label54.Text = (totalprice+" Rs").ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                comboBox8.Enabled = true;
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox8.Enabled = false;
                comboBox7.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox6.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                comboBox11.Enabled = true;
                comboBox12.Enabled = true;
            }
            else
            {
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                comboBox9.Enabled = true;
                comboBox10.Enabled = true;
            }
            else
            {
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            comboBox8.Text = null;
            comboBox9.Text = null;
            comboBox10.Text = null;
            comboBox11.Text = null;
            comboBox12.Text = null;
            label52.Text = "..";
            label54.Text = "..";
            label36.Text = "Null";
            label42.Text = "Null";
            label37.Text = "Null";
            label43.Text = "Null";
            label38.Text = "Null";
            label44.Text = "Null";
            label39.Text = "Null";
            label45.Text = "Null";
            label40.Text = "Null";
            label46.Text = "Null";
            label41.Text = "Null";
            label47.Text = "Null";
            label56.Text = "";
            label29.Text = "..";
            radioButton1.Checked = false;
            radioButton2.Checked = true;

        }
    }
}
