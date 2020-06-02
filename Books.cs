using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace E_Book_Library
{
    class Books
    {
        
        public string bookName;
        public string bookContent;
        public Image bookIcon;
        public Books(string bookName,Image bookIcon)
        {
            this.bookName = bookName;
            this.bookIcon = bookIcon;
        }
        public void OpenBook(string bookPath)
        {
            
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using(StreamReader reader =new StreamReader(bookPath))
            {
                bookName = reader.ReadLine();
                bookContent = reader.ReadLine();
            }
        }
        public void AddToLibrary(string bookToAdd)
        {

        }
    }
}
