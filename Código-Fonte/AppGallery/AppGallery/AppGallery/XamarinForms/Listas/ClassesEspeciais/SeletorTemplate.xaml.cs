using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ClassesEspeciais
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeletorTemplate : ContentPage
    {
        public SeletorTemplate()
        {
            InitializeComponent();

            Lista01.ItemsSource = GetProdutos();
        }

        private List<Produto> GetProdutos()
        {
            //Mercearia
            return new List<Produto>
            {
                new Produto {Nome = "Arroz", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Feijão", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Óleo", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Azeite de oliva", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Vinagre", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Açúcar", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Milho para pipoca", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Farinha de trigo", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Fermento em pó", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Aveia", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Cereais", Valor = 1.0, Setor = "Mercearia"},
                new Produto {Nome = "Amido de milho", Valor = 1.0, Setor = "Mercearia"},

                new Produto {Nome = "Ovos", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Verduras", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Legumes", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Vegetais variados", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Frutas da estação", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Cebola", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Alho", Valor = 1.0, Setor = "Feira"},
                new Produto {Nome = "Ervas e temperos frescos", Valor = 1.0, Setor = "Feira"},

                new Produto {Nome = "Bifes", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Carne moída", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Carne de frango", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Filés de peixes", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Hambúrgueres", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Linguiças", Valor = 1.0, Setor = "Açougue"},
                new Produto {Nome = "Salsichas", Valor = 1.0, Setor = "Açougue"},
            };
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Setor { get; set; }
    }

    public class SetorDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MerceariaTemplate { get; set; }
        public DataTemplate FeiraTemplate { get; set; }
        public DataTemplate AcougueTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Produto produto = (Produto)item;

            if (produto.Setor == "Mercearia")
                return MerceariaTemplate;

            if (produto.Setor == "Feira")
                return FeiraTemplate;

            if (produto.Setor == "Açougue")
                return AcougueTemplate;

            return null;
        }
    }
}