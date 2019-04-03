// This code is auto generated. Changes to this file will be lost!
using Microsoft.EntityFrameworkCore;
using TexTranAsync.Data.Abstractions.Entities;

namespace TexTranAsync.Data.Access.Context
{
	public class TexTranAsyncContext : DbContext
	{
		public TexTranAsyncContext(DbContextOptions options) 
			: base(options) 
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}

		public DbSet<Group> Groups { get; set; }
		public DbSet<User> Users { get; set; }
	}
}

