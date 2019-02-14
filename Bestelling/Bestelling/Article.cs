using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestelling
{
    public abstract class Article
    {
        protected string articleNumber;
        protected string title;
        protected string type;
        protected double price;
        protected int manufacturingYear;
        protected int orderAmount;

        public Article(string articleNumber, string title, string type, double price, int manufacturingYear, int orderAmount)
        {
            this.articleNumber = articleNumber;
            this.title = title;
            this.type = type;
            this.price = price;
            this.manufacturingYear = manufacturingYear;
            this.orderAmount = orderAmount;
        }

        public abstract override string ToString();

        public string ArticleNumber
        {
            get { return articleNumber; }
            set { articleNumber = value; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Type
        {
            get { return type; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int ManufacturingYear
        {
            get { return manufacturingYear; }
            set { manufacturingYear = value; }
        }

        public int OrderAmount
        {
            get { return orderAmount; }
            set { orderAmount = value; }
        }
    }
}
