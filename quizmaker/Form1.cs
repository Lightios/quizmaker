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
            dataLoader.Fun(richTextBox2);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            quizManager.StartQuiz(dataLoader, i,questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answera_radiobtn.Checked == false & answerb_radiobtn.Checked == false & answerc_radiobtn.Checked == false & answerd_radiobtn.Checked == false)
            {
                MessageBox.Show("Zaznacz odpowiedź.");
                return;
            }       
            
            i++;
            quizManager.StartQuiz(dataLoader, i, questionnmbr_label, questiontxt_label, answera_radiobtn, answerb_radiobtn, answerc_radiobtn, answerd_radiobtn);
            
        }
    } }
