using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AppTarefa.Banco
{
    public static class Constantes
    {
        public const string NomeDoArquivo = "AppTarefa.db3";

        public static string CaminhoDoBanco
        {
            get
            {
                var caminhoBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(caminhoBase, NomeDoArquivo);
            }
        }
    }
}
