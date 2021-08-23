using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class Reserve : DialogPage
    {
        
        private Reserve()
        {
            InitializeComponent();
        }
        private static Reserve instance;
        public static Reserve Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Reserve();
                }
                return instance;
            }
        }
        public void ShowPopup()
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(this);
        }

        private bool View_TouchEvent(object source, TouchEventArgs e)
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Pop();
            return true;
        }

        private bool startReserve_TouchEvent(object source, TouchEventArgs e)
        {
            Reserved reserved = new Reserved();
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(reserved);
            return true;
        }
    }
}
