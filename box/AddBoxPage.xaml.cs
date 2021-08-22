using System.Collections.Generic;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class AddBoxPage : ContentPage
    {
        public AddBoxPage()
        {
            InitializeComponent();

            List<Boxes> dataSource = new List<Boxes>();
            foreach(var item in Resources.Cnu)
            {
                dataSource.Add(new Boxes(item.stn, item.bxn, item.iso, item.umb, item.mask));
            }

            CollectionView stationInfoTableView = new CollectionView()
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                ItemsSource = dataSource,
                ItemsLayouter = new LinearLayouter(),
                ItemTemplate = new DataTemplate(() =>
                {
                    return new CustomText();
                }),
            };
            stationInfo.Add(stationInfoTableView);

            CollectionView boxContainerView = new CollectionView()
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                ItemsSource=dataSource,
                ItemsLayouter= new GridLayouter(),
                ItemTemplate = new DataTemplate(() =>
                {
                    return new CustomBox();
                }),

            };
            boxInfo.Add(boxContainerView);

        }

    }
}
