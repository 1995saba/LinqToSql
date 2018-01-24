using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinqToSql
{
    [Table(Name = "Employees")]
    public class Employee
    {
        [Column(Name = "EmployeeID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int EmployeeId { get; set; }

        [Column(Name = "LastName", DbType = "nvarchar(20)")]
        public string LastName { get; set; }

        [Column(Name = "FirstName", DbType = "nvarchar(10)")]
        public string FirstName { get; set; }

        [Column(Name = "Title", DbType = "nvarchar(30)")]
        public string Title { get; set; }

        [Column(Name = "TitleOfCourtesy", DbType = "nvarchar(25)")]
        public string TitleOfCourtesy { get; set; }

        [Column(Name = "BirthDate", DbType = "datetime")]
        public DateTime BirthDate { get; set; }

        [Column(Name = "HireDate", DbType = "datetime")]
        public DateTime HireDate { get; set; }

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

        [Column(Name = "HomePhone", DbType = "nvarchar(24)")]
        public string HomePhone { get; set; }

        [Column(Name = "Extension", DbType = "nvarchar(4)")]
        public string Extension { get; set; }

        [Column(Name = "Notes", DbType = "ntext")]
        public string Notes { get; set; }

        [Column(Name = "ReportsTo", DbType = "int")]
        public string ReportsTo { get; set; }

        [Column(Name = "PhotoPath", DbType = "nvarchar(255)")]
        public string PhotoPath { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId}-{FirstName}-{LastName}";
        }
    }
}
