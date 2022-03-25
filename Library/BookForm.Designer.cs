namespace LibraryForm
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.LoadImageBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PublisherTxtBox = new System.Windows.Forms.TextBox();
            this.TittleTxtBox = new System.Windows.Forms.TextBox();
            this.AuthorTxtBox = new System.Windows.Forms.TextBox();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.PublicDateLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.NumberOfBooksTxtBox = new System.Windows.Forms.TextBox();
            this.NumberOfBooksLbl = new System.Windows.Forms.Label();
            this.PublicDateMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadImageBtn
            // 
            this.LoadImageBtn.BackColor = System.Drawing.Color.Bisque;
            this.LoadImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadImageBtn.Location = new System.Drawing.Point(12, 220);
            this.LoadImageBtn.Name = "LoadImageBtn";
            this.LoadImageBtn.Size = new System.Drawing.Size(150, 53);
            this.LoadImageBtn.TabIndex = 34;
            this.LoadImageBtn.Text = "Загрузить изображение";
            this.LoadImageBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.LightGreen;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(374, 239);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 34);
            this.SaveBtn.TabIndex = 33;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(474, 239);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 34);
            this.DeleteBtn.TabIndex = 32;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PublisherTxtBox
            // 
            this.PublisherTxtBox.Location = new System.Drawing.Point(361, 137);
            this.PublisherTxtBox.Name = "PublisherTxtBox";
            this.PublisherTxtBox.Size = new System.Drawing.Size(221, 27);
            this.PublisherTxtBox.TabIndex = 31;
            this.PublisherTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // TittleTxtBox
            // 
            this.TittleTxtBox.Location = new System.Drawing.Point(361, 57);
            this.TittleTxtBox.Name = "TittleTxtBox";
            this.TittleTxtBox.Size = new System.Drawing.Size(221, 27);
            this.TittleTxtBox.TabIndex = 29;
            // 
            // AuthorTxtBox
            // 
            this.AuthorTxtBox.Location = new System.Drawing.Point(361, 17);
            this.AuthorTxtBox.Name = "AuthorTxtBox";
            this.AuthorTxtBox.Size = new System.Drawing.Size(221, 27);
            this.AuthorTxtBox.TabIndex = 28;
            this.AuthorTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Check_Is_Digit);
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublisherLbl.Location = new System.Drawing.Point(188, 136);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(136, 28);
            this.PublisherLbl.TabIndex = 26;
            this.PublisherLbl.Text = "Издательство";
            // 
            // PublicDateLbl
            // 
            this.PublicDateLbl.AutoSize = true;
            this.PublicDateLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublicDateLbl.Location = new System.Drawing.Point(188, 96);
            this.PublicDateLbl.Name = "PublicDateLbl";
            this.PublicDateLbl.Size = new System.Drawing.Size(125, 28);
            this.PublicDateLbl.TabIndex = 24;
            this.PublicDateLbl.Text = "Год издания";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(188, 56);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(100, 28);
            this.NameLbl.TabIndex = 23;
            this.NameLbl.Text = "Название";
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorLbl.Location = new System.Drawing.Point(188, 16);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(68, 28);
            this.AuthorLbl.TabIndex = 22;
            this.AuthorLbl.Text = "Автор";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.Image = global::Library.Properties.Resources.NoPicture;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 14);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(150, 200);
            this.PhotoPictureBox.TabIndex = 21;
            this.PhotoPictureBox.TabStop = false;
            // 
            // NumberOfBooksTxtBox
            // 
            this.NumberOfBooksTxtBox.Location = new System.Drawing.Point(362, 177);
            this.NumberOfBooksTxtBox.Name = "NumberOfBooksTxtBox";
            this.NumberOfBooksTxtBox.Size = new System.Drawing.Size(221, 27);
            this.NumberOfBooksTxtBox.TabIndex = 36;
            this.NumberOfBooksTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfBooksTxtBox_KeyPress);
            // 
            // NumberOfBooksLbl
            // 
            this.NumberOfBooksLbl.AutoSize = true;
            this.NumberOfBooksLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfBooksLbl.Location = new System.Drawing.Point(189, 176);
            this.NumberOfBooksLbl.Name = "NumberOfBooksLbl";
            this.NumberOfBooksLbl.Size = new System.Drawing.Size(167, 28);
            this.NumberOfBooksLbl.TabIndex = 35;
            this.NumberOfBooksLbl.Text = "Количество книг";
            // 
            // PublicDateMskdTxtBox
            // 
            this.PublicDateMskdTxtBox.Location = new System.Drawing.Point(361, 97);
            this.PublicDateMskdTxtBox.Mask = "0000";
            this.PublicDateMskdTxtBox.Name = "PublicDateMskdTxtBox";
            this.PublicDateMskdTxtBox.Size = new System.Drawing.Size(221, 27);
            this.PublicDateMskdTxtBox.TabIndex = 37;
            this.PublicDateMskdTxtBox.ValidatingType = typeof(int);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 288);
            this.Controls.Add(this.PublicDateMskdTxtBox);
            this.Controls.Add(this.NumberOfBooksTxtBox);
            this.Controls.Add(this.NumberOfBooksLbl);
            this.Controls.Add(this.LoadImageBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.PublisherTxtBox);
            this.Controls.Add(this.TittleTxtBox);
            this.Controls.Add(this.AuthorTxtBox);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.PublicDateLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AuthorLbl);
            this.Controls.Add(this.PhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление книги";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LoadImageBtn;
        private Button SaveBtn;
        private Button DeleteBtn;
        private TextBox PublisherTxtBox;
        private TextBox TittleTxtBox;
        private TextBox AuthorTxtBox;
        private Label PublisherLbl;
        private Label PublicDateLbl;
        private Label NameLbl;
        private Label AuthorLbl;
        private PictureBox PhotoPictureBox;
        private TextBox NumberOfBooksTxtBox;
        private Label NumberOfBooksLbl;
        private MaskedTextBox PublicDateMskdTxtBox;
    }
}