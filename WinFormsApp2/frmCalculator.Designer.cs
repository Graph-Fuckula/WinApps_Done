using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopApp1
{
    partial class frmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Display = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(6, 186);
            button1.Name = "button1";
            button1.Size = new Size(75, 71);
            button1.TabIndex = 0;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = false;
            // 
            // Display
            // 
            Display.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            Display.Location = new Point(6, 12);
            Display.Multiline = true;
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.Size = new Size(323, 163);
            Display.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(87, 186);
            button2.Name = "button2";
            button2.Size = new Size(75, 71);
            button2.TabIndex = 10;
            button2.Text = "AC";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(168, 186);
            button3.Name = "button3";
            button3.Size = new Size(75, 71);
            button3.TabIndex = 11;
            button3.Text = "%";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(249, 186);
            button4.Name = "button4";
            button4.Size = new Size(80, 71);
            button4.TabIndex = 12;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += operationClick;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(249, 263);
            button5.Name = "button5";
            button5.Size = new Size(80, 71);
            button5.TabIndex = 16;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += operationClick;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.AppWorkspace;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(168, 263);
            button6.Name = "button6";
            button6.Size = new Size(75, 71);
            button6.TabIndex = 15;
            button6.Text = "9";
            button6.UseVisualStyleBackColor = false;
            button6.Click += allBtnClick;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.AppWorkspace;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(87, 263);
            button7.Name = "button7";
            button7.Size = new Size(75, 71);
            button7.TabIndex = 14;
            button7.Text = "8";
            button7.UseVisualStyleBackColor = false;
            button7.Click += allBtnClick;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.AppWorkspace;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(6, 263);
            button8.Name = "button8";
            button8.Size = new Size(75, 71);
            button8.TabIndex = 13;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = false;
            button8.Click += allBtnClick;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 128, 0);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(249, 340);
            button9.Name = "button9";
            button9.Size = new Size(80, 71);
            button9.TabIndex = 20;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = false;
            button9.Click += operationClick;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ButtonShadow;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(168, 340);
            button10.Name = "button10";
            button10.Size = new Size(75, 71);
            button10.TabIndex = 19;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = false;
            button10.Click += allBtnClick;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.AppWorkspace;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(87, 340);
            button11.Name = "button11";
            button11.Size = new Size(75, 71);
            button11.TabIndex = 18;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = false;
            button11.Click += allBtnClick;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.AppWorkspace;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(6, 340);
            button12.Name = "button12";
            button12.Size = new Size(75, 71);
            button12.TabIndex = 17;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += allBtnClick;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(255, 128, 0);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(249, 417);
            button13.Name = "button13";
            button13.Size = new Size(80, 71);
            button13.TabIndex = 24;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += operationClick;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.AppWorkspace;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(168, 417);
            button14.Name = "button14";
            button14.Size = new Size(75, 71);
            button14.TabIndex = 23;
            button14.Text = "3";
            button14.UseVisualStyleBackColor = false;
            button14.Click += allBtnClick;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.AppWorkspace;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(87, 417);
            button15.Name = "button15";
            button15.Size = new Size(75, 71);
            button15.TabIndex = 22;
            button15.Text = "2";
            button15.UseVisualStyleBackColor = false;
            button15.Click += allBtnClick;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.AppWorkspace;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(6, 417);
            button16.Name = "button16";
            button16.Size = new Size(75, 71);
            button16.TabIndex = 21;
            button16.Text = "1";
            button16.UseVisualStyleBackColor = false;
            button16.Click += allBtnClick;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(255, 128, 0);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(249, 494);
            button17.Name = "button17";
            button17.Size = new Size(80, 71);
            button17.TabIndex = 28;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = false;
            button17.Click += btn_equal;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.AppWorkspace;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(168, 494);
            button18.Name = "button18";
            button18.Size = new Size(75, 71);
            button18.TabIndex = 27;
            button18.Text = ",";
            button18.UseVisualStyleBackColor = false;
            button18.Click += allBtnClick;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.AppWorkspace;
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(87, 494);
            button19.Name = "button19";
            button19.Size = new Size(75, 71);
            button19.TabIndex = 26;
            button19.Text = "0";
            button19.UseVisualStyleBackColor = false;
            button19.Click += allBtnClick;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.AppWorkspace;
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(6, 494);
            button20.Name = "button20";
            button20.Size = new Size(75, 71);
            button20.TabIndex = 25;
            button20.Text = "+/-";
            button20.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(333, 575);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Display);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox Display;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}