using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizmaker
{
    class QuizManager
    {
        int correct_answers = 0, wrong_answers = 0;
        public void StartQuiz(DataLoader dataLoader, int i, Label totalquestionsnmbr_label, Label labelnmbr, Label questiontxt, RadioButton answera, RadioButton answerb, RadioButton answerc, RadioButton answerd)
        {
            totalquestionsnmbr_label.Text = (dataLoader.questions.Count).ToString();
           

            if (i >= 1) {
               
                if (answera.Checked && answera.Text == dataLoader.questions[i-1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++;}
                else if (answera.Checked && answera.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }
                if (answerb.Checked && answerb.Text == dataLoader.questions[i-1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
                else if (answerb.Checked && answerb.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }
                if (answerc.Checked && answerc.Text == dataLoader.questions[i-1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
                else if (answerc.Checked && answerb.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }
                if (answerd.Checked && answerd.Text == dataLoader.questions[i-1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
                else if (answerd.Checked && answerb.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }
                Console.WriteLine("Poprawne odpowiedzi: " + correct_answers.ToString());
                Console.WriteLine("Złe odpowiedzi: " + wrong_answers.ToString());
            }
            
            
            labelnmbr.Text = (i + 1).ToString();
            questiontxt.Text = dataLoader.questions[i].content;
            answera.Text = dataLoader.questions[i].answerA;
            answerb.Text = dataLoader.questions[i].answerB;
            answerc.Text = dataLoader.questions[i].answerC;
            answerd.Text = dataLoader.questions[i].answerD;
            answera.Checked = false;
            answerb.Checked = false;
            answerc.Checked = false;
            answerd.Checked = false;
            
           
            
            



        }
    }
}
