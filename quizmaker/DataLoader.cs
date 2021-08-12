using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizmaker
{
    internal class DataLoader
    {

        Form1 Form;

        public void Fun(System.Windows.Forms.RichTextBox textBox) 
        {
            string[] data = System.IO.File.ReadAllLines("Data.txt");

            foreach (string line in data)
            {
                textBox.AppendText(line + "\n");
            }
        }
    }
}
