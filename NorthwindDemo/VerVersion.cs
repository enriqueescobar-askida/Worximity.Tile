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

    // VER_Versions
    [Table("VER_Versions", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class VerVersion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"VER_cID", Order = 1, TypeName = "uniqueidentifier")]
        [Index(@"PK_VER_Versions", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Ver c ID")]
        public System.Guid VerCId { get; set; } // VER_cID (Primary key)

        [Column(@"VER_cKey", Order = 2, TypeName = "varchar")]
        [Index(@"IX_VER_cKey", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ver c key")]
        public string VerCKey { get; set; } // VER_cKey (length: 50)

        [Column(@"VER_cValue", Order = 3, TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ver c value")]
        public string VerCValue { get; set; } // VER_cValue (length: 50)

        [Column(@"VER_cAppStoreSite", Order = 4, TypeName = "varchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Ver c app store site")]
        public string VerCAppStoreSite { get; set; } // VER_cAppStoreSite (length: 100)
    }

}
// </auto-generated>