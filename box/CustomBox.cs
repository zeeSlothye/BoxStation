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
    class CustomBox : RecyclerViewItem
    {
        private Button btn;
        private TextLabel label;
        public CustomBox()
        {
            float sizeW = Window.Instance.WindowSize.Width * 0.3f;
            Size = new Size(sizeW, sizeW);

            btn = new Button()
            {
                StyleName = "BoxButton",
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                ParentOrigin = Tizen.NUI.ParentOrigin.Center,
                PivotPoint = Tizen.NUI.PivotPoint.Center,
                PositionUsesPivotPoint = true,
            };
            btn.Icon.WidthSpecification = (int)(sizeW * 0.7f);
            btn.Icon.HeightSpecification = (int)(sizeW * 0.7f);
            btn.Icon.SetBinding(ImageView.ResourceUrlProperty, "IsOpen");
            Add(btn);
            label = new TextLabel()
            {
                PointSize = 70,
                ParentOrigin = Tizen.NUI.ParentOrigin.BottomCenter,
                PivotPoint = Tizen.NUI.PivotPoint.BottomCenter,
                PositionUsesPivotPoint = true,
            };
            Add(label);

            label.SetBinding(TextLabel.TextProperty, "BoxNumber");

        }

    }
}
