using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace E_Book_Library
{
    public partial class Form1 : Form
    {
        Profile myProfile;
        public string SelectdFolder;
        List<Books> book = new List<Books>();
        ListViewItem imageListView = new ListViewItem();
        public Form1()
        {
            InitializeComponent();
            book.Add(new Books("progit.pdf",
                System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            book.Add(new Books("Guid-To-Charges-By-Banks.pdf"
                , System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            book.Add(new Books("HOD.pdf",
                System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            book.Add(new Books("Head First C_, 3rd Edition.pdf",
                System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            book.Add(new Books("HOD EP 21.pdf",
                System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            book.Add(new Books("HOD EP22.pdf",
                System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            book.Add(new Books("HOD EP 23.pdf",
                System.Drawing.Image.FromFile("C://Users//Acer//Desktop/book.png")));
            foreach (Books item in book)
            {
                comboBox1.Items.Add(item.bookName);
                imageList1.Images.Add(item.bookIcon);
                ListViewItem items = new ListViewItem();
                items.ImageIndex = book.IndexOf(item);
                listView1.Items.Add(items);
                imageListView.ImageIndex = book.IndexOf(item);
            }
            UpdateForm();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please Help Us Know It's You", "Please login", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Sorry, What You Seek Is Not Here");
                Application.Exit();
            }
        }
        private void saveChanges_Click(object sender, EventArgs e)
        {
            myProfile = new Profile();
            if (!string.IsNullOrEmpty(userName.Text))
            {
                userName.Text = myProfile.UserName(userName.Text);
                usersName.Text = userName.Text;
            }
            else
            {
                usersName.Text = "Your Name Please";
            }
            if (masculine.Checked)
                genders.Text = gender.Male.ToString();
            else if (feminine.Checked)
                genders.Text = gender.Female.ToString();
            else if (dontKnow.Checked)
                genders.Text = gender.DontKnow.ToString();
            else
                genders.Text = gender.DontKnow.ToString();
            userName.Clear();
            if (!string.IsNullOrEmpty(picName.Text))
                pictureBox1.Load(picName.Text);
            else
                pictureBox1.InitialImage = null;
            tabControl1.SelectedIndex = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void readerBoard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void myMarket_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void openBook_Click(object sender, EventArgs e)
        {
            readBook.src = @"C://Users//Acer//Desktop/" + comboBox1.SelectedItem;
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void editPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "JPEG Files(*.jpg)|*.jpg";
            Open.FileName = "";
            DialogResult result = Open.ShowDialog();
            if (result == DialogResult.OK)
            {
                picName.Text = Open.FileName;
            }
        }
        private void UpdateForm()
        {
            foreach (Books Bookitem in book)
            {
                Bookitem.bookName = comboBox1.Items.ToString();
                comboBox1.SelectedIndex = 0;

            }
            listView1.ArrangeIcons(ListViewAlignment.Top);
            listView1.View = View.LargeIcon;
            imageList1.ImageSize = new Size(50, 30);
            listView1.LargeImageList = imageList1;
            numberOfBooks.Text = ("Books: " + book.Count + " number of books").ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            UpdateForm();
        }
    }
}
