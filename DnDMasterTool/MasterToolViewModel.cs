using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMasterTool
{
    public class MasterToolViewModel
    {
        public MasterToolViewModel()
        {
            Heroes = new ObservableCollection<Hero>();
        }

        #region Properties

        public ObservableCollection<Hero> Heroes { get; set; }

        #endregion
    }
}
