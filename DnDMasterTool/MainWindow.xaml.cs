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

namespace DnDMasterTool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MasterToolViewModel _model;
        public MainWindow()
        {
            InitializeComponent();
            _model = new MasterToolViewModel();
            DataContext = _model;
        }

        private void AddHero_OnClick(object sender, RoutedEventArgs e)
        {
            var hero = new Hero();
            hero.Name = "Hero";
            _model.Heroes.Add(hero);
        }

        private void DeleteHero_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
