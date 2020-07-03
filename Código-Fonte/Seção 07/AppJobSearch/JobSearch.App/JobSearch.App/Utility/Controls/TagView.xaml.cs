using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobSearch.App.Utility.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TagView : ContentView
    {
        public static readonly BindableProperty TechonologiesProperty = BindableProperty.Create("Techonologies", typeof(string), typeof(TagView));

        public string Techonologies
        {
            get => (string)GetValue(TagView.TechonologiesProperty);
            set => SetValue(TagView.TechonologiesProperty, value);
        }

        public static readonly BindableProperty NumberOfWordsProperty = BindableProperty.Create("NumberOfWords", typeof(int), typeof(TagView));

        public int NumberOfWords
        {
            get => (int)GetValue(TagView.NumberOfWordsProperty);
            set => SetValue(TagView.NumberOfWordsProperty, value);
        }
        public TagView()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(propertyName == "Techonologies")
            {
                Container.Children.Clear();
                if (Techonologies != null)
                {
                    string[] words = Techonologies.Split(',');

                    if(NumberOfWords == 0)
                    {
                        NumberOfWords = words.Count();
                    }

                    int limit = (words.Count() >= NumberOfWords) ? NumberOfWords : words.Count();
                    for (int i = 0; i < limit; i++)
                    {
                        var frame = new Frame() { Margin = new Thickness(0, 3, 3, 3), BackgroundColor = Color.FromHex("#F7F8FA"), Padding = new Thickness(3), HasShadow = false };
                        var label = new Label() { Text = words[i], Padding = new Thickness(3), FontFamily = "MontserratLight", FontSize= 10, TextColor = Color.FromHex("#8D9EAA") };

                        frame.Content = label;

                        Container.Children.Add(frame);
                    }
                }
            }
            base.OnPropertyChanged(propertyName);
        }
    }
}