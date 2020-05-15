using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.NavegadorControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navegador : ContentPage
    {
        public Navegador()
        {
            InitializeComponent();

            var webViewHtmlSource = new HtmlWebViewSource();
            webViewHtmlSource.Html =
                @"<html>
                    <body>
                        <h1>Sou uma página</h1>
                        <h2>dentro do WebView</h2>
                        <p>
                            Este é um teste do nosso WebView renderizando HTML e <span style='color: red; text-decoration: underline; font-weight: bold'>CSS</span>.
                        </p>
                    </body>
                </html>";
            WebView2.Source = webViewHtmlSource;

            var endereco = new UrlWebViewSource();
            var BaseURL = DependencyService.Get<IBaseUrl>().Get();
            endereco.Url = Path.Combine(BaseURL, "index.html");
            
            //DependecyService - Xamarin.Forms - Caminho Onde se encontra Arquivos do Site.
            WebView3.Source = endereco;


        }

        private void BotaoVoltar(object sender, EventArgs e)
        {
            if (WebView3.CanGoBack)
            {
                WebView3.GoBack();
            }
        }

        private void BotaoAtualizar(object sender, EventArgs e)
        {
            WebView3.Reload();
        }

        private void BotaoProximo(object sender, EventArgs e)
        {
            if (WebView3.CanGoForward)
            {
                WebView3.GoForward();
            }
        }

        private void Carregando(object sender, WebNavigatingEventArgs e)
        {
            LblStatus.Text = "Carregando...";
        }

        private void Carregado(object sender, WebNavigatedEventArgs e)
        {
            LblStatus.Text = "Carregado!";
            LblUrl.Text = e.Url;
        }
    }
}