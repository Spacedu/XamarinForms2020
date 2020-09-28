using AppGallery.AppBase.Models;
using AppGallery.XamarinForms.Listas.ListaControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AppGallery.AppBase.ViewModels
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public List<Pagina> PageListBackup { get; set; }

        private List<Pagina> _PageList;
        public List<Pagina> PageList { 
            get {
                return _PageList;
            }
            set {
                _PageList = value;
                RaisePropertyChanged(nameof(PageList));
            } 
        }
        public InicioViewModel()
        {
            PageListBackup = ConversorListaPaginaColecaoParaListaPagina(App.MenuItensColecao);
            PageList = ConversorListaPaginaColecaoParaListaPagina(App.MenuItensColecao);
        }

        public void Pesquisa(string textoPesquisa)
        {
            var listaFiltrada = new List<Pagina>();
            foreach (var pagina in PageListBackup)
            {
                if (pagina.Nome.ToLower().Contains(textoPesquisa.ToLower().Trim()))
                {
                    listaFiltrada.Add(pagina);
                }
            }

            PageList = listaFiltrada;
        }


        private List<Pagina> ConversorListaPaginaColecaoParaListaPagina(List<PaginaColecao> paginaColecao)
        {
            var listaPagina = new List<Pagina>();
            foreach (var colecao in paginaColecao)
            {
                listaPagina.AddRange(colecao);
            }

            return listaPagina;
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
