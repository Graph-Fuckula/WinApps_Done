namespace DesktopApp1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        bool newOperation = true;
        double firstValue;
        double secondValue;
        double result = 0.0;
        string operation = "";

        private void allBtnClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (newOperation)
            {
                Display.Text = "";
                newOperation = false;
            }

            if (btn.Text == ",")
            {
                if (Display.Text.Contains(","))
                {
                    return;
                }
            }
            Display.Text += btn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void operationClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            firstValue = Convert.ToDouble(Display.Text);
            newOperation = true;
        }
        private void btn_equal(object sender, EventArgs e)
        {
            secondValue = Convert.ToDouble(Display.Text);
            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "X":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if (secondValue != 0)
                    {
                        result = firstValue / secondValue;
                    }
                    else
                    {
                        Display.Text = "Деление на ноль";
                    }
                    break;
            }
            Display.Text = result.ToString();
            newOperation = true;
        }

        private void del_Click(object sender, EventArgs e)
        {

        }
    }
}