
namespace quizmaker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.questionnmbr_label = new System.Windows.Forms.Label();
            this.answera_radiobtn = new System.Windows.Forms.RadioButton();
            this.answerb_radiobtn = new System.Windows.Forms.RadioButton();
            this.answerc_radiobtn = new System.Windows.Forms.RadioButton();
            this.answerd_radiobtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.questiontxt_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 68);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "Check correctness";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(496, 248);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(227, 144);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(578, 427);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(132, 153);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pytanie nr. ";
            // 
            // questionnmbr_label
            // 
            this.questionnmbr_label.AutoSize = true;
            this.questionnmbr_label.Location = new System.Drawing.Point(78, 9);
            this.questionnmbr_label.Name = "questionnmbr_label";
            this.questionnmbr_label.Size = new System.Drawing.Size(12, 13);
            this.questionnmbr_label.TabIndex = 9;
            this.questionnmbr_label.Text = "x";
            // 
            // answera_radiobtn
            // 
            this.answera_radiobtn.AutoSize = true;
            this.answera_radiobtn.Location = new System.Drawing.Point(35, 59);
            this.answera_radiobtn.Name = "answera_radiobtn";
            this.answera_radiobtn.Size = new System.Drawing.Size(85, 17);
            this.answera_radiobtn.TabIndex = 14;
            this.answera_radiobtn.TabStop = true;
            this.answera_radiobtn.Text = "radioButton1";
            this.answera_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answerb_radiobtn
            // 
            this.answerb_radiobtn.AutoSize = true;
            this.answerb_radiobtn.Location = new System.Drawing.Point(35, 82);
            this.answerb_radiobtn.Name = "answerb_radiobtn";
            this.answerb_radiobtn.Size = new System.Drawing.Size(85, 17);
            this.answerb_radiobtn.TabIndex = 15;
            this.answerb_radiobtn.TabStop = true;
            this.answerb_radiobtn.Text = "radioButton2";
            this.answerb_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answerc_radiobtn
            // 
            this.answerc_radiobtn.AutoSize = true;
            this.answerc_radiobtn.Location = new System.Drawing.Point(34, 103);
            this.answerc_radiobtn.Name = "answerc_radiobtn";
            this.answerc_radiobtn.Size = new System.Drawing.Size(85, 17);
            this.answerc_radiobtn.TabIndex = 17;
            this.answerc_radiobtn.TabStop = true;
            this.answerc_radiobtn.Text = "radioButton3";
            this.answerc_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answerd_radiobtn
            // 
            this.answerd_radiobtn.AutoSize = true;
            this.answerd_radiobtn.Location = new System.Drawing.Point(34, 126);
            this.answerd_radiobtn.Name = "answerd_radiobtn";
            this.answerd_radiobtn.Size = new System.Drawing.Size(85, 17);
            this.answerd_radiobtn.TabIndex = 16;
            this.answerd_radiobtn.TabStop = true;
            this.answerd_radiobtn.Text = "radioButton4";
            this.answerd_radiobtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Dalej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(320, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 68);
            this.button4.TabIndex = 23;
            this.button4.Text = "Start";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // questiontxt_label
            // 
            this.questiontxt_label.AutoSize = true;
            this.questiontxt_label.Location = new System.Drawing.Point(23, 31);
            this.questiontxt_label.Name = "questiontxt_label";
            this.questiontxt_label.Size = new System.Drawing.Size(49, 13);
            this.questiontxt_label.TabIndex = 24;
            this.questiontxt_label.Text = "Question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 625);
            this.Controls.Add(this.questiontxt_label);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerc_radiobtn);
            this.Controls.Add(this.answerd_radiobtn);
            this.Controls.Add(this.answerb_radiobtn);
            this.Controls.Add(this.answera_radiobtn);
            this.Controls.Add(this.questionnmbr_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questionnmbr_label;
        private System.Windows.Forms.RadioButton answera_radiobtn;
        private System.Windows.Forms.RadioButton answerb_radiobtn;
        private System.Windows.Forms.RadioButton answerc_radiobtn;
        private System.Windows.Forms.RadioButton answerd_radiobtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label questiontxt_label;
    }
}

