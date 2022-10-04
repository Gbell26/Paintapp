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
            this.label1 = new System.Windows.Forms.Label();
            this.brushSizeBox = new System.Windows.Forms.ComboBox();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.btnActuallyDog = new System.Windows.Forms.Button();
            this.btnTurtle = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
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
            this.panel1.Size = new System.Drawing.Size(153, 450);
            this.panel1.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Coloring Book App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

