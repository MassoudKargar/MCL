﻿namespace MCL.Application.Persistence.Contracts;
public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id, CancellationToken cancellationToken);
    Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(CancellationToken cancellationToken);
}
