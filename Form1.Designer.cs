namespace Paintapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBrushType = new System.Windows.Forms.ComboBox();
            this.chooseShapeBox = new System.Windows.Forms.ComboBox();
            this.btnMakeShape = new System.Windows.Forms.Button();
            this.txtCirHeight = new System.Windows.Forms.Label();
            this.txtCirWidth = new System.Windows.Forms.Label();
            this.txtCirY = new System.Windows.Forms.Label();
            this.txtCirX = new System.Windows.Forms.Label();
            this.txtShapeHeight = new System.Windows.Forms.TextBox();
            this.txtShapeWidth = new System.Windows.Forms.TextBox();
            this.txtShapeY = new System.Windows.Forms.TextBox();
            this.txtShapeX = new System.Windows.Forms.TextBox();
            this.btnTurtle = new System.Windows.Forms.Button();
            this.btnActuallyDog = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brushSizeBox = new System.Windows.Forms.ComboBox();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow",
            "Purple",
            "Orange",
            "Pink"});
            this.comboBox1.Location = new System.Drawing.Point(12, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Brush Color";
            this.toolTip1.SetToolTip(this.comboBox1, "Choose Your Brush Color");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.comboBrushType);
            this.panel1.Controls.Add(this.chooseShapeBox);
            this.panel1.Controls.Add(this.btnMakeShape);
            this.panel1.Controls.Add(this.txtCirHeight);
            this.panel1.Controls.Add(this.txtCirWidth);
            this.panel1.Controls.Add(this.txtCirY);
            this.panel1.Controls.Add(this.txtCirX);
            this.panel1.Controls.Add(this.txtShapeHeight);
            this.panel1.Controls.Add(this.txtShapeWidth);
            this.panel1.Controls.Add(this.txtShapeY);
            this.panel1.Controls.Add(this.txtShapeX);
            this.panel1.Controls.Add(this.btnTurtle);
            this.panel1.Controls.Add(this.btnActuallyDog);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brushSizeBox);
            this.panel1.Controls.Add(this.btnCat);
            this.panel1.Controls.Add(this.btnDog);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 747);
            this.panel1.TabIndex = 1;
            // 
            // comboBrushType
            // 
            this.comboBrushType.FormattingEnabled = true;
            this.comboBrushType.Items.AddRange(new object[] {
            "Brush",
            "Draw Line",
            "Print Square",
            "Print Circle"});
            this.comboBrushType.Location = new System.Drawing.Point(12, 19);
            this.comboBrushType.Name = "comboBrushType";
            this.comboBrushType.Size = new System.Drawing.Size(121, 21);
            this.comboBrushType.TabIndex = 19;
            this.comboBrushType.Text = "Brush Type";
            this.comboBrushType.SelectedIndexChanged += new System.EventHandler(this.comboBrushType_SelectedIndexChanged);
            // 
            // chooseShapeBox
            // 
            this.chooseShapeBox.FormattingEnabled = true;
            this.chooseShapeBox.Items.AddRange(new object[] {
            "Oval",
            "Rectangle"});
            this.chooseShapeBox.Location = new System.Drawing.Point(11, 286);
            this.chooseShapeBox.Name = "chooseShapeBox";
            this.chooseShapeBox.Size = new System.Drawing.Size(121, 21);
            this.chooseShapeBox.TabIndex = 18;
            this.chooseShapeBox.Text = "Shape";
            this.chooseShapeBox.SelectedIndexChanged += new System.EventHandler(this.chooseShapeBox_SelectedIndexChanged);
            // 
            // btnMakeShape
            // 
            this.btnMakeShape.Location = new System.Drawing.Point(21, 391);
            this.btnMakeShape.Name = "btnMakeShape";
            this.btnMakeShape.Size = new System.Drawing.Size(108, 23);
            this.btnMakeShape.TabIndex = 17;
            this.btnMakeShape.Text = "Make Shape";
            this.btnMakeShape.UseVisualStyleBackColor = true;
            this.btnMakeShape.Click += new System.EventHandler(this.btnMakeShape_Click);
            // 
            // txtCirHeight
            // 
            this.txtCirHeight.AutoSize = true;
            this.txtCirHeight.Location = new System.Drawing.Point(85, 349);
            this.txtCirHeight.Name = "txtCirHeight";
            this.txtCirHeight.Size = new System.Drawing.Size(44, 13);
            this.txtCirHeight.TabIndex = 16;
            this.txtCirHeight.Text = "Height: ";
            // 
            // txtCirWidth
            // 
            this.txtCirWidth.AutoSize = true;
            this.txtCirWidth.Location = new System.Drawing.Point(12, 349);
            this.txtCirWidth.Name = "txtCirWidth";
            this.txtCirWidth.Size = new System.Drawing.Size(38, 13);
            this.txtCirWidth.TabIndex = 15;
            this.txtCirWidth.Text = "Width:";
            // 
            // txtCirY
            // 
            this.txtCirY.AutoSize = true;
            this.txtCirY.Location = new System.Drawing.Point(85, 310);
            this.txtCirY.Name = "txtCirY";
            this.txtCirY.Size = new System.Drawing.Size(17, 13);
            this.txtCirY.TabIndex = 14;
            this.txtCirY.Text = "Y:";
            // 
            // txtCirX
            // 
            this.txtCirX.AutoSize = true;
            this.txtCirX.Location = new System.Drawing.Point(12, 310);
            this.txtCirX.Name = "txtCirX";
            this.txtCirX.Size = new System.Drawing.Size(17, 13);
            this.txtCirX.TabIndex = 13;
            this.txtCirX.Text = "X:";
            // 
            // txtShapeHeight
            // 
            this.txtShapeHeight.Location = new System.Drawing.Point(88, 365);
            this.txtShapeHeight.Name = "txtShapeHeight";
            this.txtShapeHeight.Size = new System.Drawing.Size(40, 20);
            this.txtShapeHeight.TabIndex = 12;
            // 
            // txtShapeWidth
            // 
            this.txtShapeWidth.Location = new System.Drawing.Point(21, 365);
            this.txtShapeWidth.Name = "txtShapeWidth";
            this.txtShapeWidth.Size = new System.Drawing.Size(46, 20);
            this.txtShapeWidth.TabIndex = 11;
            // 
            // txtShapeY
            // 
            this.txtShapeY.Location = new System.Drawing.Point(88, 326);
            this.txtShapeY.Name = "txtShapeY";
            this.txtShapeY.Size = new System.Drawing.Size(44, 20);
            this.txtShapeY.TabIndex = 10;
            // 
            // txtShapeX
            // 
            this.txtShapeX.Location = new System.Drawing.Point(21, 326);
            this.txtShapeX.Name = "txtShapeX";
            this.txtShapeX.Size = new System.Drawing.Size(46, 20);
            this.txtShapeX.TabIndex = 9;
            // 
            // btnTurtle
            // 
            this.btnTurtle.Location = new System.Drawing.Point(12, 257);
            this.btnTurtle.Name = "btnTurtle";
            this.btnTurtle.Size = new System.Drawing.Size(121, 23);
            this.btnTurtle.TabIndex = 7;
            this.btnTurtle.Text = "Wizard Turtle";
            this.btnTurtle.UseVisualStyleBackColor = true;
            this.btnTurtle.Click += new System.EventHandler(this.btnTurtle_Click);
            // 
            // btnActuallyDog
            // 
            this.btnActuallyDog.Location = new System.Drawing.Point(12, 228);
            this.btnActuallyDog.Name = "btnActuallyDog";
            this.btnActuallyDog.Size = new System.Drawing.Size(121, 23);
            this.btnActuallyDog.TabIndex = 6;
            this.btnActuallyDog.Text = "Dog";
            this.btnActuallyDog.UseVisualStyleBackColor = true;
            this.btnActuallyDog.Click += new System.EventHandler(this.btnActuallyDog_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What would you like to Draw?";
            // 
            // brushSizeBox
            // 
            this.brushSizeBox.FormattingEnabled = true;
            this.brushSizeBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.brushSizeBox.Location = new System.Drawing.Point(12, 46);
            this.brushSizeBox.Name = "brushSizeBox";
            this.brushSizeBox.Size = new System.Drawing.Size(121, 21);
            this.brushSizeBox.TabIndex = 3;
            this.brushSizeBox.Text = "Brush Size";
            this.brushSizeBox.SelectedIndexChanged += new System.EventHandler(this.brushSizeBox_SelectedIndexChanged);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(12, 197);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(121, 25);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(12, 167);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(121, 24);
            this.btnDog.TabIndex = 1;
            this.btnDog.Text = "Penguin";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(828, 451);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Coloring Book App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.ComboBox brushSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnActuallyDog;
        private System.Windows.Forms.Button btnTurtle;
        private System.Windows.Forms.ComboBox chooseShapeBox;
        private System.Windows.Forms.Button btnMakeShape;
        private System.Windows.Forms.Label txtCirHeight;
        private System.Windows.Forms.Label txtCirWidth;
        private System.Windows.Forms.Label txtCirY;
        private System.Windows.Forms.Label txtCirX;
        private System.Windows.Forms.TextBox txtShapeHeight;
        private System.Windows.Forms.TextBox txtShapeWidth;
        private System.Windows.Forms.TextBox txtShapeY;
        private System.Windows.Forms.TextBox txtShapeX;
        private System.Windows.Forms.ComboBox comboBrushType;
    }
}

