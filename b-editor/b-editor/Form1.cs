namespace b_editor
{
    public partial class Form1 : Form
    {
        private TextBox textBoxSearch;
        private Button buttonSearch;
       

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this. KeyDown += new KeyEventHandler(Form1_KeyDown);

            // 검색 텍스트 박스와 버튼 초기 설정
            InitializeSearchComponents();
        }

        private void InitializeSearchComponents()
        {
            // 검색 텍스트 박스 생성 및 설정
            textBoxSearch = new TextBox();
            textBoxSearch.Size = new System.Drawing.Size(200, 20);
            textBoxSearch.Location = new System.Drawing.Point(this.ClientSize.Width - 220, 10);
            textBoxSearch.Visible = false;
            textBoxSearch.BringToFront(); // 컨트롤을 맨 앞으로 가져오기
            this.Controls.Add(textBoxSearch);

            // 검색 버튼 생성 및 설정
            buttonSearch = new Button();
            buttonSearch.Text = "Search";
            buttonSearch.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            buttonSearch.Click += new EventHandler(ButtonSearch_Click);
            buttonSearch.Visible = false;
            textBoxSearch.BringToFront(); // 컨트롤을 맨 앞으로 가져오기
            this.Controls.Add(buttonSearch);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                textBoxSearch.Visible = true; // 검색 텍스트 박스 보이기
                buttonSearch.Visible = true;  // 검색 버튼 보이기
                textBoxSearch.BringToFront(); // 컨트롤을 맨 앞으로 가져오기
                buttonSearch.BringToFront();  // 컨트롤을 맨 앞으로 가져오기
                textBoxSearch.Focus(); // 검색 텍스트 박스에 포커스 이동
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            string mainText = textEditor.Text; // 메인 텍스트 박스의 텍스트

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter text to search for.");
                return;
            }

            int index = mainText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);
            if (index != -1)
            {
                textEditor.SelectionStart = index;
                textEditor.SelectionLength = searchText.Length;
                textEditor.ScrollToCaret();
                textEditor.Focus();
            }
            else
            {
                MessageBox.Show("Text not found.");
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
    }
}
