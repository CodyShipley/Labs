using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBuilding
{

    /// <summary>
    ///  Represents a product.
    /// </summary>
    class Product
    {

        /// <summary>
        /// The name of the product.
        /// </summary>
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// The price of the product.
        /// </summary>
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {

                _price = value < 0 ? 0 : value;

            }
        }

        public decimal CalculateTax(decimal taxRate)
        {
            return this.Price * taxRate;
        }



    }
}
