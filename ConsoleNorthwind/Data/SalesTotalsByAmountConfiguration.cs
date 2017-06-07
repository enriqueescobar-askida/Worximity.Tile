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

    // Sales Totals by Amount
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.0.0")]
    public class SalesTotalsByAmountConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SalesTotalsByAmount>
    {
        public SalesTotalsByAmountConfiguration()
            : this("dbo")
        {
        }

        public SalesTotalsByAmountConfiguration(string schema)
        {
            ToTable("Sales Totals by Amount", schema);
            HasKey(x => new { x.OrderId, x.CompanyName });

            Property(x => x.SaleAmount).HasColumnName(@"SaleAmount").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.OrderId).HasColumnName(@"OrderID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyName).HasColumnName(@"CompanyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(40).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ShippedDate).HasColumnName(@"ShippedDate").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
