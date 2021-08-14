using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace quizmaker
{
    public partial class Form1 : MaterialForm
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
        

        private void StartButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            dataLoader.LoadData(richTextBox2);
            quizManager.StartQuiz(dataLoader, i, totalquestionsnmbr_label, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
            NextButton.Enabled = true;
            i++;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
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
                Console.WriteLine("Koniec pytań.");
            }
        }
    } }
