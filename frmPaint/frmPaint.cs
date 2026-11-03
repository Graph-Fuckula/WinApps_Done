namespace WinAppPaint1
{
    public partial class frmPaint : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Color currentColor = Color.Black;
        private float brushsize = 4f;
        private string currentTool = "None";
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
                if (currentTool == "Pen" || currentTool == "Eraser")
                {
                    isDrawing = true;
                    previousPoint = e.Location;
                }
                if (currentTool == "Eraser")
                {
                    currentColor = pictureBox1.BackColor;
                }
                else
                {
                    currentColor = Color.Black;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
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
    }
}