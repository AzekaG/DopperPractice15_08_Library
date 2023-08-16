using DopperPractice15_08.Model;

namespace DopperPractice15_08
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller();
            comboBoxAuthors.DataSource = controller.GetAuthorList();
            listBoxBooks.DataSource = controller.GetBookList((Author)comboBoxAuthors.SelectedItem);
        }

        private void listBoxBooks_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxBooks.DataSource = controller.GetBookList((Author)comboBoxAuthors.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text != "" && textBoxSurname.Text != "")
            {
                controller.AddAuthor(textBoxName.Text, textBoxSurname.Text);
                comboBoxAuthors.DataSource = controller.GetAuthorList();
                MessageBox.Show("New author was Added");
            }
            else MessageBox.Show("Enter Full Data");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text != "" || textBoxSurname.Text != "")
            {
                if (textBoxName.Text == "")
                {
                    listBoxBooks.DataSource = controller.GetAuthorListBySurName(textBoxSurname.Text);

                }

                else if (textBoxSurname.Text == "")
                {
                    listBoxBooks.DataSource = controller.GetAuthorListByName(textBoxName.Text);
                }
                else
                {
                    listBoxBooks.DataSource = controller.GetAuthorListByName(textBoxName.Text, textBoxSurname.Text);
                }


            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            if (txtBoxNameBook.Text != "" && txtBoxyearPress.Text != "")
            {
                controller.AddBook(new Book { Name = txtBoxNameBook.Text, YearPress = int.Parse(txtBoxyearPress.Text) },
                    (Author)comboBoxAuthors.SelectedItem);
            }
            listBoxBooks.DataSource = controller.GetBookList((Author)comboBoxAuthors.SelectedItem);
            MessageBox.Show("Book was added");

        }

        private void txtBoxyearPress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;
            e.Handled = true;

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItems.Count == 0) return;
            Book book = (Book)listBoxBooks.SelectedItem;
            controller.DeleteBook(book);
            listBoxBooks.DataSource = controller.GetBookList((Author)comboBoxAuthors.SelectedItem);

        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            controller.DeleteAuthor((Author)comboBoxAuthors.SelectedItem);
            comboBoxAuthors.DataSource = controller.GetAuthorList();
        }
    }
}
