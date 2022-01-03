using PracaInżynierska.Glowny;
using PracaInżynierska.State;

namespace PracaInżynierska.MVVM.ViewModel
{
    class MainWindowVM : ObiektZauwazalny
    {
        private readonly NavigationState _navigationState;

        public Przekazanie LoginPanelCommand { get; set; }
        public Przekazanie GlownyViewCommand { get; set; }
        public Przekazanie UzytkownikViewCommand { get; set; }
        public Przekazanie KalendarzViewCommand { get; set; }
        public static LoginPanelVM LoginPanel { get; set; }
        public static GlownaVM HomeVM { get; set; }
        public static UzytkownikVM UzytkownikVM { get; set; }
        public static UzytkownikVM uzytkownikVM { get { return UzytkownikVM; } }
        public static KalendarzVM KalendarzVM { get; set; }
        public bool _isHidden { get; set; }
        public bool isHidden
        {
            get
            {
                return _isHidden;
            }
            set
            {
                _isHidden = value;
                OnPropertyChanged();
            }
        }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainWindowVM()
        {
            isHidden = false;
            HomeVM = new GlownaVM();
            UzytkownikVM = new UzytkownikVM();
            KalendarzVM = new KalendarzVM();
            LoginPanel = new LoginPanelVM(this);
            HomeVM.ReloadNews();
            CurrentView = LoginPanel;
            LoginPanelCommand = new Przekazanie(o =>
            {
                CurrentView = LoginPanel;
            });
            GlownyViewCommand = new Przekazanie(o =>
            {
                CurrentView = HomeVM;
                HomeVM.ReloadNews();
            });
            UzytkownikViewCommand = new Przekazanie(o =>
            {
                CurrentView = UzytkownikVM;
                UzytkownikVM.reloaduserdata();
            });
            KalendarzViewCommand = new Przekazanie(o =>
            {
                CurrentView = KalendarzVM;
            });
        }
        public void ChangeViewToHome()
        {
            isHidden = true;
            CurrentView = HomeVM;
            HomeVM.ReloadNews();
            KalendarzVM.GetEvents();
        }

    }
}
