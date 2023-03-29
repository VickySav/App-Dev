using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W6_TJOK_SAVITRI
{
    public class Category
    {
        public string _category, _idCategory;
        public string idCategory
        {
            get { return _idCategory; }
            set { _idCategory = value; }
        }
        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Category(string idCategory, string category)
        {
            this._idCategory = idCategory;
            this._category = category;
        }
    }
}
