namespace WinFormsApp1
{
    public partial class frmNoteBook : Form
    {
        public frmNoteBook()
        {
            InitializeComponent();
        }
        private void переносПоСловамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Filepath = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(Filepath))
                {
                    writer.Write(richTextBox1.Rtf);
                }

            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.ShowDialog();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                string Filepath = openFileDialog1.FileName;

                using (StreamReader reader = new StreamReader(Filepath))
                {
                    richTextBox1.Rtf = reader.ReadToEnd();
                }
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;

            }
        }
        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }
    }
}