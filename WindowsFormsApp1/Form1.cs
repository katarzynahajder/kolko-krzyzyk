using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label10.Text = e.X + "; " + e.Y;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label13.Text = "";
            string znak1 = "X";
            string znak2 = "O";
            if (e.Y < 200)
            {
                if (e.X < 200)
                {
                    if (label1.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole A1";
                        label1.Text = znak1;
                    }
                }
                else if (e.X > 400)
                {
                    if (label3.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole A3";
                        label3.Text = znak1;
                    }
                }
                else
                {
                    if (label2.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole A2";
                        label2.Text = znak1;
                    }
                }
            }
            else if (e.Y > 400)
            {
                if (e.X < 200)
                {
                    if (label7.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole C1";
                        label7.Text = znak1;
                    }
                }
                else if (e.X > 400)
                {
                    if (label9.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole C3";
                        label9.Text = znak1;
                    }
                }
                else
                {
                    if (label8.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole C2";
                        label8.Text = znak1;
                    }
                }
            }
            else
            {
                if (e.X < 200)
                {
                    if (label4.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole B1";
                        label4.Text = znak1;
                    }
                }
                else if (e.X > 400)
                {
                    if (label6.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole B3";
                        label6.Text = znak1;
                    }
                }
                else
                {
                    if (label5.Text != "") label11.Text = "Wybrane pole jest zajęte!";
                    else
                    {
                        label11.Text = "Wybrano pole B2";
                        label5.Text = znak1;
                    }
                }
            }
            if (((label1.Text == znak1) && (label2.Text == znak1) && (label3.Text == znak1)) || ((label7.Text == znak1) && (label8.Text == znak1) && (label9.Text == znak1)) || ((label1.Text == znak1) && (label4.Text == znak1) && (label7.Text == znak1)) || ((label3.Text == znak1) && (label6.Text == znak1) && (label9.Text == znak1)) || ((label1.Text == znak1) && (label5.Text == znak1) && (label9.Text == znak1)) || ((label3.Text == znak1) && (label5.Text == znak1) && (label7.Text == znak1)) || ((label2.Text == znak1) && (label5.Text == znak1) && (label8.Text == znak1)) || ((label4.Text == znak1) && (label5.Text == znak1) && (label6.Text == znak1)))
            {
                label13.Text = "GRACZ WYGRAŁ!";
                pictureBox1.Enabled = false;
            }
            else
            {
                for (; ; )
                {
                    if ((label1.Text != "") && (label2.Text != "") && (label3.Text != "") && (label4.Text != "") && (label5.Text != "") && (label6.Text != "") && (label7.Text != "") && (label8.Text != "") && (label9.Text != ""))
                    {
                        break;
                        pictureBox1.Enabled = false;
                    }
                    if (((label1.Text == znak1 && label9.Text == znak1) || (label3.Text == znak1 && label7.Text == znak1) || (label2.Text == znak1 && label8.Text == znak1) || (label4.Text == znak1 && label6.Text == znak1)) && label5.Text == "")
                    {
                        label5.Text = znak2;
                        label12.Text = "Komputer wybrał pole B2";
                        break;
                    }
                    else if (label1.Text == znak1 && label3.Text == znak1 && label2.Text == "")
                    {
                        label2.Text = znak2;
                        label12.Text = "Komputer wybrał pole A2";
                        break;
                    }
                    else if (label1.Text == znak1 && label7.Text == znak1 && label4.Text == "")
                    {
                        label4.Text = znak2;
                        label12.Text = "Komputer wybrał pole B1";
                        break;
                    }
                    else if (label3.Text == znak1 && label9.Text == znak1 && label6.Text == "")
                    {
                        label6.Text = znak2;
                        label12.Text = "Komputer wybrał pole B3";
                        break;
                    }
                    else if (label7.Text == znak1 && label9.Text == znak1 && label8.Text == "")
                    {
                        label8.Text = znak2;
                        label12.Text = "Komputer wybrał pole C2";
                        break;
                    }
                    Random generator = new Random();
                    int x = generator.Next(1, 10);
                    switch (x)
                    {
                        case 1:
                            if (label1.Text == "")
                            {
                                label1.Text = znak2;
                                label12.Text = "Komputer wybrał pole A1";
                                break;
                            }
                            else continue;
                        case 2:
                            if (label2.Text == "")
                            {
                                label2.Text = znak2;
                                label12.Text = "Komputer wybrał pole A2";
                                break;
                            }
                            else continue;
                        case 3:
                            if (label3.Text == "")
                            {
                                label3.Text = znak2;
                                label12.Text = "Komputer wybrał pole A3";
                                break;
                            }
                            else continue;
                        case 4:
                            if (label4.Text == "")
                            {
                                label4.Text = znak2;
                                label12.Text = "Komputer wybrał pole B1";
                                break;
                            }
                            else continue;
                        case 5:
                            if (label5.Text == "")
                            {
                                label5.Text = znak2;
                                label12.Text = "Komputer wybrał pole B2";
                                break;
                            }
                            else continue;
                        case 6:
                            if (label6.Text == "")
                            {
                                label6.Text = znak2;
                                label12.Text = "Komputer wybrał pole B3";
                                break;
                            }
                            else continue;
                        case 7:
                            if (label7.Text == "")
                            {
                                label7.Text = znak2;
                                label12.Text = "Komputer wybrał pole C1";
                                break;
                            }
                            else continue;
                        case 8:
                            if (label8.Text == "")
                            {
                                label8.Text = znak2;
                                label12.Text = "Komputer wybrał pole C2";
                                break;
                            }
                            else continue;
                        case 9:
                            if (label9.Text == "")
                            {
                                label9.Text = znak2;
                                label12.Text = "Komputer wybrał pole C3";
                                break;
                            }
                            else continue;
                    }
                    break;
                }
            }
            if (((label1.Text == znak2) && (label2.Text == znak2) && (label3.Text == znak2)) || ((label7.Text == znak2) && (label8.Text == znak2) && (label9.Text == znak2)) || ((label1.Text == znak2) && (label4.Text == znak2) && (label7.Text == znak2)) || ((label3.Text == znak2) && (label6.Text == znak2) && (label9.Text == znak2)) || ((label1.Text == znak2) && (label5.Text == znak2) && (label9.Text == znak2)) || ((label3.Text == znak2) && (label5.Text == znak2) && (label7.Text == znak2)) || ((label2.Text == znak2) && (label5.Text == znak2) && (label8.Text == znak2)) || ((label4.Text == znak2) && (label5.Text == znak2) && (label6.Text == znak2)))
            {
                label13.Text = "KOMPUTER WYGRAŁ!";
                pictureBox1.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label13.Text = "Rozpocznij grę";
        }
    }
}
