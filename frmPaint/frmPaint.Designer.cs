namespace WinAppPaint1
{
    partial class frmPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaint));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem1 = new ToolStripMenuItem();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStrip1 = new ToolStrip();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton5 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            vScrollBar1 = new VScrollBar();
            hScrollBar1 = new HScrollBar();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, главнаяToolStripMenuItem, видToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, видToolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(132, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(132, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(132, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // видToolStripMenuItem1
            // 
            видToolStripMenuItem1.Name = "видToolStripMenuItem1";
            видToolStripMenuItem1.Size = new Size(132, 22);
            видToolStripMenuItem1.Text = "Выход";
            видToolStripMenuItem1.Click += видToolStripMenuItem1_Click;
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(63, 20);
            главнаяToolStripMenuItem.Text = "Главная";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator8, toolStripButton7, toolStripSeparator7, toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripSeparator2, toolStripButton3, toolStripSeparator3, toolStripButton4, toolStripSeparator4, toolStripButton5, toolStripSeparator5, toolStripButton6, toolStripSeparator6 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 5, 1, 5);
            toolStrip1.Size = new Size(800, 49);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 39);
            // 
            // toolStripButton7
            // 
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(59, 36);
            toolStripButton7.Text = "Вставить";
            toolStripButton7.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 39);
            // 
            // toolStripButton1
            // 
            toolStripButton1.ForeColor = SystemColors.ControlText;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(67, 36);
            toolStripButton1.Text = "Карандаш";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(88, 36);
            toolStripButton2.Text = "Заливка";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // toolStripButton3
            // 
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(49, 36);
            toolStripButton3.Text = "Ластик";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // toolStripButton4
            // 
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(41, 36);
            toolStripButton4.Text = "Текст";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // toolStripButton5
            // 
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(54, 36);
            toolStripButton5.Text = "Фигуры";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 39);
            // 
            // toolStripButton6
            // 
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(81, 36);
            toolStripButton6.Text = "Выбор цвета";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 39);
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(hScrollBar1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 355);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(782, 340);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(782, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(18, 367);
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(0, 364);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(782, 15);
            hScrollBar1.TabIndex = 0;
            // 
            // frmPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPaint";
            Text = "Paint";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton6;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private VScrollBar vScrollBar1;
        private HScrollBar hScrollBar1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton7;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator6;
        private PictureBox pictureBox1;
    }
}