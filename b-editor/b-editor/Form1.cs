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

        private void toolStrip_underline_Click(object sender, EventArgs e)
        {
            if (textEditor.SelectionFont != null)
            {
                Font currentFont = textEditor.SelectionFont;
                FontStyle newFontStyle;

                if (textEditor.SelectionFont.Underline)
                {
                    // Remove underline
                    newFontStyle = currentFont.Style & ~FontStyle.Underline;
                }
                else
                {
                    // Add underline
                    newFontStyle = currentFont.Style | FontStyle.Underline;
                }

                textEditor.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }
    }
}
