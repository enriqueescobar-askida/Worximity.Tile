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

    // CSE_ClientSensors
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CseClientSensorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CseClientSensor>
    {
        public CseClientSensorConfiguration()
            : this("dbo")
        {
        }

        public CseClientSensorConfiguration(string schema)
        {
            Property(x => x.CseDtDeleted).IsOptional();
            Property(x => x.CliCId).IsOptional();
            Property(x => x.CseCKey).IsOptional().IsUnicode(false);
            Property(x => x.CseCDesc).IsOptional().IsUnicode(false);

        }
    }

}
// </auto-generated>
