namespace LinqMarbles.Client.Models
{
    public class GlobalObject
    {
        public bool IsDarkMode 
        { 
            get => _isDarkMode; 
            set
            {
                if (value != _isDarkMode)
                {
                    _isDarkMode = value;
                    OnDarkModeChanged?.Invoke(this, _isDarkMode);
                }
            }
        }

        public event EventHandler<bool>? OnDarkModeChanged;


        private bool _isDarkMode = false;
    }
}
