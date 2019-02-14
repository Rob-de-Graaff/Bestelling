using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestelling
{
    public class CD : Article
    {
        private string artist;
        private int numberOfTracks;

        public CD(string articleNumber, string title, string type, string artist, int numberOfTracks, double price, int manufacturingYear, int orderAmount)
            : base(articleNumber, title, type,  price, manufacturingYear, orderAmount)
        {
            this.artist = artist;
            this.numberOfTracks = numberOfTracks;
        }

        public override string ToString()
        {
            return $"ArticleNumber:{articleNumber}, Title:{title}, Artist:{artist}, Price:{price:0.00}, Type:{type}, Year:{manufacturingYear}, Orders:{orderAmount}";
        }

        public string Artist
        {
            get { return artist; }
        }

        public int NumberOfTracks
        {
            get { return numberOfTracks; }
        }
    }
}
