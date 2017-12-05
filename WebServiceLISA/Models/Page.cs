using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    class Page
    {

        private int _Id;
        private int _Num;
        private int _IdCatalog;

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

        public int Num
        {
            get
            {
                return _Num;
            }

            set
            {
                _Num = value;
            }
        }

        public int IdCatalog
        {
            get
            {
                return _IdCatalog;
            }

            set
            {
                _IdCatalog = value;
            }
        }

        public Page(int Id, int Num, int IdCatalog)
        {
            this.Id = Id;
            this.Num = Num;
            this.IdCatalog = IdCatalog;
        }
    }
}
