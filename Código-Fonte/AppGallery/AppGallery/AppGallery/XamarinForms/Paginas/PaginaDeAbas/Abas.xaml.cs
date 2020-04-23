using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeAbas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();
            //CurrentPage = Children[1];
        }
    }
}