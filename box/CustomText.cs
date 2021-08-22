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
    class CustomText : RecyclerViewItem
    {
        private TextLabel stationLabel;
        private TextLabel umbrellaLabel;
        private TextLabel maskLabel;

        public CustomText()
        {
            float sizeW = Window.Instance.WindowSize.Width*0.95f;
            float sizeH = Window.Instance.WindowSize.Height * 0.3f;
            Size = new Size(sizeW, sizeH);

            stationLabel = new TextLabel()
            {
                PointSize = 100,
                ParentOrigin = Tizen.NUI.ParentOrigin.TopCenter,
                PivotPoint = Tizen.NUI.PivotPoint.TopCenter,
                PositionUsesPivotPoint = true,
            };

            Add(stationLabel);
            stationLabel.SetBinding(TextLabel.TextProperty, "StationName");

            umbrellaLabel = new TextLabel()
            {
                PointSize = 70,
                ParentOrigin = Tizen.NUI.ParentOrigin.BottomLeft,
                PivotPoint = Tizen.NUI.PivotPoint.BottomLeft,
                PositionUsesPivotPoint = true,
            };
            Add(umbrellaLabel);
            umbrellaLabel.SetBinding(TextLabel.TextProperty, "Umbrella");

            maskLabel = new TextLabel()
            {
                PointSize = 70,
                ParentOrigin = Tizen.NUI.ParentOrigin.BottomRight,
                PivotPoint = Tizen.NUI.PivotPoint.BottomRight,
                PositionUsesPivotPoint = true,
            };
            Add(maskLabel);
            maskLabel.SetBinding(TextLabel.TextProperty, "Mask");
        }
    }
}
