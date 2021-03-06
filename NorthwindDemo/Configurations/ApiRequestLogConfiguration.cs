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


namespace NorthwindDemo.Configurations
{

    using NorthwindDemo.Entities;

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
            Property(x => x.Verb).IsOptional();
            Property(x => x.Source).IsOptional();
            Property(x => x.Destination).IsOptional();

        }
    }

}
// </auto-generated>
