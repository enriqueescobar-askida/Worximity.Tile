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

    // UserAccount
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class UserAccountConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserAccount>
    {
        public UserAccountConfiguration()
            : this("dbo")
        {
        }

        public UserAccountConfiguration(string schema)
        {
            Property(x => x.Deleted).IsOptional();
            Property(x => x.Password).IsOptional();
            Property(x => x.FirstName).IsOptional();
            Property(x => x.LastName).IsOptional();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.Address).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.State).IsOptional();
            Property(x => x.Country).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.EmailRegistrationToken).IsOptional();
            Property(x => x.ForgottenPasswordToken).IsOptional();
            Property(x => x.ForgottenPasswordCreatedDate).IsOptional();
            Property(x => x.CompanyId).IsOptional();
            Property(x => x.UserAccountGroupId).IsOptional();
            Property(x => x.TempPassword).IsOptional();

        }
    }

}
// </auto-generated>