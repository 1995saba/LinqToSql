using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    [Table(Name = "Customers")]
    public class Customer
    {
        [Column(Name = "CustomerID", IsPrimaryKey = true, DbType = "nvarchar(5)")]
        public string CustomerId { get; set; }

        [Column(Name = "CompanyName", DbType = "nvarchar(40)")]
        public string CompanyName { get; set; }

        [Column(Name = "ContactName", DbType = "nvarchar(30)")]
        public string ContactName { get; set; }

        [Column(Name = "ContactTitle", DbType = "nvarchar(30)")]
        public string ContactTitle { get; set; }

        [Column(Name = "Address", DbType = "nvarchar(60)")]
        public string Address { get; set; }

        [Column(Name = "City", DbType = "nvarchar(15)")]
        public string City { get; set; }

        [Column(Name = "Region", DbType = "nvarchar(15)")]
        public string Region { get; set; }

        [Column(Name = "PostalCode", DbType = "nvarchar(10)")]
        public string PostalCode { get; set; }

        [Column(Name = "Country", DbType = "nvarchar(15)")]
        public string Country { get; set; }

        [Column(Name = "Phone", DbType = "nvarchar(24)")]
        public string Phone { get; set; }

        [Column(Name = "Fax", DbType = "nvarchar(24)")]
        public string Fax { get; set; }

        public override string ToString()
        {
            return $"{CustomerId}-{CompanyName}-{ContactName}" +
                $"-{ContactTitle}-{Address}-{City}-{Region}" +
                $"-{PostalCode}-{Country}-{Phone}-{Fax}";
        }
    }
}
