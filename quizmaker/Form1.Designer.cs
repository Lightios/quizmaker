
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.NextButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.answera_radiobtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.answerb_radiobtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.answerc_radiobtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.answerd_radiobtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.questionnmbr_label = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.totalquestionsnmbr_label = new MaterialSkin.Controls.MaterialLabel();
            this.questiontxt_label = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(514, 99);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(227, 144);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Pytania";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(378, 207);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 27;
            this.materialFlatButton1.Text = "Start";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // NextButton
            // 
            this.NextButton.AutoSize = true;
            this.NextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NextButton.Depth = 0;
            this.NextButton.Icon = null;
            this.NextButton.Location = new System.Drawing.Point(253, 169);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NextButton.Name = "NextButton";
            this.NextButton.Primary = false;
            this.NextButton.Size = new System.Drawing.Size(62, 36);
            this.NextButton.TabIndex = 28;
            this.NextButton.Text = "Dalej";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // answera_radiobtn
            // 
            this.answera_radiobtn.AutoSize = true;
            this.answera_radiobtn.Depth = 0;
            this.answera_radiobtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.answera_radiobtn.Location = new System.Drawing.Point(27, 128);
            this.answera_radiobtn.Margin = new System.Windows.Forms.Padding(0);
            this.answera_radiobtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answera_radiobtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answera_radiobtn.Name = "answera_radiobtn";
            this.answera_radiobtn.Ripple = true;
            this.answera_radiobtn.Size = new System.Drawing.Size(163, 30);
            this.answera_radiobtn.TabIndex = 29;
            this.answera_radiobtn.TabStop = true;
            this.answera_radiobtn.Text = "materialRadioButton1";
            this.answera_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answerb_radiobtn
            // 
            this.answerb_radiobtn.AutoSize = true;
            this.answerb_radiobtn.Depth = 0;
            this.answerb_radiobtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.answerb_radiobtn.Location = new System.Drawing.Point(27, 158);
            this.answerb_radiobtn.Margin = new System.Windows.Forms.Padding(0);
            this.answerb_radiobtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerb_radiobtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerb_radiobtn.Name = "answerb_radiobtn";
            this.answerb_radiobtn.Ripple = true;
            this.answerb_radiobtn.Size = new System.Drawing.Size(163, 30);
            this.answerb_radiobtn.TabIndex = 30;
            this.answerb_radiobtn.TabStop = true;
            this.answerb_radiobtn.Text = "materialRadioButton2";
            this.answerb_radiobtn.UseVisualStyleBackColor = true;
            // 
            // answerc_radiobtn
            // 
            this.answerc_radiobtn.AutoSize = true;
            this.answerc_radiobtn.BackColor = System.Drawing.Color.Transparent;
            this.answerc_radiobtn.Depth = 0;
            this.answerc_radiobtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.answerc_radiobtn.Location = new System.Drawing.Point(27, 188);
            this.answerc_radiobtn.Margin = new System.Windows.Forms.Padding(0);
            this.answerc_radiobtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerc_radiobtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerc_radiobtn.Name = "answerc_radiobtn";
            this.answerc_radiobtn.Ripple = true;
            this.answerc_radiobtn.Size = new System.Drawing.Size(163, 30);
            this.answerc_radiobtn.TabIndex = 31;
            this.answerc_radiobtn.TabStop = true;
            this.answerc_radiobtn.Text = "materialRadioButton3";
            this.answerc_radiobtn.UseVisualStyleBackColor = false;
            // 
            // answerd_radiobtn
            // 
            this.answerd_radiobtn.AutoSize = true;
            this.answerd_radiobtn.Depth = 0;
            this.answerd_radiobtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.answerd_radiobtn.Location = new System.Drawing.Point(27, 218);
            this.answerd_radiobtn.Margin = new System.Windows.Forms.Padding(0);
            this.answerd_radiobtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.answerd_radiobtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerd_radiobtn.Name = "answerd_radiobtn";
            this.answerd_radiobtn.Ripple = true;
            this.answerd_radiobtn.Size = new System.Drawing.Size(163, 30);
            this.answerd_radiobtn.TabIndex = 32;
            this.answerd_radiobtn.TabStop = true;
            this.answerd_radiobtn.Text = "materialRadioButton4";
            this.answerd_radiobtn.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 67);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 33;
            this.materialLabel1.Text = "Pytanie nr: ";
            // 
            // questionnmbr_label
            // 
            this.questionnmbr_label.AutoSize = true;
            this.questionnmbr_label.Depth = 0;
            this.questionnmbr_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.questionnmbr_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questionnmbr_label.Location = new System.Drawing.Point(112, 67);
            this.questionnmbr_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionnmbr_label.Name = "questionnmbr_label";
            this.questionnmbr_label.Size = new System.Drawing.Size(16, 19);
            this.questionnmbr_label.TabIndex = 34;
            this.questionnmbr_label.Text = "x";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(134, 67);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(15, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "/";
            // 
            // totalquestionsnmbr_label
            // 
            this.totalquestionsnmbr_label.AutoSize = true;
            this.totalquestionsnmbr_label.Depth = 0;
            this.totalquestionsnmbr_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalquestionsnmbr_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalquestionsnmbr_label.Location = new System.Drawing.Point(155, 67);
            this.totalquestionsnmbr_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalquestionsnmbr_label.Name = "totalquestionsnmbr_label";
            this.totalquestionsnmbr_label.Size = new System.Drawing.Size(16, 19);
            this.totalquestionsnmbr_label.TabIndex = 36;
            this.totalquestionsnmbr_label.Text = "x";
            // 
            // questiontxt_label
            // 
            this.questiontxt_label.AutoSize = true;
            this.questiontxt_label.Depth = 0;
            this.questiontxt_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.questiontxt_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.questiontxt_label.Location = new System.Drawing.Point(24, 93);
            this.questiontxt_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.questiontxt_label.Name = "questiontxt_label";
            this.questiontxt_label.Size = new System.Drawing.Size(0, 19);
            this.questiontxt_label.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 266);
            this.Controls.Add(this.questiontxt_label);
            this.Controls.Add(this.totalquestionsnmbr_label);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.questionnmbr_label);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.answerd_radiobtn);
            this.Controls.Add(this.answerc_radiobtn);
            this.Controls.Add(this.answerb_radiobtn);
            this.Controls.Add(this.answera_radiobtn);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox2);
            this.Name = "Form1";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton NextButton;
        private MaterialSkin.Controls.MaterialRadioButton answera_radiobtn;
        private MaterialSkin.Controls.MaterialRadioButton answerb_radiobtn;
        private MaterialSkin.Controls.MaterialRadioButton answerc_radiobtn;
        private MaterialSkin.Controls.MaterialRadioButton answerd_radiobtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel questionnmbr_label;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel totalquestionsnmbr_label;
        private MaterialSkin.Controls.MaterialLabel questiontxt_label;
    }
}

