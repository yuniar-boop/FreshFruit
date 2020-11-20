using FreshFruit.Controller;
using FreshFruit.Model;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        private Seller yuniar;
        Fruit anggur = new Fruit("Anggur");
        Fruit Apel = new Fruit("Apel");
        Fruit Pisang = new Fruit("Pisang");
        Fruit jeruk = new Fruit("Jeruk");
        public MainWindow()
        {
            InitializeComponent();

            Bucket KeranjangBuah = new Bucket(2);
            BucketController bucketController = new
                BucketController(KeranjangBuah, this);

            yuniar = new Seller("Paijo", bucketController);
            ListBoxBucket.ItemsSource = KeranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            yuniar.addFruit(anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruit apel = new Fruit("Apel");
            yuniar.addFruit(apel);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruit pisang = new Fruit("Pisang");
            yuniar.addFruit(pisang);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            yuniar.addFruit(jeruk);
        }

        private void HAPUS_Click(object sender, RoutedEventArgs e)
        {
            yuniar.removeFruit(anggur);
            yuniar.removeFruit(Apel);
            yuniar.removeFruit(Pisang);
            yuniar.removeFruit(jeruk);
        }
    }
}
