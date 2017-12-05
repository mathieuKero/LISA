using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lisa_GetXmlValues
{
    class Operation
    {

        private int _Id;
        private string _Code;
        private string _Title;
        private long _StartTime;
        private long _EndTime;

        public Operation(int Id, string Code, string Title, long StartTime, long EndTime)
        {
            this._Id = Id;
            this._Code = Code;
            this._Title = Title;
            this._StartTime = StartTime;
            this._EndTime = EndTime;
        }


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

        public string Code
        {
            get
            {
                return _Code;
            }

            set
            {
                _Code = value;
            }
        }

        public string Title
        {
            get
            {
                return _Title;
            }

            set
            {
                _Title = value;
            }
        }

        public long StartTime
        {
            get
            {
                return _StartTime;
            }

            set
            {
                _StartTime = value;
            }
        }

        public long EndTime
        {
            get
            {
                return _EndTime;
            }

            set
            {
                _EndTime = value;
            }
        }

    }
}
