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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwindDemo
{

    // Company
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CompanyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
            : this("dbo")
        {
        }

        public CompanyConfiguration(string schema)
        {
            Property(x => x.Name).IsOptional();
            Property(x => x.Phone).IsOptional();
        }
    }

}
// </auto-generated>
