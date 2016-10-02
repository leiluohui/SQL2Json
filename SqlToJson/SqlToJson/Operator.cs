using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Edi.ExtensionMethods;

namespace SqlToJson
{
    public class Operator
    {
        #region Static Methods

        public static async Task<Response> TestConnection(
            string server, string username, string password, string initDb, bool useWindowsAuth = false)
        {
            try
            {
                var connectionStr = BuildConnectionString(server, username, password, initDb, useWindowsAuth);
                var conn = new SqlConnection(connectionStr);

                await conn.OpenAsync();
                conn.Close();
                return new Response()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        #endregion

        private readonly Database _db;

        public Operator(string server, string username, string password, string initDb = null, bool useWindowsAuth = false)
        {
            _db = new SqlDatabase(BuildConnectionString(server, username, password, initDb, useWindowsAuth));
        }

        private static string BuildConnectionString(
            string server, string username, string password, string initDb = null, bool useWindowsAuth = false)
        {
            var builder = new SqlConnectionStringBuilder { DataSource = server, InitialCatalog = initDb };
            if (!useWindowsAuth)
            {
                builder.UserID = username;
                builder.Password = password;
            }
            else
            {
                builder.IntegratedSecurity = true;
            }
            return builder.ConnectionString;
        }

        #region Helpers

        private DbCommand GetCommand(string sql)
        {
            var cmd = _db.GetSqlStringCommand(sql);
            return cmd;
        }

        private IDataReader GetReader(string sql)
        {
            var cmd = GetCommand(sql);
            return _db.ExecuteReader(cmd);
        }

        #endregion

        public Response<List<string>> GetDatabaseList()
        {
            try
            {
                var reader = GetReader("EXEC sp_databases");
                using (reader)
                {
                    var dt = new DataTable();
                    dt.Load(reader);

                    var query = from q in dt.AsEnumerable()
                                select q.Field<string>("DATABASE_NAME");

                    return new Response<List<string>>()
                    {
                        IsSuccess = true,
                        Item = query.ToList()
                    };
                }
            }
            catch (Exception e)
            {
                return new Response<List<string>>()
                {
                    IsSuccess = false,
                    Item = new List<string>(),
                    Message = e.Message
                };
            }
        }

        public Response<string> SqlToJson(string sql)
        {
            try
            {
                var reader = GetReader(sql);
                var json = DataReaderToJson(reader);
                return new Response<string>()
                {
                    IsSuccess = true,
                    Item = json
                };
            }
            catch (Exception e)
            {
                return new Response<string>()
                {
                    IsSuccess = false,
                    Message = e.Message
                };
            }
        }

        private string DataReaderToJson(IDataReader reader)
        {
            using (reader)
            {
                var dt = new DataTable();
                dt.Load(reader);
                var json = JsonConvert.SerializeObject(dt, Formatting.Indented);
                return json;
            }
        }
    }
}
