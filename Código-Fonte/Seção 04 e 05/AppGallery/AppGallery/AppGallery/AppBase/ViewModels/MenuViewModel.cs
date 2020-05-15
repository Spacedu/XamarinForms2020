using AppGallery.AppBase.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGallery.AppBase.ViewModels
{
    public class MenuViewModel
    {
        public List<PaginaColecao> MenuItens { get; set; }
        public MenuViewModel()
        {
            MenuItens = App.MenuItensColecao;
        }
    }
}
