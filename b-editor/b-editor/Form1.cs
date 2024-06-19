using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using static b_editor.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;

namespace b_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textEditor.LinkClicked += new LinkClickedEventHandler(textEditor_LinkClicked);
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                openFileDialog.Title = "그림 삽입";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    Image image = Image.FromFile(imagePath);

                    Clipboard.SetImage(image);
                    textEditor.Paste();
                    Clipboard.Clear();
                }
            }
        }
    }
}