using AppShopping.Libraries.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping.ViewModels
{
    public class RestaurantsViewModel : EstablishmentViewModel
    {
        public RestaurantsViewModel(EstablishmentType establishmentType) : base(establishmentType)
        {
        }
    }
}
