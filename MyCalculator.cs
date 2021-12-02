namespace DZ01_2
{
    public partial class MyCalculator : Form
    {
        bool havePoint = false;
        string operation = "";

        float firstArg = 0;
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void MyCalculator_Shown(object sender, EventArgs e)
        {
            int buttonWidth = (ClientSize.Width - 15) / 4;
            int buttonHeight = (ClientSize.Height - 110 - 25) / 5;

            btCE.Left = 0;
            btCE.Top = 110;
            btCE.Width = buttonWidth;
            btCE.Height = buttonHeight;

            btC.Left = buttonWidth + 5;
            btC.Top = 110;
            btC.Width = buttonWidth;
            btC.Height = buttonHeight;

            btBackSpace.Left = 2*(buttonWidth + 5);
            btBackSpace.Top = 110;
            btBackSpace.Width = buttonWidth;
            btBackSpace.Height = buttonHeight;

            btDivision.Left = 3 * (buttonWidth + 5);
            btDivision.Top = 110;
            btDivision.Width = buttonWidth;
            btDivision.Height = buttonHeight;

            bt7.Left = 0;
            bt7.Top = 110 + 5 + buttonHeight; 
            bt7.Width = buttonWidth;
            bt7.Height = buttonHeight;

            bt8.Left = buttonWidth + 5;
            bt8.Top = 110 + 5 + buttonHeight;
            bt8.Width = buttonWidth;
            bt8.Height = buttonHeight;

            bt9.Left = 2 * (buttonWidth + 5);
            bt9.Top = 110 + 5 + buttonHeight;
            bt9.Width = buttonWidth;
            bt9.Height = buttonHeight;

            btMulti.Left = 3 * (buttonWidth + 5);
            btMulti.Top = 110 + 5 + buttonHeight;
            btMulti.Width = buttonWidth;
            btMulti.Height = buttonHeight;

            bt4.Left = 0;
            bt4.Top = 110 + 2 * (5 + buttonHeight);
            bt4.Width = buttonWidth;
            bt4.Height = buttonHeight;

            bt5.Left = buttonWidth + 5;
            bt5.Top = 110 + 2 * (5 + buttonHeight);
            bt5.Width = buttonWidth;
            bt5.Height = buttonHeight;

            bt6.Left = 2 * (buttonWidth + 5);
            bt6.Top = 110 + 2 * (5 + buttonHeight);
            bt6.Width = buttonWidth;
            bt6.Height = buttonHeight;

            btMinus.Left = 3 * (buttonWidth + 5);
            btMinus.Top = 110 + 2 * (5 + buttonHeight);
            btMinus.Width = buttonWidth;
            btMinus.Height = buttonHeight;

            bt1.Left = 0;
            bt1.Top = 110 + 3 * (5 + buttonHeight);
            bt1.Width = buttonWidth;
            bt1.Height = buttonHeight;

            bt2.Left = buttonWidth + 5;
            bt2.Top = 110 + 3 * (5 + buttonHeight);
            bt2.Width = buttonWidth;
            bt2.Height = buttonHeight;

            bt3.Left = 2 * (buttonWidth + 5);
            bt3.Top = 110 + 3 * (5 + buttonHeight);
            bt3.Width = buttonWidth;
            bt3.Height = buttonHeight;

            btPlus.Left = 3 * (buttonWidth + 5);
            btPlus.Top = 110 + 3 * (5 + buttonHeight);
            btPlus.Width = buttonWidth;
            btPlus.Height = buttonHeight;

            bt0.Left = 0;
            bt0.Top = 110 + 4 * (5 + buttonHeight);
            bt0.Width = buttonWidth;
            bt0.Height = buttonHeight;

            btPoint.Left = buttonWidth + 5;
            btPoint.Top = 110 + 4 * (5 + buttonHeight);
            btPoint.Width = buttonWidth;
            btPoint.Height = buttonHeight;

            btEquals.Left = 2 * (buttonWidth + 5);
            btEquals.Top = 110 + 4 * (5 + buttonHeight);
            btEquals.Width = 2 * buttonWidth + 5;
            btEquals.Height = buttonHeight;

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            if (tbMain.Text == "")
            {
                tbMain.Text = "0";
            }
            if (tbMain.Text != "0")
            {
                tbMain.Text = tbMain.Text + '0';
                tbHistory.Text = tbHistory.Text + '0';
            }

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
            {
                tbMain.Text = tbMain.Text + ((Button)sender).Text;
            }
            if (tbMain.Text == "" || tbMain.Text == "0") 
            {
                tbMain.Text = ((Button)sender).Text;
            }
            tbHistory.Text = tbHistory.Text+((Button)sender).Text;
        }

        private void btPoint_Click(object sender, EventArgs e)
        {
            if (!havePoint) 
            {
                havePoint = true;
                if (tbMain.Text == "")
                {
                    tbMain.Text = "0,";
                    tbHistory.Text = tbHistory.Text + "0,";
                }
                else
                {
                    tbMain.Text = tbMain.Text + ',';
                    tbHistory.Text = tbHistory.Text + ',';
                }
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            if (operation != "" && tbMain.Text == "") 
            {
                tbHistory.Text = tbHistory.Text.Remove(tbHistory.Text.Length - 3);
                operation = "";
            }
            if (operation == "") 
            {
                if (tbMain.Text == "")
                {
                    if (tbHistory.Text == "")
                    {
                        tbHistory.Text = "0";
                        firstArg = 0;
                    }
                }
                else
                    firstArg = float.Parse(tbMain.Text);
                operation = ((Button)sender).Text;
                tbHistory.Text = tbHistory.Text + ' ' + operation + ' ';
                tbMain.Text = "";
                havePoint = false;
            }
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            
            if (operation!="")
            {
                if (operation == "+")
                {
                    tbMain.Text = (firstArg + float.Parse(tbMain.Text)).ToString();
                    firstArg = 0;
                    operation = "";
                    havePoint = false;
                }
                if (operation == "-")
                {
                    tbMain.Text = (firstArg - float.Parse(tbMain.Text)).ToString();
                    firstArg = 0;
                    operation = "";
                    havePoint = false;
                }
                if (operation == "/")
                {
                    if (tbMain.Text != "0" && tbMain.Text != "")
                    {
                        tbMain.Text = (firstArg / float.Parse(tbMain.Text)).ToString();
                        firstArg = 0;
                        operation = "";
                        havePoint = false;
                    }
                }
                    if (operation == "*")
                {
                    tbMain.Text = (firstArg * float.Parse(tbMain.Text)).ToString();
                    firstArg = 0;
                    operation = "";
                    havePoint = false;
                }
            }
        }

        private void btC_Click(object sender, EventArgs e)
        {
            firstArg = 0;
            operation = "";
            havePoint = false;
            tbMain.Text = "";
            tbHistory.Text = "";
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            tbMain.Text = "";
            if (operation != "")
                tbHistory.Text = firstArg + " " + operation + " ";
            else
                tbHistory.Text = "";

        }

        private void btBackSpace_Click(object sender, EventArgs e)
        {
            if (tbMain.Text.Length > 0) 
            {
                tbMain.Text = tbMain.Text.Remove(tbMain.Text.Length - 1);
                tbHistory.Text = tbHistory.Text.Remove(tbHistory.Text.Length - 1);
            }
        }
    }
}