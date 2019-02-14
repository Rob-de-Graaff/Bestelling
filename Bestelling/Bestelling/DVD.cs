using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestelling
{
    public class DVD : Article
    {
        private string director;
        private int regionCode;
        private int playTime;

        public DVD(string articleNumber, string title, string type, string director, int regionCode, int playTime, double price, int manufacturingYear, int orderAmount)
            : base(articleNumber, title, type, price, manufacturingYear, orderAmount)
        {
            this.director = director;
            this.regionCode = regionCode;
            this.playTime = playTime;
        }

        public override string ToString()
        {
            return $"ArticleNumber:{articleNumber}, Title:{title}, Director:{director}, Price:{price:0.00}, Type:{type}, Year:{manufacturingYear}, Orders:{orderAmount}";
        }

        public string Director
        {
            get { return director; }
        }

        public int RegionCode
        {
            get { return regionCode; }
        }     
        
        public int PlayTime
        {
            get { return playTime; }
        }
    }
}
