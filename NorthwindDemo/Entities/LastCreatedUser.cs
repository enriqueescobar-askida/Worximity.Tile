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

namespace NorthwindDemo.Entities
{

    // The table 'LastCreatedUsers' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // LastCreatedUsers
    [NotMapped]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class LastCreatedUser
    {
        [Column(@"dd", Order = 1, TypeName = "date")]
        [Display(Name = "Dd")]
        public System.DateTime? Dd { get; set; } // dd

        [Column(@"TheCount", Order = 2, TypeName = "int")]
        [Display(Name = "The count")]
        public int? TheCount { get; set; } // TheCount

        [Column(@"Clients", Order = 3, TypeName = "nvarchar(max)")]
        [Display(Name = "Clients")]
        public string Clients { get; set; } // Clients
    }

}
// </auto-generated>
