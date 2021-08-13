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

        public void StartQuiz(DataLoader dataLoader, int i, Label labelnmbr, Label questiontxt, RadioButton answera, RadioButton answerb, RadioButton answerc, RadioButton answerd)
        {
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
