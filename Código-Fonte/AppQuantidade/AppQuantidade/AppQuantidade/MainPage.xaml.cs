using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int quantidade = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Aumentar(object sender, EventArgs e)
        {
            quantidade++;
            LblQuantidade.Text = quantidade.ToString();
        }

        private void Diminuir(object sender, EventArgs e)
        {
            if(quantidade != 0)
            {
                quantidade--;
                LblQuantidade.Text = quantidade.ToString();
            }            
        }
    }
}
