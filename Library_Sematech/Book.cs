using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Sematech
{
    public class Book
    {
        #region Fields
        private string _bookcode;
        private string _bookname;
        private string _bookauthor;
        private string _bookdesc;
        private bool _ifexists;
        #endregion

        #region Properties

        public string BookCode
		{
			get { return _bookcode; }
			set { _bookcode = value; }
		}

		

		public string BookName
		{
			get { return _bookname; }
			set { _bookname = value; }
		}


	

		public string BookAuthor
		{
			get { return _bookauthor; }
			set { _bookauthor = value; }
		}

		

		public string BookDesc
		{
			get { return _bookdesc; }
			set { _bookdesc = value; }
		}


	

		public bool IfExists
		{
			get { return _ifexists; }
			set { _ifexists = value; }
		}

        #endregion

        #region Constructor

        public Book()
        {
           
        }

		public Book(string bookcode, string bookname, string bookAuthor,  string bookDesc, bool ifExists)
        {

			this.BookCode = bookcode;
			this.BookName = bookname;
			this.BookAuthor = bookAuthor;
			this.BookDesc = bookDesc;
			this.IfExists = ifExists;
       
        }
        #endregion
    }
}
