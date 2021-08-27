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
            
            //station 정보들 받아옴. 
            Dictionary<string, Data.Stations> stationDataSource = new Dictionary<string, Data.Stations>();
            foreach (var item in Data.Resources.Stations)
            {
                //("충남대학교 정류장","0000","10","5"),
                stationDataSource.Add(item.uuid, new Data.Stations(item.bst, item.uuid, item.umb, item.msk));
            }

            //UUID로 정류장 구분. ; uuid와 일치하는 정류장을 찾아서 저장함. 
            string uuid = "0000"; //TODO 서버로부터 받아와야함. 
            Data.Stations station = stationDataSource[uuid];

            //textlabel 설정
            stationName.Text = station.BusStation;
            remainUmbrella.Text = station.Umbrella;
            remainMask.Text = station.Mask;

            //Boxes에서 station.BusStation과 동일한 정보를 가진것만 뽑아서 dict에 추가. 
            List<Data.Boxes> boxesDataSource = new List<Data.Boxes>();
            foreach (var item in Data.Resources.Boxes)
            {
                if (item.bst == station.BusStation){
                    //("충남대학교 정류장","1","isOpen_true.PNG","false","과자","1234","2021.01.19-AM.5:30")
                    boxesDataSource.Add(new Data.Boxes(item.bst, item.bxn, item.isO, item.isP, item.stf, item.pw, item.date));
                }
            }

            //collectionView에 보여주기. 
            CollectionView boxContainerView = new CollectionView()
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                ItemsSource = boxesDataSource,
                ItemsLayouter = new GridLayouter(),
                ItemTemplate = new DataTemplate(() =>
                {
                    return new CustomBox();
                }),
            };

            boxInfo.Add(boxContainerView);

            //박스번호를 통해 박스 구분하도록 dict만듦. 
            Data.BoxDataSource box = new Data.BoxDataSource();
            box.BoxDict(boxesDataSource);
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
