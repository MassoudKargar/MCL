﻿namespace MCL.Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int id, CancellationToken cancellationToken);
    Task<IReadOnlyList<T>> GetAllAsync(CancellationToken cancellationToken);
    Task<T> UpdateAsync(T entity, CancellationToken cancellationToken);
    Task<T> AddAsync(T entity, CancellationToken cancellationToken);
    Task<T> DeleteAsync(T entity, CancellationToken cancellationToken);
    Task<bool> ExistAsync(int id, CancellationToken cancellationToken);
}
