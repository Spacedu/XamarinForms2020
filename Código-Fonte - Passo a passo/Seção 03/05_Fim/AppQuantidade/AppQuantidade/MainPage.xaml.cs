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
        private int _quantidade = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClickedMais(object sender, EventArgs e)
        {
            _quantidade++;
            LblQuantidade.Text = _quantidade.ToString();
        }

        private void ButtonClickedMenos(object sender, EventArgs e)
        {
            if(_quantidade > 0)
            {
                _quantidade--;
                LblQuantidade.Text = _quantidade.ToString();
            }            
        }
    }
}
