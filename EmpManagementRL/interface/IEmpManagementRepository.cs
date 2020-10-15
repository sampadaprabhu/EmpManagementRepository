using EmpManagementML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagementRL.implementation
{
    public interface IEmpManagementRepository
    {
        EmpManagementModel AddEmployee(EmpManagementModel empManagementModel);

        bool UpdateEmployee(EmpManagementModel empManagementModel);

        bool DeleteEmployee(string EmpID);

        DataSet GetAllEmployee();

        EmpManagementModel GetEmployeeOnBasisfEmailID(string EmailID);

        EmpManagementModel GetEmployeeOnBasisfEmpID(int EmpID);
    }
}
