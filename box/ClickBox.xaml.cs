using System.Text.RegularExpressions;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class ClickBox : ContentPage
    {
        public ClickBox()
        {
            InitializeComponent();

        }
        
        public void ShowClickBoxPage()
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(this);
        }
        private void back_Clicked(object sender, ClickedEventArgs e)
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Pop();
        }

        private void startUse_Clicked(object sender, ClickedEventArgs e)
        {
            Reserve.Instance.ShowPopup();
        }

        private bool enterPW_TouchEvent(object source, TouchEventArgs e)
        {
            SetPasswordOnlyDigit(enterPW);
            return true;
        }

        private void enterPW_MaxLengthReached(object sender, TextEditor.MaxLengthReachedEventArgs e)
        {
            
        }
        private void SetPasswordOnlyDigit(TextField field)
        {

            /*hide password 
             * PropertyMap passwordMap = new PropertyMap();
            passwordMap.Add(HiddenInputProperty.Mode, new PropertyValue((int)HiddenInputModeType.HideAll));
            passwordMap.Add(HiddenInputProperty.SubstituteCharacter, new PropertyValue(0x2022));
            field.HiddenInputSettings = passwordMap;*/

            InputMethod inputMethod = new InputMethod();
            inputMethod.PanelLayout = InputMethod.PanelLayoutType.Password;
            field.InputMethodSettings = inputMethod.OutputMap;

            field.TextChanged += (s, e) =>
            {
                string str = Regex.Replace(e.TextField.Text, @"[\D_]", "");
                e.TextField.Text = str;
            };
        }

        
    }
}
