using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStation.Data
{
    class BoxDataSource
    {
        //AddBoxPage의 init에서 BoxDict를 호출하여 boxDataSource를 저장함. 
        public static Dictionary<string, Boxes> boxDataSource = new Dictionary<string, Boxes>();

        public void BoxDict(List<Boxes> boxesDataSource)
        {
            foreach (var item in boxesDataSource)
            {
                boxDataSource.Add(item.BoxNumber, item);
            }
        }
    }
    
}
