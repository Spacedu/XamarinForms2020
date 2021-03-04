using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.Resources.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubtitleComponentView : ContentView
    {
        public static readonly BindableProperty PropertiesProperty = BindableProperty.Create(nameof(Properties), typeof(string), typeof(SubtitleComponentView));
        public static readonly BindableProperty EventsProperty = BindableProperty.Create(nameof(Events), typeof(string), typeof(SubtitleComponentView));
        public static readonly BindableProperty MethodsProperty = BindableProperty.Create(nameof(Methods), typeof(string), typeof(SubtitleComponentView));
        public static readonly BindableProperty ObservationProperty = BindableProperty.Create(nameof(Observation), typeof(string), typeof(SubtitleComponentView));
        public static readonly BindableProperty ComponentProperty = BindableProperty.Create(nameof(Component), typeof(View), typeof(SubtitleComponentView));

        public string Properties
        {
            get { return (string)GetValue(PropertiesProperty); }
            set { SetValue(PropertiesProperty, value); }
        }
        public string Events
        {
            get { return (string)GetValue(EventsProperty); }
            set { SetValue(EventsProperty, value); }
        }
        public string Methods
        {
            get { return (string)GetValue(MethodsProperty); }
            set { SetValue(MethodsProperty, value); }
        }
        public string Observation
        {
            get { return (string)GetValue(ObservationProperty); }
            set { SetValue(ObservationProperty, value); }
        }

        public View Component
        {
            get { return (View)GetValue(ComponentProperty); }
            set { SetValue(ComponentProperty, value); }
        }
        public SubtitleComponentView()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == "Component")
            {
                myContainer.Children.Add(Component);
            }




            string[] fields = new string[] { "Properties", "Events", "Methods", "Observation" };

            if (myComponent != null)
            {
                foreach (var field in fields)
                {
                    var titulo = myComponent.FindByName<Label>("Lbl" + field);
                    var valor = myComponent.FindByName<Label>("Lbl" + field + "Value");

                    if (string.IsNullOrEmpty(valor.Text))
                    {
                        UpdateVisible(titulo, valor, false);
                    }
                    else
                    {
                        UpdateVisible(titulo, valor, true);
                    }
                }
            }
        }

        private void UpdateVisible(Label titulo, Label valor, Boolean visibility)
        {
            titulo.IsVisible = visibility;
            valor.IsVisible = visibility;
        }
    }
}