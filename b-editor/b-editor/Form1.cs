using System.Threading;
using System.IO;

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

            // 해당 폴더에 포스트가 없는 경우
            if (postings.Length == 0)
            {
                // 새 포스트 생성
                createNewPost();
                postings = Directory.GetFiles(settings.savePath, "*.rtf");
            }

            postList.Items.Clear();

            // 사이드바에 rtf 파일 목록 표시
            for (int i = 0; i < postings.Length; i++)
            {
                // 해당 코드로부터, postings 배열과 postList.Items 배열의 인덱스는 동일한 순서임이 보장됨
                string postname = postings[i].Substring(postings[i].LastIndexOf("\\") + 1).Replace(".rtf", "");
                postList.Items.Add(postname);
            }

            // settings.currentPost에 해당하는 포스트 index 검색
            int index = Array.IndexOf(postings, settings.currentPost);

            // settings.currentPost 포스트가 폴더에 존재하지 않는 경우
            if (index == -1)
            {
                // 첫번째 포스트 선택
                settings.currentPost = postings[0];
                postList.SelectedIndex = 0;
            }
            else
            {
                // settings.currentPost에 해당하는 포스트 선택
                postList.SelectedIndex = index;
            }

            openPost(settings.currentPost);

            postList.SelectedIndexChanged += postList_SelectedIndexChanged;
        }

        private void savePost(string filename)
        {
            // 현재 열려있는 포스트 저장
            textEditor.SaveFile(filename);
            // 자동저장 타이머 정지
            autoSaveTimer.Stop();
            // 로드 직후 지나치게 빠른 저장으로 인한 에러 예방
            Thread.Sleep(100);
        }

        private void openPost(string filename)
        {
            // 해당 포스트 선택해서 편집기에 열기
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

            // 첫 줄을 제목으로 설정
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            int cursorPosition = textEditor.SelectionStart; // 현재 커서 위치 저장

            int firstLineEnd = textEditor.Text.IndexOf('\n');
            if (firstLineEnd > -1)
            {
                string firstLine = textEditor.Text.Substring(0, firstLineEnd).Trim();
                postList.Items[postList.SelectedIndex] = firstLine;
            }
            else
            {
                postList.Items[postList.SelectedIndex] = textEditor.Text.Trim();
            }

            textEditor.SelectionStart = cursorPosition; // 원래 커서 위치 복원
            textEditor.SelectionLength = 0; // 선택 영역 해제
        }
    }
}
