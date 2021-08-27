using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class ReservedListPopup : DialogPage
    {
        public ReservedListPopup()
        {
            InitializeComponent();
        }

        public void ShowPopUpPage()
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(this);
        }

        private bool goHome_TouchEvent(object source, TouchEventArgs e)
        {
            Navigator.Push(new NaviPage());
            return true;
        }

        private bool reservedListPopup_TouchEvent(object source, TouchEventArgs e)
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Pop();
            return true;
        }
    }
}
