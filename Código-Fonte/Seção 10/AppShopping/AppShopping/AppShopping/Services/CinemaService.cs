using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Services
{
    public class CinemaService
    {
        public List<Film> GetFilms()
        {
            return new List<Film>()
            {
                new Film(){
                    Cover = "https://th.bing.com/th/id/OIP._4AE31XZPtavwsAbuOKK0AAAAA?pid=Api&rs=1",
                    Name = "1917",
                    Description = "Na Primeira Guerra Mundial, dois soldados britânicos recebem ordens aparentemente impossíveis de cumprir. Em uma corrida contra o tempo, eles precisam atravessar o território inimigo e entregar uma mensagem que pode salvar 1600 de seus companheiros.",
                    SessionGroups = new List<SessionGroup>{
                        new SessionGroup("Legendadas", new List<string>(){ 
                            "10:30h",
                            "14:30h",
                            "16:30h",
                            "17:30h",
                            "19:30h",
                        }),
                        new SessionGroup("Dublado", new List<string>(){
                            "15:30h",
                            "16:30h",
                            "17:30h",
                            "19:30h",
                        }),
                    }
                },
                new Film(){ 
                    Cover = "https://www.cine14bis.com.br/site/wp-content/uploads/2019/12/12684_medio.jpg",
                    Name = "Arlequina em Aves de Rapina", 
                    Description = "Depois de se aventurar com o Coringa, Arlequina se junta a Canário Negro, Caçadora e Renee Montoya para salvar a vida de uma garotinha do criminoso Máscara Negra em Gotham City.",
                    SessionGroups = new List<SessionGroup>{
                        new SessionGroup("Legendadas", new List<string>(){
                            "10:30h",
                            "14:30h",
                            "16:30h",
                            "17:30h",
                            "19:30h",
                        }),
                        new SessionGroup("Dublado", new List<string>(){
                            "15:30h",
                            "16:30h",
                            "17:30h",
                            "19:30h",
                        }),
                    }
                },
            };
        }
    }
}
