using AppGallery.AppBase.Models;
using AppGallery.Resources.Controls;
using AppGallery.Resources.Effetcs;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /*
                var pagina = new NavigationPage(
                    new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01()
                );

                var pagina = new XamarinForms.Paginas.Modal.Conteudo01();
                
                var pagina = new CarouselPage();
                pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
                pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
                pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());

                pagina.CurrentPage = pagina.Children[1];

                var pagina = new TabbedPage();
                pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
                pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
                pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());

                pagina.CurrentPage = pagina.Children[1];

                var pagina = new MasterDetailPage();
                //Menu
                pagina.Master = ;
                //Conteúdo
                pagina.Detail = ;    

            */

            //MainPage = new NavigationPage(new TelaTemp());
            MainPage = new AppBase.Menu();
            LogicUpdateStatusBarColorByTheme();
        }

        
        public static List<PaginaColecao> MenuItensColecao { 
            get {
                var paginas = new PaginaColecao()
                {
                    new Pagina() { Nome = "ContentPage", Descricao = "Página de Conteúdo", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeConteudo.Conteudo01), TemNavegacao = false },
                    new Pagina() { Nome = "NavigationPage", Descricao = "Estrutura de navegação", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01), TemNavegacao = true },
                    new Pagina() { Nome = "CarouselPage", Descricao = "Navegue entre páginas lado a lado", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeCarrossel.Carrossel), TemNavegacao = false },
                    new Pagina() { Nome = "TabbedPage", Descricao = "Navegação em abas", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeAbas.Abas), TemNavegacao = false },
                    new Pagina() { Nome = "MasterDetailPage", Descricao = "Navegue com menu hamburgue", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral), TemNavegacao = false },
                    new Pagina() { Nome = "Modal", Descricao = "Abra páginas no estilo Modal", ArquivoPagina = typeof(XamarinForms.Paginas.Modal.Conteudo01), TemNavegacao = false },
                };
                paginas.Nome = "Páginas";


                var leiautes = new PaginaColecao()
                {
                    new Pagina() { Nome = "StackLayout", Descricao = "Organize o conteúdo em pilha", ArquivoPagina = typeof(XamarinForms.Leiautes.PilhaLeiaute.Pilha), TemNavegacao = true },
                    new Pagina() { Nome = "Grid", Descricao = "Organize o conteúdo em tabela", ArquivoPagina = typeof(XamarinForms.Leiautes.GradeLeiaute.Grade), TemNavegacao = true },
                    new Pagina() { Nome = "AbsoluteLayout", Descricao = "Posicione o conteúdo em qualquer lugar", ArquivoPagina = typeof(XamarinForms.Leiautes.AbsolutoLeiaute.Absoluto), TemNavegacao = true },
                    new Pagina() { Nome = "RelativeLayout", Descricao = "Posicione o conteúdo em relação a outro elemento", ArquivoPagina = typeof(XamarinForms.Leiautes.RelativoLeiaute.Relativo), TemNavegacao = true },
                    new Pagina() { Nome = "FlexLayout", Descricao = "Posicione o conteúdo em caixas flexíveis", ArquivoPagina = typeof(XamarinForms.Leiautes.FlexivelLeiaute.Flexivel), TemNavegacao = true },
                    new Pagina() { Nome = "ScrollView", Descricao = "Adicione barra de rolagem ao seu conteúdo", ArquivoPagina = typeof(XamarinForms.Leiautes.BarraDeRolagelLeiaute.BarraDeRolagem), TemNavegacao = true },
                    new Pagina() { Nome = "ContentView", Descricao = "Organize o conteúdo dentro de outro elemento", ArquivoPagina = typeof(XamarinForms.Leiautes.ControleLeiaute.Controle), TemNavegacao = true },
                    new Pagina() { Nome = "Frame", Descricao = "Quadro de conteúdo", ArquivoPagina = typeof(XamarinForms.Leiautes.QuadradoLeiaute.Quadrado), TemNavegacao = true },
                };
                leiautes.Nome = "Leiautes";

                var controles = new PaginaColecao()
                {
                    new Pagina() { Nome = "BoxView", Descricao = "Crie quadrados, retângulo e até circulo", ArquivoPagina = typeof(XamarinForms.Controles.CaixaControle.Caixa), TemNavegacao = true },
                    new Pagina() { Nome = "Label", Descricao = "Rótulo - Componente para apresentar texto", ArquivoPagina = typeof(XamarinForms.Controles.RotuloControle.Rotulo), TemNavegacao = true },
                    new Pagina() { Nome = "Button", Descricao = "Botão - Exibe um botão com texto e ação", ArquivoPagina = typeof(XamarinForms.Controles.BotaoControle.Botao), TemNavegacao = true },
                    new Pagina() { Nome = "ImageButton", Descricao = "Botão com imagem - Exibe uma imagem com ação de botão", ArquivoPagina = typeof(XamarinForms.Controles.BotaoImagemControle.BotaoImagem), TemNavegacao = true },
                    new Pagina() { Nome = "Image", Descricao = "Imagem - Componente para apresentar um bitmap (imagem)", ArquivoPagina = typeof(XamarinForms.Controles.ImagemControle.Imagem), TemNavegacao = true },
                    new Pagina() { Nome = "Entry", Descricao = "Controle de entrada de texto em uma única linha", ArquivoPagina = typeof(XamarinForms.Controles.CampoDeEntradaSimplesControle.CampoDeEntradaSimples), TemNavegacao = true },
                    new Pagina() { Nome = "Editor", Descricao = "Controle de entrada de texto em várias linhas", ArquivoPagina = typeof(XamarinForms.Controles.CampoDeEntradaMultilineControle.CampoDeEntradaMultiline), TemNavegacao = true },
                    new Pagina() { Nome = "Checkbox", Descricao = "Componente de valor booleano permite marca ou desmarca a opção", ArquivoPagina = typeof(XamarinForms.Controles.CaixaDeMarcacaoControle.CaixaDeMarcacao), TemNavegacao = true },
                    new Pagina() { Nome = "RadioButton", Descricao = "Componente permite marca uma opção entre várias", ArquivoPagina = typeof(XamarinForms.Controles.CaixaDeRadioControle.CaixaDeRadio), TemNavegacao = true },
                    new Pagina() { Nome = "Switch", Descricao = "Controle em formato de chave com valor booleano", ArquivoPagina = typeof(XamarinForms.Controles.InterruptorControle.Interruptor), TemNavegacao = true },
                    new Pagina() { Nome = "Stepper", Descricao = "Controle passador de valores em double", ArquivoPagina = typeof(XamarinForms.Controles.PassadorControle.Passador), TemNavegacao = true },
                    new Pagina() { Nome = "Slider", Descricao = "Controle deslizante com valor em double", ArquivoPagina = typeof(XamarinForms.Controles.DeslizanteControle.Deslizante), TemNavegacao = true },
                    new Pagina() { Nome = "Picker", Descricao = "Exibe uma lista de opções para seleção", ArquivoPagina = typeof(XamarinForms.Controles.SelecaoControle.Selecao), TemNavegacao = true },
                    new Pagina() { Nome = "DatePicker", Descricao = "Controle permite selecionar data", ArquivoPagina = typeof(XamarinForms.Controles.DataSelecaoControle.DataSelecao), TemNavegacao = true },
                    new Pagina() { Nome = "TimePicker", Descricao = "Controle permite selecionar horário", ArquivoPagina = typeof(XamarinForms.Controles.TempoSelecaoControle.TempoSelecao), TemNavegacao = true },
                    new Pagina() { Nome = "ActivityIndicator", Descricao = "Exibe um indicador de atividade sem indicador de progresso", ArquivoPagina = typeof(XamarinForms.Controles.IndicadorDeAtividadeControle.IndicadorDeAtividades), TemNavegacao = true },
                    new Pagina() { Nome = "ProgressBar", Descricao = "Exibe um indicador de atividade com indicador de progresso", ArquivoPagina = typeof(XamarinForms.Controles.BarraDeProgressoControle.BarraDeProgresso), TemNavegacao = true },
                    new Pagina() { Nome = "SearchBar", Descricao = "Área de digitação com botão de pesquisa", ArquivoPagina = typeof(XamarinForms.Controles.BarraDePesquisaControle.BarraDePesquisa), TemNavegacao = true },
                    new Pagina() { Nome = "RefreshView", Descricao = "Componente com ação de pull (Puxar) utilizado para atualização de uma tela ou componente", ArquivoPagina = typeof(XamarinForms.Controles.AtualizaControle.Atualiza), TemNavegacao = true },
                    new Pagina() { Nome = "SwipeView", Descricao = "Componente de exibição de opções após realizar um gesto", ArquivoPagina = typeof(XamarinForms.Controles.ArrastaControle.Arrasta), TemNavegacao = true },
                    new Pagina() { Nome = "WebView", Descricao = "Navegador - Exibe um conteúdo HTML", ArquivoPagina = typeof(XamarinForms.Controles.NavegadorControle.Navegador), TemNavegacao = true },
                    new Pagina() { Nome = "MediaElement", Descricao = "Player de música e vídeo", ArquivoPagina = typeof(XamarinForms.Controles.MediaControle.Media), TemNavegacao = true },
                    new Pagina() { Nome = "Expander", Descricao = "Componente de expansão", ArquivoPagina = typeof(XamarinForms.Controles.ExpansorControle.Expansor), TemNavegacao = true },
                };
                controles.Nome = "Controles";

                var listas = new PaginaColecao()
                {
                    new Pagina() { Nome = "TableView", Descricao = "Exibe uma lista de linhas com tipos de células", ArquivoPagina = typeof(XamarinForms.Listas.TabelaControle.Tabela), TemNavegacao = true },
                    new Pagina() { Nome = "ListView", Descricao = "Exibe elementos em lista", ArquivoPagina = typeof(XamarinForms.Listas.ListaControle.Lista), TemNavegacao = true },
                    new Pagina() { Nome = "CollectionView", Descricao = "Exibe elementos em lista.", ArquivoPagina = typeof(XamarinForms.Listas.ColecaoControle.Colecao), TemNavegacao = true },
                    new Pagina() { Nome = "CarouselView", Descricao = "Exibe elementos lado a lado", ArquivoPagina = typeof(XamarinForms.Listas.CarrosselControle.Carrossel), TemNavegacao = true },
                    new Pagina() { Nome = "IndicatorView", Descricao = "Exibe um indicador de posição", ArquivoPagina = typeof(XamarinForms.Listas.IndicadorControle.Indicador), TemNavegacao = true },
                    new Pagina() { Nome = "ObservableCollection", Descricao = "Classe que atualiza os controles de lista automaticamente", ArquivoPagina = typeof(XamarinForms.Listas.ClassesEspeciais.ColecaoObservavel), TemNavegacao = true },
                    new Pagina() { Nome = "INotifyPropertyChanged", Descricao = "Classe que atualiza os controles de lista automaticamente", ArquivoPagina = typeof(XamarinForms.Listas.ClassesEspeciais.NotificarMundacaPropriedade), TemNavegacao = true },
                    new Pagina() { Nome = "DataTemplateSelector", Descricao = "Classe que permite escolher o layout de cada linha da lista", ArquivoPagina = typeof(XamarinForms.Listas.ClassesEspeciais.SeletorTemplate), TemNavegacao = true },
                };
                listas.Nome = "Listas";

                var estilos = new PaginaColecao()
                {
                    new Pagina() { Nome = "ExplicitStyle", Descricao = "Forma explicita de adicionar estilo", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloExplicito.Explicito), TemNavegacao = true },
                    new Pagina() { Nome = "ImplicitStyle", Descricao = "Forma implicita de adicionar estilo", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloImplicito.Implicito), TemNavegacao = true },
                    new Pagina() { Nome = "GlobalStyle", Descricao = "Estilo global", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloGlobal.Global), TemNavegacao = true },
                    new Pagina() { Nome = "InheritStyle", Descricao = "Criar estilos a partir de outros", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloHerdado.Herdado), TemNavegacao = true },
                    new Pagina() { Nome = "DynamicStyle", Descricao = "Estilo que pode mudar em tempo de execução", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloDinamico.Dinamico), TemNavegacao = true },
                    new Pagina() { Nome = "StyleClass", Descricao = "Forma de nomear estilos", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloClasse.Classe), TemNavegacao = true },
                    new Pagina() { Nome = "VisualStateManager", Descricao = "Apresentação visual diferente em situações(state) do componente", ArquivoPagina = typeof(XamarinForms.Estilos.VSM.VSM), TemNavegacao = true },
                    new Pagina() { Nome = "MaterialDesign", Descricao = "Aplicar Google Material Design no app", ArquivoPagina = typeof(XamarinForms.Estilos.MaterialDesign.Material), TemNavegacao = true },
                    new Pagina() { Nome = "Font", Descricao = "Adicionar fonte personalizada", ArquivoPagina = typeof(XamarinForms.Estilos.FontePersonalizada.Fonte), TemNavegacao = true },
                    new Pagina() { Nome = "ChangeTheme", Descricao = "Mudar o tema do App", ArquivoPagina = typeof(XamarinForms.Estilos.TrocarTema.Tema), TemNavegacao = true },
                    new Pagina() { Nome = "LightDarkTheme", Descricao = "Reagir a mudança de Tema do Android", ArquivoPagina = typeof(XamarinForms.Estilos.TemaClaroEscuro.ClaroEscuro), TemNavegacao = true },
                };
                estilos.Nome = "Estilos";

                var animacao = new PaginaColecao()
                {
                    new Pagina() { Nome = "Animações simples", Descricao = "Anime quase tudo no Xamarin Forms, de leiautes a controles", ArquivoPagina = typeof(XamarinForms.Animacoes.Simples.Simples), TemNavegacao = true },
                };
                animacao.Nome = "Animação";

                var gestos = new PaginaColecao()
                {
                    new Pagina() { Nome = "Gestos simples", Descricao = "Detecte gestos feito pelo usuário", ArquivoPagina = typeof(XamarinForms.Gestos.Gestos), TemNavegacao = true },
                };
                gestos.Nome = "Gestos";

                var classesuteis = new PaginaColecao()
                {
                    new Pagina() { Nome = "Display", Descricao = "Apresente Pop-ups para o usuário", ArquivoPagina = typeof(XamarinForms.Classes.Alertas.Alerta), TemNavegacao = true },
                    new Pagina() { Nome = "Converter", Descricao = "Mude/Converte a informação da tela", ArquivoPagina = typeof(XamarinForms.Classes.Conversores.Conversor), TemNavegacao = true },
                    new Pagina() { Nome = "MessageCenter", Descricao = "Troque mensagens entre telas de forma elegante", ArquivoPagina = typeof(XamarinForms.Classes.CentroMensagem.Pagina01), TemNavegacao = true },
                    new Pagina() { Nome = "OnPlatform/OnIdiom", Descricao = "Detecte sistema operacional, dispositivo e personalize sua interface", ArquivoPagina = typeof(XamarinForms.Classes.Detectar.Detectar), TemNavegacao = true },
                };
                classesuteis.Nome = "Classes úteis";

                var xf47 = new PaginaColecao()
                {
                    new Pagina() { Nome = "Grid Rápida", Descricao = "Uma nova forma de declarar colunas e linhas", ArquivoPagina = typeof(XamarinForms.XF47.GridRapida), TemNavegacao = true },
                    new Pagina() { Nome = "Multi-bindings", Descricao = "Texto com vínculos multiplos", ArquivoPagina = typeof(XamarinForms.XF47.MultiplosVinculos), TemNavegacao = true },
                    new Pagina() { Nome = "Formas (Shapes)", Descricao = "Construa formas retângulares, elipse e linhas.", ArquivoPagina = typeof(XamarinForms.XF47.Formas), TemNavegacao = true },
                    new Pagina() { Nome = "Caminhos (Paths)", Descricao = "Desenhe livremente.", ArquivoPagina = typeof(XamarinForms.XF47.Caminhos), TemNavegacao = true },
                };
                xf47.Nome = "Xamarin Forms 4.7";

                var shell = new PaginaColecao()
                {
                    new Pagina() { Nome = "Tabbar (Shell)", Descricao = "Uma nova forma de navegação baseada em abas com Shell", ArquivoPagina = typeof(XamarinForms.Concha.Abas.AppShellTabbar), SubstituirMainPage = true },
                    new Pagina() { Nome = "Flyout (Shell)", Descricao = "Uma nova forma de navegação baseada em menu hamburgue com Shell", ArquivoPagina = typeof(XamarinForms.Concha.Hamburgue.AppShellFlyoutItem), SubstituirMainPage = true }
                };
                shell.Nome = "Shell";

                return new List<PaginaColecao>()
                {
                    paginas,
                    leiautes,
                    controles,
                    listas,
                    estilos,
                    animacao,
                    gestos,
                    classesuteis,
                    xf47,
                    shell
                };
            } 
        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }


        private void AbrirPagina(object sender, EventArgs e)
        {
            TappedEventArgs eventArgs = (TappedEventArgs)e;
            Pagina parametro = (Pagina)eventArgs.Parameter;

            Page pagina = null;

            if (parametro.SubstituirMainPage)
            {
                pagina = (Page)Activator.CreateInstance(parametro.ArquivoPagina);
                App.Current.MainPage = pagina;
            }
            else { 
                if (parametro.TemNavegacao)
                {
                    pagina = new NavigationPage(
                        (Page)Activator.CreateInstance(parametro.ArquivoPagina)
                    );
                }
                else
                {
                    pagina = (Page)Activator.CreateInstance(parametro.ArquivoPagina);
                }

                ((MasterDetailPage)App.Current.MainPage).Detail = pagina;
                ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
            }
        }
        private void LogicUpdateStatusBarColorByTheme()
        {
            UpdateStatusBarColorByTheme();
            Application.Current.RequestedThemeChanged += (obj, args) => {
                UpdateStatusBarColorByTheme();
            };
        }
        private void UpdateStatusBarColorByTheme()
        {
            if (Application.Current.RequestedTheme == OSAppTheme.Light)
            {
                ((MasterDetailPage)MainPage).Detail.Effects.Add(new StatusBarEffect() { BackgroundColor = Color.FromHex("#C4C4C4") });
            }
            else
            {
                ((MasterDetailPage)MainPage).Detail.Effects.Add(new StatusBarEffect() { BackgroundColor = Color.FromHex("#000000") });
            }
        }
    }
}
