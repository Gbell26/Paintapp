using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paintapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool shouldPaint { get; set; } = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedIndex.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics g = CreateGraphics())
                using (SolidBrush myBrush = new SolidBrush(Color.Blue))
                {
                    switch (comboBox1.Text)
                    {
                        case "Blue":
                            myBrush.Color = Color.Blue;
                            break;
                        case "Red":
                            myBrush.Color = Color.Red;
                            break;
                        case "Yellow":
                            myBrush.Color = Color.Yellow;
                            break;
                        case "Green":
                            myBrush.Color = Color.Green;
                            break;
                        case "Purple":
                            myBrush.Color = Color.Purple;
                            break;
                        case "Pink":
                            myBrush.Color = Color.Pink;
                            break;
                        case "Orange":
                            myBrush.Color = Color.Orange;
                            break;
                        default:
                            myBrush.Color = Color.Blue;
                            break;
                    }
                    switch (brushSizeBox.Text)
                    {
                        case "Small":
                            g.FillEllipse(myBrush, e.X, e.Y, 4, 4);
                            break;
                        case "Medium":
                            g.FillEllipse(myBrush, e.X, e.Y, 7, 7);
                            break;
                        case "Large":
                            g.FillEllipse(myBrush, e.X, e.Y, 12, 12);
                            break;
                        default:
                            g.FillEllipse(myBrush, e.X, e.Y, 7, 7);
                            break;
                    }
                    
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
  
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            using (Graphics g = base.CreateGraphics())
            using (Pen pen = new Pen(Color.Black))
            {
                g.Clear(Color.White);
                //Head
                g.DrawEllipse(pen, 400, 120, 80, 80);
                //Body
                g.DrawEllipse(pen, 405, 200, 70, 150);
                //Left Wing
                g.DrawEllipse(pen, 400, 220, 35, 100);
                //Right wing
                g.DrawEllipse(pen, 445, 220, 35, 100);
                //left foot
                g.DrawEllipse(pen, 390, 340, 40, 20);
                //Right foot
                g.DrawEllipse(pen, 450, 340, 40, 20);
                //Beak
                g.DrawLine(pen, 430, 160, 440, 180);
                g.DrawLine(pen, 450, 160, 440, 180);
                //left Eye
                g.DrawRectangle(pen, 415, 140 , 15, 6);
                //right Eye
                g.DrawRectangle(pen, 450, 140, 15, 6);
            }
        }


        private void brushSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            brushSizeBox.Text = brushSizeBox.SelectedIndex.ToString();

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            using (Graphics g = base.CreateGraphics())
            using (Pen pen = new Pen(Color.Black))
            {
                g.Clear(Color.White);
                //head
                g.DrawEllipse(pen, 400, 120, 80, 80);
                //body
                g.DrawEllipse(pen, 390, 200, 100, 120);
                //left foot
                g.DrawEllipse(pen, 390, 310, 30, 20);
                //right foot
                g.DrawEllipse(pen, 460, 310, 30, 20);
                //left hand
                g.DrawEllipse(pen, 390, 230, 30, 20);
                //right hand
                g.DrawEllipse(pen, 460, 230, 30, 20);
                //left ear
                g.DrawLine(pen, 410, 130, 420, 100);
                g.DrawLine(pen, 430, 120, 420, 100);
                //right ear
                g.DrawLine(pen, 450, 120, 460, 100);
                g.DrawLine(pen, 470, 130, 460, 100);
                //left eye
                g.DrawEllipse(pen, 415, 130, 20, 20);
                //right eye
                g.DrawEllipse(pen, 445, 130, 20, 20);
                //nose
                g.DrawEllipse(pen, 435, 150, 10, 10);
                //left whiskers
                g.DrawLine(pen, 430, 155, 410, 150);
                g.DrawLine(pen, 430, 155, 410, 155);
                //right whiskers
                g.DrawLine(pen, 470, 150, 450, 155);
                g.DrawLine(pen, 470, 155, 450, 155);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = base.CreateGraphics())
                g.Clear(Color.White);
        }

        private void btnActuallyDog_Click(object sender, EventArgs e)
        {
            using (Graphics g = base.CreateGraphics())
            using (Pen pen = new Pen(Color.Black))
            {
                g.Clear(Color.White);
                //head
                g.DrawEllipse(pen, 400, 120, 80, 80);
                //body
                g.DrawEllipse(pen, 390, 200, 100, 120);
                //left foot
                g.DrawEllipse(pen, 390, 310, 30, 20);
                //right foot
                g.DrawEllipse(pen, 460, 310, 30, 20);
                //left hand
                g.DrawEllipse(pen, 390, 230, 30, 20);
                //right hand
                g.DrawEllipse(pen, 460, 230, 30, 20);
                //left ear
                g.DrawLine(pen, 410, 130, 420, 100);
                g.DrawLine(pen, 430, 120, 420, 100);
                //right ear
                g.DrawLine(pen, 450, 120, 460, 100);
                g.DrawLine(pen, 470, 130, 460, 100);
                //left eye
                g.DrawEllipse(pen, 415, 130, 20, 20);
                //right eye
                g.DrawEllipse(pen, 445, 130, 20, 20);
                //nose
                g.DrawLine(pen, 435, 155, 435, 175);
                g.DrawLine(pen, 450, 155, 450, 175);
                g.DrawLine(pen, 435, 175, 450, 175);
                g.DrawLine(pen, 435, 175, 440, 180);
                g.DrawLine(pen, 450, 175, 440, 180);
            }
        }

        private void btnTurtle_Click(object sender, EventArgs e)
        {
            using (Graphics g = base.CreateGraphics())
            using (Pen pen = new Pen(Color.Black))
            {
                g.Clear(Color.White);
                //Head
                g.DrawEllipse(pen, 400, 120, 80, 80);
                //Body
                g.DrawEllipse(pen, 405, 200, 120, 150);
                //left foot
                g.DrawEllipse(pen, 400, 330, 40, 40);
                //Right foot
                g.DrawEllipse(pen, 450, 340, 40, 40);
                g.DrawEllipse(pen, 390, 220, 40, 40);
                //Right foot
                g.DrawEllipse(pen, 450, 220, 40, 40);
                //left Eye
                g.DrawEllipse(pen, 415, 140, 15, 6);
                //right Eye
                g.DrawEllipse(pen, 450, 140, 15, 6);
                //staff
                g.DrawLine(pen, 390, 200, 390, 400);
                g.DrawEllipse(pen, 385, 180, 10, 20);
                //Hat
                g.DrawEllipse(pen, 400, 110, 100, 10);
                g.DrawLine(pen, 420, 115, 450, 50);
                g.DrawLine(pen, 480, 115, 450, 50);
            }
        }
    }
   }
