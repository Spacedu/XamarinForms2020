using System;
using System.Collections.Generic;
using System.Text;

namespace AppGallery.AppBase.Models
{
    public class Pagina
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Type ArquivoPagina { get; set; }
        public bool TemNavegacao { get; set; }
        public bool SubstituirMainPage { get; set; }
    }
}
