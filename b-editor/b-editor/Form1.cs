using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

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

            File.Create(filename).Close();
            textEditor.Text = "";
            textEditor.SaveFile(filename);
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

        private void textEditor_SelectionChanged(object sender, EventArgs e)
        {
            UpdateToolbar();
        }

        private void UpdateToolbar()
        {
            toolStrip_bold.Checked = textEditor.SelectionFont != null && textEditor.SelectionFont.Bold;
            toolStrip_italic.Checked = textEditor.SelectionFont != null && textEditor.SelectionFont.Italic;
            toolStrip_underline.Checked = textEditor.SelectionFont != null && textEditor.SelectionFont.Underline;
            toolStrip_cancellation.Checked = textEditor.SelectionFont != null && textEditor.SelectionFont.Strikeout; // 추가
        }

        

        private void toolStrip_bold_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont != null)
            {
                Font currentFont = textEditor.SelectionFont;
                FontStyle newFontStyle;

                if (textEditor.SelectionFont.Bold)
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
        }

        private void toolStrip_italic_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont != null)
            {
                Font currentFont = textEditor.SelectionFont;
                FontStyle newFontStyle;

                if (textEditor.SelectionFont.Italic)
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
        }

        private void toolStrip_underline_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont != null)
            {
                Font currentFont = textEditor.SelectionFont;
                FontStyle newFontStyle;

                if (textEditor.SelectionFont.Underline)
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
        }

        private void toolStrip_cancellation_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont != null)
            {
                Font currentFont = textEditor.SelectionFont;
                FontStyle newFontStyle;

                if (textEditor.SelectionFont.Strikeout)
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
        }
    }
}
