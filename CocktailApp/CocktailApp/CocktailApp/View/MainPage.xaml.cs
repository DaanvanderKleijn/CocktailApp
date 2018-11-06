using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CocktailApp.View
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> mainMenuItemList { get; set; }
        public MainPage()
        {
            InitializeComponent();
            mainMenuItemList = new ObservableCollection<string>();

            mainMenuItemList.Add("Instellingen");
            mainMenuItemList.Add("Categorieën");
            mainMenuItemList.Add("EULA");
            mainMenuItemList.Add("Achievements");

            mainMenu.ItemsSource = mainMenuItemList;
        }

        public void UpdateContentPage(object sender, Syncfusion.ListView.XForms.ItemAppearingEventArgs e)
        {
            switch (e.ItemData.ToString())
            {
                case "Instellingen":
                    navDrawer.ContentView = new Instellingen().Content;
                    break;

                case "Categorieën":
                    navDrawer.ContentView = new Categorieën().Content;
                    break;

                case "EULA":
                    navDrawer.ContentView = new EULA().Content;
                    break;

                case "Achievements":
                    navDrawer.ContentView = new Achievements().Content;
                    break;
            }
            navDrawer.ToggleDrawer();
        }
    }
}
