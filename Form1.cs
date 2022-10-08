// Gregory Bell, Jaleel Gonzales, Levi Bushey
// Paint app, with ability to draw lines, squares, ovals, as well as outlines for a penguin
// cat dog and wizard turtle
// brush function allows different size brushes

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
        bool printShape { get; set; } = false;
        bool line { get; set; } = false;
        int lineX { get; set; } = 0;
        int lineY { get; set; } = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.SelectedIndex.ToString();
        }

       
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            using (Pen mypen = new Pen(Color.Black))
                //Switch to select brush type (Brush, draw lines, print square or circle
                switch (comboBrushType.Text)
            {
                    //Brush is true, draws colored lines on mouseMove
                case "Brush":
                    shouldPaint = true;
                    break;
                        //Draw line becomes true and uses the xy of the mouse click as the start of a straight line
                case "Draw Line":
                    line = true;
                    break;
                        //Prints a small medium or large square at the xy of the mouse click 
                case "Print Square":
                        if (brushSizeBox.Text == "Large")
                        {
                            g.DrawRectangle(mypen, e.X, e.Y, 100, 100);
                        }
                        else if (brushSizeBox.Text == "Medium")
                        {
                            g.DrawRectangle(mypen, e.X, e.Y, 60, 60);
                        }
                        else
                        {
                            g.DrawRectangle(mypen, e.X, e.Y, 30, 30);
                        }
                        break;
                    //Prints a small medium or large circle at the xy of the mouse click 
                    case "Print Circle":
                        if (brushSizeBox.Text == "Large")
                        {
                            g.DrawEllipse(mypen, e.X, e.Y, 100, 100);
                        }
                        else if (brushSizeBox.Text == "Medium")
                        {
                            g.DrawEllipse(mypen, e.X, e.Y, 60, 60);
                        }
                        else
                        {
                            g.DrawEllipse(mypen, e.X, e.Y, 30, 30);
                        }
                        break;
                    default:
                        //If no choice is made then the default is a brush
                    shouldPaint = true;
                    break;
            }
            //Records the XY of the mouse click, to be used to draw a straight line ending at 
            //The XY of mouse up
            lineX = e.X;
            lineY = e.Y;
            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            using (SolidBrush myBrush = new SolidBrush(Color.Blue))
            using (Pen mypen = new Pen(Color.Black))
            {
                //When Brush is chosen shouldpaint is true and on mouse move it draws a colored brush line
                //comboBox1 decides the color of this brush with the default color being blue
                if (shouldPaint)
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
                    //brushSizeBox decides the size of the brush with the default size being medium
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
            //shouldPaint is false to end the drawn line if brush was chosen
            shouldPaint = false;

            using (Graphics g = CreateGraphics())
            using (Pen mypen = new Pen(Color.Black))
            {
                //if Draw line was chosen a line is drawn 
                if (line)
                {//Uses the X,Y, coordinates taken when the mouse is clicked and draws a line
                 //using the x, y coordinates of the mouse when you release the click
                    g.DrawLine(mypen, lineX, lineY, e.X, e.Y);
                }
            }
            line = false;
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
  
        }

        //Draws a picture of a PENGUIN. NOT A DOG 
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

        //Changes the text in the brushSizeBox to whatever selection was made
        private void brushSizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            brushSizeBox.Text = brushSizeBox.SelectedIndex.ToString();

        }

        //draws outline of a cat
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

        //Clears the screen
        private void btnClear_Click(object sender, EventArgs e)
        {
            using (Graphics g = base.CreateGraphics())
                g.Clear(Color.White);
        }

        //Draws the outline of a dog
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

        //Generate the outline of a wizardly turtle 
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


        //Generate a shape that will be filled with whatever color the brush color drop down box is selected as
        private void btnMakeShape_Click(object sender, EventArgs e)
        {
            try
            {
                //Takes the color, location and size of a shape you want to generate
                string shapeColor = comboBox1.Text;
                int coodX = Convert.ToInt32(txtShapeX.Text);
                int coodY = Convert.ToInt32(txtShapeY.Text);
                int shapeHeight = Convert.ToInt32(txtShapeHeight.Text);
                int shapeWidth = Convert.ToInt32(txtShapeWidth.Text);

                using (Graphics g = base.CreateGraphics())
                using (Pen pen = new Pen(Color.Black))
                using (SolidBrush myBrush = new SolidBrush(Color.Blue))
                {
                    //The shape will be filled with whatever color is chosen in brush color box
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
                    //This box chooses between a rectangle and an oval
                    switch (chooseShapeBox.Text)
                    {
                        case "Rectangle":
                            g.FillRectangle(myBrush, coodX, coodY, shapeWidth, shapeHeight);
                            break;
                        case "Oval":
                            g.FillEllipse(myBrush, coodX, coodY, shapeWidth, shapeHeight);
                            break;
                        default:
                            break;
                    }
                }
            }
            //try catch to handle format exceptions for the inputs
            catch (FormatException)
            {
                MessageBox.Show("Entry must be an integer", "Entry Error");
                txtShapeX.Focus();
            }
        }

        //Changes text in the Box for shape 
        private void chooseShapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseShapeBox.Text = chooseShapeBox.SelectedIndex.ToString();
        }
        //Changes text in the Box for brush type
        private void comboBrushType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBrushType.Text = comboBrushType.SelectedIndex.ToString();
        }
    }
   }
