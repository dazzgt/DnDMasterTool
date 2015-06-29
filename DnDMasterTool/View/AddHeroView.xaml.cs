using System.Windows;
using DnDMasterTool.Models;

namespace DnDMasterTool.View
{
    /// <summary>
    /// Логика взаимодействия для AddHeroView.xaml
    /// </summary>
    public partial class AddHeroView
    {
        private Hero _hero;
        public AddHeroView()
        {
            InitializeComponent();
            _hero = new Hero();
            DataContext = _hero;
        }

        public new Hero Show()
        {
            if (ShowDialog() ?? false)
            {
                return _hero;
            }
            return null;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (_hero.Points > 10)
                MessageBox.Show("Распределите больше очков");
            else if (_hero.Points < 0)
                MessageBox.Show("Имбааа!!! Кастрируй!!");
            else
                DialogResult = true;
        }

        private void AddItem_OnClick(object sender, RoutedEventArgs e)
        {
            Item item = new AddItemView().Show();
            if(item!=null)
                _hero.Inventory.Add(item);
        }
    }
}
