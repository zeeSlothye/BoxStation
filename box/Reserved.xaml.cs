using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class Reserved : DialogPage
    {
        public Reserved()
        {
            InitializeComponent();
        }

        public void ShowPopup()
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(this);
        }


        private bool reservePopup_TouchEvent(object source, View.TouchEventArgs e)
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Pop();
            return true;
        }

        private bool goHome_TouchEvent(object source, TouchEventArgs e)
        {
            Navigator.Push(new NaviPage());
            return true;
        }
    }
}
