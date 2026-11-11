using System.Net;

namespace WinAppPaint1
{
    public partial class frmPaint : Form
    {
        private bool isDrawing = false;
        private Bitmap bmp;
        private Point previousPoint;
        private Point StartPoint;
        private Point EndPoint;
        private Color currentColor = Color.Black;
        private float brushsize = 4f;
        private string currentTool = "None";
        public Pen pen = new Pen(Color.Black, 7f);
        public Graphics g;
        private struct LineData
        {
            public Point Start;
            public Point End;
            public Color Color;
            public float Width;
        }
        private List<LineData> lines = new List<LineData>();
        public frmPaint()
        {
            InitializeComponent();
            toolStripButton7.Image = global::Paint.Properties.Resources.иконка_вставки;
            toolStripButton1.Image = global::Paint.Properties.Resources.pen_icon;
            toolStripButton3.Image = global::Paint.Properties.Resources.ластик;
            toolStripButton4.Image = global::Paint.Properties.Resources.иконка_текст;
            toolStripButton5.Image = global::Paint.Properties.Resources.фигуры;
            toolStripButton6.Image = global::Paint.Properties.Resources.палитра_иконка;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void âèäToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void видToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentTool == "Pen" || currentTool == "Eraser" || currentTool == "Square" || currentTool == "Circle" || currentTool == "Triangle")
                {
                    isDrawing = true;
                    previousPoint = e.Location;
                    StartPoint = e.Location;
                }
                if (currentTool == "Eraser")
                {
                    currentColor = Color.White;
                    brushsize = 16f;
                }
                else
                {
                    currentColor = Color.Black;
                    brushsize = 4f;
                }
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && isDrawing)
            {
                if (currentTool == "Square")
                {
                    EndPoint = e.Location;
                    int x = Math.Min(StartPoint.X, EndPoint.X);
                    int y = Math.Min(StartPoint.Y, EndPoint.Y);
                    int width = Math.Abs(StartPoint.X - EndPoint.X);
                    int height = Math.Abs(StartPoint.Y - EndPoint.Y);
                    g.DrawRectangle(pen, x, y, width, height);
                    pictureBox1.Invalidate();
                }
                else if (currentTool == "Triangle")
                {
                    EndPoint = e.Location;
                    int x = Math.Min(StartPoint.X, EndPoint.X);
                    int y = Math.Min(StartPoint.Y, EndPoint.Y);
                    int width = Math.Abs(StartPoint.X - EndPoint.X);
                    int height = Math.Abs(StartPoint.Y - EndPoint.Y);

                    Point Top = new Point(x + width / 2, y);   
                    Point Left = new Point(x, y + height);         
                    Point Right = new Point(x + width, y + height);
                    Point[] trianglePoints = { Top, Left, Right };
                    g.DrawPolygon(pen, trianglePoints);
                    pictureBox1.Invalidate(); 
                }
                else if (currentTool == "Circle")
                {
                    pictureBox1.Invalidate();

                }
                isDrawing = false;
            }
        }




        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && (currentTool == "Pen" || currentTool == "Eraser"))
            {
                LineData newLine = new LineData
                {
                    Start = previousPoint,
                    End = e.Location,
                    Color = currentColor,
                    Width = brushsize,
                };
                lines.Add(newLine);
                previousPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var line in lines)
            {
                using Pen pen = new Pen(line.Color, line.Width);
                {
                    e.Graphics.DrawLine(pen, line.Start, line.End);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currentTool = "Pen";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            currentTool = "Eraser";
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            currentTool = "Square";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Нарисуйте что-нибудь!");
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            currentTool = "Triangle";
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            currentTool = "Circle";
        }
    }
}