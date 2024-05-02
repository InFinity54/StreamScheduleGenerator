namespace StreamScheduleGenerator
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Footer_SaveAndClose = new Button();
            Header_Title = new Label();
            Header_Icon = new PictureBox();
            GraphicalElements_ImgBgLabel = new Label();
            GraphicalElements_ImgBgPath = new TextBox();
            GraphicalElements_ImgBgFind = new Button();
            GraphicalElements_Group = new GroupBox();
            SettingsUserFileChoose = new OpenFileDialog();
            Colors_Group = new GroupBox();
            Colors_OnDayColorSelect = new Button();
            Colors_OnDayColor = new TextBox();
            Colors_OnDayColorLabel = new Label();
            Colors_OffDayColorSelect = new Button();
            Colors_OffDayColor = new TextBox();
            Colors_OffDayColorLabel = new Label();
            Colors_TitlesColorSelect = new Button();
            Colors_TitlesColor = new TextBox();
            Colors_TitlesColorLabel = new Label();
            SettingsColorPicker = new ColorDialog();
            Colors_OnDayContrastColorSelect = new Button();
            Colors_OnDayContrastColor = new TextBox();
            Colors_OnDayContrastColorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Header_Icon).BeginInit();
            GraphicalElements_Group.SuspendLayout();
            Colors_Group.SuspendLayout();
            SuspendLayout();
            // 
            // Footer_SaveAndClose
            // 
            Footer_SaveAndClose.ForeColor = Color.Black;
            Footer_SaveAndClose.Location = new Point(593, 526);
            Footer_SaveAndClose.Name = "Footer_SaveAndClose";
            Footer_SaveAndClose.Size = new Size(179, 23);
            Footer_SaveAndClose.TabIndex = 0;
            Footer_SaveAndClose.Text = "&Sauvegarder et fermer";
            Footer_SaveAndClose.UseVisualStyleBackColor = true;
            Footer_SaveAndClose.Click += Footer_SaveAndClose_Click;
            // 
            // Header_Title
            // 
            Header_Title.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header_Title.Location = new Point(68, 12);
            Header_Title.Name = "Header_Title";
            Header_Title.Size = new Size(704, 50);
            Header_Title.TabIndex = 3;
            Header_Title.Text = "Paramètres de l'application";
            Header_Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Header_Icon
            // 
            Header_Icon.Image = Properties.Resources.app_icon;
            Header_Icon.Location = new Point(12, 12);
            Header_Icon.Name = "Header_Icon";
            Header_Icon.Size = new Size(50, 50);
            Header_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            Header_Icon.TabIndex = 2;
            Header_Icon.TabStop = false;
            // 
            // GraphicalElements_ImgBgLabel
            // 
            GraphicalElements_ImgBgLabel.AutoSize = true;
            GraphicalElements_ImgBgLabel.Location = new Point(6, 28);
            GraphicalElements_ImgBgLabel.Name = "GraphicalElements_ImgBgLabel";
            GraphicalElements_ImgBgLabel.Size = new Size(113, 17);
            GraphicalElements_ImgBgLabel.TabIndex = 4;
            GraphicalElements_ImgBgLabel.Text = "Image de fond :";
            // 
            // GraphicalElements_ImgBgPath
            // 
            GraphicalElements_ImgBgPath.Location = new Point(125, 25);
            GraphicalElements_ImgBgPath.Name = "GraphicalElements_ImgBgPath";
            GraphicalElements_ImgBgPath.Size = new Size(535, 23);
            GraphicalElements_ImgBgPath.TabIndex = 5;
            GraphicalElements_ImgBgPath.Leave += GraphicalElements_ImgBgPath_Leave;
            // 
            // GraphicalElements_ImgBgFind
            // 
            GraphicalElements_ImgBgFind.ForeColor = Color.Black;
            GraphicalElements_ImgBgFind.Location = new Point(666, 25);
            GraphicalElements_ImgBgFind.Name = "GraphicalElements_ImgBgFind";
            GraphicalElements_ImgBgFind.Size = new Size(88, 23);
            GraphicalElements_ImgBgFind.TabIndex = 6;
            GraphicalElements_ImgBgFind.Text = "Parcourir";
            GraphicalElements_ImgBgFind.UseVisualStyleBackColor = true;
            GraphicalElements_ImgBgFind.Click += GraphicalElements_ImgBgFind_Click;
            // 
            // GraphicalElements_Group
            // 
            GraphicalElements_Group.Controls.Add(GraphicalElements_ImgBgLabel);
            GraphicalElements_Group.Controls.Add(GraphicalElements_ImgBgFind);
            GraphicalElements_Group.Controls.Add(GraphicalElements_ImgBgPath);
            GraphicalElements_Group.ForeColor = Color.White;
            GraphicalElements_Group.Location = new Point(12, 73);
            GraphicalElements_Group.Name = "GraphicalElements_Group";
            GraphicalElements_Group.Size = new Size(760, 61);
            GraphicalElements_Group.TabIndex = 7;
            GraphicalElements_Group.TabStop = false;
            GraphicalElements_Group.Text = "Éléments graphiques";
            // 
            // SettingsUserFileChoose
            // 
            SettingsUserFileChoose.FileName = "openFileDialog1";
            // 
            // Colors_Group
            // 
            Colors_Group.Controls.Add(Colors_OnDayContrastColorSelect);
            Colors_Group.Controls.Add(Colors_OnDayContrastColor);
            Colors_Group.Controls.Add(Colors_OnDayContrastColorLabel);
            Colors_Group.Controls.Add(Colors_OnDayColorSelect);
            Colors_Group.Controls.Add(Colors_OnDayColor);
            Colors_Group.Controls.Add(Colors_OnDayColorLabel);
            Colors_Group.Controls.Add(Colors_OffDayColorSelect);
            Colors_Group.Controls.Add(Colors_OffDayColor);
            Colors_Group.Controls.Add(Colors_OffDayColorLabel);
            Colors_Group.Controls.Add(Colors_TitlesColorSelect);
            Colors_Group.Controls.Add(Colors_TitlesColor);
            Colors_Group.Controls.Add(Colors_TitlesColorLabel);
            Colors_Group.ForeColor = Color.White;
            Colors_Group.Location = new Point(12, 140);
            Colors_Group.Name = "Colors_Group";
            Colors_Group.Size = new Size(760, 88);
            Colors_Group.TabIndex = 8;
            Colors_Group.TabStop = false;
            Colors_Group.Text = "Couleurs";
            // 
            // Colors_OnDayColorSelect
            // 
            Colors_OnDayColorSelect.ForeColor = Color.Black;
            Colors_OnDayColorSelect.Location = new Point(182, 52);
            Colors_OnDayColorSelect.Name = "Colors_OnDayColorSelect";
            Colors_OnDayColorSelect.Size = new Size(66, 23);
            Colors_OnDayColorSelect.TabIndex = 12;
            Colors_OnDayColorSelect.Text = "Choisir";
            Colors_OnDayColorSelect.UseVisualStyleBackColor = true;
            Colors_OnDayColorSelect.Click += Colors_OnDayColorSelect_Click;
            // 
            // Colors_OnDayColor
            // 
            Colors_OnDayColor.Location = new Point(76, 52);
            Colors_OnDayColor.Name = "Colors_OnDayColor";
            Colors_OnDayColor.Size = new Size(100, 23);
            Colors_OnDayColor.TabIndex = 11;
            // 
            // Colors_OnDayColorLabel
            // 
            Colors_OnDayColorLabel.AutoSize = true;
            Colors_OnDayColorLabel.Location = new Point(6, 55);
            Colors_OnDayColorLabel.Name = "Colors_OnDayColorLabel";
            Colors_OnDayColorLabel.Size = new Size(64, 17);
            Colors_OnDayColorLabel.TabIndex = 10;
            Colors_OnDayColorLabel.Text = "Jour on :";
            // 
            // Colors_OffDayColorSelect
            // 
            Colors_OffDayColorSelect.ForeColor = Color.Black;
            Colors_OffDayColorSelect.Location = new Point(579, 23);
            Colors_OffDayColorSelect.Name = "Colors_OffDayColorSelect";
            Colors_OffDayColorSelect.Size = new Size(66, 23);
            Colors_OffDayColorSelect.TabIndex = 9;
            Colors_OffDayColorSelect.Text = "Choisir";
            Colors_OffDayColorSelect.UseVisualStyleBackColor = true;
            Colors_OffDayColorSelect.Click += Colors_OffDayColorSelect_Click;
            // 
            // Colors_OffDayColor
            // 
            Colors_OffDayColor.Location = new Point(473, 22);
            Colors_OffDayColor.Name = "Colors_OffDayColor";
            Colors_OffDayColor.Size = new Size(100, 23);
            Colors_OffDayColor.TabIndex = 8;
            // 
            // Colors_OffDayColorLabel
            // 
            Colors_OffDayColorLabel.AutoSize = true;
            Colors_OffDayColorLabel.Location = new Point(403, 25);
            Colors_OffDayColorLabel.Name = "Colors_OffDayColorLabel";
            Colors_OffDayColorLabel.Size = new Size(64, 17);
            Colors_OffDayColorLabel.TabIndex = 7;
            Colors_OffDayColorLabel.Text = "Jour off :";
            // 
            // Colors_TitlesColorSelect
            // 
            Colors_TitlesColorSelect.ForeColor = Color.Black;
            Colors_TitlesColorSelect.Location = new Point(182, 22);
            Colors_TitlesColorSelect.Name = "Colors_TitlesColorSelect";
            Colors_TitlesColorSelect.Size = new Size(66, 23);
            Colors_TitlesColorSelect.TabIndex = 6;
            Colors_TitlesColorSelect.Text = "Choisir";
            Colors_TitlesColorSelect.UseVisualStyleBackColor = true;
            Colors_TitlesColorSelect.Click += Colors_TitlesColorSelect_Click;
            // 
            // Colors_TitlesColor
            // 
            Colors_TitlesColor.Location = new Point(76, 22);
            Colors_TitlesColor.Name = "Colors_TitlesColor";
            Colors_TitlesColor.Size = new Size(100, 23);
            Colors_TitlesColor.TabIndex = 5;
            // 
            // Colors_TitlesColorLabel
            // 
            Colors_TitlesColorLabel.AutoSize = true;
            Colors_TitlesColorLabel.Location = new Point(26, 25);
            Colors_TitlesColorLabel.Name = "Colors_TitlesColorLabel";
            Colors_TitlesColorLabel.Size = new Size(46, 17);
            Colors_TitlesColorLabel.TabIndex = 4;
            Colors_TitlesColorLabel.Text = "Titres :";
            // 
            // SettingsColorPicker
            // 
            SettingsColorPicker.AnyColor = true;
            // 
            // Colors_OnDayContrastColorSelect
            // 
            Colors_OnDayContrastColorSelect.ForeColor = Color.Black;
            Colors_OnDayContrastColorSelect.Location = new Point(579, 52);
            Colors_OnDayContrastColorSelect.Name = "Colors_OnDayContrastColorSelect";
            Colors_OnDayContrastColorSelect.Size = new Size(66, 23);
            Colors_OnDayContrastColorSelect.TabIndex = 15;
            Colors_OnDayContrastColorSelect.Text = "Choisir";
            Colors_OnDayContrastColorSelect.UseVisualStyleBackColor = true;
            Colors_OnDayContrastColorSelect.Click += Colors_OnDayContrastColorSelect_Click;
            // 
            // Colors_OnDayContrastColor
            // 
            Colors_OnDayContrastColor.Location = new Point(473, 52);
            Colors_OnDayContrastColor.Name = "Colors_OnDayContrastColor";
            Colors_OnDayContrastColor.Size = new Size(100, 23);
            Colors_OnDayContrastColor.TabIndex = 14;
            // 
            // Colors_OnDayContrastColorLabel
            // 
            Colors_OnDayContrastColorLabel.AutoSize = true;
            Colors_OnDayContrastColorLabel.Location = new Point(329, 55);
            Colors_OnDayContrastColorLabel.Name = "Colors_OnDayContrastColorLabel";
            Colors_OnDayContrastColorLabel.Size = new Size(138, 17);
            Colors_OnDayContrastColorLabel.TabIndex = 13;
            Colors_OnDayContrastColorLabel.Text = "Jour on (contrasté) :";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(784, 561);
            Controls.Add(Colors_Group);
            Controls.Add(GraphicalElements_Group);
            Controls.Add(Header_Title);
            Controls.Add(Header_Icon);
            Controls.Add(Footer_SaveAndClose);
            Font = new Font("Century Gothic", 9.75F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paramètres de génération";
            ((System.ComponentModel.ISupportInitialize)Header_Icon).EndInit();
            GraphicalElements_Group.ResumeLayout(false);
            GraphicalElements_Group.PerformLayout();
            Colors_Group.ResumeLayout(false);
            Colors_Group.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Footer_SaveAndClose;
        private Label Header_Title;
        private PictureBox Header_Icon;
        private Label GraphicalElements_ImgBgLabel;
        private TextBox GraphicalElements_ImgBgPath;
        private Button GraphicalElements_ImgBgFind;
        private GroupBox GraphicalElements_Group;
        private OpenFileDialog SettingsUserFileChoose;
        private GroupBox Colors_Group;
        private TextBox Colors_TitlesColor;
        private Label Colors_TitlesColorLabel;
        private ColorDialog SettingsColorPicker;
        private Button Colors_TitlesColorSelect;
        private Button Colors_OnDayColorSelect;
        private TextBox Colors_OnDayColor;
        private Label Colors_OnDayColorLabel;
        private Button Colors_OffDayColorSelect;
        private TextBox Colors_OffDayColor;
        private Label Colors_OffDayColorLabel;
        private Button Colors_OnDayContrastColorSelect;
        private TextBox Colors_OnDayContrastColor;
        private Label Colors_OnDayContrastColorLabel;
    }
}