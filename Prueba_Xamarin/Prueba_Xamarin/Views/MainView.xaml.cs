using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        int count = 0;
        public MainView()
        {
            InitializeComponent();


            MyButton.Clicked += (sender, args) =>
            {
                LblClicks.Text = String.Format("Botón pulsado {0} veces.", ++count);
            };
        }
    }
}