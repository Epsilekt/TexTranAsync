//This code is auto generated. Changes to this file will be lost!
using System;
using System.Linq;
using TexTranAsync.Data.Abstractions.Interfaces;
using TexTranAsync.Data.Abstractions.Entities;
using TexTranAsync.Data.Access.Context;

namespace TexTranAsync.Data.Access.Repositories
{
	public class UserRepository: IUserRepository
	{
		private readonly TexTranAsyncContext _context;

		public UserRepository(TexTranAsyncContext context)
		{
			_context = context;
		}

		public void Add(User user)
		{
			_context.Users.Add(user);
		}

		public void Delete(User user)
		{
			_context.Users.Remove(user);
		}

		public void Edit(User user)
		{
			var editedEntity = _context.Users.FirstOrDefault(e => e.Id == user.Id);
			editedEntity = user;
		}

		public User GetById(Guid id)
		{
			return _context.Users.FirstOrDefault(e => e.Id == id);
		}

		public User[] GetAll()
		{
			return _context.Users.ToArray();
		}

		public void SaveChanges() => _context.SaveChanges();
	}
}

