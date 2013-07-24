using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WordzCheat.Controller;
using System.Threading;
using System.Diagnostics;

namespace WordzCheat
{
    public partial class Form1 : Form, IViewDisplay
    {
        CheatGenerator _generator;

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayWords(List<string> inWords)
        {
            var words = inWords.OrderBy(item => item.Length);
            listBox_WordsDisplay.Items.Clear();
            foreach (string word in words.Reverse())
            {
                listBox_WordsDisplay.Items.Add(word);
            }
            
            if (checkBox_AutoInput.Checked)
            {
                AutoInputWords();
            }
        }

        public void DisplayLetterBoard(char[] inLetters)
        {
            for (int index = 0; index < inLetters.Length; index++)
            {
                string controlName = "pictureBox" + (index + 1).ToString();
                PictureBox picBox = GetPicBox(controlName);
                DisplayLetter(inLetters[index], picBox);
            }
        }

        #region private help methods

        private void AutoInputWords()
        {
            Thread.Sleep(13000);
            int numberOfAutoInputWords = 7;
            
            if (listBox_WordsDisplay.Items.Count < numberOfAutoInputWords)
                numberOfAutoInputWords = listBox_WordsDisplay.Items.Count;

            for (int index = 0; index < numberOfAutoInputWords; index++)
            {
                SendKeys.SendWait((string)listBox_WordsDisplay.Items[index]);
                SendKeys.SendWait("{ENTER}");
            }
        }

        private PictureBox GetPicBox(string picBoxName)
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Name == picBoxName)
                {
                    return (PictureBox)control;
                }
            }
            throw new Exception();
        }

        private void DisplayLetter(char letter, PictureBox inPicBox)
        {
            Bitmap letterImage = new Bitmap(inPicBox.Size.Width, inPicBox.Size.Height);
            Graphics valueToImageWriter = Graphics.FromImage(letterImage);
            Font font = new Font("Times New Roman", 25, FontStyle.Italic);
            Brush brush = new SolidBrush(Color.FromArgb(47, 79, 79));
            Point point = new Point(13, 7);
            valueToImageWriter.DrawString(letter.ToString(), font, brush, point);
            inPicBox.Image = letterImage;
            valueToImageWriter.Dispose();
        }

        #endregion

        #region event methods

        private void Form1_Load(object sender, EventArgs e)
        {
            _generator = new CheatGenerator(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _generator.Dispose();
        }

        private void checkBox_ManuelInput_CheckedChanged(object sender, EventArgs e)
        {
            textBox_BoardLetters.Text = "";
            checkBox_AutoInput.Checked = false;
            if (!checkBox_ManuelInput.Checked)
            {
                textBox_BoardLetters.Enabled = false;
                btn_FindWords.Enabled = false;
                label1.Text = "";
                _generator.AutoInputBoardLetters = true;
            }
            else
            {
                textBox_BoardLetters.Enabled = true;
                btn_FindWords.Enabled = true;
                _generator.AutoInputBoardLetters = false;
            }
        }

        private void btn_FindWords_Click(object sender, EventArgs e)
        {
            if (textBox_BoardLetters.Text.Length < 16)
            {
                MessageBox.Show("Potrebno je unijeti 16 slova, vi ste unijeli: " + textBox_BoardLetters.Text.Length);
            }
            else
            {
                char[] boardLetters = textBox_BoardLetters.Text.ToUpper().ToCharArray();
                _generator.DisplayBoardAndWords(boardLetters);
                textBox_BoardLetters.Text = "";
            }
        }

        private void checkBox_AutoInput_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_ManuelInput.Checked = false;
            if (checkBox_AutoInput.Checked)
                label1.Text = "Za automatski unos internet preglednik mora biti aktivan.";
            else
                label1.Text = "";
        }

        #endregion
    }
}
