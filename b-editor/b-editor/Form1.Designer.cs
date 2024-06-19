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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_sidebar = new Panel();
            btn_newPost = new Button();
            postList = new ListBox();
            chk_sidebar = new CheckBox();
            textEditor = new RichTextBox();
            menuStrip = new MenuStrip();
            menu_file = new ToolStripMenuItem();
            menu_newPost = new ToolStripMenuItem();
            menu_import = new ToolStripMenuItem();
            menu_export = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menu_save = new ToolStripMenuItem();
            menu_connect = new ToolStripMenuItem();
            menu_upload = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menu_exit = new ToolStripMenuItem();
            menu_edit = new ToolStripMenuItem();
            menu_cut = new ToolStripMenuItem();
            menu_copy = new ToolStripMenuItem();
            menu_paste = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            menu_insert = new ToolStripMenuItem();
            menu_insertImage = new ToolStripMenuItem();
            menu_insertLink = new ToolStripMenuItem();
            menu_view = new ToolStripMenuItem();
            menu_preview = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStrip_bold = new ToolStripButton();
            toolStrip_italic = new ToolStripButton();
            toolStrip_underline = new ToolStripButton();
            toolStrip_cancellation = new ToolStripButton();
            toolStrip_fontType = new ToolStripComboBox();
            toolStrip_fontSize = new ToolStripComboBox();
            toolStrip_BGColor = new ToolStripButton();
            toolStrip_textColor = new ToolStripButton();
            leftButton = new ToolStripButton();
            centerButton = new ToolStripButton();
            rightButton = new ToolStripButton();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            menu_viewFolder = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            menu_editFolder = new ToolStripMenuItem();
            folderBrowserDialog = new FolderBrowserDialog();
            autoSaveTimer = new System.Windows.Forms.Timer(components);
            panel_sidebar.SuspendLayout();
            menuStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            openFileDialog1 = new OpenFileDialog();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BorderStyle = BorderStyle.Fixed3D;
            panel_sidebar.Controls.Add(btn_newPost);
            panel_sidebar.Controls.Add(postList);
            panel_sidebar.Controls.Add(chk_sidebar);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Margin = new Padding(5);
            panel_sidebar.Location = new Point(0, 56);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(200, 571);
            panel_sidebar.TabIndex = 0;
            // 
            // btn_newPost
            // 
            btn_newPost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_newPost.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_newPost.Location = new Point(71, 489);
            btn_newPost.Name = "btn_newPost";
            btn_newPost.Size = new Size(121, 42);
            btn_newPost.TabIndex = 2;
            btn_newPost.Text = "+ New Post";
            btn_newPost.UseVisualStyleBackColor = true;
            btn_newPost.Click += newPost_Click;
            // 
            // postList
            // 
            postList.BackColor = SystemColors.Window;
            postList.BorderStyle = BorderStyle.None;
            postList.Dock = DockStyle.Fill;
            postList.DrawMode = DrawMode.OwnerDrawFixed;
            postList.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            postList.FormattingEnabled = true;
            postList.ItemHeight = 31;
            postList.Location = new Point(0, 0);
            postList.Margin = new Padding(5);
            postList.Name = "postList";
            postList.Size = new Size(196, 537);
            postList.TabIndex = 1;
            postList.DrawItem += postList_DrawItem;
            postList.SelectedIndexChanged += postList_SelectedIndexChanged;
            // 
            // chk_sidebar
            // 
            chk_sidebar.Appearance = Appearance.Button;
            chk_sidebar.Dock = DockStyle.Bottom;
            chk_sidebar.FlatAppearance.BorderColor = Color.Gainsboro;
            chk_sidebar.FlatStyle = FlatStyle.Flat;
            chk_sidebar.Margin = new Padding(5);
            chk_sidebar.Location = new Point(0, 537);
            chk_sidebar.Name = "chk_sidebar";
            chk_sidebar.Size = new Size(196, 30);
            chk_sidebar.TabIndex = 0;
            chk_sidebar.Text = "Toggle";
            chk_sidebar.TextAlign = ContentAlignment.MiddleCenter;
            chk_sidebar.UseVisualStyleBackColor = true;
            // 
            // textEditor
            // 
            textEditor.Dock = DockStyle.Fill;
            textEditor.Location = new Point(200, 56);
            textEditor.HideSelection = false;
            textEditor.Margin = new Padding(5);
            textEditor.Name = "textEditor";
            textEditor.Size = new Size(765, 571);
            textEditor.TabIndex = 1;
            textEditor.Text = "";
            textEditor.SelectionChanged += textEditor_SelectionChanged;
            textEditor.TextChanged += textEditor_TextChanged;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menu_file, menu_edit, menu_view });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(9, 3, 0, 3);
            menuStrip.Size = new Size(965, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // menu_file
            // 
            menu_file.DropDownItems.AddRange(new ToolStripItem[] { menu_newPost, menu_import, menu_export, toolStripSeparator4, menu_editFolder, menu_viewFolder, toolStripSeparator2, menu_save, menu_connect, menu_upload, toolStripSeparator1, menu_exit });
            menu_file.Name = "menu_file";
            menu_file.Size = new Size(53, 24);
            menu_file.Text = "파일";
            // 
            // menu_newPost
            // 
            menu_newPost.Name = "menu_newPost";
            menu_newPost.Size = new Size(224, 26);
            menu_newPost.Text = "새로 만들기";
            menu_newPost.Click += newPost_Click;
            // 
            // menu_import
            // 
            menu_import.Name = "menu_import";
            menu_import.Size = new Size(224, 26);
            menu_import.Text = "불러오기";
            // 
            // menu_export
            // 
            menu_export.Enabled = false;
            menu_export.Name = "menu_export";
            menu_export.Size = new Size(224, 26);
            menu_export.Text = "내보내기";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(269, 6);
            // 
            // menu_editFolder
            // 
            menu_editFolder.Name = "menu_editFolder";
            menu_editFolder.Size = new Size(272, 26);
            menu_editFolder.Text = "저장소 폴더 변경...";
            menu_editFolder.Click += menu_editFolder_Click;
            // 
            // menu_viewFolder
            // 
            menu_viewFolder.Name = "menu_viewFolder";
            menu_viewFolder.Size = new Size(272, 26);
            menu_viewFolder.Text = "파일 탐색기에서 폴더 보기";
            menu_viewFolder.Click += menu_viewFolder_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // menu_save
            // 
            menu_save.Name = "menu_save";
            menu_save.Size = new Size(224, 26);
            menu_save.Text = "저장";
            // 
            // menu_connect
            // 
            menu_connect.Name = "menu_connect";
            menu_connect.Size = new Size(224, 26);
            menu_connect.Text = "연결...";
            // 
            // menu_upload
            // 
            menu_upload.Enabled = false;
            menu_upload.Name = "menu_upload";
            menu_upload.Size = new Size(224, 26);
            menu_upload.Text = "업로드";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // menu_exit
            // 
            menu_exit.Name = "menu_exit";
            menu_exit.Size = new Size(224, 26);
            menu_exit.Text = "끝내기";
            menu_exit.Click += menu_exit_Click;
            // 
            // menu_edit
            // 
            menu_edit.DropDownItems.AddRange(new ToolStripItem[] { menu_cut, menu_copy, menu_paste, toolStripSeparator3, menu_insert });
            menu_edit.Name = "menu_edit";
            menu_edit.Size = new Size(53, 24);
            menu_edit.Text = "편집";
            // 
            // menu_cut
            // 
            menu_cut.Name = "menu_cut";
            menu_cut.Size = new Size(186, 34);
            menu_cut.Text = "잘라내기";
            menu_cut.Click += menu_cut_Click;
            // 
            // menu_copy
            // 
            menu_copy.Name = "menu_copy";
            menu_copy.Size = new Size(186, 34);
            menu_copy.Text = "복사";
            menu_copy.Click += menu_copy_Click;
            // 
            // menu_paste
            // 
            menu_paste.Name = "menu_paste";
            menu_paste.Size = new Size(186, 34);
            menu_paste.Text = "붙여넣기";
            menu_paste.Click += menu_paste_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(149, 6);
            // 
            // menu_insert
            // 
            menu_insert.DropDownItems.AddRange(new ToolStripItem[] { menu_insertImage, menu_insertLink });
            menu_insert.Name = "menu_insert";
            menu_insert.Size = new Size(152, 26);
            menu_insert.Text = "삽입. . .";
            // 
            // menu_insertImage
            // 
            menu_insertImage.Name = "menu_insertImage";
            menu_insertImage.Size = new Size(204, 34);
            menu_insertImage.Text = "그림";
            menu_insertImage.Click += menu_insertImage_Click;
            // 
            // menu_insertLink
            // 
            menu_insertLink.Name = "menu_insertLink";
            menu_insertLink.Size = new Size(204, 34);
            menu_insertLink.Text = "하이퍼링크";
            menu_insertLink.Click += menu_insertLink_Click;
            // 
            // menu_view
            // 
            menu_view.DropDownItems.AddRange(new ToolStripItem[] { menu_preview });
            menu_view.Name = "menu_view";
            menu_view.Size = new Size(53, 24);
            menu_view.Text = "보기";
            // 
            // menu_preview
            // 
            menu_preview.Name = "menu_preview";
            menu_preview.Size = new Size(152, 26);
            menu_preview.Text = "미리보기";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_bold, toolStrip_italic, toolStrip_underline, toolStrip_cancellation, toolStrip_fontType, toolStrip_fontSize, toolStrip_BGColor, toolStrip_textColor, leftButton, centerButton, rightButton });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(965, 28);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_bold
            // 
            toolStrip_bold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_bold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            toolStrip_bold.ImageTransparentColor = Color.Magenta;
            toolStrip_bold.Name = "toolStrip_bold";
            toolStrip_bold.Size = new Size(29, 25);
            toolStrip_bold.Text = "가";
            toolStrip_bold.Click += toolStrip_bold_Click;
            // 
            // toolStrip_italic
            // 
            toolStrip_italic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_italic.Font = new Font("맑은 고딕 Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point, 129);
            toolStrip_italic.ImageTransparentColor = Color.Magenta;
            toolStrip_italic.Name = "toolStrip_italic";
            toolStrip_italic.Size = new Size(29, 25);
            toolStrip_italic.Text = "가";
            toolStrip_italic.Click += toolStrip_italic_Click;
            // 
            // toolStrip_underline
            // 
            toolStrip_underline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_underline.Font = new Font("맑은 고딕", 9F, FontStyle.Underline, GraphicsUnit.Point, 129);
            toolStrip_underline.ImageTransparentColor = Color.Magenta;
            toolStrip_underline.Name = "toolStrip_underline";
            toolStrip_underline.Size = new Size(29, 25);
            toolStrip_underline.Text = "가";
            toolStrip_underline.Click += toolStrip_underline_Click;
            // 
            // toolStrip_cancellation
            // 
            toolStrip_cancellation.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_cancellation.Font = new Font("맑은 고딕", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 129);
            toolStrip_cancellation.ImageTransparentColor = Color.Magenta;
            toolStrip_cancellation.Name = "toolStrip_cancellation";
            toolStrip_cancellation.Size = new Size(29, 25);
            toolStrip_cancellation.Text = "가";
            toolStrip_cancellation.Click += toolStrip_cancellation_Click;
            // 
            // toolStrip_fontType
            // 
            toolStrip_fontType.CausesValidation = false;
            toolStrip_fontType.Name = "toolStrip_fontType";
            toolStrip_fontType.Size = new Size(121, 28);
            toolStrip_fontType.Text = "폰트";
            toolStrip_fontType.SelectedIndexChanged += toolStrip_fontType_SelectedIndexChanged;
            toolStrip_fontType.KeyPress += toolStrip_fontType_KeyPress;
            // 
            // toolStrip_fontSize
            // 
            toolStrip_fontSize.CausesValidation = false;
            toolStrip_fontSize.Items.AddRange(new object[] { "8", "9", "10", "12", "14", "16", "20", "24", "28", "32", "36", "42", "48", "56", "64", "72", "84", "96", "108", "120" });
            toolStrip_fontSize.Name = "toolStrip_fontSize";
            toolStrip_fontSize.Size = new Size(121, 28);
            toolStrip_fontSize.Text = "크기";
            toolStrip_fontSize.SelectedIndexChanged += toolStrip_fontSize_SelectedIndexChanged;
            toolStrip_fontSize.KeyPress += toolStrip_fontSize_KeyPress;
            // 
            // toolStrip_BGColor
            // 
            toolStrip_BGColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_BGColor.Image = (Image)resources.GetObject("toolStrip_BGColor.Image");
            toolStrip_BGColor.ImageTransparentColor = Color.Magenta;
            toolStrip_BGColor.Name = "toolStrip_BGColor";
            toolStrip_BGColor.Size = new Size(70, 25);
            toolStrip_BGColor.Text = "BGColor";
            // 
            // toolStrip_textColor
            // 
            toolStrip_textColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStrip_textColor.Image = (Image)resources.GetObject("toolStrip_textColor.Image");
            toolStrip_textColor.ImageTransparentColor = Color.Magenta;
            toolStrip_textColor.Name = "toolStrip_textColor";
            toolStrip_textColor.Size = new Size(78, 25);
            toolStrip_textColor.Text = "TextColor";
            // 
            // leftButton
            // 
            leftButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            leftButton.Image = (Image)resources.GetObject("leftButton.Image");
            leftButton.ImageTransparentColor = Color.Magenta;
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(46, 36);
            leftButton.Text = "leftButton";
            leftButton.Click += leftButton_Click;
            // 
            // centerButton
            // 
            centerButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            centerButton.Image = (Image)resources.GetObject("centerButton.Image");
            centerButton.ImageTransparentColor = Color.Magenta;
            centerButton.Name = "centerButton";
            centerButton.Size = new Size(46, 36);
            centerButton.Text = "centerButton";
            centerButton.Click += centerButton_Click;
            // 
            // rightButton
            // 
            rightButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rightButton.Image = (Image)resources.GetObject("rightButton.Image");
            rightButton.ImageTransparentColor = Color.Magenta;
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(46, 36);
            rightButton.Text = "rightButton";
            rightButton.Click += rightButton_Click;
            // 
            // autoSaveTimer
            // 
            autoSaveTimer.Interval = 300;
            autoSaveTimer.Tick += autoSaveTimer_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1501, 1003);
            Controls.Add(textEditor);
            Controls.Add(panel_sidebar);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "b-editor";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel_sidebar.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem menu_viewFolder;
        private ListBox postList;
        private ToolStripMenuItem menu_editFolder;
        private FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Timer autoSaveTimer;
        private Button btn_newPost;
        private ToolStripButton leftButton;
        private ToolStripButton centerButton;
        private ToolStripButton rightButton;
        private OpenFileDialog openFileDialog1;
    }
}
