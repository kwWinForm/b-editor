namespace b_editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_copy_Click(object sender, EventArgs e)
        {
            {
                txtEdit.Copy();
            }
        }

        private void menu_cut_Click(object sender, EventArgs e)
        {
            {
                txtEdit.Cut();
            }
        }
        private void menu_paste_Click(object sender, EventArgs e)
        {
            {
                txtEdit.Paste();
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