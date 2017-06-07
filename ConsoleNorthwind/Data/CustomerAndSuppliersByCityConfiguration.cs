// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ConsoleNorthwind.Data
{

    // Customer and Suppliers by City
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.0.0")]
    public class CustomerAndSuppliersByCityConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CustomerAndSuppliersByCity>
    {
        public CustomerAndSuppliersByCityConfiguration()
            : this("dbo")
        {
        }

        public CustomerAndSuppliersByCityConfiguration(string schema)
        {
            ToTable("Customer and Suppliers by City", schema);
            HasKey(x => new { x.CompanyName, x.Relationship });

            Property(x => x.City).HasColumnName(@"City").HasColumnType("nvarchar").IsOptional().HasMaxLength(15);
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ContactName).HasColumnName(@"ContactName").HasColumnType("nvarchar").IsOptional().HasMaxLength(30);
            Property(x => x.Relationship).HasColumnName(@"Relationship").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(9).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
// </auto-generated>
