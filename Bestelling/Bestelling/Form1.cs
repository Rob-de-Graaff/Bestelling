using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestelling
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Article> articleDict;
        private List<string> orderList;
        private double ageDiscountCD = 1;
        private double ageDiscountDVD = 1;
        private double extraDiscountCD = 1;
        private double extraDiscountDVD = 1;
        private double _priceTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            articleDict = new Dictionary<int, Article>();
            
            orderList = new List<string>();
            articleDict.Add(1,new CD("", "Machine Head", "CD", "Deep Purple", 7, 11.99, 1971, 0));
            articleDict.Add(2,new DVD("", "Titanic", "DVD", "James Cameron", 2, 195, 9.99, 1997, 0));

            foreach(KeyValuePair<int, Article> entry in articleDict)
            {
                //sets article number "year+serial number"
                entry.Value.ArticleNumber = entry.Value.ManufacturingYear.ToString() + entry.Key.ToString("00");
            }

            // Displays title property
            //listBoxArticles.DataSource = new BindingSource(articleDict, null);
            listBoxArticles.DataSource = articleDict.Values.ToList();
            listBoxArticles.DisplayMember = "title";

            // Displays calculation, total
            labelTicketsTotal.Text = $@"total = (price * amount) * (discount + discount) + (price * amount) * (discount + discount)";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
        }

        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            Article tempArticle = (Article)listBoxArticles.SelectedItem;

            tempArticle.OrderAmount = (int)numericUpDownAmount.Value;
            orderList.Add(tempArticle.ToString());

            // Displays properties
            listBoxOrders.DataSource = null;
            listBoxOrders.DataSource = orderList;
            listBoxOrders.DisplayMember = "Value";
        }
        
        private void ButtonRemoveOrder_Click(object sender, EventArgs e)
        {
            Article tempArticle = (Article)listBoxArticles.SelectedItem;

            orderList.Remove(tempArticle.ToString());

            // Displays properties
            listBoxOrders.DataSource = null;
            listBoxOrders.DataSource = orderList;
            listBoxOrders.DisplayMember = "Value";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            //buttonAddOrder.Visible = false;
            string type = "";
            int age = 0;
            int articleNumber = 0;
            int CDAmount = 0;
            int DVDAmount = 0;
            int articleAmount = 0;
            double CDPrice = 0;
            double DVDPrice = 0;
            double tempDiscountCD = 1;
            double tempDiscountDVD = 1;

            if (listBoxOrders != null)
            {
                foreach (string order in orderList)
                {
                    int indexStart = order.IndexOf("Year:")+5;
                    int indexEnd = order.IndexOf("Orders:")-2;
                    int lenght = indexEnd - indexStart;
                    age = CalculateAge(Convert.ToInt32(order.Substring(indexStart, lenght)));
                    
                    indexStart = order.IndexOf("ArticleNumber:")+18;
                    indexEnd = order.IndexOf("Title:")-2;
                    lenght = indexEnd - indexStart;
                    articleNumber = Convert.ToInt32(order.Substring(indexStart, lenght));
                    
                    indexStart = order.IndexOf("Type:")+5;
                    indexEnd = order.IndexOf("Year:")-2;
                    lenght = indexEnd - indexStart;
                    type = order.Substring(indexStart, lenght);

                    indexStart = order.IndexOf("Price:")+6;
                    indexEnd = order.IndexOf("Type:")-2;
                    lenght = indexEnd - indexStart;
                    _priceTotal = Convert.ToDouble(order.Substring(indexStart, lenght));

                    indexStart = order.IndexOf("Orders:")+7;
                    indexEnd = order.Length;
                    lenght = indexEnd - indexStart;
                    articleAmount = Convert.ToInt32(order.Substring(indexStart, lenght));

                    if (type == "CD")
                    {
                        CDPrice += _priceTotal;
                        CDAmount += articleAmount;
                        if (age >= 5)
                        {
                            ageDiscountCD = 0.75;
                        }
                        else if (age < 3 && age >= 5)
                        {
                            ageDiscountCD = 0.90;
                        }
                        else if (age < 2 && age >= 3)
                        {
                            ageDiscountCD = 0.95;
                        }

                        if (articleNumber % 2 == 0)
                        {
                            extraDiscountCD = 0.02;
                        }
                        else
                        {
                            extraDiscountCD = 0;
                            
                        }

                        tempDiscountCD = ageDiscountCD + extraDiscountCD;
                    }
                    else if (type == "DVD")
                    {
                        DVDPrice += _priceTotal;
                        DVDAmount += articleAmount;
                        if (age >= 5)
                        {
                            ageDiscountDVD = 0.75;
                        }
                        else if (age < 3 && age >= 5)
                        {
                            ageDiscountDVD = 0.90;
                        }
                        else if (age < 2 && age >= 3)
                        {
                            ageDiscountDVD = 0.95;
                        }

                        if (articleNumber % 2 == 0)
                        {
                            extraDiscountDVD = 0.02;
                        }
                        else
                        {
                            extraDiscountDVD = 0;
                            
                        }

                        tempDiscountDVD = ageDiscountDVD + extraDiscountDVD;
                    }
                }

                if (CDAmount == 0)
                {
                    ageDiscountCD = 1;
                    extraDiscountCD = 0;
                }

                if (DVDAmount == 0)
                {
                    ageDiscountDVD = 1;
                    extraDiscountDVD = 0;
                }

                _priceTotal = 0;
                _priceTotal += (CDPrice * CDAmount) * tempDiscountCD + (DVDPrice * DVDAmount) * tempDiscountDVD;

                // Displays calculation, total
                labelTicketsTotal.Text = $@"total = (price € {CDPrice}* amount {CDAmount}) * (discount {(1 - ageDiscountCD)*100}% + discount {extraDiscountCD*100}%) + (price € {DVDPrice} * amount {DVDAmount}) * (discount {(1- ageDiscountDVD)*100}% + discount {extraDiscountDVD*100}%)";
                labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
            }
            else
            {
                MessageBox.Show("You must have ordered any article.");
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            numericUpDownAmount.Value = 1;
            listBoxOrders.DataSource = null;
            orderList.Clear();
            ageDiscountCD = 1;
            ageDiscountDVD = 1;
            extraDiscountCD = 1;
            extraDiscountDVD = 1;
            _priceTotal = 0;

            // Displays calculation, total
            labelTicketsTotal.Text = $@"total = (price € {0}* amount {0}) * (discount {(1 - ageDiscountCD)*100}% + discount {(1 - extraDiscountCD)*100}%) + (price € {0} * amount {0}) * (discount {(1- ageDiscountCD)*100}% + discount {(1-extraDiscountCD)*100}%)";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_priceTotal, 2):0.00},-";
        }

        private static int CalculateAge(int manufacteringYear)
        {
            int age = DateTime.Now.Year - manufacteringYear; 
  
            return age; 
        }
    }
}
