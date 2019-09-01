using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnDApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorNavigationPage : NavigationPage
    {
        public ColorNavigationPage(ContentPage mainPage) : base(mainPage)
        {
            InitializeComponent();
        }
    }
}