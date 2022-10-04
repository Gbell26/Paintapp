using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                        default:
                            myBrush.Color = Color.Blue;
                            break;
                    }
                    g.FillEllipse(myBrush, e.X, e.Y, 15, 15);
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
    }
   }
