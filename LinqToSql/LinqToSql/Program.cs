using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager
                  .ConnectionStrings["MyConnectionString"]
                  .ToString();

            DataContext dataContext = new DataContext(connectionString);

            Table<CurrentSession> curSessionTable = dataContext.GetTable<CurrentSession>();

            // Create
            //var newCurSession = new CurrentSession()
            //{
            //    ApplicationName = "Test",
            //    UserId = "test",
            //    LogInTime = DateTime.Now,
            //    LastOperationTime=DateTime.Now
            //};

            //curSessionTable.InsertOnSubmit(newCurSession);
            //dataContext.SubmitChanges();

            // Read
            //var noTestCurSessions = from item in curSessionTable
            //                        select item;

            //foreach (var item in noTestCurSessions)
            //{
            //    Console.WriteLine(item);
            //}

            //// Update
            //var testCurSession = curSessionTable.FirstOrDefault(p => p.CurrentSessionId == 12);
            //testCurSession.ApplicationName = "asdasd";
            //dataContext.SubmitChanges();

            // Delete
            //var deleteTest = curSessionTable.First(p => p.CurrentSessionId == 11);
            //curSessionTable.DeleteOnSubmit(deleteTest);
            //dataContext.SubmitChanges();

            Console.ReadLine();


        }
    }
}