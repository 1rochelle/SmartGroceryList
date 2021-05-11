using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGroceryList.Data
{
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int StoreAddressNumber { get; set; }
        public string StoreStreetName { get; set; }
        public string StoreTownOrCity { get; set; }
        public enum StoreState { AL, AK, AS, AZ, AR, CA, CO, CT, DE, DC, FL, GA, GU, HI, ID, IL, IN, IA, KS, KY, LA, ME, MD, MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ, NM, NY, NC, ND, MP, OH, OK, OR, PA, PR, RI, SC, SD, TN, TX, UT, VT, VA, VI, WA, WV, WI, WY }
        public int StoreZIP { get; set; }
        public List<Store> StoreNames { get; set; }
    }
}
