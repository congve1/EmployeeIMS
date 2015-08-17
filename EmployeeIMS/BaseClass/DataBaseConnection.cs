using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace EmployeeIMS.BaseClass
{
    class DataBaseConnection
    {
        //建立数据库连接
        public SqlConnection getConnection()
        {
            String sqlCon = "Data Source=.;Database=EmployeeIMS;User id=mjq;PWD=zhenpiaoliang";
            SqlConnection con = new SqlConnection(sqlCon);
            return con;
        }
        //执行SQL命令
        public void executeSQLCommand(String sqlCmand)
        {
            SqlConnection con = this.getConnection();
            con.Open();//打开数据库连接
            SqlCommand sqlcom = new SqlCommand(sqlCmand, con);
            sqlcom.ExecuteNonQuery();
            sqlcom.Dispose();
            con.Close();
            con.Dispose();
        }
        //创建DataSet对象
        public DataSet getDataSets(String sqlcom, String sqlTable)
        {
            SqlConnection con = this.getConnection();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlcom,con);
            DataSet myDataSet = new DataSet();
            sqlAdapter.Fill(myDataSet,sqlTable);
            return myDataSet;

        }
        //此方法中，首先执行SQL语句，然后生成一个SQLDataReader类的对象,然后返回该对象
        public SqlDataReader getRead(string M_str_sqlstr)
        {
            SqlConnection sqlcon = this.getConnection();
            SqlCommand sqlcom = new SqlCommand(M_str_sqlstr, sqlcon);
            sqlcon.Open();
            SqlDataReader sqlread = sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return sqlread;
        }
    }
}
    