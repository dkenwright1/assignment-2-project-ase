using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using logon;


namespace tracker_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void connection_test()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ben\Documents\myDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    Assert.IsTrue(true);
                }
                catch (SqlException)
                {
                    Assert.IsTrue(false);
                }
            }
        }
    }
}
