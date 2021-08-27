using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStation.Data
{
    static class BoxDataSource
    {

       static public Dictionary<string, Boxes> Source(List<Boxes> boxesDataSource)
        {
            Dictionary<string, Boxes> boxDataSource = new Dictionary<string, Boxes>();
            foreach (var item in boxesDataSource)
            {
                boxDataSource.Add(item.BoxNumber, item);
            }
            return boxDataSource;
        }
    }
    
}
