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
            ((System.ComponentModel.ISupportInitialize)Header_Icon).BeginInit();
            GraphicalElements_Group.SuspendLayout();
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
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(784, 561);
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
    }
}