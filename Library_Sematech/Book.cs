using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Sematech
{
	/// <summary>
	/// This Class is used to enter books information
	/// Author : Ashkan Paydari
	/// Tel : 09129734590
	/// Email : paydari.ashkann@gmail.com
	/// Version 1.0
	/// </summary>


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

        /// <summary>
        /// Validations :  More than 5 digits - Only numeric values
        /// </summary>

        public string BookCode
		{
			get 
			{ 
				return _bookcode; 
			}
			set 
			{
                if (value.Length < 5)
                {
                    throw new ArgumentException("Book code can not be less than 5 digits");

                }
                else
                {
                    _bookcode = value;
                }
            }
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
