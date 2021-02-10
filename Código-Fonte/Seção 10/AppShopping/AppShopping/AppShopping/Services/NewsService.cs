using AppShopping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.Services
{
    public class NewsService
    {
        private static List<News> fakeNews = new List<News>()
        {
            new News() { Title = "DIA DAS MÃES", Description = "A cada R$ 100,00 em compras você ganha um cupom para concorre a 5 lindos Honda Fit para sua mãe." },
            new News() { Title = "NATAL", Description = "A cada R$ 100,00 em compras você ganha um cupom para concorre a 2 Honda HRV." },
        };
        public List<News> GetNews()
        {
            return fakeNews;
        }
    }
}
