namespace Anket_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label1 = new Label();
            txtBoxName = new TextBox();
            txtBoxSurname = new TextBox();
            label2 = new Label();
            dtpBirtDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dtpEntryDate = new DateTimePicker();
            label5 = new Label();
            rbAzerbaijan = new RadioButton();
            rbEnglish = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            cmbSpeciality = new ComboBox();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(138, 8);
            label6.Name = "label6";
            label6.Size = new Size(224, 69);
            label6.TabIndex = 11;
            label6.Text = "Anket";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(92, 158, 173);
            label1.Location = new Point(153, 114);
            label1.Name = "label1";
            label1.Size = new Size(77, 27);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(236, 111);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(182, 34);
            txtBoxName.TabIndex = 1;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(236, 168);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(182, 34);
            txtBoxSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(92, 158, 173);
            label2.Location = new Point(114, 171);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 2;
            label2.Text = "Surname:";
            // 
            // dtpBirtDate
            // 
            dtpBirtDate.CalendarTitleForeColor = Color.Black;
            dtpBirtDate.Cursor = Cursors.Hand;
            dtpBirtDate.Location = new Point(236, 223);
            dtpBirtDate.Name = "dtpBirtDate";
            dtpBirtDate.Size = new Size(232, 34);
            dtpBirtDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(92, 158, 173);
            label3.Location = new Point(36, 229);
            label3.Name = "label3";
            label3.Size = new Size(194, 27);
            label3.TabIndex = 5;
            label3.Text = "Date Of Birth:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(92, 158, 173);
            label4.Location = new Point(75, 290);
            label4.Name = "label4";
            label4.Size = new Size(155, 27);
            label4.TabIndex = 6;
            label4.Text = "Entry Date:";
            // 
            // dtpEntryDate
            // 
            dtpEntryDate.Cursor = Cursors.Hand;
            dtpEntryDate.Location = new Point(236, 284);
            dtpEntryDate.Name = "dtpEntryDate";
            dtpEntryDate.Size = new Size(232, 34);
            dtpEntryDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(92, 158, 173);
            label5.Location = new Point(10, 411);
            label5.Name = "label5";
            label5.Size = new Size(220, 27);
            label5.TabIndex = 8;
            label5.Text = "Native Language:";
            // 
            // rbAzerbaijan
            // 
            rbAzerbaijan.AutoSize = true;
            rbAzerbaijan.Cursor = Cursors.Hand;
            rbAzerbaijan.ForeColor = SystemColors.ButtonFace;
            rbAzerbaijan.Location = new Point(19, 18);
            rbAzerbaijan.Name = "rbAzerbaijan";
            rbAzerbaijan.Size = new Size(163, 31);
            rbAzerbaijan.TabIndex = 9;
            rbAzerbaijan.TabStop = true;
            rbAzerbaijan.Text = "Azerbaijan";
            rbAzerbaijan.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            rbEnglish.AutoSize = true;
            rbEnglish.Cursor = Cursors.Hand;
            rbEnglish.ForeColor = SystemColors.ButtonFace;
            rbEnglish.Location = new Point(19, 64);
            rbEnglish.Name = "rbEnglish";
            rbEnglish.Size = new Size(124, 31);
            rbEnglish.TabIndex = 10;
            rbEnglish.TabStop = true;
            rbEnglish.Text = "English";
            rbEnglish.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(92, 158, 173);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 88);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(92, 158, 173);
            panel2.Location = new Point(1, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 38);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(92, 158, 173);
            panel3.Controls.Add(rbAzerbaijan);
            panel3.Controls.Add(rbEnglish);
            panel3.Location = new Point(236, 411);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 111);
            panel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(92, 158, 173);
            label7.Location = new Point(75, 352);
            label7.Name = "label7";
            label7.Size = new Size(155, 27);
            label7.TabIndex = 15;
            label7.Text = "Speciality:";
            // 
            // cmbSpeciality
            // 
            cmbSpeciality.Cursor = Cursors.Hand;
            cmbSpeciality.FormattingEnabled = true;
            cmbSpeciality.Items.AddRange(new object[] { "Design", "IT", "Programming" });
            cmbSpeciality.Location = new Point(236, 349);
            cmbSpeciality.Name = "cmbSpeciality";
            cmbSpeciality.Size = new Size(199, 35);
            cmbSpeciality.TabIndex = 16;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(92, 158, 173);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.ForeColor = SystemColors.ButtonFace;
            btnSubmit.Location = new Point(194, 556);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 49);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(489, 657);
            Controls.Add(btnSubmit);
            Controls.Add(cmbSpeciality);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(dtpEntryDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpBirtDate);
            Controls.Add(txtBoxSurname);
            Controls.Add(label2);
            Controls.Add(txtBoxName);
            Controls.Add(label1);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anket Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
        private Label label2;
        private DateTimePicker dtpBirtDate;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpEntryDate;
        private Label label5;
        private RadioButton rbAzerbaijan;
        private RadioButton rbEnglish;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private ComboBox cmbSpeciality;
        private Button btnSubmit;
    }
}