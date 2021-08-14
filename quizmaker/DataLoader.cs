﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizmaker
{
    internal class DataLoader
    {
        public List<Question> questions = new List<Question>();

        public void Fun(RichTextBox textBox) 
        {
            string[] data = System.IO.File.ReadAllLines("Data.txt");
            textBox.Clear();
            int i = 0;

            foreach (string line in data)
            {
                i++;

                // Validation 
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

            // Creating questions objects % saving answer
            for (int x = 0; x < data.Length / 7; x++)
            {
                
                if(data[x * 7 + 5] == "A" | data[x * 7 + 5] == "a")
                {
                    data[x * 7 + 5] = data[x * 7 + 1];
                }
                if (data[x * 7 + 5] == "B" | data[x * 7 + 5] == "b")
                {
                    data[x * 7 + 5] = data[x * 7 + 2];
                }
                if (data[x * 7 + 5] == "C" | data[x * 7 + 5] == "c")
                {
                    data[x * 7 + 5] = data[x * 7 + 3];
                }
                if (data[x * 7 + 5] == "D" | data[x * 7 + 5] == "d")
                {
                    data[x * 7 + 5] = data[x * 7 + 4];
                }
                Question current = new Question
                {
                    content = data[x * 7],
                    answerA = data[x * 7 + 1],
                    answerB = data[x * 7 + 2],
                    answerC = data[x * 7 + 3],
                    answerD = data[x * 7 + 4],
                    correctAnswer = data[x * 7 + 5]
                };                
                questions.Add(current);
            }

            //foreach (var question in questions)
            //{
              
            //}

        }
    }
}
