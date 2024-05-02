namespace TrelloApps
{
    partial class TrelloManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelBoards = new System.Windows.Forms.Button();
            this.ListBoard = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnAddBoard = new System.Windows.Forms.Button();
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelListCards = new System.Windows.Forms.Label();
            this.btnDelListCards = new System.Windows.Forms.Button();
            this.btnAddListCards = new System.Windows.Forms.Button();
            this.textBListCards = new System.Windows.Forms.TextBox();
            this.listCards = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCards = new System.Windows.Forms.Button();
            this.btnDelCards = new System.Windows.Forms.Button();
            this.textBCards = new System.Windows.Forms.TextBox();
            this.Cards = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnDelBoards);
            this.panel1.Controls.Add(this.ListBoard);
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 413);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách bảng";
            // 
            // btnDelBoards
            // 
            this.btnDelBoards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelBoards.Location = new System.Drawing.Point(223, 379);
            this.btnDelBoards.Name = "btnDelBoards";
            this.btnDelBoards.Size = new System.Drawing.Size(88, 31);
            this.btnDelBoards.TabIndex = 4;
            this.btnDelBoards.Text = "Xóa";
            this.btnDelBoards.UseVisualStyleBackColor = true;
            this.btnDelBoards.Click += new System.EventHandler(this.btnDelBoards_Click);
            // 
            // ListBoard
            // 
            this.ListBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ListBoard.FormattingEnabled = true;
            this.ListBoard.ItemHeight = 18;
            this.ListBoard.Location = new System.Drawing.Point(3, 44);
            this.ListBoard.Name = "ListBoard";
            this.ListBoard.Size = new System.Drawing.Size(311, 310);
            this.ListBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bttnAddBoard);
            this.panel2.Controls.Add(this.txtBoard);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 57);
            this.panel2.TabIndex = 1;
            // 
            // bttnAddBoard
            // 
            this.bttnAddBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttnAddBoard.Location = new System.Drawing.Point(223, 13);
            this.bttnAddBoard.Name = "bttnAddBoard";
            this.bttnAddBoard.Size = new System.Drawing.Size(88, 31);
            this.bttnAddBoard.TabIndex = 2;
            this.bttnAddBoard.Text = "Tạo bảng";
            this.bttnAddBoard.UseVisualStyleBackColor = true;
            this.bttnAddBoard.Click += new System.EventHandler(this.bttnAddBoard_Click);
            // 
            // txtBoard
            // 
            this.txtBoard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoard.Location = new System.Drawing.Point(3, 13);
            this.txtBoard.Multiline = true;
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(214, 31);
            this.txtBoard.TabIndex = 0;
            this.txtBoard.Text = "Nhập tiêu đề cho bảng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelListCards);
            this.panel3.Controls.Add(this.btnDelListCards);
            this.panel3.Controls.Add(this.btnAddListCards);
            this.panel3.Controls.Add(this.textBListCards);
            this.panel3.Controls.Add(this.listCards);
            this.panel3.Location = new System.Drawing.Point(335, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 308);
            this.panel3.TabIndex = 2;
            // 
            // labelListCards
            // 
            this.labelListCards.AutoSize = true;
            this.labelListCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelListCards.Location = new System.Drawing.Point(8, 24);
            this.labelListCards.Name = "labelListCards";
            this.labelListCards.Size = new System.Drawing.Size(131, 20);
            this.labelListCards.TabIndex = 4;
            this.labelListCards.Text = "Danh sách thẻ";
            // 
            // btnDelListCards
            // 
            this.btnDelListCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelListCards.Location = new System.Drawing.Point(410, 263);
            this.btnDelListCards.Name = "btnDelListCards";
            this.btnDelListCards.Size = new System.Drawing.Size(88, 31);
            this.btnDelListCards.TabIndex = 3;
            this.btnDelListCards.Text = "Xóa";
            this.btnDelListCards.UseVisualStyleBackColor = true;
            this.btnDelListCards.Click += new System.EventHandler(this.btnDelListCards_Click);
            // 
            // btnAddListCards
            // 
            this.btnAddListCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddListCards.Location = new System.Drawing.Point(297, 265);
            this.btnAddListCards.Name = "btnAddListCards";
            this.btnAddListCards.Size = new System.Drawing.Size(88, 31);
            this.btnAddListCards.TabIndex = 2;
            this.btnAddListCards.Text = "Thêm";
            this.btnAddListCards.UseVisualStyleBackColor = true;
            this.btnAddListCards.Click += new System.EventHandler(this.btnAddListCards_Click);
            // 
            // textBListCards
            // 
            this.textBListCards.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBListCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBListCards.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBListCards.Location = new System.Drawing.Point(12, 265);
            this.textBListCards.Multiline = true;
            this.textBListCards.Name = "textBListCards";
            this.textBListCards.Size = new System.Drawing.Size(279, 31);
            this.textBListCards.TabIndex = 0;
            this.textBListCards.Text = "Nhập tiêu đề cho danh sách";
            // 
            // listCards
            // 
            this.listCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listCards.FormattingEnabled = true;
            this.listCards.ItemHeight = 18;
            this.listCards.Location = new System.Drawing.Point(3, 47);
            this.listCards.Name = "listCards";
            this.listCards.Size = new System.Drawing.Size(507, 202);
            this.listCards.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnAddCards);
            this.panel4.Controls.Add(this.btnDelCards);
            this.panel4.Controls.Add(this.textBCards);
            this.panel4.Controls.Add(this.Cards);
            this.panel4.Location = new System.Drawing.Point(335, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(513, 345);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thẻ";
            // 
            // btnAddCards
            // 
            this.btnAddCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddCards.Location = new System.Drawing.Point(297, 300);
            this.btnAddCards.Name = "btnAddCards";
            this.btnAddCards.Size = new System.Drawing.Size(88, 31);
            this.btnAddCards.TabIndex = 5;
            this.btnAddCards.Text = "Thêm";
            this.btnAddCards.UseVisualStyleBackColor = true;
            this.btnAddCards.Click += new System.EventHandler(this.btnAddCards_Click);
            // 
            // btnDelCards
            // 
            this.btnDelCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelCards.Location = new System.Drawing.Point(410, 300);
            this.btnDelCards.Name = "btnDelCards";
            this.btnDelCards.Size = new System.Drawing.Size(88, 31);
            this.btnDelCards.TabIndex = 4;
            this.btnDelCards.Text = "Xóa";
            this.btnDelCards.UseVisualStyleBackColor = true;
            // 
            // textBCards
            // 
            this.textBCards.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBCards.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBCards.Location = new System.Drawing.Point(12, 300);
            this.textBCards.Multiline = true;
            this.textBCards.Name = "textBCards";
            this.textBCards.Size = new System.Drawing.Size(279, 31);
            this.textBCards.TabIndex = 1;
            this.textBCards.Text = "Nhập tiêu đề cho thẻ";
            // 
            // Cards
            // 
            this.Cards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cards.FormattingEnabled = true;
            this.Cards.ItemHeight = 18;
            this.Cards.Location = new System.Drawing.Point(3, 38);
            this.Cards.Name = "Cards";
            this.Cards.Size = new System.Drawing.Size(507, 256);
            this.Cards.TabIndex = 0;
            // 
            // TrelloManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 726);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TrelloManagement";
            this.Text = "TrelloManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnAddBoard;
        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.ListBox ListBoard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listCards;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox Cards;
        private System.Windows.Forms.Button btnDelBoards;
        private System.Windows.Forms.Button btnDelListCards;
        private System.Windows.Forms.Button btnAddListCards;
        private System.Windows.Forms.TextBox textBListCards;
        private System.Windows.Forms.Button btnAddCards;
        private System.Windows.Forms.Button btnDelCards;
        private System.Windows.Forms.TextBox textBCards;
        private System.Windows.Forms.Label labelListCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}