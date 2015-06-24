namespace DnDMasterTool.Models
{
    public class Hero : INPC
    {
        #region Fields

        private string _name = "";
        private int _str = 10;
        private int _con = 10;
        private int _dex = 10;
        private int _wis = 10;
        private int _int = 10;
        private int _cha = 10;

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Str
        {
            get { return _str; }
            set
            {
                _str = value;
                OnPropertyChanged("Str", "StrMod");
            }
        }
        public int Con
        {
            get { return _con; }
            set
            {
                _con = value;
                OnPropertyChanged("Con","ConMod");
            }
        }
        public int Dex
        {
            get { return _dex; }
            set
            {
                _dex = value;
                OnPropertyChanged("Dex","DexMod");
            }
        }
        public int Wis
        {
            get { return _wis; }
            set
            {
                _wis = value;
                OnPropertyChanged("Wis", "WisMod");
            }
        }
        public int Int
        {
            get { return _int; }
            set
            {
                _int = value;
                OnPropertyChanged("Int", "IntMod");
            }
        }
        public int Cha
        {
            get { return _cha; }
            set
            {
                _cha = value;
                OnPropertyChanged("Cha", "ChaMod");
            }
        }
        public int StrMod
        {
            get { return (_str - 10) / 2; }
        }
        public int ConMod
        {
            get { return (_con - 10) / 2; }
        }
        public int DexMod
        {
            get { return (_dex - 10) / 2; }
        }
        public int WisMod
        {
            get { return (_wis - 10) / 2; }
        }
        public int IntMod
        {
            get { return (_int - 10) / 2; }
        }
        public int ChaMod
        {
            get { return (_cha - 10) / 2; }
        }

        public int Points
        {
            get { return _cha + _con + _dex + _int + _str + _wis; }
        }
        #endregion
    }
}
