using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Sematech
{
    /// <summary>
	/// This Class is used to enter subscribers information
	/// Author : Ashkan Paydari
	/// Tel : 09129734590
	/// Email : paydari.ashkann@gmail.com
	/// Version 1.0
	/// </summary>

    public class Subscriber
    {
        #region Fields
        private string _subscribercode;
        private string _subscriberfirstname;
        private string _subscriberlasttname;
        private string _subscriberphoneno;
        #endregion

        #region Propreties

        /// <summary>
        /// Validations :  More than 5 digits - Only numeric values
        /// </summary>
        public string SubscriberCode
        {
            get 
            { 
                return _subscribercode;
            }
            set 
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Subscriber code can not be less than 5 digits");
                    
                }
                else
                {
                   _subscribercode = value;
                }
            }
        }



    

		public string SubscriberFirstName
		{
			get { return _subscriberfirstname; }
			set { _subscriberfirstname = value; }
		}

	
		public string SubscriberLastName
		{
			get { return _subscriberlasttname; }
			set { _subscriberlasttname = value; }
		}

		
		
		public string SubscriberPhoneNo
		{
			get { return _subscriberphoneno; }
			set { _subscriberphoneno = value; }
		}
        #endregion

        #region Constructors
        public Subscriber() 
		{ 

		}

        public Subscriber(string subscribercode , string subscriberfirstname , string subscriberlasttname , string subscriberphoneno )
        {
            this.SubscriberCode = subscribercode;
            this.SubscriberFirstName = subscriberfirstname;
			this.SubscriberLastName = subscriberlasttname;
			this.SubscriberPhoneNo = subscriberphoneno;	
			

        }
        #endregion




    }
}
