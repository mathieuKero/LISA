using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    class OperationShop
    {

        private int _IdOperation;
        private int _IdShop;

        public OperationShop(int IdOperation, int IdShop)
        {
            this._IdOperation = IdOperation;
            this._IdShop = IdShop;
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

        public int IdShop
        {
            get
            {
                return _IdShop;
            }

            set
            {
                _IdShop = value;
            }
        }
    }
}
