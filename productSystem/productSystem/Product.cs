using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace productSystem
{
    class Product
    {
        public int ProductId { get; set; }
        public int ProductName { get; set; }
        public int Category { get; set; }
        public int Price { get; set; }

    }
}
