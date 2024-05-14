namespace b_editor
{
    public partial class Form1 : Form
    {
        Settings settings; 
        string[] postings;

        public Form1()
        {
            InitializeComponent();
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

        private void loadPostings()
        {
            postings = Directory.GetFiles(settings.savePath, "*.rtf");

            // 사이드바에 rtf 파일 목록 표시

            // 해당 폴더에 포스트가 없는 경우
            if (postings.Length == 0)
            {
                // 새 포스트 생성
                createNewPost();
                postings = Directory.GetFiles(settings.savePath, "*.rtf");
            }
            // 첫번째 포스트 선택
            settings.currentPost = postings[0];
            openPost(settings.currentPost);
        }

        private void savePost(string filename)
        {
            // 현재 열려있는 포스트 저장
            textEditor.SaveFile(filename);
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
            while(File.Exists(filename))
            {
                filename = settings.savePath + "\\post" + i + ".rtf";
                i++;
            }

            File.Create(filename).Close(); // 빈 파일 생성 후
            textEditor.Text = "";
            textEditor.SaveFile(filename); // 빈 텍스트 rtf 포맷으로 저장
        }

        private void menu_viewFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", settings.savePath);
        }
    }
}
