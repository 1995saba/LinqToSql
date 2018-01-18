using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    [Table(Name = "CurrentSessionDto")]
    public class CurrentSession
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int CurrentSessionId { get; set; }

        [Column(Name = "ApplicationName", DbType = "nvarchar(40)")]
        public string ApplicationName { get; set; }

        [Column(Name = "UserId", DbType = "nvarchar(24)")]
        public string UserId { get; set; }

        [Column(Name = "LogInTime", DbType = "datetime")]
        public DateTime LogInTime { get; set; }

        [Column(Name = "LastOperationTime", DbType = "datetime")]
        public DateTime LastOperationTime { get; set; }

        public override string ToString()
        {
            return $"{CurrentSessionId}-{ApplicationName}-{UserId}-{LogInTime}-{LastOperationTime}";
        }
    }
}
