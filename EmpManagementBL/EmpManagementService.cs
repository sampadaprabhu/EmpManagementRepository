using EmpManagementBL.implementation;
using EmpManagementML;
using EmpManagementRL;
using EmpManagementRL.implementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementBL
{
    public class EmpManagementService : IEmpManagementService
    {

        private readonly IEmpManagementRepository empManagementRepository;
        public EmpManagementService(IEmpManagementRepository empManagementRepository)
        {
            this.empManagementRepository = empManagementRepository;
        }

        public EmpManagementModel AddEmployee(EmpManagementModel empManagementModel)
        {
            try
            {
                return this.empManagementRepository.AddEmployee(empManagementModel);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public bool DeleteEmployee(string EmpID)
        {
            try
            {
                return this.empManagementRepository.DeleteEmployee(EmpID);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public EmpManagementModel UpdateEmployee(EmpManagementModel empManagementModel)
        {
            try
            {
                return this.empManagementRepository.UpdateEmployee(empManagementModel);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public DataSet GetAllEmployee()
        {
            try
            {
                return this.empManagementRepository.GetAllEmployee();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public EmpManagementModel GetEmployeeOnBasisfEmailID(string EmailID)
        {
            try
            {
                return this.empManagementRepository.GetEmployeeOnBasisfEmailID(EmailID);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public EmpManagementModel GetEmployeeOnBasisfEmpID(int EmpID)
        {
            try
            {
                return this.empManagementRepository.GetEmployeeOnBasisfEmpID(EmpID);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
