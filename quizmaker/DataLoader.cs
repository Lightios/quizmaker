using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace quizmaker
{
    internal class DataLoader
    {       

        public void Fun(System.Windows.Forms.RichTextBox textBox) 
        {
            string[] data = System.IO.File.ReadAllLines("Data.txt");
            textBox.Clear();
            int i = 0;
            foreach (string line in data)
            {
                i++;
                if(i%7 == 0)
                {
                    if (line != "")
                    {
                        MessageBox.Show("There is no empty line for question separator.");
                    }
                }
                if((i-6)%7 == 0)
                {
                    if(line != "A" & line != "B" & line != "C" & line != "D" & line != "a" & line != "b" & line != "c" & line != "d" )
                    {
                        MessageBox.Show("There is no answer char." + i.ToString());
                    }
                }
                textBox.AppendText(line + "\n");
            }
        }
    }
}
