using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DnDMasterTool.Models;

namespace DnDMasterTool.View
{
    /// <summary>
    /// Логика взаимодействия для AddHeroView.xaml
    /// </summary>
    public partial class AddHeroView : Window
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
    }
}
