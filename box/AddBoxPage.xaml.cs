using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
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
            foreach(var item in Resources.Box)
            {
                dataSource.Add(new Boxes(item.stn, item.bxn, item.iso, item.umb, item.mask));
            }

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
            stationName.Text = "버스정류장: 충남대학교";
            remainUmbrella.Text = "남은 우산 수: 5";
            remainMask.Text = "남은 마스크 수: 10";
        }

        private async Task<HttpResponseMessage> get_user()
        {
            //https://stackoverflow.com/questions/2246694/how-to-convert-json-object-to-custom-c-sharp-object
            //서버로 보낼 데이터
            var parameters = new Dictionary<string, string>();
            parameters.Add("userId", "abc");
            parameters.Add("userPw", "abc");
            //type : Dict => HttpContent 
            var encodedContent = new FormUrlEncodedContent(parameters);
            //서버로 데이터를 보내고 받는.. => response로 return
            HttpResponseMessage response = await new HttpClient().PostAsync("http://3.37.186.43:8000/user/get_user", encodedContent);

            Console.WriteLine(response);
            string json = await response.Content.ReadAsStringAsync(); ;
            return response;
        }

        
    }
}
