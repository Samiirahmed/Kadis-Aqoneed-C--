using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class Quiz_Form : Form
    {
        public Quiz_Form()
        {
            InitializeComponent();
        }

        // create an array of questions
        string[] questions = { "200 - 173 = ?", "100 + 1000 = ?", "300 x 50 = ?", "400 / 10 = ?", "100 - 100 = ?", };

        // create an array of options
        // 5 questions
        // 5 options
        // the last option will be the correct answer
        // and we will use it to check if the user selected the correct answer
        string[,] options = new string[5, 5] {{"100","123","27","28","27"}, 
                                               {"1100","500","900","2000","1100"},
                                                {"1700","15000","20000","30000","15000"},
                                                 {"4","4000","400","40","40"},
                                                  {"0","1","90","100","0"}};

      




        int index = 0, correct = 0;

        // create a function to check if the user has selected the correct answer
        public void checkAnswer(RadioButton rbt)
        {
            // the 4th item(we start from 0) is the correct answer in every question
            if(rbt.Text.Equals(options[index,4]))
            {
                correct++;
                // you can make the correct answer become green
                // and the wrang anwer red
                rbt.BackColor = Color.Green;
            }
            else
            {
                rbt.BackColor = Color.Red;
            }

            index++;
            // disable radiobuttons
            setEnable(false);
        }

        // create a function to uncheck radiobuttons
        public void uncheck()
        {
            radioButtonOption_1.Checked = false;
            radioButtonOption_2.Checked = false;
            radioButtonOption_3.Checked = false;
            radioButtonOption_4.Checked = false;
        }

        // create a function to change radiobuttons backcolor and color
        public void resetRadio()
        {
            // we are gonna use the foreach loop 
            // the color change automatically when disabled
            foreach(Control c in this.Controls)
            {
                if(c is RadioButton)
                {
                    RadioButton rdb = (RadioButton)c;
                    rdb.BackColor = Color.White;
                }
            }
        }

        // create a function to enable/disable radiobuttons
        public void setEnable(Boolean yes_or_no)
        {
            radioButtonOption_1.Enabled = yes_or_no;
            radioButtonOption_2.Enabled = yes_or_no;
            radioButtonOption_3.Enabled = yes_or_no;
            radioButtonOption_4.Enabled = yes_or_no;
        }

        private void Quiz_Form_Load(object sender, EventArgs e)
        {
            // call the button click even
            button_Next.PerformClick();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            resetRadio();

            if (button_Next.Text.Equals("Restart The Quiz"))
            {
                index = 0;
                correct = 0;
                richTextBox_Question.BackColor = Color.White;
                richTextBox_Question.ForeColor = Color.Black;
                button_Next.Text = "Next";
            }

            string user_out = OUTTXT.Text;

            if (index == questions.Length)
            {
                richTextBox_Question.Text = "Your Name is : " + user_out + "\n" +"Your Score:" + correct + " / " + questions.Length;

                if(correct >= (float)questions.Length/2)
                {
                    richTextBox_Question.BackColor = Color.Green;
                    richTextBox_Question.ForeColor = Color.White;
                }
                else
                {
                    richTextBox_Question.BackColor = Color.Red;
                    richTextBox_Question.ForeColor = Color.White;
                }

                button_Next.Text = "Restart The Quiz";
                OUTTXT.Text = "";

            }

            else
            {
                // enable radiobuttons
                setEnable(true);
                // uncheck radiobuttons
                uncheck();
                // display the question
                richTextBox_Question.Text = questions[index];
                // display options
                radioButtonOption_1.Text = options[index, 0];
                radioButtonOption_2.Text = options[index, 1];
                radioButtonOption_3.Text = options[index, 2];
                radioButtonOption_4.Text = options[index, 3];

                if(index == questions.Length - 1)
                {
                    button_Next.Text = "Finish And See Your Results";
                }
            }
        }

        private void radioButtonOption_1_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption_1);
        }

        private void radioButtonOption_2_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption_2);
        }

        private void radioButtonOption_3_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption_3);
        }

        private void radioButtonOption_4_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption_4);
        }
    }
}
