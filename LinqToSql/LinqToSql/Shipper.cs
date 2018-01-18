using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    [Table (Name="Shippers")] 
    public class Shipper
    {
        [Column(Name ="ShipperID", IsPrimaryKey =true, IsDbGenerated =true)]
        public int ShipperId { get; set; }
        [Column(Name = "CompanyName", DbType ="nvarchar(40)")]
        public string CompanyName { get; set; }
        [Column(Name = "Phone", DbType = "nvarchar(24)",CanBeNull =true)]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{ShipperId}-{CompanyName}";
        }
    }
}
