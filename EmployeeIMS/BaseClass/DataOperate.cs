using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIMS.BaseClass
{
    class DataOperate
    {
        DataBaseConnection dataCon = new DataBaseConnection(); //创建DataBaseConnection类的对象，并调用其方法
        //cboxBind方法无返回值，主要用来执行SQL语句，并将执行结果绑定到ComBox控件上面
        public void cboxBind(String sqlCom, String sqlTable, String tbMember, ComboBox cbox)
        {
            DataSet myds = dataCon.getDataSets(sqlCom, sqlTable);
            cbox.DataSource = myds.Tables[sqlTable];//设置ComboBox控件进行数据绑定
            cbox.DisplayMember = tbMember;//设置空间中的显示字段
        }
        //用户登录方法
        public int userLogin(String usrName, String usrPassword)
        {
            SqlConnection con = dataCon.getConnection();
            SqlCommand command = new SqlCommand("proc_Login", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@userName", SqlDbType.VarChar, 20).Value = usrName;//用户名
            command.Parameters.Add("@userPassword", SqlDbType.VarChar, 20).Value = usrPassword;//用户密码
            SqlParameter returnValue = command.Parameters.Add("retrunValue", SqlDbType.Int, 4);
            returnValue.Direction = ParameterDirection.ReturnValue;//返回值
            con.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                command.Dispose();
                con.Close();
                con.Dispose();//释放数据连接对象
            }
            int intReturnValue = (int)returnValue.Value;//得到返回值
            return intReturnValue;
        }
        //压缩文件方法
        public void compressFile(string SFile, string CFile)
        {
            //判断文件是否存在
            if (!File.Exists(SFile)) throw new FileNotFoundException();
            using(FileStream sourceStream = new FileStream(SFile,FileMode.Open,
                                            FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                byte[] buffer = new byte[sourceStream.Length];//定义字节数组，存储文件内容
                int checkCounter = sourceStream.Read(buffer, 0, buffer.Length);//读取字节数组长度
                if (checkCounter != buffer.Length) throw new ApplicationException();
                using(FileStream destStream = new FileStream(
                        CFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //实例化压缩对象
                    using(GZipStream compressStream = new GZipStream(
                            destStream, CompressionMode.Compress, true))
                    {
                        compressStream.Write(buffer, 0, buffer.Length);//压缩文件
                    }
                }

            }
        }
        //验证输入的字符串是否为数字
        public bool validateNum(string str)
        {
            return Regex.IsMatch(str, "^[0-9]*$");//验证数字
        }
        public void updateUser(int P_int_UID, string P_str_UserPwd, string P_str_UserRight)
        {
            SqlConnection sqlcon =dataCon.getConnection();
            SqlCommand sqlcom = new SqlCommand("proc_updateUser", sqlcon);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add("@UserID", SqlDbType.Int).Value = P_int_UID;
            sqlcom.Parameters.Add("@UserPwd", SqlDbType.VarChar, 20).Value = P_str_UserPwd;
            sqlcom.Parameters.Add("@UserRight", SqlDbType.VarChar, 30).Value = P_str_UserRight;
            sqlcon.Open();
            try
            {
                sqlcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcom.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
            }
        }
        //添加新用户
        public int InsertUser(string P_str_UserName, string P_str_UserPwd, string P_str_UserRight)
        {
            SqlConnection sqlcon = dataCon.getConnection();
            SqlCommand sqlcom = new SqlCommand("proc_insertUser", sqlcon);
            sqlcom.CommandType = CommandType.StoredProcedure;
            sqlcom.Parameters.Add("@UserName", SqlDbType.VarChar, 20).Value = P_str_UserName;
            sqlcom.Parameters.Add("@UserPwd", SqlDbType.VarChar, 20).Value = P_str_UserPwd;
            sqlcom.Parameters.Add("@UserRight", SqlDbType.VarChar, 30).Value = P_str_UserRight;
            SqlParameter returnValue = sqlcom.Parameters.Add("returnValue", SqlDbType.Int, 4);
            returnValue.Direction = ParameterDirection.ReturnValue;
            sqlcon.Open();
            try
            {
                sqlcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcom.Dispose();
                sqlcon.Close();
                sqlcon.Dispose();
            }
            int P_int_returnValue = (int)returnValue.Value;
            return P_int_returnValue;
        }
    }
}
