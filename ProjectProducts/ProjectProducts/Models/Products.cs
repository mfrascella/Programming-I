using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectProducts.Models
{
    public class Products
    {
        private int productId = -1;
        private string name = "n/a";
        private string unitPrice = "$9999999.00";
        private int supplierId = -1;
        private int categoryId = -1;

        public int ProductId
        {
            get
            {
                return this.productId;
            }
            set
            {
                this.productId = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string UnitPrice
        {
            get
            {
                return this.unitPrice;
            }
            set
            {
                this.unitPrice = value;
            }
        }

        public int SupplierId
        {
            get
            {
                return this.supplierId;
            }
            set
            {
                this.supplierId = value;
            }
        }

        public int CategoryId
        {
            get
            {
                return this.categoryId;
            }
            set
            {
                this.categoryId = value;
            }
        }

        public Products(int aProductId, string aName, string aUnitPrice, int aSupplierId, int aCategoryId)
        {
            this.productId = aProductId;
            this.name = aName;
            this.unitPrice = aUnitPrice;
            this.supplierId = aSupplierId;
            this.categoryId = aCategoryId;
        }

        public override string ToString()
        {
            string aMessage = "";
            aMessage += "Product ID: " + this.productId + "     ";
            aMessage += "Product Name: " + this.name + "     ";
            aMessage += "Unit Price: " + this.unitPrice + "     ";
            aMessage += "Supplier ID: " + this.supplierId + "     ";
            aMessage += "Category ID: " + this.categoryId + "     ";

            return aMessage;
        }
    }
}