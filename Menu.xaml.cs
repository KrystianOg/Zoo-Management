using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zoo_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private IDictionary<Button, Panel> buttonPanelMap = new Dictionary<Button, Panel>();
        private IDictionary<Panel, MaterialDesignThemes.Wpf.PackIcon> panelIconMap = new Dictionary<Panel, MaterialDesignThemes.Wpf.PackIcon>();
        private IDictionary<Panel, bool> privileges = new Dictionary<Panel, bool>();
        private IDictionary<Panel, Control> enumToPanel = new Dictionary<Panel, Control>();

        public Menu()
        {
            InitializeComponent();

            Application.Current.MainWindow = this;
            MenuIcons.Visibility = Visibility.Visible;

            //hide functions 

            //button panel map
            buttonPanelMap.Add(AccountButton, Panel.Account);
            buttonPanelMap.Add(AnimalsButton, Panel.Animals);
            buttonPanelMap.Add(TruckButton, Panel.Deliveries);
            buttonPanelMap.Add(WarehouseButton, Panel.Storage);
            buttonPanelMap.Add(SettingsButton, Panel.Settings);

            //set button to icon map
            panelIconMap.Add(Panel.Account, AccountIcon);
            panelIconMap.Add(Panel.Deliveries, TruckIcon);
            panelIconMap.Add(Panel.Animals, AnimalsIcon);
            panelIconMap.Add(Panel.Storage, WarehouseIcon);
            panelIconMap.Add(Panel.Settings, SettingsIcon);

            //set privileges

            //set enumToPanel
            enumToPanel.Add(Panel.Account, AccountPanel);
            enumToPanel.Add(Panel.Animals, AnimalsPanel);
            enumToPanel.Add(Panel.Deliveries, DeliveryPanel);
            enumToPanel.Add(Panel.Settings, SettingsPanel);
            enumToPanel.Add(Panel.Storage, StoragePanel);

            SetUsedPanel(AnimalsButton, new RoutedEventArgs());
        }

        private void BorderMouseDown(object sender,MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (InvalidOperationException) { }
        }

        private void SetUsedPanel(object sender,RoutedEventArgs e)
        {
            var senderPanel = buttonPanelMap[(Button)sender];

            //set all buttons to default color except for current
            foreach (KeyValuePair<Panel, MaterialDesignThemes.Wpf.PackIcon> kv in panelIconMap)
                kv.Value.Foreground = App.Current.Resources["DefaultWhite"] as SolidColorBrush;

            panelIconMap[senderPanel].Foreground = App.Current.Resources["Apricot"] as SolidColorBrush;
            //

            //panel change
            foreach (KeyValuePair<Panel, Control> kv in enumToPanel)
                kv.Value.Visibility = Visibility.Hidden;

            enumToPanel[senderPanel].Visibility = Visibility.Visible;
            //
        }

        //change some things while resing or do it in wpf
        private void OnResize()
        {

        }
    }

    enum Panel
    {
        Account,
        Animals,
        Deliveries,
        Storage,
        Settings
    }
}
