namespace b_editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.postLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chk_sidebar = new System.Windows.Forms.CheckBox();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_newPost = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_import = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_upload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_insertImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_insertLink = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_preview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_bold = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_italic = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_cancellation = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_fontType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip_fontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip_BGColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_textColor = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel_sidebar.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Controls.Add(this.postLayoutPanel);
            this.panel_sidebar.Controls.Add(this.chk_sidebar);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 33);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(222, 531);
            this.panel_sidebar.TabIndex = 0;
            // 
            // postLayoutPanel
            // 
            this.postLayoutPanel.ColumnCount = 1;
            this.postLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.postLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.postLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.postLayoutPanel.Name = "postLayoutPanel";
            this.postLayoutPanel.RowCount = 1;
            this.postLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.postLayoutPanel.Size = new System.Drawing.Size(222, 503);
            this.postLayoutPanel.TabIndex = 1;
            // 
            // chk_sidebar
            // 
            this.chk_sidebar.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_sidebar.AutoSize = true;
            this.chk_sidebar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chk_sidebar.FlatAppearance.BorderSize = 0;
            this.chk_sidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_sidebar.Location = new System.Drawing.Point(0, 503);
            this.chk_sidebar.Name = "chk_sidebar";
            this.chk_sidebar.Size = new System.Drawing.Size(222, 28);
            this.chk_sidebar.TabIndex = 0;
            this.chk_sidebar.Text = "Toggle";
            this.chk_sidebar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_sidebar.UseVisualStyleBackColor = true;
            // 
            // textEditor
            // 
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.Location = new System.Drawing.Point(222, 67);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(850, 497);
            this.textEditor.TabIndex = 1;
            this.textEditor.Text = "";
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_edit,
            this.menu_view});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1072, 33);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_newPost,
            this.menu_import,
            this.menu_export,
            this.toolStripSeparator2,
            this.menu_save,
            this.menu_connect,
            this.menu_upload,
            this.toolStripSeparator1,
            this.menu_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(64, 29);
            this.menu_file.Text = "파일";
            // 
            // menu_newPost
            // 
            this.menu_newPost.Name = "menu_newPost";
            this.menu_newPost.Size = new System.Drawing.Size(210, 34);
            this.menu_newPost.Text = "새로 만들기";
            // 
            // menu_import
            // 
            this.menu_import.Name = "menu_import";
            this.menu_import.Size = new System.Drawing.Size(210, 34);
            this.menu_import.Text = "불러오기";
            // 
            // menu_export
            // 
            this.menu_export.Enabled = false;
            this.menu_export.Name = "menu_export";
            this.menu_export.Size = new System.Drawing.Size(210, 34);
            this.menu_export.Text = "내보내기";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(210, 34);
            this.menu_save.Text = "저장";
            // 
            // menu_connect
            // 
            this.menu_connect.Name = "menu_connect";
            this.menu_connect.Size = new System.Drawing.Size(210, 34);
            this.menu_connect.Text = "연결...";
            // 
            // menu_upload
            // 
            this.menu_upload.Enabled = false;
            this.menu_upload.Name = "menu_upload";
            this.menu_upload.Size = new System.Drawing.Size(210, 34);
            this.menu_upload.Text = "업로드";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(210, 34);
            this.menu_exit.Text = "끝내기";
            // 
            // menu_edit
            // 
            this.menu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cut,
            this.menu_copy,
            this.menu_paste,
            this.toolStripSeparator3,
            this.menu_insert});
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(64, 29);
            this.menu_edit.Text = "편집";
            // 
            // menu_cut
            // 
            this.menu_cut.Name = "menu_cut";
            this.menu_cut.Size = new System.Drawing.Size(186, 34);
            this.menu_cut.Text = "잘라내기";
            this.menu_cut.Click += new System.EventHandler(this.menu_cut_Click);
            // 
            // menu_copy
            // 
            this.menu_copy.Name = "menu_copy";
            this.menu_copy.Size = new System.Drawing.Size(186, 34);
            this.menu_copy.Text = "복사";
            this.menu_copy.Click += new System.EventHandler(this.menu_copy_Click);
            // 
            // menu_paste
            // 
            this.menu_paste.Name = "menu_paste";
            this.menu_paste.Size = new System.Drawing.Size(186, 34);
            this.menu_paste.Text = "붙여넣기";
            this.menu_paste.Click += new System.EventHandler(this.menu_paste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // menu_insert
            // 
            this.menu_insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_insertImage,
            this.menu_insertLink});
            this.menu_insert.Name = "menu_insert";
            this.menu_insert.Size = new System.Drawing.Size(186, 34);
            this.menu_insert.Text = "삽입. . .";
            // 
            // menu_insertImage
            // 
            this.menu_insertImage.Name = "menu_insertImage";
            this.menu_insertImage.Size = new System.Drawing.Size(204, 34);
            this.menu_insertImage.Text = "그림";
            // 
            // menu_insertLink
            // 
            this.menu_insertLink.Name = "menu_insertLink";
            this.menu_insertLink.Size = new System.Drawing.Size(204, 34);
            this.menu_insertLink.Text = "하이퍼링크";
            // 
            // menu_view
            // 
            this.menu_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_preview});
            this.menu_view.Name = "menu_view";
            this.menu_view.Size = new System.Drawing.Size(64, 29);
            this.menu_view.Text = "보기";
            // 
            // menu_preview
            // 
            this.menu_preview.Name = "menu_preview";
            this.menu_preview.Size = new System.Drawing.Size(186, 34);
            this.menu_preview.Text = "미리보기";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_bold,
            this.toolStrip_italic,
            this.toolStrip_underline,
            this.toolStrip_cancellation,
            this.toolStrip_fontType,
            this.toolStrip_fontSize,
            this.toolStrip_BGColor,
            this.toolStrip_textColor});
            this.toolStrip1.Location = new System.Drawing.Point(222, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 34);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_bold
            // 
            this.toolStrip_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_bold.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_bold.Name = "toolStrip_bold";
            this.toolStrip_bold.Size = new System.Drawing.Size(34, 29);
            this.toolStrip_bold.Text = "가";
            // 
            // toolStrip_italic
            // 
            this.toolStrip_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_italic.Font = new System.Drawing.Font("맑은 고딕 Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_italic.Name = "toolStrip_italic";
            this.toolStrip_italic.Size = new System.Drawing.Size(34, 29);
            this.toolStrip_italic.Text = "가";
            // 
            // toolStrip_underline
            // 
            this.toolStrip_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_underline.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_underline.Name = "toolStrip_underline";
            this.toolStrip_underline.Size = new System.Drawing.Size(34, 29);
            this.toolStrip_underline.Text = "가";
            // 
            // toolStrip_cancellation
            // 
            this.toolStrip_cancellation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_cancellation.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStrip_cancellation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_cancellation.Name = "toolStrip_cancellation";
            this.toolStrip_cancellation.Size = new System.Drawing.Size(34, 29);
            this.toolStrip_cancellation.Text = "가";
            // 
            // toolStrip_fontType
            // 
            this.toolStrip_fontType.Name = "toolStrip_fontType";
            this.toolStrip_fontType.Size = new System.Drawing.Size(134, 34);
            this.toolStrip_fontType.Text = "폰트";
            // 
            // toolStrip_fontSize
            // 
            this.toolStrip_fontSize.Name = "toolStrip_fontSize";
            this.toolStrip_fontSize.Size = new System.Drawing.Size(134, 34);
            this.toolStrip_fontSize.Text = "크기";
            // 
            // toolStrip_BGColor
            // 
            this.toolStrip_BGColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_BGColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_BGColor.Name = "toolStrip_BGColor";
            this.toolStrip_BGColor.Size = new System.Drawing.Size(83, 29);
            this.toolStrip_BGColor.Text = "BGColor";
            this.toolStrip_BGColor.Click += new System.EventHandler(this.toolStrip_BGColor_Click);
            // 
            // toolStrip_textColor
            // 
            this.toolStrip_textColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_textColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_textColor.Name = "toolStrip_textColor";
            this.toolStrip_textColor.Size = new System.Drawing.Size(93, 29);
            this.toolStrip_textColor.Text = "TextColor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 564);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "b-editor";
            this.panel_sidebar.ResumeLayout(false);
            this.panel_sidebar.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_sidebar;
        private RichTextBox textEditor;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menu_file;
        private ToolStripMenuItem menu_newPost;
        private ToolStripMenuItem menu_import;
        private ToolStripMenuItem menu_save;
        private ToolStripMenuItem menu_edit;
        private ToolStripMenuItem menu_cut;
        private ToolStripMenuItem menu_copy;
        private ToolStripMenuItem menu_paste;
        private ToolStripMenuItem menu_view;
        private ToolStripMenuItem menu_preview;
        private CheckBox chk_sidebar;
        private ToolStripMenuItem menu_export;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem menu_upload;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menu_exit;
        private TableLayoutPanel postLayoutPanel;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem menu_insert;
        private ToolStripMenuItem menu_insertImage;
        private ToolStripMenuItem menu_insertLink;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStrip_bold;
        private ToolStripButton toolStrip_italic;
        private ToolStripButton toolStrip_underline;
        private ToolStripButton toolStrip_cancellation;
        private ToolStripComboBox toolStrip_fontType;
        private ToolStripComboBox toolStrip_fontSize;
        private ToolStripButton toolStrip_BGColor;
        private ColorDialog colorDialog1;
        private ToolStripButton toolStrip_textColor;
        private FontDialog fontDialog1;
        private ToolStripMenuItem menu_connect;
    }
}