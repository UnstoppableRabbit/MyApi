using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using aaaaaaa.Models;
using System.Data.SqlClient;

namespace aaaaaaa.Controllers
{
    [Route("Anek/[controller]")]
    [ApiController]
    public class AbcController : ControllerBase
    {
        // GET: api/Abc
        [HttpGet]
        public IEnumerable<MainLOLICH> Get()
        {
            Chtoto qwe = new Chtoto();
            return Chtoto.mlist;
        }

        // GET: anek/Abc/5
        [HttpGet("{id}", Name = "Get")]
        public MainLOLICH Get(int id)
        {
            Chtoto qwe = new Chtoto(id);
            
            return Chtoto.lols;
        }

        // POST: api/Abc
        [HttpPost]
        public void Post([FromBody] MainLOLICH value)
        {
            SqlConnection conn = new SqlConnection(
               "Data Source=sql2.aksenov.in;user=out_east;Initial Catalog=minaev;password=gisiperu;");
            conn.Open();

            string sql = $@"Update anek set Anek = N'{value.anek}' where Id = {value.id}";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            //string l = value.anek;
            //int w = value.id;
        }
        
        // PUT: api/Abc
        [HttpPut]
        public void Put([FromBody] MainLOLICH value)
        {
            SqlConnection conn = new SqlConnection(
               "Data Source=sql2.aksenov.in;user=out_east;Initial Catalog=minaev;password=gisiperu;");
            conn.Open();

            string sql = $@"INSERT INTO Anek (anek) values(N'{value.anek}')";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        // DELETE: Anek/Abc/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection(
               "Data Source=sql2.aksenov.in;user=out_east;Initial Catalog=minaev;password=gisiperu;");
            conn.Open();

            string sql = $@"Delete from anek where Id = {id}";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
