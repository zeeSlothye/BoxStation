using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class Reserve : DialogPage
    {
        //이전화면에서 user가 "예약하기"를 누르면 다음 행동요령을 알려줌. 
        //사물함이 isOpen상태가 되고 -> user가 물건을 넣은 후 닫으면 -> !isOpen이 되고-> 이떄의 시간이 기록됨. 
        //user가 예약확인 누른 시간을 저장해야함. 
        public Reserve()
        {
            InitializeComponent();
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
