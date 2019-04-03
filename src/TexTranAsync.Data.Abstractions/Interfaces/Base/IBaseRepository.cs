// This code is auto generated. Changes to this file will be lost!
using System;
using System.Linq;
using System.Threading.Tasks;
using TexTranAsync.Data.Abstractions.Entities;

public interface IBaseRepository<TEntity>
 where TEntity : class, IEntity
{
    IQueryable<TEntity> GetAll();
 
    Task<TEntity> GetById(Guid id);
 
    Task Create(TEntity entity);
 
    Task Update(Guid id, TEntity entity);
 
    Task Delete(Guid id);
}

