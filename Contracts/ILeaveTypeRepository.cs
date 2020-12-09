using System;
using System.Collections.Generic;
using leave_management.Data; // needs to know where LeaveType is located

namespace leave_management.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
