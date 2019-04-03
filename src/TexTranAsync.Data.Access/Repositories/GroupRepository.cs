//This code is auto generated. Changes to this file will be lost!
using System;
using System.Linq;
using TexTranAsync.Data.Abstractions.Interfaces;
using TexTranAsync.Data.Abstractions.Entities;
using TexTranAsync.Data.Access.Context;

namespace TexTranAsync.Data.Access.Repositories
{
	public class GroupRepository: IGroupRepository
	{
		private readonly TexTranAsyncContext _context;

		public GroupRepository(TexTranAsyncContext context)
		{
			_context = context;
		}

		public void Add(Group group)
		{
			_context.Groups.Add(group);
		}

		public void Delete(Group group)
		{
			_context.Groups.Remove(group);
		}

		public void Edit(Group group)
		{
			var editedEntity = _context.Groups.FirstOrDefault(e => e.Id == group.Id);
			editedEntity = group;
		}

		public Group GetById(Guid id)
		{
			return _context.Groups.FirstOrDefault(e => e.Id == id);
		}

		public Group[] GetAll()
		{
			return _context.Groups.ToArray();
		}

		public void SaveChanges() => _context.SaveChanges();
	}
}

