using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    class OperationCatalog
    {

        private int _IdOperation;
        private int _IdCatalog;

        public OperationCatalog(int IdOperation, int IdCatalog)
        {
            this._IdOperation = IdOperation;
            this._IdCatalog = IdCatalog;
        }

        public int IdOperation
        {
            get
            {
                return _IdOperation;
            }

            set
            {
                _IdOperation = value;
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
    }
}
