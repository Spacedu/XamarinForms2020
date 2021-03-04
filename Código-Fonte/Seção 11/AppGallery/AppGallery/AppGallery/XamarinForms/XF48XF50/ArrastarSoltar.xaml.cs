using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.XF48XF50
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArrastarSoltar : ContentPage
    {
        public double Preco = 0.0;
        public int QuantidadeItens = 0;
        public ArrastarSoltar()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStartingDog(object sender, DragStartingEventArgs e)
        {
            e.Data.Properties.Add("Preco", 100.00);
        }

        private void DragGestureRecognizer_DragStartingCat(object sender, DragStartingEventArgs e)
        {
            e.Data.Properties.Add("Preco", 75.00);
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {

            double precoItem = (double)e.Data.Properties["Preco"];
            Preco += precoItem;
            QuantidadeItens += 1;

            Carrinho.Text = $"Carrinho: {QuantidadeItens} item - {Preco.ToString("C")}";
        }

        private void DropGestureRecognizer_DragOver(object sender, DragEventArgs e)
        {

        }
    }
}