namespace E_Book_Library
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.openBook = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.readBook = new AxAcroPDFLib.AxAcroPDF();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picName = new System.Windows.Forms.Label();
            this.editPic = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masculine = new System.Windows.Forms.RadioButton();
            this.feminine = new System.Windows.Forms.RadioButton();
            this.dontKnow = new System.Windows.Forms.RadioButton();
            this.saveChanges = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.icon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myMarket = new System.Windows.Forms.Button();
            this.readerBoard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.genders = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.usersName = new System.Windows.Forms.Label();
            this.numberOfBooks = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readBook)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(888, 395);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Market";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.openBook);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.readBook);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(888, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reading Board";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.Location = new System.Drawing.Point(232, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 21);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // openBook
            // 
            this.openBook.Location = new System.Drawing.Point(699, 4);
            this.openBook.Name = "openBook";
            this.openBook.Size = new System.Drawing.Size(183, 23);
            this.openBook.TabIndex = 2;
            this.openBook.Text = "Open Book";
            this.openBook.UseVisualStyleBackColor = true;
            this.openBook.Click += new System.EventHandler(this.openBook_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // readBook
            // 
            this.readBook.Enabled = true;
            this.readBook.Location = new System.Drawing.Point(3, 33);
            this.readBook.Name = "readBook";
            this.readBook.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("readBook.OcxState")));
            this.readBook.Size = new System.Drawing.Size(879, 356);
            this.readBook.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.picName);
            this.tabPage2.Controls.Add(this.editPic);
            this.tabPage2.Controls.Add(this.addBook);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.saveChanges);
            this.tabPage2.Controls.Add(this.userName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Profile";
            // 
            // picName
            // 
            this.picName.BackColor = System.Drawing.Color.Transparent;
            this.picName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picName.Location = new System.Drawing.Point(312, 29);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(448, 19);
            this.picName.TabIndex = 17;
            // 
            // editPic
            // 
            this.editPic.BackColor = System.Drawing.Color.Transparent;
            this.editPic.Location = new System.Drawing.Point(165, 29);
            this.editPic.Name = "editPic";
            this.editPic.Size = new System.Drawing.Size(84, 23);
            this.editPic.TabIndex = 16;
            this.editPic.Text = "browse image";
            this.editPic.UseVisualStyleBackColor = false;
            this.editPic.Click += new System.EventHandler(this.editPic_Click);
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.LightSlateGray;
            this.addBook.Location = new System.Drawing.Point(230, 277);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(398, 26);
            this.addBook.TabIndex = 14;
            this.addBook.Text = "Buy A Book";
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.masculine);
            this.groupBox2.Controls.Add(this.feminine);
            this.groupBox2.Controls.Add(this.dontKnow);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(165, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 177);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // masculine
            // 
            this.masculine.AutoSize = true;
            this.masculine.Location = new System.Drawing.Point(6, 41);
            this.masculine.Name = "masculine";
            this.masculine.Size = new System.Drawing.Size(184, 49);
            this.masculine.TabIndex = 11;
            this.masculine.TabStop = true;
            this.masculine.Text = "Masculine";
            this.masculine.UseVisualStyleBackColor = true;
            // 
            // feminine
            // 
            this.feminine.AutoSize = true;
            this.feminine.Location = new System.Drawing.Point(6, 86);
            this.feminine.Name = "feminine";
            this.feminine.Size = new System.Drawing.Size(168, 49);
            this.feminine.TabIndex = 10;
            this.feminine.TabStop = true;
            this.feminine.Text = "Feminine";
            this.feminine.UseVisualStyleBackColor = true;
            // 
            // dontKnow
            // 
            this.dontKnow.AutoSize = true;
            this.dontKnow.Location = new System.Drawing.Point(6, 134);
            this.dontKnow.Name = "dontKnow";
            this.dontKnow.Size = new System.Drawing.Size(262, 49);
            this.dontKnow.TabIndex = 9;
            this.dontKnow.TabStop = true;
            this.dontKnow.Text = "MascuFeminine";
            this.dontKnow.UseVisualStyleBackColor = true;
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.saveChanges.Location = new System.Drawing.Point(165, 369);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(593, 23);
            this.saveChanges.TabIndex = 4;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(312, 62);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(448, 20);
            this.userName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.icon);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home Page";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listView1.Location = new System.Drawing.Point(208, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(677, 226);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon.Enabled = false;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(821, 6);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(61, 53);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 16;
            this.icon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.myMarket);
            this.groupBox1.Controls.Add(this.readerBoard);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genders);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.usersName);
            this.groupBox1.Controls.Add(this.numberOfBooks);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 392);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-Book";
            // 
            // myMarket
            // 
            this.myMarket.Location = new System.Drawing.Point(19, 259);
            this.myMarket.Name = "myMarket";
            this.myMarket.Size = new System.Drawing.Size(165, 23);
            this.myMarket.TabIndex = 1;
            this.myMarket.Text = "Market";
            this.myMarket.UseVisualStyleBackColor = true;
            this.myMarket.Click += new System.EventHandler(this.myMarket_Click);
            // 
            // readerBoard
            // 
            this.readerBoard.Location = new System.Drawing.Point(19, 302);
            this.readerBoard.Name = "readerBoard";
            this.readerBoard.Size = new System.Drawing.Size(165, 23);
            this.readerBoard.TabIndex = 14;
            this.readerBoard.Text = "Reader  Board";
            this.readerBoard.UseVisualStyleBackColor = true;
            this.readerBoard.Click += new System.EventHandler(this.readerBoard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender description:";
            // 
            // genders
            // 
            this.genders.AutoSize = true;
            this.genders.BackColor = System.Drawing.SystemColors.WindowText;
            this.genders.ForeColor = System.Drawing.Color.FloralWhite;
            this.genders.Location = new System.Drawing.Point(111, 110);
            this.genders.Name = "genders";
            this.genders.Size = new System.Drawing.Size(0, 13);
            this.genders.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 25);
            this.button3.TabIndex = 10;
            this.button3.Text = "Make Changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // usersName
            // 
            this.usersName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usersName.Location = new System.Drawing.Point(5, 85);
            this.usersName.Name = "usersName";
            this.usersName.Size = new System.Drawing.Size(197, 13);
            this.usersName.TabIndex = 9;
            this.usersName.Text = "UserName:";
            // 
            // numberOfBooks
            // 
            this.numberOfBooks.Location = new System.Drawing.Point(6, 98);
            this.numberOfBooks.Name = "numberOfBooks";
            this.numberOfBooks.Size = new System.Drawing.Size(178, 25);
            this.numberOfBooks.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(309, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOME PAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readBook)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button openBook;
        private System.Windows.Forms.ComboBox comboBox1;
        private AxAcroPDFLib.AxAcroPDF readBook;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label picName;
        private System.Windows.Forms.Button editPic;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton masculine;
        private System.Windows.Forms.RadioButton feminine;
        private System.Windows.Forms.RadioButton dontKnow;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button myMarket;
        private System.Windows.Forms.Button readerBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label genders;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label usersName;
        private System.Windows.Forms.Label numberOfBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
    }
}

