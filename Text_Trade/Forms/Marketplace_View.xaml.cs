﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Text_Trade.Forms;

namespace Text_Trade
{
    /// <summary>
    /// Interaction logic for MarketplaceView1.xaml
    /// </summary>
    public partial class Marketplace_View : Window
    {
        public Marketplace_View()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            TraderHome frm = new TraderHome();
            frm.Show();
            this.Close();
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void Marketplace_View_Load(object sender, RoutedEventArgs e)
        {
            Marketplace marketView = new Marketplace();
            List<Listing> listings = new List<Listing>();

            listings = marketView.SearchAll();

            for( int i = 0; i < listings.Count; i++)
            {
                resultsListBox.Items.Add(listings.ElementAt(i));
            }
        }

        private void button_filterResults_Click(object sender, RoutedEventArgs e)
        {
            Coming_soon frm = new Coming_soon();
            frm.Show();
        }

        private void button_search_Click(object sender, RoutedEventArgs e)
        {
            Marketplace mkt = new Marketplace();
        }
    }
}