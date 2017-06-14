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

    // Right
    [Table("Right", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class Right
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"RightId", Order = 1, TypeName = "bigint")]
        [Index(@"PK_RIG_Rights", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Right ID")]
        public long RightId { get; set; } // RightId (Primary key)

        [Column(@"RightActionId", Order = 2, TypeName = "bigint")]
        [Required]
        [Display(Name = "Right action ID")]
        public long RightActionId { get; set; } // RightActionId

        [Column(@"UserAccountGroupId", Order = 3, TypeName = "bigint")]
        [Display(Name = "User account group ID")]
        public long? UserAccountGroupId { get; set; } // UserAccountGroupId

        [Column(@"DatabaseOwnerOnly", Order = 4, TypeName = "bit")]
        [Display(Name = "Database owner only")]
        public bool? DatabaseOwnerOnly { get; set; } // DatabaseOwnerOnly

        [Column(@"CanCreate", Order = 5, TypeName = "bit")]
        [Required]
        [Display(Name = "Can create")]
        public bool CanCreate { get; set; } // CanCreate

        [Column(@"CanRead", Order = 6, TypeName = "bit")]
        [Required]
        [Display(Name = "Can read")]
        public bool CanRead { get; set; } // CanRead

        [Column(@"CanUpdate", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Can update")]
        public bool CanUpdate { get; set; } // CanUpdate

        [Column(@"CanDelete", Order = 8, TypeName = "bit")]
        [Required]
        [Display(Name = "Can delete")]
        public bool CanDelete { get; set; } // CanDelete

        // Foreign keys

        /// <summary>
        /// Parent RightAction pointed by [Right].([RightActionId]) (FK_Right_RightAction)
        /// </summary>
        [ForeignKey("RightActionId")] public virtual RightAction RightAction { get; set; } // FK_Right_RightAction
        /// <summary>
        /// Parent UserAccountGroup pointed by [Right].([UserAccountGroupId]) (FK_RIG_Rights_UAG_UserAccountGroups)
        /// </summary>
        [ForeignKey("UserAccountGroupId")] public virtual UserAccountGroup UserAccountGroup { get; set; } // FK_RIG_Rights_UAG_UserAccountGroups

        public Right()
        {
            DatabaseOwnerOnly = false;
            CanCreate = false;
            CanRead = false;
            CanUpdate = false;
            CanDelete = false;
        }
    }

}
// </auto-generated>
