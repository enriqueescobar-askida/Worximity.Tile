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

    // HFD_HistoryFormDefinitionVersions
    [Table("HFD_HistoryFormDefinitionVersions", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class HfdHistoryFormDefinitionVersion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"HFD_iNoSeq", Order = 1, TypeName = "int")]
        [Index(@"PK_HFD_HistoryFormDefinitionVersions", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Hfd i no seq")]
        public int HfdINoSeq { get; set; } // HFD_iNoSeq (Primary key)

        [Column(@"FDV_cId", Order = 2, TypeName = "uniqueidentifier")]
        [Required]
        [Display(Name = "Fdv c ID")]
        public System.Guid FdvCId { get; set; } // FDV_cId

        [Column(@"HFD_dtCreated", Order = 3, TypeName = "datetime")]
        [Required]
        [Display(Name = "Hfd dt created")]
        public System.DateTime HfdDtCreated { get; set; } // HFD_dtCreated

        [Column(@"HFD_cForm", Order = 4, TypeName = "nvarchar(max)")]
        [Display(Name = "Hfd c form")]
        public string HfdCForm { get; set; } // HFD_cForm

        // Foreign keys

        /// <summary>
        /// Parent FdvFormDefinitionVersion pointed by [HFD_HistoryFormDefinitionVersions].([FdvCId]) (FK_HFD_HistoryFormDefinitionVersions_FDV_FormDefinitionVersions)
        /// </summary>
        [ForeignKey("FdvCId")] public virtual FdvFormDefinitionVersion FdvFormDefinitionVersion { get; set; } // FK_HFD_HistoryFormDefinitionVersions_FDV_FormDefinitionVersions
    }

}
// </auto-generated>
