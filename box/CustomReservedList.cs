using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    class CustomReservedList: RecyclerViewItem
    {
        private Button btn;
        private TextLabel stationLabel;
        private TextLabel boxNumberLabel;
        private TextLabel pWLabel;
        private TextLabel reservedDateLabel;
        private TextLabel reservedStuffLabel;
        private TextLabel presentCostLabel;
        public CustomReservedList()
        {
            float sizeW = Window.Instance.WindowSize.Width * 0.9f;
            float sizeH = Window.Instance.WindowSize.Width * 0.1f;
            Size = new Size(sizeW, sizeH);

            //버튼(틀), 클릭시 detail info
            btn = new Button()
            {
                StyleName = "ReservedListButton",
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                ParentOrigin = Tizen.NUI.ParentOrigin.Center,
                PivotPoint = Tizen.NUI.PivotPoint.Center,
                PositionUsesPivotPoint = true,
            };
            btn.Clicked += Btn_Clicked;
            Add(btn);

            stationLabel = new TextLabel()
            {
                PointSize = 100,
                ParentOrigin = Tizen.NUI.ParentOrigin.TopLeft,
                PivotPoint = Tizen.NUI.PivotPoint.TopLeft,
                PositionUsesPivotPoint = true,
            };
            Add(stationLabel);
            stationLabel.SetBinding(TextLabel.TextProperty, "StationName");

            boxNumberLabel = new TextLabel()
            {
                PointSize = 100,
                ParentOrigin = Tizen.NUI.ParentOrigin.Center,
                PivotPoint = Tizen.NUI.PivotPoint.Center,
                PositionUsesPivotPoint = true,
            };
            Add(boxNumberLabel);
            boxNumberLabel.SetBinding(TextLabel.TextProperty, "BoxNumber");

            pWLabel = new TextLabel()
            {
                PointSize = 30,
                ParentOrigin = Tizen.NUI.ParentOrigin.BottomCenter,
                PivotPoint = Tizen.NUI.PivotPoint.BottomCenter,
                PositionUsesPivotPoint = true,
            };
            Add(pWLabel);
            //pWLabel.SetBinding(TextLabel.TextProperty, "PW");
            pWLabel.Text = "1234";

            reservedStuffLabel = new TextLabel()
            {
                PointSize = 100,
                ParentOrigin = Tizen.NUI.ParentOrigin.TopCenter,
                PivotPoint = Tizen.NUI.PivotPoint.TopCenter,
                PositionUsesPivotPoint = true,
            };
            Add(reservedStuffLabel);
            //reservedStuffLabel.SetBinding(TextLabel.TextProperty, "ReservedDate");
            reservedStuffLabel.Text = "노트북";

            /*reservedDateLabel = new TextLabel()
             {
                PointSize = 30,
                ParentOrigin = Tizen.NUI.ParentOrigin.TopRight,
                PivotPoint = Tizen.NUI.PivotPoint.TopRight,
                PositionUsesPivotPoint = true,
            };
            Add(reservedDateLabel);
            //reservedDateLabel.SetBinding(TextLabel.TextProperty, "ReservedDate");
            reservedDateLabel.Text = "2021.08.25 PM 7:11";*/
            
            /*presentCostLabel = new TextLabel()
            {
                PointSize = 30,
                ParentOrigin = Tizen.NUI.ParentOrigin.BottomRight,
                PivotPoint = Tizen.NUI.PivotPoint.BottomRight,
                PositionUsesPivotPoint = true,
            };
            Add(presentCostLabel);
            //presentCostLabel.SetBinding(TextLabel.TextProperty, "PresentCost");
            presentCostLabel.Text = "29,480";*/
        }

        private void Btn_Clicked(object sender, ClickedEventArgs e)
        {
            //ClickBox clickbox = new ClickBox();
            //clickbox.BindingContext = this.BindingContext;
            //clickbox.ShowClickBoxPage(parameters);
        }
    }
}
