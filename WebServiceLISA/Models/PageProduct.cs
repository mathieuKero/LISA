using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    class PageProduct
    {

        private int _IdPage;
        private int _IdProduct;

        public PageProduct(int IdPage, int IdProduct)
        {
            this._IdPage = IdPage;
            this._IdProduct = IdProduct;
        }

        public int IdPage
        {
            get
            {
                return _IdPage;
            }

            set
            {
                _IdPage = value;
            }
        }

        public int IdProduct
        {
            get
            {
                return _IdProduct;
            }

            set
            {
                _IdProduct = value;
            }
        }
    }
}
