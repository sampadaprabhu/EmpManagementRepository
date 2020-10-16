using EmpManagementML;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementRL
{
    public class EmpManagementRepository : IEmpManagementRepository
    {
        static string connect = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
        SqlConnection connection = new SqlConnection(connect);
        public EmpManagementModel AddEmployee(EmpManagementModel empManagementModel)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SPAddEmployeeData", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", empManagementModel.FirstName);
                    command.Parameters.AddWithValue("@LastName", empManagementModel.LastName);
                    command.Parameters.AddWithValue("@EmailID", empManagementModel.EmailID);
                    command.Parameters.AddWithValue("@PhoneNumber", empManagementModel.PhoneNumber);
                    command.Parameters.AddWithValue("@DepartmentID", empManagementModel.DepartmentID);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (result != 0)
                    {
                        return this.GetEmployeeOnBasisfEmailID(empManagementModel.EmailID);
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool UpdateEmployee(EmpManagementModel empManagementModel)
        {
            try
            {
                using(this.connection)
                {
                    SqlCommand command = new SqlCommand("SPUpdateEmployeeData",this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpID",empManagementModel.EmpID);
                    command.Parameters.AddWithValue("@FirstName", empManagementModel.FirstName);
                    command.Parameters.AddWithValue("@LastName", empManagementModel.LastName);
                    command.Parameters.AddWithValue("@EmailID", empManagementModel.EmailID);
                    command.Parameters.AddWithValue("@PhoneNumber", empManagementModel.PhoneNumber);
                    command.Parameters.AddWithValue("@DepartmentID", empManagementModel.DepartmentID);
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    this.connection.Close();
                    if(result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public bool DeleteEmployee(string EmpID)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SPDeleteEmployeeData", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpID", Convert.ToInt32(EmpID));
                    this.connection.Open();
                    var result = command.ExecuteNonQuery();
                    if(result > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public DataSet GetAllEmployee()
        {
            try
            {
                DataSet dataset = new DataSet();
                using(this.connection)
                {
                    this.connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SPGetEmployeeList", this.connection);
                    adapter.Fill(dataset);
                    this.connection.Close();
                    return dataset;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public EmpManagementModel GetEmployeeOnBasisfEmailID(string EmailID)
        {
            try {
                using (this.connection)
                {
                    EmpManagementModel empManagementModel = new EmpManagementModel();
                    SqlCommand command = new SqlCommand("SpGetEmployeeDetailsOnParticularEmailID", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmailID", EmailID);
                    this.connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empManagementModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                            empManagementModel.FirstName = dataReader["FirstName"].ToString();
                            empManagementModel.LastName = dataReader["LastName"].ToString();
                            empManagementModel.EmailID = dataReader["EmailID"].ToString();
                            empManagementModel.PhoneNumber = dataReader["PhoneNumber"].ToString();
                            empManagementModel.DepartmentID = Convert.ToInt32(dataReader["DepartmentID"]);
                        }
                        return empManagementModel;
                    }
                    return null;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }

        public EmpManagementModel GetEmployeeOnBasisfEmpID(int EmpID)
        {
            try
            {
                using (this.connection)
                {
                    EmpManagementModel empManagementModel = new EmpManagementModel();
                    SqlCommand command = new SqlCommand("SpGetEmployeeDetailsOnParticularEmpID", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpID", EmpID);
                    this.connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            empManagementModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                            empManagementModel.FirstName = dataReader["FirstName"].ToString();
                            empManagementModel.LastName = dataReader["LastName"].ToString();
                            empManagementModel.EmailID = dataReader["EmailID"].ToString();
                            empManagementModel.PhoneNumber = dataReader["PhoneNumber"].ToString();
                            empManagementModel.DepartmentID = Convert.ToInt32(dataReader["DepartmentID"]);
                        }
                        return empManagementModel;
                    }
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}