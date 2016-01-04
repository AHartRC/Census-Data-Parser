namespace CensusDataParser.Generated.Mapping
{
	#region Using Directives
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.ModelConfiguration;
	using Binding;
	#endregion Using Directives

	public class Redistricting_TableMap : EntityTypeConfiguration<Redistricting_Table>
	{
		public Redistricting_TableMap()
		{
			ToTable("Table", "Redistricting");

			HasKey(k => new
			            {
				            k.STUB,
				            k.ITEM,
				            k.SEGMENT
			            });

			Property(p => p.STUB)
				.HasColumnName("STUB")
				.HasColumnOrder(0)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("STUB")
				.IsRequired();

			Property(p => p.ITEM)
				.HasColumnName("ITEM")
				.HasColumnOrder(1)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("ITEM")
				.IsRequired();

			Property(p => p.SEGMENT)
				.HasColumnName("SEGMENT")
				.HasColumnOrder(2)
				.HasColumnType("NVARCHAR")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
				.HasMaxLength(255)
				.HasParameterName("SEGMENT")
				.IsRequired();
		}
	}
}
