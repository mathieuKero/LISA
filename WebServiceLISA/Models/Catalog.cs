using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_GetXmlValues
{
    class Catalog
    {
        private int _Id;
        private string _Type;
        private string _Label;
        private string _Speed;
        private int _Width;
        private int _Height;

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

        public string Type
        {
            get
            {
                return _Type;
            }

            set
            {
                _Type = value;
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

        public string Speed
        {
            get
            {
                return _Speed;
            }

            set
            {
                _Speed = value;
            }
        }

        public int Width
        {
            get
            {
                return _Width;
            }

            set
            {
                _Width = value;
            }
        }

        public int Height
        {
            get
            {
                return _Height;
            }

            set
            {
                _Height = value;
            }
        }

        public Catalog(int Id, string Type, string Label, string Speed, int Width, int Height)
        {
            this._Id = Id;
            this._Type = Type;
            this._Label = Label;
            this._Speed = Speed;
            this._Width = Width;
            this._Height = Height;
        }
    }
}
