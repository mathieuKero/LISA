using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    class Shop
    {

        private int _Id;
        private DateTime _DisplayStartDate;
        private DateTime _DisplayEndDate;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public DateTime DisplayStartDate
        {
            get
            {
                return _DisplayStartDate;
            }

            set
            {
                _DisplayStartDate = value;
            }
        }

        public DateTime DisplayEndDate
        {
            get
            {
                return _DisplayEndDate;
            }

            set
            {
                _DisplayEndDate = value;
            }
        }


        public DateTime timestampToDteTime(long timestamp)
        {
            DateTime date = Convert.ToDateTime(timestamp);
            return date;
        }

        public Shop(int _Id, long DisplayStartDate, long DisplayEndDate)
        {
            this._Id = _Id;
            this._DisplayStartDate = timestampToDteTime(DisplayStartDate);
            this._DisplayEndDate = timestampToDteTime(DisplayEndDate);
        }
    }
}
