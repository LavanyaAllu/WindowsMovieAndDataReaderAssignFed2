using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReaderAssign
{
    class Customer
    {
        //POCO class:Plain Old Clr Objects
        //POCO class just contains only properties
        public int Cid { get; set; }
        public string CName { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
    }

    class Program
    {
         public static void GetDataByGetFieldValue()
        {
            List<Customer> custList = new List<Customer>();
            using (SqlConnection cn = new SqlConnection(DataReaderAssign.Properties.Settings.Default.con))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from tblCustomer1", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            custList.Add(new Customer
                            {
                                Cid = dr.GetFieldValue<int>(dr.GetOrdinal("Cid")),
                                CName = dr.GetFieldValue<string>(dr.GetOrdinal("CName")),
                                DOB = dr.GetFieldValue<DateTime>(dr.GetOrdinal("DOB")),
                                City = dr.GetFieldValue<string>(dr.GetOrdinal("City"))
                            });
                        }
                    }
                }
            }
            var resultset = custList.GetEnumerator();
            while (resultset.MoveNext())
            {
                Console.WriteLine($"{resultset.Current.Cid}\t{resultset.Current.CName}\t{resultset.Current.DOB}\t{resultset.Current.City}");
            }
        }
        public static void GatDataByGetMethodsOfDr()
        {
            List<Customer> custList = new List<Customer>();
            using (SqlConnection cn = new SqlConnection(DataReaderAssign.Properties.Settings.Default.con))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from tblCustomer1", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            custList.Add(new Customer
                            {
                                Cid = dr.GetInt32(dr.GetOrdinal("Cid")),
                                CName = dr.GetString(dr.GetOrdinal("CName")),
                                DOB = dr.GetDateTime(dr.GetOrdinal("DOB")),
                                City = dr.GetString(dr.GetOrdinal("City"))
                            });
                        }
                    }
                }
            }
            foreach (var item in custList)
            {
                Console.WriteLine($"{item.Cid}\t{item.CName}\t\t{item.DOB}\t\t{item.City}");
            }
        }
        public static void GetDataBySqlDataReader()
        {
            StringBuilder sb = new StringBuilder();
            //create connection
            using (SqlConnection cn = new SqlConnection(DataReaderAssign.Properties.Settings.Default.con))
            {
                using (SqlCommand cmd = new SqlCommand("select *from tblCustomer1", cn))
                {
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (dr.Read())
                        {
                            sb.AppendLine($"Cid:{dr[0].ToString()}");
                            sb.AppendLine($"CName:{dr[1].ToString()}");
                            sb.AppendLine($"DOB:{(dr[2]).ToString()}");
                            sb.AppendLine($"City:{dr[3].ToString()}");
                            sb.AppendLine();

                        }
                    }
                }
                var result = sb.ToString();
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
            static void Main()
          {

               Program.GetDataByGetFieldValue();
               Program.GatDataByGetMethodsOfDr();
               Program.GetDataBySqlDataReader();
          }
        
    }
}
 
