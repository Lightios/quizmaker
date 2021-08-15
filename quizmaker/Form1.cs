using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace quizmaker
{
    public partial class Form1 : Form
    {
        public static bool isopen = false;
        int i = 0;
        DataLoader dataLoader = new DataLoader();
        QuizManager quizManager = new QuizManager();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            i = 0;
            dataLoader.LoadData(richTextBox2);
            quizManager.StartQuiz(dataLoader, i, totalquestionsnmbr_label, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
            NextButton.Enabled = true;
            i++;
            //if(isopen == false)
            //{
            //    QuizForm quizForm = new QuizForm();
            //    quizForm.Show();
            //    isopen = true;
            //
            //}
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (answera_radiobtn.Checked == false & answerb_radiobtn.Checked == false & answerc_radiobtn.Checked == false & answerd_radiobtn.Checked == false)
            {
                MessageBox.Show("Zaznacz odpowiedź.");
                return;
            }

            if (i < dataLoader.questions.Count)
            {
                quizManager.CheckAnswer(dataLoader, i, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
                i++;
            }
            else
            {
                quizManager.CheckAnswer(dataLoader, i, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
                Console.WriteLine("Koniec pytań.");
                if (quizManager.wrong_answers > 0)
                {
                    var result = MessageBox.Show("Czy chcesz powtórzyć źle odpowiedziane pytania?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        i = 0;
                        dataLoader.questions = new List<Question>(quizManager.wrongAnsweredQuestions);
                        quizManager.StartQuiz(dataLoader, i, totalquestionsnmbr_label, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
                        i++;
                    }
                    else
                    {
                        i = 0;
                        dataLoader.LoadData(richTextBox2);
                        quizManager.StartQuiz(dataLoader, i, totalquestionsnmbr_label, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
                        NextButton.Enabled = true;
                        i++;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
