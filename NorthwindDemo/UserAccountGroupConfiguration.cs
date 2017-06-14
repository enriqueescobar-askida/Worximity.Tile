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


namespace NorthwindDemo
{

    // UserAccountGroup
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class UserAccountGroupConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserAccountGroup>
    {
        public UserAccountGroupConfiguration()
            : this("dbo")
        {
        }

        public UserAccountGroupConfiguration(string schema)
        {
            ToTable("UserAccountGroup", schema);
            HasKey(x => x.UserAccountGroupId);

            Property(x => x.UserAccountGroupId).HasColumnName(@"UserAccountGroupId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CreateUserAccountDefault).HasColumnName(@"CreateUserAccountDefault").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
