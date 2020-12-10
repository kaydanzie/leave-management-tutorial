using System;
using AutoMapper;
using leave_management.Data;
using leave_management.Models;

namespace leave_management.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            // Use ReverseMap so you don't need to add CreateMap<DetailsLeaveTypeVM, LeaveType>
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
        }
    }
}
