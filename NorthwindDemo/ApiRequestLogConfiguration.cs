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

    // ApiRequestLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ApiRequestLogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ApiRequestLog>
    {
        public ApiRequestLogConfiguration()
            : this("dbo")
        {
        }

        public ApiRequestLogConfiguration(string schema)
        {
            ToTable("ApiRequestLog", schema);
            HasKey(x => x.ApiRequesLogtId);

            Property(x => x.ApiRequesLogtId).HasColumnName(@"ApiRequesLogtId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserAccountId).HasColumnName(@"UserAccountId").HasColumnType("bigint").IsRequired();
            Property(x => x.DateCreated).HasColumnName(@"DateCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.Verb).HasColumnName(@"Verb").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Source).HasColumnName(@"Source").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.Destination).HasColumnName(@"Destination").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);

            // Foreign keys
            HasRequired(a => a.UserAccount).WithMany(b => b.ApiRequestLogs).HasForeignKey(c => c.UserAccountId).WillCascadeOnDelete(false); // FK_ApiRequest_UserAccount
        }
    }

}
// </auto-generated>
