using System;
using System.Threading;
using System.Windows.Forms;
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
        Settings settings;
        string[] postings;

        float idleTime = 0;

        public Form1()
        {
            InitializeComponent();
            textEditor.LinkClicked += new LinkClickedEventHandler(textEditor_LinkClicked);
        }

        private void menu_copy_Click(object sender, EventArgs e)
        {
            textEditor.Copy();
        }

        private void menu_cut_Click(object sender, EventArgs e)
        {
            textEditor.Cut();
        }

        private void menu_paste_Click(object sender, EventArgs e)
        {
            textEditor.Paste();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings = Settings.Load();
            loadPostings();

            foreach (FontFamily ff in FontFamily.Families)
            {
                toolStrip_fontType.Items.Add(ff.Name);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Save();
            savePost(settings.currentPost);

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

        private bool postMoveQuestion()
        {
            var result = MessageBox.Show(
                "기존 포스트들을 새 저장소로 이동하시겠습니까?",
                "포스트 이동",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return (result == DialogResult.Yes);
        }

        private void loadPostings()
        {
            postList.SelectedIndexChanged -= postList_SelectedIndexChanged;

            postings = Directory.GetFiles(settings.savePath, "*.rtf");

            if (postings.Length == 0)
            {
                createNewPost();
                postings = Directory.GetFiles(settings.savePath, "*.rtf");
            }

            postList.Items.Clear();

            for (int i = 0; i < postings.Length; i++)
            {
                string postname = postings[i].Substring(postings[i].LastIndexOf("\\") + 1).Replace(".rtf", "");
                postList.Items.Add(postname);
            }

            int index = Array.IndexOf(postings, settings.currentPost);

            if (index == -1)
            {
                settings.currentPost = postings[0];
                postList.SelectedIndex = 0;
            }
            else
            {
                postList.SelectedIndex = index;
            }

            openPost(settings.currentPost);

            postList.SelectedIndexChanged += postList_SelectedIndexChanged;
        }

        private void savePost(string filename)
        {
            textEditor.SaveFile(filename);
            autoSaveTimer.Stop();
            Thread.Sleep(100);
        }

        private void openPost(string filename)
        {
            textEditor.LoadFile(filename);
        }

        private void createNewPost()
        {
            int i = 1;
            string filename = settings.savePath + "\\post.rtf";
            while (File.Exists(filename))
            {
                filename = settings.savePath + "\\post" + i + ".rtf";
                i++;
            }

            settings.currentPost = filename;

            File.Create(filename).Close();
            textEditor.Text = "";
            savePost(filename);
        }

        private void menu_viewFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", settings.savePath);
        }

        private void postList_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                string item = list.Items[e.Index].ToString();
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item, e.Font);
                e.Graphics.DrawString(item, e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        private void postList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (list.SelectedIndex > -1)
            {
                savePost(settings.currentPost);
                settings.currentPost = postings[list.SelectedIndex];
                openPost(settings.currentPost);
            }
        }

        private void menu_editFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (postMoveQuestion() == true)
                {
                    foreach (string post in postings)
                    {
                        string filename = Path.GetFileName(post);
                        string destname = Path.Combine(folderBrowserDialog.SelectedPath, filename);
                        File.Move(post, destname, true);
                    }
                    settings.currentPost = Path.Combine(folderBrowserDialog.SelectedPath, Path.GetFileName(settings.currentPost));
                }
                else
                {
                    settings.currentPost = "";
                }

                settings.savePath = folderBrowserDialog.SelectedPath;
                loadPostings();
            }
        }

        private void autoSaveTimer_Tick(object sender, EventArgs e)
        {
            idleTime += autoSaveTimer.Interval;
            if (idleTime >= settings.autosaveInterval)
            {
                savePost(settings.currentPost);
                idleTime = 0;
            }
        }

        private void textEditor_TextChanged(object sender, EventArgs e)
        {
            if (autoSaveTimer.Enabled == false)
            {
                autoSaveTimer.Start();
            }
            idleTime = 0;
        }

        private void newPost_Click(object sender, EventArgs e)
        {
            savePost(settings.currentPost);
            createNewPost();
            loadPostings();
        }

        private void textEditor_SelectionChanged(object sender, EventArgs e)
        {
            UpdateToolbar();
        }

        private void UpdateToolbar()
        {
            Font? font = textEditor.SelectionFont;
            if (font != null)
            {
                toolStrip_fontSize.Text = font.Size.ToString();
                toolStrip_fontType.Text = font.FontFamily.Name;
                toolStrip_bold.Checked = font.Bold;
                toolStrip_italic.Checked = font.Italic;
                toolStrip_underline.Checked = font.Underline;
                toolStrip_cancellation.Checked = font.Strikeout;
            }
            else
            {
                toolStrip_fontSize.Text = "...";
                toolStrip_fontType.Text = "...";
                toolStrip_bold.Checked = false;
                toolStrip_italic.Checked = false;
                toolStrip_underline.Checked = false;
                toolStrip_cancellation.Checked = false;
            }

            leftButton.Checked = textEditor.SelectionAlignment == HorizontalAlignment.Left;
            centerButton.Checked = textEditor.SelectionAlignment == HorizontalAlignment.Center;
            rightButton.Checked = textEditor.SelectionAlignment == HorizontalAlignment.Right;

            textEditor.Focus();
        }

        private void toolStrip_bold_Click(object sender, EventArgs e)
        {
            Font currentFont = getCurrentFont();
            FontStyle newFontStyle;

            if (currentFont.Bold)
            {
                newFontStyle = currentFont.Style & ~FontStyle.Bold;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Bold;
            }

            textEditor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            UpdateToolbar();
        }

        private void toolStrip_italic_Click(object sender, EventArgs e)
        {
            Font currentFont = getCurrentFont();
            FontStyle newFontStyle;

            if (currentFont.Italic)
            {
                newFontStyle = currentFont.Style & ~FontStyle.Italic;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Italic;
            }

            textEditor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            UpdateToolbar();
        }

        private void toolStrip_underline_Click(object sender, EventArgs e)
        {
            Font currentFont = getCurrentFont();
            FontStyle newFontStyle;

            if (currentFont.Underline)
            {
                newFontStyle = currentFont.Style & ~FontStyle.Underline;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Underline;
            }

            textEditor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            UpdateToolbar();
        }

        private void toolStrip_cancellation_Click(object sender, EventArgs e)
        {
            Font currentFont = getCurrentFont();
            FontStyle newFontStyle;

            if (currentFont.Strikeout)  
            {
                newFontStyle = currentFont.Style & ~FontStyle.Strikeout;
            }
            else
            {
                newFontStyle = currentFont.Style | FontStyle.Strikeout;
            }

            textEditor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            UpdateToolbar();
        }

        private void toolStrip_fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (float.TryParse(toolStrip_fontSize.SelectedItem.ToString(), out float size))
            {
                Font currentFont = getCurrentFont();

                textEditor.SelectionFont = new Font(currentFont.FontFamily, size, currentFont.Style);
            }

            UpdateToolbar();
        }

        private void toolStrip_fontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (float.TryParse(toolStrip_fontSize.Text, out float size))
                {
                    Font currentFont = getCurrentFont();

                    textEditor.SelectionFont = new Font(currentFont.FontFamily, size, currentFont.Style);
                }

                UpdateToolbar();
            }
        }

        private void toolStrip_fontType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = toolStrip_fontType.SelectedItem.ToString();
            if (type != null)
            {
                Font currentFont = getCurrentFont();

                textEditor.SelectionFont = new Font(type, currentFont.Size, currentFont.Style);
            }

            UpdateToolbar();
        }

        private void toolStrip_fontType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                foreach (object fontname in toolStrip_fontType.Items)
                {
                    if (fontname.ToString() == toolStrip_fontType.Text)
                    {
                        Font currentFont = getCurrentFont();

                        textEditor.SelectionFont = new Font(fontname.ToString(), currentFont.Size, currentFont.Style);
                        break;
                    }
                }

                UpdateToolbar();
            }
        }
        private void leftButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Left;
            UpdateToolbar();
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Center;
            UpdateToolbar();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            textEditor.SelectionAlignment = HorizontalAlignment.Right;
            UpdateToolbar();
        }

        private Font getCurrentFont()
        {
            Font? currentFont = textEditor.SelectionFont;
            if (currentFont == null)
            {
                var selectionStart = textEditor.SelectionStart;
                var selectionLength = textEditor.SelectionLength;

                textEditor.Select(selectionStart + selectionLength, 0);
                currentFont = textEditor.SelectionFont;

                textEditor.Select(selectionStart, selectionLength);
            }

            return currentFont!;
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
