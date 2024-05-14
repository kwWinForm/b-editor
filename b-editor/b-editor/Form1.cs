namespace b_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void toolStrip_bold_Click(object sender, EventArgs e)
        {
            Font f = new Font(textEditor.Font.FontFamily, textEditor.Font.Size, FontStyle.Bold ^ textEditor.Font.Style);
            textEditor.Font = f;
        }
    }
}
