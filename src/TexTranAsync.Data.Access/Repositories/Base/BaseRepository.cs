//This code is auto generated. Changes to this file will be lost!
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TexTranAsync.Data.Abstractions.Entities;
using TexTranAsync.Data.Access.Context;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly TexTranAsyncContext _context;
 
    public BaseRepository(TexTranAsyncContext context)
    {
        _context = context;
    }

	public async Task<TEntity> GetById(Guid id)
	{
		return await _context.Set<TEntity>()
					.AsNoTracking()
					.FirstOrDefaultAsync(e => e.Id == id);
	}

	public IQueryable<TEntity> GetAll()
	{
		return _context.Set<TEntity>().AsNoTracking();
	}

	public async Task Create(TEntity entity)
	{
	    await _context.Set<TEntity>().AddAsync(entity);
	    await _context.SaveChangesAsync();
	}
	 
	public async Task Update(Guid id, TEntity entity)
	{
	    _context.Set<TEntity>().Update(entity);
	    await _context.SaveChangesAsync();
	}
	 
	public async Task Delete(Guid id)
	{
	    var entity = await GetById(id);
	    _context.Set<TEntity>().Remove(entity);
	    await _context.SaveChangesAsync();
	}
}

