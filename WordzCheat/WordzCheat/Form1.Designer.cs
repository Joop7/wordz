namespace WordzCheat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_WordsDisplay = new System.Windows.Forms.ListBox();
            this.btn_FindWords = new System.Windows.Forms.Button();
            this.groupBox_InputControls = new System.Windows.Forms.GroupBox();
            this.textBox_BoardLetters = new System.Windows.Forms.TextBox();
            this.checkBox_ManuelInput = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.checkBox_AutoInput = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_InputControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_WordsDisplay
            // 
            this.listBox_WordsDisplay.FormattingEnabled = true;
            this.listBox_WordsDisplay.Location = new System.Drawing.Point(13, 13);
            this.listBox_WordsDisplay.Name = "listBox_WordsDisplay";
            this.listBox_WordsDisplay.Size = new System.Drawing.Size(167, 394);
            this.listBox_WordsDisplay.TabIndex = 0;
            // 
            // btn_FindWords
            // 
            this.btn_FindWords.Enabled = false;
            this.btn_FindWords.Location = new System.Drawing.Point(6, 68);
            this.btn_FindWords.Name = "btn_FindWords";
            this.btn_FindWords.Size = new System.Drawing.Size(154, 35);
            this.btn_FindWords.TabIndex = 1;
            this.btn_FindWords.Text = "Pronađi riječi";
            this.btn_FindWords.UseVisualStyleBackColor = true;
            this.btn_FindWords.Click += new System.EventHandler(this.btn_FindWords_Click);
            // 
            // groupBox_InputControls
            // 
            this.groupBox_InputControls.Controls.Add(this.checkBox_ManuelInput);
            this.groupBox_InputControls.Controls.Add(this.textBox_BoardLetters);
            this.groupBox_InputControls.Controls.Add(this.btn_FindWords);
            this.groupBox_InputControls.Location = new System.Drawing.Point(197, 298);
            this.groupBox_InputControls.Name = "groupBox_InputControls";
            this.groupBox_InputControls.Size = new System.Drawing.Size(167, 109);
            this.groupBox_InputControls.TabIndex = 2;
            this.groupBox_InputControls.TabStop = false;
            // 
            // textBox_BoardLetters
            // 
            this.textBox_BoardLetters.Enabled = false;
            this.textBox_BoardLetters.Location = new System.Drawing.Point(6, 42);
            this.textBox_BoardLetters.MaxLength = 16;
            this.textBox_BoardLetters.Name = "textBox_BoardLetters";
            this.textBox_BoardLetters.Size = new System.Drawing.Size(154, 20);
            this.textBox_BoardLetters.TabIndex = 2;
            // 
            // checkBox_ManuelInput
            // 
            this.checkBox_ManuelInput.AutoSize = true;
            this.checkBox_ManuelInput.Location = new System.Drawing.Point(6, 19);
            this.checkBox_ManuelInput.Name = "checkBox_ManuelInput";
            this.checkBox_ManuelInput.Size = new System.Drawing.Size(159, 17);
            this.checkBox_ManuelInput.TabIndex = 3;
            this.checkBox_ManuelInput.Text = "Ručni unos slova za matricu";
            this.checkBox_ManuelInput.UseVisualStyleBackColor = true;
            this.checkBox_ManuelInput.CheckedChanged += new System.EventHandler(this.checkBox_ManuelInput_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(197, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(270, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 63);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(343, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 63);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(416, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 63);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(197, 82);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 63);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Location = new System.Drawing.Point(270, 82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(67, 63);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox7.Location = new System.Drawing.Point(343, 82);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(67, 63);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox8.Location = new System.Drawing.Point(416, 82);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(67, 63);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox9.Location = new System.Drawing.Point(197, 151);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(67, 63);
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox10.Location = new System.Drawing.Point(270, 151);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(67, 63);
            this.pictureBox10.TabIndex = 13;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox11.Location = new System.Drawing.Point(343, 151);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(67, 63);
            this.pictureBox11.TabIndex = 12;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox12.Location = new System.Drawing.Point(416, 151);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(67, 63);
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox13.Location = new System.Drawing.Point(197, 220);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(67, 63);
            this.pictureBox13.TabIndex = 18;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox14.Location = new System.Drawing.Point(270, 220);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(67, 63);
            this.pictureBox14.TabIndex = 17;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox15.Location = new System.Drawing.Point(343, 220);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(67, 63);
            this.pictureBox15.TabIndex = 16;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox16.Location = new System.Drawing.Point(416, 220);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(67, 63);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            // 
            // checkBox_AutoInput
            // 
            this.checkBox_AutoInput.AutoSize = true;
            this.checkBox_AutoInput.Location = new System.Drawing.Point(370, 317);
            this.checkBox_AutoInput.Name = "checkBox_AutoInput";
            this.checkBox_AutoInput.Size = new System.Drawing.Size(128, 17);
            this.checkBox_AutoInput.TabIndex = 19;
            this.checkBox_AutoInput.Text = "Automatski unos riječi";
            this.checkBox_AutoInput.UseVisualStyleBackColor = true;
            this.checkBox_AutoInput.CheckedChanged += new System.EventHandler(this.checkBox_AutoInput_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(370, 359);
            this.label1.MaximumSize = new System.Drawing.Size(120, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 42);
            this.label1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_AutoInput);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_InputControls);
            this.Controls.Add(this.listBox_WordsDisplay);
            this.Name = "Form1";
            this.Text = "WordzCheat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_InputControls.ResumeLayout(false);
            this.groupBox_InputControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_WordsDisplay;
        private System.Windows.Forms.Button btn_FindWords;
        private System.Windows.Forms.GroupBox groupBox_InputControls;
        private System.Windows.Forms.CheckBox checkBox_ManuelInput;
        private System.Windows.Forms.TextBox textBox_BoardLetters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.CheckBox checkBox_AutoInput;
        private System.Windows.Forms.Label label1;
    }
}

