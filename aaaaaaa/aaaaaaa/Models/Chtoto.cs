using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace aaaaaaa.Models
{
    public class Chtoto
    {
        public static MainLOLICH lols = new MainLOLICH();
        public static List<MainLOLICH> mlist = new List<MainLOLICH>();
        public Chtoto(int i)
        {
            SqlConnection conn = new SqlConnection(
            "Data Source=sql2.aksenov.in;user=out_east;Initial Catalog=minaev;password=gisiperu;");
            conn.Open();

            string sql = $@"SELECT id, anek
                            FROM anek 
                            where id={i}";
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataReader stringReader = command.ExecuteReader();
            stringReader.Read();
            lols = new MainLOLICH(String.Format("{0}", stringReader[0]),
                                  String.Format("{0}", stringReader[1]));

        }
        public Chtoto()
        {
            mlist.Clear();
            SqlConnection conn = new SqlConnection(
            "Data Source=sql2.aksenov.in;user=out_east;Initial Catalog=minaev;password=gisiperu;");
            conn.Open();

            string sql = $@"SELECT id, anek
                            FROM anek";
            SqlCommand command = new SqlCommand(sql, conn);

            SqlDataReader stringReader = command.ExecuteReader();
            while (stringReader.Read())
                mlist.Add(new MainLOLICH(String.Format("{0}", stringReader[0]),
                                      String.Format("{0}", stringReader[1])));

        }

    }
}

