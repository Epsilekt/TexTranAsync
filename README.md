# TexTranAsync

TexTranAsync is a project that contains `T4 templates` to generate classes from simple definitions, and also generates a generic repository with async methods.

## Frameworks

- .NET Core 2.2
- Entity Framework Core 2 
- AutoT4 1.2.2  (VS2017 only)

## Usage

Define classes in the definition files, and build the solution (VS2017 only). For Visual Studio 2019 choose `Build - Transform All T4 Templates`.

### Entity example

Add a definition for a entity to the definition file (`EntityDefinitions.txt`). Save the file, build the solution and following files are generated:
- {Entity}.cs inside `TexTranAsync.Data.Abstractions\Entities`
- DbContext.cs regenerates with new DbSet<{Entity}> inside `TexTranAsync.Data.Access\Context` 
- If you add a `IEntityTypeConfiguration<{Entity}>` this will also be added to the `OnModelCreating()` of the generated `DbContext` 

Example Entity definition file:

``` txt
User // Description goes here
	FirstName : string
	LastName : string
	EmailAddress : string
	DateOfBirth : DateTimeOffset
	Gender: Gender
	Group : Group
	NullableNumber : int?

Group
	Name : string
	Members : List<User>

```
Generated Entity example:

``` csharp
// This file is auto generated. Changes to this file will be lost!
using System;
using System.Collections.Generic;
using TextTran.Transformations.Enums;
	
namespace TexTran.Data.Abstractions.Entities
{
	/// <summery>
	/// Description goes here
	/// </summary>");
	public class User : BaseEntity
	{
		public string FirstName  { get; set; }

		public string LastName  { get; set; }

		public string EmailAddress  { get; set; }

		public DateTimeOffset DateOfBirth  { get; set; }

		public Gender Gender { get; set; }

		public Group Group  { get; set; }

		public int? NullableNumber  { get; set; }

	}
}
```
Generated DbContext :
``` csharp
// This code is auto generated. Changes to this file will be lost!
using Microsoft.EntityFrameworkCore;
using TexTran.Data.Abstractions.Entities;
using TexTran.Data.Access.Configurations;

namespace TextTranAsync.Data.Access.Context
{
	public class TexTranAsyncContext : DbContext
	{
		public TexTranAsyncContext(DbContextOptions options) 
			: base(options) 
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
		}

		public DbSet<Group> Groups { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
```

After adding more content to the definition files, just run `Build > Transform all T4 templates` or build the solution (VS2017) to re-generate all code. If you add an `Entity`, there will also be a `DbSet<Entity>` added to the generated DbContext. `EntityTypeConfigurations` have to be written manually, but these are also added to the `DbContext` when transforming the templates or just building the solution. 

### Set up DB

You can set the DbContextName in `TexTranAsynx.Transformer.TransformDirectives.ttinclude`.
Add your entities to the definition files, add `EntityTypeConfiguration<Entity>` and run a `Add-Migration Initial` command in the Package Manager Console followed by `Update-Database` to create the database. Don't forget to create a migration every time you change the database model.

