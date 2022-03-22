namespace LibraryForm
{
    partial class FirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstForm));
            this.ReaderCardTxtBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.ReaderCardLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.CreateCardBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReaderCardTxtBox
            // 
            this.ReaderCardTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReaderCardTxtBox.Location = new System.Drawing.Point(55, 161);
            this.ReaderCardTxtBox.MaxLength = 12;
            this.ReaderCardTxtBox.Name = "ReaderCardTxtBox";
            this.ReaderCardTxtBox.Size = new System.Drawing.Size(361, 34);
            this.ReaderCardTxtBox.TabIndex = 0;
            this.ReaderCardTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReaderCardTxtBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ReaderCardTxtBox_PreviewKeyDown);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NameLbl.Location = new System.Drawing.Point(95, 60);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(257, 41);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "\"КИТАП-БАЛЫК\"";
            // 
            // ReaderCardLbl
            // 
            this.ReaderCardLbl.AutoSize = true;
            this.ReaderCardLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReaderCardLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReaderCardLbl.Location = new System.Drawing.Point(55, 135);
            this.ReaderCardLbl.Name = "ReaderCardLbl";
            this.ReaderCardLbl.Size = new System.Drawing.Size(210, 23);
            this.ReaderCardLbl.TabIndex = 2;
            this.ReaderCardLbl.Text = "№ читательского билета";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InfoLbl.Location = new System.Drawing.Point(64, 287);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(309, 20);
            this.InfoLbl.TabIndex = 3;
            this.InfoLbl.Text = "----------Нет читательского билета----------";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Orange;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(95, 226);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(250, 37);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Войти в приложение";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // CreateCardBtn
            // 
            this.CreateCardBtn.BackColor = System.Drawing.Color.Silver;
            this.CreateCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCardBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateCardBtn.ForeColor = System.Drawing.Color.DimGray;
            this.CreateCardBtn.Location = new System.Drawing.Point(95, 337);
            this.CreateCardBtn.Name = "CreateCardBtn";
            this.CreateCardBtn.Size = new System.Drawing.Size(250, 37);
            this.CreateCardBtn.TabIndex = 5;
            this.CreateCardBtn.Text = "Завести читательский билет";
            this.CreateCardBtn.UseVisualStyleBackColor = false;
            this.CreateCardBtn.Click += new System.EventHandler(this.CreateCardBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.NameLbl);
            this.MainPanel.Controls.Add(this.CreateCardBtn);
            this.MainPanel.Controls.Add(this.ReaderCardTxtBox);
            this.MainPanel.Controls.Add(this.LoginBtn);
            this.MainPanel.Controls.Add(this.ReaderCardLbl);
            this.MainPanel.Controls.Add(this.InfoLbl);
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Location = new System.Drawing.Point(308, 57);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(448, 434);
            this.MainPanel.TabIndex = 6;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 560);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox ReaderCardTxtBox;
        private Label NameLbl;
        private Label ReaderCardLbl;
        private Label InfoLbl;
        private Button LoginBtn;
        private Button CreateCardBtn;
        private Panel MainPanel;
    }
}