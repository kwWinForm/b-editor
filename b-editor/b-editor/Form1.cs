using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using static b_editor.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;

namespace b_editor
{
    public partial class Form1 : Form
    {
        private List<PictureBox> pictureBoxes;
        private Point mouseDownLocation;
        private PictureBox selectedPictureBox;
        public Form1()
        {
            InitializeComponent();
            textEditor.LinkClicked += new LinkClickedEventHandler(textEditor_LinkClicked);
            pictureBoxes = new List<PictureBox>();
        }

        private void menu_copy_Click(object sender, EventArgs e)
        {
            {
                textEditor.Copy();
            }
        }

        private void menu_cut_Click(object sender, EventArgs e)
        {
            {
                textEditor.Cut();
            }
        }
        private void menu_paste_Click(object sender, EventArgs e)
        {
            {
                textEditor.Paste();
            }
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitQuestion() == false) e.Cancel = true;
        }

        private bool ExitQuestion()
        {
            var result = MessageBox.Show(
                "종료하시겠습니까?",
                "종료",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            return (result == DialogResult.Yes);
        }
        private void menu_insertLink_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectedText.Length > 0)
            {
                using (InsertLink insert = new InsertLink(textEditor.SelectedText))
                {

                    if (insert.ShowDialog() == DialogResult.OK)
                    {
                        string url = insert.Url;
                        int start = textEditor.SelectionStart;
                        int length = textEditor.SelectionLength;
                        string selectedText = textEditor.SelectedText;

                        textEditor.SelectedRtf = $@"{{\rtf1\ansi {{\field{{\*\fldinst HYPERLINK ""{url}""}}{{\fldrslt {selectedText}}}}}}}";

                    }
                }
            }
            else
            {
                MessageBox.Show("선택한 텍스트가 없습니다.");
            }
        }

        private void textEditor_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"링크를 열 수 없습니다 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menu_insertImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    InsertImage(ofd.FileName);
                }
            }
        }
        private void InsertImage(string imagePath)
        {
            try
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(100, 100), 
                    Location = Cursor()
                };

                pictureBox.MouseDown += PictureBox_MouseDown;
                pictureBox.MouseMove += PictureBox_MouseMove;

                this.Controls.Add(pictureBox);
                pictureBoxes.Add(pictureBox);

                pictureBox.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 삽입 오류", "오류");
            }
        }

        private Point Cursor()
        {
            int cursor = textEditor.SelectionStart;
            Point point = textEditor.GetPositionFromCharIndex(cursor);
            point.X += textEditor.Location.X;
            point.Y += textEditor.Location.Y;
            return point;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPictureBox = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                selectedPictureBox.Cursor = Cursors.SizeNWSE;
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedPictureBox == null)
                return;

            if (e.Button == MouseButtons.Left)
            {
                selectedPictureBox.Left = e.X + selectedPictureBox.Left - mouseDownLocation.X;
                selectedPictureBox.Top = e.Y + selectedPictureBox.Top - mouseDownLocation.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                selectedPictureBox.Width = e.X;
                selectedPictureBox.Height = e.Y;
            }
        }
    }
}