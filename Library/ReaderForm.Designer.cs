namespace LibraryForm
{
    partial class ReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.PatronymicLbl = new System.Windows.Forms.Label();
            this.CardNumberLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.SurnameTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.PatronymicTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.CardNumberMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneNumberMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(150, 200);
            this.PhotoPictureBox.TabIndex = 1;
            this.PhotoPictureBox.TabStop = false;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameLbl.Location = new System.Drawing.Point(188, 14);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(96, 28);
            this.SurnameLbl.TabIndex = 4;
            this.SurnameLbl.Text = "Фамилия";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(188, 54);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 28);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Имя";
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatronymicLbl.Location = new System.Drawing.Point(188, 94);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(96, 28);
            this.PatronymicLbl.TabIndex = 6;
            this.PatronymicLbl.Text = "Отчество";
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardNumberLbl.Location = new System.Drawing.Point(188, 134);
            this.CardNumberLbl.Name = "CardNumberLbl";
            this.CardNumberLbl.Size = new System.Drawing.Size(133, 28);
            this.CardNumberLbl.TabIndex = 7;
            this.CardNumberLbl.Text = "Номер карты";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLbl.Location = new System.Drawing.Point(188, 174);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(67, 28);
            this.AddressLbl.TabIndex = 8;
            this.AddressLbl.Text = "Адрес";
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLbl.Location = new System.Drawing.Point(188, 214);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(166, 28);
            this.PhoneNumberLbl.TabIndex = 9;
            this.PhoneNumberLbl.Text = "Номер телефона";
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.Location = new System.Drawing.Point(361, 15);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.Size = new System.Drawing.Size(221, 27);
            this.SurnameTxtBox.TabIndex = 10;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(361, 55);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(221, 27);
            this.NameTxtBox.TabIndex = 11;
            // 
            // PatronymicTxtBox
            // 
            this.PatronymicTxtBox.Location = new System.Drawing.Point(361, 95);
            this.PatronymicTxtBox.Name = "PatronymicTxtBox";
            this.PatronymicTxtBox.Size = new System.Drawing.Size(221, 27);
            this.PatronymicTxtBox.TabIndex = 12;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(361, 175);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(221, 27);
            this.AddressTxtBox.TabIndex = 14;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(473, 259);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(94, 34);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(373, 259);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 34);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.BackColor = System.Drawing.Color.Bisque;
            this.LoadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageBtn.Location = new System.Drawing.Point(12, 218);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(150, 53);
            this.LoadImageBtn.TabIndex = 18;
            this.LoadImageBtn.Text = "Загрузить изображение";
            this.LoadImageBtn.UseVisualStyleBackColor = false;
            // 
            // CardNumberMskdTxtBox
            // 
            this.CardNumberMskdTxtBox.Location = new System.Drawing.Point(361, 135);
            this.CardNumberMskdTxtBox.Mask = "000000000000";
            this.CardNumberMskdTxtBox.Name = "CardNumberMskdTxtBox";
            this.CardNumberMskdTxtBox.PromptChar = '#';
            this.CardNumberMskdTxtBox.Size = new System.Drawing.Size(221, 27);
            this.CardNumberMskdTxtBox.TabIndex = 19;
            // 
            // PhoneNumberMskdTxtBox
            // 
            this.PhoneNumberMskdTxtBox.Location = new System.Drawing.Point(361, 215);
            this.PhoneNumberMskdTxtBox.Mask = "+7 (999) 000-0000";
            this.PhoneNumberMskdTxtBox.Name = "PhoneNumberMskdTxtBox";
            this.PhoneNumberMskdTxtBox.Size = new System.Drawing.Size(221, 27);
            this.PhoneNumberMskdTxtBox.TabIndex = 20;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 309);
            this.Controls.Add(this.PhoneNumberMskdTxtBox);
            this.Controls.Add(this.CardNumberMskdTxtBox);
            this.Controls.Add(this.LoadImageBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.PatronymicTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.SurnameTxtBox);
            this.Controls.Add(this.PhoneNumberLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.CardNumberLbl);
            this.Controls.Add(this.PatronymicLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.PhotoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Читатель";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PhotoPictureBox;
        private Label SurnameLbl;
        private Label NameLbl;
        private Label PatronymicLbl;
        private Label CardNumberLbl;
        private Label AddressLbl;
        private Label PhoneNumberLbl;
        private TextBox SurnameTxtBox;
        private TextBox NameTxtBox;
        private TextBox PatronymicTxtBox;
        private TextBox AddressTxtBox;
        private Button CancelBtn;
        private Button SaveBtn;
        private Button LoadImageBtn;
        private MaskedTextBox CardNumberMskdTxtBox;
        private MaskedTextBox PhoneNumberMskdTxtBox;
    }
}