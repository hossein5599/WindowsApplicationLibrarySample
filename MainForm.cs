using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppLibrarySample.Data;
using WindowsAppLibrarySample.Models;
using WindowsAppLibrarySample.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsAppLibrarySample
{

    public partial class MainForm : Form
    {
        private readonly Services.Library _libraryService;
        public MainForm(Services.Library libraryService)
        {
            _libraryService = libraryService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnList.Text = "نمایش کل کتاب ها";

            //new book panel
            lblTitle.Text = "عنوان";
            lblAuthor.Text = "نویسنده";
            lblIsbn.Text = "ISBN";
            lblYearPublished.Text = "سال نشر";
            btnAdd.Text = "افزودن";
            btnClearNewBook.Text = "پاک کردن";

            //remove panel
            lblISBNRemove.Text = "ISBN";
            btnRemove.Text = "حذف";
            btnClearRemoveByISBN.Text = "پاک کردن";

            LoadBooks();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(txtIsbn.Text) || string.IsNullOrWhiteSpace(txtYearPublished.Text))
            {
                MessageBox.Show("Fill All Text Boxes Please!");
                return;
            }
            try
            {
                var book = new Book()
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtIsbn.Text,
                    YearPublished = int.Parse(txtYearPublished.Text)
                };


                _libraryService.AddBook(book);
                MessageBox.Show("Books added!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Books Is Not added And Error {ex.Message}!");
            }
            ClearFieldsAddBook();
            LoadBooks();

        }
        private void LoadBooks()
        {
            lbBooks.Items.Clear();
            var books = _libraryService.ListBooks();

            foreach (var book in books)
            {
                lbBooks.Items.Add(book);
            }
        }

        private void ClearFieldsAddBook()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtIsbn.Clear();
            txtYearPublished.Clear();
        }

        private void ClearFieldsRemoveBook()
        {
            txtISBNRemove.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISBNRemove.Text))
            {
                MessageBox.Show("ISB Is Empty!");
                return;
            }
            try
            {

                var isbn = txtISBNRemove.Text;
                var isRemoved = _libraryService.RemoveBook(isbn);

                if (isRemoved)
                {
                    MessageBox.Show("Book Removed!");
                }
                else
                {
                    MessageBox.Show("Failed!! Book Is Not Found Or Is Not Removed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Books Is Not added And Error {ex.Message}!");
            }
            ClearFieldsRemoveBook();
            LoadBooks();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ClearFieldsAddBook();
            ClearFieldsRemoveBook();
            LoadBooks();
        }

        private void btnClearNewBook_Click(object sender, EventArgs e)
        {
            ClearFieldsAddBook();
        }

        private void btnClearRemoveByISBN_Click(object sender, EventArgs e)
        {
            ClearFieldsRemoveBook();
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null)
            {
                var selectedItem = lbBooks.SelectedItem.ToString();
                var isbn = ExtractIsbn(selectedItem);
                txtISBNRemove.Text = isbn;
                //MessageBox.Show("You selected: " + isbn);
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private string ExtractIsbn(string item)
        {
            // Example: "Title by Author, ISBN: 1234567890, Year: 1400"
            string[] parts = item.Split(new[] { ", " }, StringSplitOptions.None);

            foreach (var part in parts)
            {
                if (part.StartsWith("ISBN:"))
                {
                    return part.Substring("ISBN: ".Length).Trim();
                }
            }
            return string.Empty;
        }
    }
}
