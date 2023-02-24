namespace Tic_Tac_Toe
{
    public partial class FormMain : Form
    {
        char turn = 'x';
        int count1 = 0;
        int count2 = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (turn == 'x')
            {
                if (btn.Text == "")
                {
                    btn.Text = "x";
                    if (IsWinner())
                    {
                        count1++;
                        score1.Text = count1.ToString();
                        MessageBox.Show("X is Winner!!!");
                        Clear();
                        turn = 'x';
                    }
                    else if(IsDraw())
                    {
                        MessageBox.Show("Draw");
                        Clear();
                        turn = 'x';
                    }
                    else
                        turn = 'o';
                }
            }
            else if (turn == 'o')
            {
                if (btn.Text == "")
                {
                    btn.Text = "o";
                    if (IsWinner())
                    {
                        count2++;
                        score2.Text = count2.ToString();
                        MessageBox.Show("O is winner!!!");
                        Clear();
                    }
                    else if (IsDraw())
                    {
                        MessageBox.Show("Draw");
                        Clear();
                    }
                    turn = 'x';
                }
            }
        }
        private bool IsWinner()
        {
            if ((btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn2.Text != "") ||
                (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn4.Text != "") ||
                (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn5.Text != "") ||
                (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn5.Text != "") ||
                (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn5.Text != "") ||
                (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn6.Text != "") ||
                (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn5.Text != "") ||
                (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn8.Text != ""))
                return true;
            else
                return false;

        }
        private bool IsDraw()
        {
            if (btn1.Text != "" &&
            btn2.Text != "" &&
            btn3.Text != "" &&
            btn4.Text != "" &&
            btn5.Text != "" &&
            btn6.Text != "" &&
            btn7.Text != "" &&
            btn8.Text != "" &&
            btn9.Text != "" && !IsWinner())
                return true;
            else
                return false;
        }
        private void Clear()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }
        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}