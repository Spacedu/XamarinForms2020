using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using JobSearch.Domain.Models;

namespace JobSearch.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Visualizer : ContentPage
    {
        public Visualizer()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Job job = ((Job)BindingContext);

            if (string.IsNullOrEmpty( job.CompanyDescription ))
            {
                HeaderCompanyDescription.IsVisible = false;
                TextCompanyDescription.IsVisible = false;
            }

            if (string.IsNullOrEmpty(job.JobDescription))
            {
                HeaderJobDescription.IsVisible = false;
                TextJobDescription.IsVisible = false;
            }

            if (string.IsNullOrEmpty(job.Benefits))
            {
                HeaderBenefits.IsVisible = false;
                TextBenefits.IsVisible = false;
            }
        }
    }
}