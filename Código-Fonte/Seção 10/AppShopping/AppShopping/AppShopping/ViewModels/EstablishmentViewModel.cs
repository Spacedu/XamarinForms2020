using AppShopping.Libraries.Helpers.MVVM;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using AppShopping.Models;
using AppShopping.Services;
using System.Linq;
using Xamarin.Forms;
using AppShopping.Libraries.Enums;
using Newtonsoft.Json;

namespace AppShopping.ViewModels
{
    public abstract class EstablishmentViewModel : BaseViewModel
    {

        /*
         * MVVM - View <-> ViewModel <-> Model
         * - Commands: Ações > Métodos.
         * - Bindings: Vinculos > Propriedades.
         * - Notifications: 
         * 
         * 
         * View(Lojas-Stores): Entry(Text=Binding SearchWord, Mode=TwoWay)
         * ViewModel: string SearchWord
         * Entry-Text=Renner (ViewModel-SearchWord: Renner)
         * 
         * Notificação: INotifyPropertyChanged. MessageCenter(Code Behind)
         */

        public String SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }

        private List<Establishment> _establishments;
        public List<Establishment> Establishments
        {
            get
            {
                return _establishments;
            }
            set
            {
                SetProperty(ref _establishments, value);
            }
        }
        private List<Establishment> _allEstablishments;

        public ICommand DetailCommand { get; set; }

        private EstablishmentType _establishmentType;

        public EstablishmentViewModel(EstablishmentType establishmentType)
        {
            _establishmentType = establishmentType;
            SearchCommand = new Command(Search);
            DetailCommand = new Command<Establishment>(Detail);

            var allEstablishment = new EstablishmentService().GetEstablishments(); //E30 = L20 + R10
            var allStores = allEstablishment.Where(a => a.Type == _establishmentType).ToList();

            Establishments = allStores;
            _allEstablishments = allStores;
        }

        private void Search()
        {
            Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
        private void Detail(Establishment establishment)
        {
            String establishmentSerialized = JsonConvert.SerializeObject(establishment);

            Shell.Current.GoToAsync($"establishment/detail?establishmentSerialized={Uri.EscapeDataString(establishmentSerialized)}");
        }
    }
}
