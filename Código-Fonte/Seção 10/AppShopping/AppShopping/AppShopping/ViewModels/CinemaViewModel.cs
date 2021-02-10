using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    public class CinemaViewModel : BaseViewModel
    {
        public ICommand FilmDetailCommand { get; set; }
        public List<Film> Films { get; set; }

        public CinemaViewModel()
        {
            FilmDetailCommand = new Command<Film>(FilmDetail);

            Films = new CinemaService().GetFilms();
        }
        private void FilmDetail(Film film)
        {
            var filmSerialized = JsonConvert.SerializeObject(film);
            Shell.Current.GoToAsync($"film/detail?filmSerialized={Uri.EscapeDataString(filmSerialized)}");
        }
    }
}
