using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookPanel
    {
        public Panel panel = new Panel();
        public PictureBox pictureBox = new PictureBox();
        public Label title_lbl = new Label();
        public Label author_lbl = new Label();
        public Label publisher_lbl = new Label();
        public Label qty_lbl = new Label();
        public Button giveBook_btn = new Button();
        public Button pickUp_btn = new Button();
        public BookPanel() { }
        public BookPanel(Panel SearchBooksPanel, int k)
        {
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Controls.Add(giveBook_btn);
            panel.Controls.Add(pickUp_btn);
            panel.Controls.Add(qty_lbl);
            panel.Controls.Add(publisher_lbl);
            panel.Controls.Add(author_lbl);
            panel.Controls.Add(title_lbl);
            panel.Controls.Add(pictureBox);
            panel.Location = new System.Drawing.Point(9, 59 + k * 150);
            panel.Name = "panel0";
            panel.Size = new System.Drawing.Size(718, 134);
            panel.TabIndex = 1;
            panel.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            panel.Dock = DockStyle.Top;
            // 
            // giveBook_btn
            // 
            giveBook_btn.BackColor = System.Drawing.Color.Salmon;
            giveBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            giveBook_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            giveBook_btn.Location = new System.Drawing.Point(571, 98);
            giveBook_btn.Name = "delete_button";
            giveBook_btn.Size = new System.Drawing.Size(142, 29);
            giveBook_btn.TabIndex = 6;
            giveBook_btn.Text = "Удалить встречу";
            giveBook_btn.UseVisualStyleBackColor = false;
            giveBook_btn.Anchor = AnchorStyles.Right;
            // 
            // pickUp_btn
            // 
            pickUp_btn.BackColor = System.Drawing.Color.Salmon;
            pickUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            pickUp_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            pickUp_btn.Location = new System.Drawing.Point(571, 98);
            pickUp_btn.Name = "delete_button";
            pickUp_btn.Size = new System.Drawing.Size(142, 29);
            pickUp_btn.TabIndex = 6;
            pickUp_btn.Text = "Удалить встречу";
            pickUp_btn.UseVisualStyleBackColor = false;
            pickUp_btn.Anchor = AnchorStyles.Right;
            // 
            // textBox
            // 
            //textBox.BackColor = System.Drawing.Color.White;
            //textBox.Enabled = false;
            //textBox.HideSelection = false;
            //textBox.Location = new System.Drawing.Point(70, 4);
            //textBox.Multiline = true;
            //textBox.Name = "textBox";
            //textBox.PlaceholderText = "Автор: " + /*meet.name +*/ "\n"
            //    + "Название: " + /*meet.phone_number +*/ "\n"
            //    + "Год издания: " + /*meet.town +*/ "\n"
            //    + "Издательство: " ;
            //textBox.ReadOnly = true;
            //textBox.Size = new System.Drawing.Size(643, 88);
            //textBox.TabIndex = 4;
            //textBox.TabStop = false;
            //textBox.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            //// 
            //// label
            //// 
            //label.AutoSize = true;
            //label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            //label.Location = new System.Drawing.Point(3, 0);
            //label.Name = "label0";
            //label.Size = new System.Drawing.Size(61, 28);
            //label.TabIndex = 0;
            //label.Text = "Тут есть текст"/*meet.date.ToString("HH:mm")*/;
            //// 
            //// label_d
            //// 
            //label_d.AutoSize = true;
            //label_d.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.GraphicsUnit.Point);
            //label_d.Location = new System.Drawing.Point(3, 30);
            //label_d.Name = "label0";
            //label_d.Size = new System.Drawing.Size(61, 28);
            //label_d.TabIndex = 0;
            //label_d.Text = "Тут тоже есть текст"/*meet.date.ToString("d")*/;

            SearchBooksPanel.Controls.Add(panel);
        }
    }
}