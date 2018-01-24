using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    [Table(Name = "Region")]
    public class Region
    {
        [Column(Name = "RegionID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int RegionId { get; set; }

        [Column(Name = "RegionDescription", DbType = "nchar(50)")]
        public string RegionDescription { get; set; }

        public override string ToString()
        {
            return $"{RegionId}-{RegionDescription}";
        }
    }
}
