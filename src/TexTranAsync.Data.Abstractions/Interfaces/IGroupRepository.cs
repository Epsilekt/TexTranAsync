//This code is auto generated. Changes to this file will be lost!
using System;
using TexTranAsync.Data.Abstractions.Entities;

namespace TexTranAsync.Data.Abstractions.Interfaces
{
	public interface IGroupRepository
	{
		void Add(Group group);

		void Delete(Group group);

		void Edit(Group group);

		Group GetById(Guid id);

		Group[] GetAll();

		void SaveChanges();
	}
}

