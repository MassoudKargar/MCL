﻿namespace MCL.Application.DTOs.LeaveType;

public class CreateLeaveTypeDto : ILeaveTypeDto
{
    public string Name { get; set; }
    public int DefaultDay { get; set; }
}
