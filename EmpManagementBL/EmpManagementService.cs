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
            return this.empManagementRepository.AddEmployee(empManagementModel);
        }

        public bool DeleteEmployee(string EmpID)
        {
            return this.empManagementRepository.DeleteEmployee(EmpID);
        }

        public EmpManagementModel UpdateEmployee(EmpManagementModel empManagementModel)
        {
            return this.empManagementRepository.UpdateEmployee(empManagementModel);
        }

        public DataSet GetAllEmployee()
        {
            return this.empManagementRepository.GetAllEmployee();
        }

        public EmpManagementModel GetEmployeeOnBasisfEmailID(string EmailID)
        {
            return this.empManagementRepository.GetEmployeeOnBasisfEmailID(EmailID);
        }

        public EmpManagementModel GetEmployeeOnBasisfEmpID(int EmpID)
        {
            return this.empManagementRepository.GetEmployeeOnBasisfEmpID(EmpID);
        }
    }
}
