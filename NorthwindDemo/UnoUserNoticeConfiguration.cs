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

    // UNO_UserNotices
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class UnoUserNoticeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UnoUserNotice>
    {
        public UnoUserNoticeConfiguration()
            : this("dbo")
        {
        }

        public UnoUserNoticeConfiguration(string schema)
        {
            Property(x => x.UnoDtDeleted).IsOptional();
            Property(x => x.UnoVcConfidentialityEn).IsOptional();
            Property(x => x.UnoVcConfidentialityFr).IsOptional();
            Property(x => x.UnoVcConfidentialityEs).IsOptional();
        }
    }

}
// </auto-generated>