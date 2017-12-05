using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    public class Product
    {

        private int _Id;
        private string _Code;
        private string _Label;
        private string _Description;
        private string _Category;
        private double _Price;
        private double _Ecotaxe;
        private string _ImagePath;
        private string _PictoPath;
        private string _Origin;
        private string _Mention;
        private double _LowerPrice;
        private string _Color;

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

        public string Label
        {
            get
            {
                return _Label;
            }

            set
            {
                _Label = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public string Category
        {
            get
            {
                return _Category;
            }

            set
            {
                _Category = value;
            }
        }

        public double Price
        {
            get
            {
                return _Price;
            }

            set
            {
                _Price = value;
            }
        }

        public double Ecotaxe
        {
            get
            {
                return _Ecotaxe;
            }

            set
            {
                _Ecotaxe = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return _ImagePath;
            }

            set
            {
                _ImagePath = value;
            }
        }

        public string PictoPath
        {
            get
            {
                return _PictoPath;
            }

            set
            {
                _PictoPath = value;
            }
        }

        public string Origin
        {
            get
            {
                return _Origin;
            }

            set
            {
                _Origin = value;
            }
        }

        public string Mention
        {
            get
            {
                return _Mention;
            }

            set
            {
                _Mention = value;
            }
        }

        public double LowerPrice
        {
            get
            {
                return _LowerPrice;
            }

            set
            {
                _LowerPrice = value;
            }
        }

        public string Color
        {
            get
            {
                return _Color;
            }

            set
            {
                _Color = value;
            }
        }

        public Product(int Id, string Code, string Label, string Description, string Category, double Price, double Ecotaxe, string ImagePath, string PictoPath, string Origin, string Mention, double LowerPrice, string Color)
        {
            this._Id = Id;
            this._Code = Code;
            this._Label = Label;
            this._Description = Description;
            this._Category = Category;
            this._Price = Price;
            this._Ecotaxe = Ecotaxe;
            this._ImagePath = ImagePath;
            this._PictoPath = PictoPath;
            this._Origin = Origin;
            this._Mention = Mention;
            this._LowerPrice = LowerPrice;
            this._Color = Color;
        }
    }
}
