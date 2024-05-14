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

        private void menu_TextColor_Click(object sender, EventArgs e)
        {
            {
                int selectionStart = txtEdit.SelectionStart;
                int selectionLength = txtEdit.SelectionLength;

                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {

                    txtEdit.SelectionStart = selectionStart;
                    txtEdit.SelectionLength = selectionLength;
                    txtEdit.SelectionColor = colorDialog.Color;
                    txtEdit.SelectionLength = 0;
                }
            }
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
