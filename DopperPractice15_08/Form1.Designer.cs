namespace DopperPractice15_08
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxBooks = new ListBox();
            comboBoxAuthors = new ComboBox();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtBoxNameBook = new TextBox();
            txtBoxyearPress = new TextBox();
            btnAddBook = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnDeleteBook = new Button();
            btnDeleteAuthor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(12, 12);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(550, 94);
            listBoxBooks.TabIndex = 0;
            listBoxBooks.SelectedValueChanged += listBoxBooks_SelectedValueChanged;
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(568, 12);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(225, 23);
            comboBoxAuthors.TabIndex = 1;
            comboBoxAuthors.SelectedIndexChanged += comboBoxAuthors_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 165);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(124, 23);
            textBoxName.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 208);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(124, 23);
            textBoxSurname.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 147);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 190);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // button1
            // 
            button1.Location = new Point(12, 237);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 6;
            button1.Text = "Добавить автора";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 266);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 7;
            button2.Text = "Поиск Автора";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBoxNameBook
            // 
            txtBoxNameBook.Location = new Point(191, 165);
            txtBoxNameBook.Name = "txtBoxNameBook";
            txtBoxNameBook.Size = new Size(144, 23);
            txtBoxNameBook.TabIndex = 8;
            // 
            // txtBoxyearPress
            // 
            txtBoxyearPress.Location = new Point(191, 208);
            txtBoxyearPress.Name = "txtBoxyearPress";
            txtBoxyearPress.Size = new Size(144, 23);
            txtBoxyearPress.TabIndex = 9;
            txtBoxyearPress.KeyPress += txtBoxyearPress_KeyPress;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(191, 241);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(144, 48);
            btnAddBook.TabIndex = 10;
            btnAddBook.Text = "Доабвить книгу выбранному автору";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 147);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 11;
            label3.Text = "Название книги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 190);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 12;
            label4.Text = "Год выпуска";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Menu;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(510, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(13, 112);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(137, 23);
            btnDeleteBook.TabIndex = 14;
            btnDeleteBook.Text = "Удалить книгу";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(571, 46);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(222, 23);
            btnDeleteAuthor.TabIndex = 15;
            btnDeleteAuthor.Text = "Удалить автора";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 294);
            Controls.Add(btnDeleteAuthor);
            Controls.Add(btnDeleteBook);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddBook);
            Controls.Add(txtBoxyearPress);
            Controls.Add(txtBoxNameBook);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxAuthors);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxBooks;
        private ComboBox comboBoxAuthors;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private TextBox txtBoxNameBook;
        private TextBox txtBoxyearPress;
        private Button btnAddBook;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnDeleteBook;
        private Button btnDeleteAuthor;
    }
}