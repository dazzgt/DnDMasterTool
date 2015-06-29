using System.Windows;
using DnDMasterTool.Models;

namespace DnDMasterTool.View
{
    /// <summary>
    /// Логика взаимодействия для AddItemView.xaml
    /// </summary>
    public partial class AddItemView
    {
        private Item _item;
        public AddItemView()
        {
            InitializeComponent();
            _item = new Item();
            DataContext = _item;
        }

        public new Item Show()
        {
            if (ShowDialog() ?? false)
            {
                return _item;
            }
            return null;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
