﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace leave_management.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }

        public EmployeeVM RequestingEmployee { get; set; }
        public string RequestingEmployeeId { get; set; }

        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }

        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        public bool? Approved { get; set; }
    }
}