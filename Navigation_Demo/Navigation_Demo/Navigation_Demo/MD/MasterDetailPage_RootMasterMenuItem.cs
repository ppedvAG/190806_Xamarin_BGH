using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_Demo.MD
{

    public class MasterDetailPage_RootMasterMenuItem
    {
        public MasterDetailPage_RootMasterMenuItem()
        {
            TargetType = typeof(MasterDetailPage_RootDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}