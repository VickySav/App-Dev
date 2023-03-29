using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W6_TJOK_SAVITRI
{
    public class Product
    {
        public string _namaproduct, _category, _idProduct, _idCategory;
        public int _harga, _stock;
        public string namaProduct
        {
            get { return _namaproduct; }
            set { _namaproduct = value; }
        }
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
        public int harga
        {
            get { return _harga; }
            set { _harga = value; }
        }
        public int stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public string idCategory
        {
            get { return _idCategory; }
            set { _idCategory = value; }
        }
        public string idProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }

        public Product(string idProduct, string namaProduct, int harga, int stock, string idCategory, string category)
        {
            this._idProduct = idProduct;
            this._namaproduct = namaProduct;
            this._harga = harga;
            this._stock = stock;
            this._idCategory = idCategory;
            this._category = category;
        }
    }
}
