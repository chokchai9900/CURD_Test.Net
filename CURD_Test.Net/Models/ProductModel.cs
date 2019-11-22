using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_Test.Net.Models
{
    public class ProductModel
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string discription { get; set; }
        public double price { get; set; }
        public int countOfProduct { get; set; }
        public DateTime FirstImportedDatetime { get; set; }
        public DateTime LastUpdateDatetime { get; set; }
    }
}
