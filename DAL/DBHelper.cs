using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {
        private static string connectionString = "server=.;database=CBQDB;uid=sa;pwd=a1b2c3;";

        /// <summary>
        /// 执行SQL语句获取数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>DataTable数据集</returns>
        public static DataTable GetDataTableBySql(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                var da = new SqlDataAdapter(sql, conn);
                try
                {
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>是否执行成功</returns>
        public static bool ExcuteSql(string sql)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="proName">存储过程名称</param>
        /// <param name="paras">存储过程参数</param>
        /// <returns>是否执行成功</returns>
        public static bool ExcuteProcedure(string proName, SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(proName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < paras.Length; i++)
                {
                    cmd.Parameters.Add(paras[i]);
                }
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
        /// <summary>
        /// 执行存储过程获得数据集
        /// </summary>
        /// <param name="proName">存储过程名</param>
        /// <param name="paras">存储过程参数</param>
        /// <returns>DataTable数据集</returns>
        public DataTable GetDataTableByProcedure(string proName, SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand(proName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                for (int i = 0; i < paras.Length; i++)
                {
                    cmd.Parameters.Add(paras[i]);
                }
                try
                {
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
