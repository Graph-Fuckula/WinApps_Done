using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class frmNoteBook
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            btn_save_as = new ToolStripMenuItem();
            параметрыСтраницыToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            поискСПомощьюBingToolStripMenuItem = new ToolStripMenuItem();
            найтиToolStripMenuItem = new ToolStripMenuItem();
            найтиДалееToolStripMenuItem = new ToolStripMenuItem();
            заменитьToolStripMenuItem = new ToolStripMenuItem();
            перейтиToolStripMenuItem = new ToolStripMenuItem();
            выделелитьВсеToolStripMenuItem = new ToolStripMenuItem();
            времяИДатаToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            переносПоСловамToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            цветШрифтаToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            масштабToolStripMenuItem = new ToolStripMenuItem();
            увеличитьToolStripMenuItem = new ToolStripMenuItem();
            уменьшитьToolStripMenuItem = new ToolStripMenuItem();
            восстановитьМасштабПоУмолчаниюToolStripMenuItem = new ToolStripMenuItem();
            строкаСостоянияToolStripMenuItem = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            просмотретьСправкуToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem, видToolStripMenuItem, about });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(685, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, btn_save_as, параметрыСтраницыToolStripMenuItem, печатьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(204, 22);
            создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(204, 22);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(204, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // btn_save_as
            // 
            btn_save_as.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btn_save_as.Name = "btn_save_as";
            btn_save_as.Size = new Size(204, 22);
            btn_save_as.Text = "Сохранить как...";
            btn_save_as.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            параметрыСтраницыToolStripMenuItem.Size = new Size(204, 22);
            параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы...";
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(204, 22);
            печатьToolStripMenuItem.Text = "Печать...";
            печатьToolStripMenuItem.Click += печатьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(204, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, поискСПомощьюBingToolStripMenuItem, найтиToolStripMenuItem, найтиДалееToolStripMenuItem, заменитьToolStripMenuItem, перейтиToolStripMenuItem, выделелитьВсеToolStripMenuItem, времяИДатаToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "&Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.Size = new Size(214, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(214, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(214, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(214, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(214, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // поискСПомощьюBingToolStripMenuItem
            // 
            поискСПомощьюBingToolStripMenuItem.Name = "поискСПомощьюBingToolStripMenuItem";
            поискСПомощьюBingToolStripMenuItem.Size = new Size(214, 22);
            поискСПомощьюBingToolStripMenuItem.Text = "Поиск с помощью Bing...";
            // 
            // найтиToolStripMenuItem
            // 
            найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            найтиToolStripMenuItem.Size = new Size(214, 22);
            найтиToolStripMenuItem.Text = "Найти...";
            // 
            // найтиДалееToolStripMenuItem
            // 
            найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            найтиДалееToolStripMenuItem.Size = new Size(214, 22);
            найтиДалееToolStripMenuItem.Text = "Найти далее";
            // 
            // заменитьToolStripMenuItem
            // 
            заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            заменитьToolStripMenuItem.Size = new Size(214, 22);
            заменитьToolStripMenuItem.Text = "Заменить...";
            // 
            // перейтиToolStripMenuItem
            // 
            перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            перейтиToolStripMenuItem.Size = new Size(214, 22);
            перейтиToolStripMenuItem.Text = "Перейти...";
            // 
            // выделелитьВсеToolStripMenuItem
            // 
            выделелитьВсеToolStripMenuItem.Name = "выделелитьВсеToolStripMenuItem";
            выделелитьВсеToolStripMenuItem.Size = new Size(214, 22);
            выделелитьВсеToolStripMenuItem.Text = "Выделелить все";
            // 
            // времяИДатаToolStripMenuItem
            // 
            времяИДатаToolStripMenuItem.Name = "времяИДатаToolStripMenuItem";
            времяИДатаToolStripMenuItem.Size = new Size(214, 22);
            времяИДатаToolStripMenuItem.Text = "Время и дата";
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { переносПоСловамToolStripMenuItem, шрифтToolStripMenuItem, цветШрифтаToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(62, 20);
            форматToolStripMenuItem.Text = "Фор&мат";
            // 
            // переносПоСловамToolStripMenuItem
            // 
            переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            переносПоСловамToolStripMenuItem.Size = new Size(183, 22);
            переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(183, 22);
            шрифтToolStripMenuItem.Text = "Шрифт...";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // цветШрифтаToolStripMenuItem
            // 
            цветШрифтаToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            цветШрифтаToolStripMenuItem.Size = new Size(183, 22);
            цветШрифтаToolStripMenuItem.Text = "Цвет Шрифта";
            цветШрифтаToolStripMenuItem.Click += цветШрифтаToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { масштабToolStripMenuItem, строкаСостоянияToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "&Вид";
            // 
            // масштабToolStripMenuItem
            // 
            масштабToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { увеличитьToolStripMenuItem, уменьшитьToolStripMenuItem, восстановитьМасштабПоУмолчаниюToolStripMenuItem });
            масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            масштабToolStripMenuItem.Size = new Size(173, 22);
            масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // увеличитьToolStripMenuItem
            // 
            увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            увеличитьToolStripMenuItem.Size = new Size(288, 22);
            увеличитьToolStripMenuItem.Text = "Увеличить";
            // 
            // уменьшитьToolStripMenuItem
            // 
            уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            уменьшитьToolStripMenuItem.Size = new Size(288, 22);
            уменьшитьToolStripMenuItem.Text = "Уменьшить";
            // 
            // восстановитьМасштабПоУмолчаниюToolStripMenuItem
            // 
            восстановитьМасштабПоУмолчаниюToolStripMenuItem.Name = "восстановитьМасштабПоУмолчаниюToolStripMenuItem";
            восстановитьМасштабПоУмолчаниюToolStripMenuItem.Size = new Size(288, 22);
            восстановитьМасштабПоУмолчаниюToolStripMenuItem.Text = "Восстановить масштаб по умолчанию";
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            строкаСостоянияToolStripMenuItem.CheckOnClick = true;
            строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            строкаСостоянияToolStripMenuItem.Size = new Size(173, 22);
            строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            // 
            // about
            // 
            about.DropDownItems.AddRange(new ToolStripItem[] { просмотретьСправкуToolStripMenuItem, оПрограммеToolStripMenuItem });
            about.Name = "about";
            about.Size = new Size(65, 20);
            about.Text = "&Справка";
            // 
            // просмотретьСправкуToolStripMenuItem
            // 
            просмотретьСправкуToolStripMenuItem.Name = "просмотретьСправкуToolStripMenuItem";
            просмотретьСправкуToolStripMenuItem.Size = new Size(195, 22);
            просмотретьСправкуToolStripMenuItem.Text = "Просмотреть справку";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(195, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(685, 476);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 476);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(685, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(453, 19);
            toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel2.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(80, 19);
            toolStripStatusLabel2.Text = "Стр 1, стлб 1";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel3.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(98, 19);
            toolStripStatusLabel3.Text = "Windows (CRLF)";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.BorderSides = ToolStripStatusLabelBorderSides.Left;
            toolStripStatusLabel4.BorderStyle = Border3DStyle.Etched;
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(39, 19);
            toolStripStatusLabel4.Text = "100%";
            // 
            // frmNoteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 500);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmNoteBook";
            Text = "Блокнот";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem btn_save_as;
        private ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem поискСПомощьюBingToolStripMenuItem;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem найтиДалееToolStripMenuItem;
        private ToolStripMenuItem заменитьToolStripMenuItem;
        private ToolStripMenuItem перейтиToolStripMenuItem;
        private ToolStripMenuItem выделелитьВсеToolStripMenuItem;
        private ToolStripMenuItem времяИДатаToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem about;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private ToolStripMenuItem просмотретьСправкуToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem уменьшитьToolStripMenuItem;
        private ToolStripMenuItem восстановитьМасштабПоУмолчаниюToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
    }
}