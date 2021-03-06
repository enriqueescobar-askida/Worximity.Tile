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

    // RightAction
    [Table("RightAction", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class RightAction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"RightActionId", Order = 1, TypeName = "bigint")]
        [Index(@"PK_RIA_RightActions", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Right action ID")]
        public long RightActionId { get; set; } // RightActionId (Primary key)

        [Column(@"ActionKey", Order = 2, TypeName = "nvarchar")]
        [Required]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Action key")]
        public string ActionKey { get; set; } // ActionKey (length: 50)

        [Column(@"Description", Order = 3, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; } // Description (length: 100)

        [Column(@"DefaultGranted", Order = 4, TypeName = "bit")]
        [Required]
        [Display(Name = "Default granted")]
        public bool DefaultGranted { get; set; } // DefaultGranted

        // Reverse navigation

        /// <summary>
        /// Child Rights where [Right].[RightActionId] point to this entity (FK_Right_RightAction)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Right> Rights { get; set; } // Right.FK_Right_RightAction

        public RightAction()
        {
            Rights = new System.Collections.Generic.List<Right>();
        }
    }

}
// </auto-generated>
