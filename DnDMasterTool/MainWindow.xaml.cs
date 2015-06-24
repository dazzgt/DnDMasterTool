using System.Windows;
using DnDMasterTool.Models;
using DnDMasterTool.View;

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
            var hero = new AddHeroView().Show();
            if (hero != null)
                _model.Heroes.Add(hero);
        }

        private void DeleteHero_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void PrintHero_OnClick(object sender, RoutedEventArgs e)
        {
            _model.PrintHero();
        }

        private void PrintAllHero_OnClick(object sender, RoutedEventArgs e)
        {
            _model.PrintAllHero();
        }
    }
}
