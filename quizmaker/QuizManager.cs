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
        string[] answers = {"", "", "", ""};
        List<int> indexes = new List<int>();

        Random rnd = new Random();

        int correct_answers = 0, wrong_answers = 0; 
        public List<Question> wrongAnsweredQuestions = new List<Question>();
        string answer;

        public void StartQuiz(DataLoader dataLoader, int i, Label totalquestionsnmbr_label, Label labelnmbr, Label questiontxt, RadioButton answera, RadioButton answerb, RadioButton answerc, RadioButton answerd)
        {
            RefreshLabels(dataLoader, i, labelnmbr, questiontxt, answera, answerb, answerc, answerd);
            totalquestionsnmbr_label.Text = (dataLoader.questions.Count).ToString();
        }

        public void RefreshLabels(DataLoader dataLoader, int i, Label labelnmbr, Label questiontxt, RadioButton answera, RadioButton answerb, RadioButton answerc, RadioButton answerd)
        {
            labelnmbr.Text = (i + 1).ToString();
            questiontxt.Text = dataLoader.questions[i].content;

            // Add indexes to list
            for (int x = 0; x < 4; x++)
                indexes.Add(x);

            // Set answer A to random index and remove that index from list
            int random = rnd.Next(0, 4);
            answers[indexes[random]] = dataLoader.questions[i].answerA;
            indexes.Remove(indexes[random]);

            // B
            random = rnd.Next(0, 3);
            answers[indexes[random]] = dataLoader.questions[i].answerB;
            indexes.Remove(indexes[random]);

            // C
            random = rnd.Next(0, 2);
            answers[indexes[random]] = dataLoader.questions[i].answerC;
            indexes.Remove(indexes[random]);

            // D
            answers[indexes[0]] = dataLoader.questions[i].answerD;
            indexes.Remove(indexes[0]);

            // Set labels to randomized answers
            answera.Text = answers[0];
            answerb.Text = answers[1];
            answerc.Text = answers[2];
            answerd.Text = answers[3];

            answera.Checked = false;
            answerb.Checked = false;
            answerc.Checked = false;
            answerd.Checked = false;
        }

        public void CheckAnswer(DataLoader dataLoader, int i, Label labelnmbr, Label questiontxt, RadioButton answera, RadioButton answerb, RadioButton answerc, RadioButton answerd)
        {
            if (answera.Checked) answer = answera.Text;
            else if (answerb.Checked) answer = answerb.Text;
            else if (answerc.Checked) answer = answerc.Text;
            else if (answerd.Checked) answer = answerd.Text;

            /*
            if (answera.Checked && answera.Text == dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
            else if (answera.Checked && answera.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }

            if (answerb.Checked && answerb.Text == dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
            else if (answerb.Checked && answerb.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }

            if (answerc.Checked && answerc.Text == dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
            else if (answerc.Checked && answerc.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }

            if (answerd.Checked && answerd.Text == dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); correct_answers++; }
            else if (answerd.Checked && answerd.Text != dataLoader.questions[i - 1].correctAnswer) { Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); wrong_answers++; }
            */

            if (answer == dataLoader.questions[i - 1].correctAnswer)
            {
                Console.WriteLine("Pytanie nr. " + i + " Poprawna odpowiedź!"); 
                correct_answers++; 
            }
            else
            {
                Console.WriteLine("Pytanie nr. " + i + " Zła odpowiedź!"); 
                wrong_answers++;
                wrongAnsweredQuestions.Add(dataLoader.questions[i - 1]);
            }

            Console.WriteLine("Poprawne odpowiedzi: " + correct_answers.ToString());
            Console.WriteLine("Złe odpowiedzi: " + wrong_answers.ToString());

            if (i < dataLoader.questions.Count)
                RefreshLabels(dataLoader, i, labelnmbr, questiontxt, answera, answerb, answerc, answerd);

            foreach (var question in wrongAnsweredQuestions)
            {
                Console.WriteLine(question.content);
            }
        }
    }
}
