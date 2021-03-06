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

    // FDV_FormDefinitionVersions
    [Table("FDV_FormDefinitionVersions", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FdvFormDefinitionVersion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FDV_cID", Order = 1, TypeName = "uniqueidentifier")]
        [Index(@"PK_FDV_FormDefinitionVersions", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Fdv c ID")]
        public System.Guid FdvCId { get; set; } // FDV_cID (Primary key)

        [Column(@"FOD_cID", Order = 2, TypeName = "uniqueidentifier")]
        [Required]
        [Display(Name = "Fod c ID")]
        public System.Guid FodCId { get; set; } // FOD_cID

        [Column(@"FDV_dtCreated", Order = 3, TypeName = "datetime")]
        [Required]
        [Display(Name = "Fdv dt created")]
        public System.DateTime FdvDtCreated { get; set; } // FDV_dtCreated

        [Column(@"FDV_dtLastModified", Order = 4, TypeName = "datetime")]
        [Required]
        [Display(Name = "Fdv dt last modified")]
        public System.DateTime FdvDtLastModified { get; set; } // FDV_dtLastModified

        [Column(@"FDV_dtDeleted", Order = 5, TypeName = "datetime")]
        [Display(Name = "Fdv dt deleted")]
        public System.DateTime? FdvDtDeleted { get; set; } // FDV_dtDeleted

        [Column(@"FDV_cVersion", Order = 6, TypeName = "varchar")]
        [Required]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Fdv c version")]
        public string FdvCVersion { get; set; } // FDV_cVersion (length: 20)

        [Column(@"FDV_dtBegin", Order = 7, TypeName = "datetime")]
        [Display(Name = "Fdv dt begin")]
        public System.DateTime? FdvDtBegin { get; set; } // FDV_dtBegin

        [Column(@"FDV_cForm", Order = 8, TypeName = "xml")]
        [Display(Name = "Fdv c form")]
        public string FdvCForm { get; set; } // FDV_cForm

        [Column(@"FDV_cWebForm", Order = 9, TypeName = "xml")]
        [Display(Name = "Fdv c web form")]
        public string FdvCWebForm { get; set; } // FDV_cWebForm

        [Column(@"FDV_cTextForm", Order = 10, TypeName = "nvarchar(max)")]
        [Display(Name = "Fdv c text form")]
        public string FdvCTextForm { get; set; } // FDV_cTextForm

        // Reverse navigation

        /// <summary>
        /// Child FstFormSyncTasks where [FST_FormSyncTasks].[FDV_cID] point to this entity (FK_FST_FormSyncTasks_FDV_FormDefinitionVersions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FstFormSyncTask> FstFormSyncTasks { get; set; } // FST_FormSyncTasks.FK_FST_FormSyncTasks_FDV_FormDefinitionVersions
        /// <summary>
        /// Child HfdHistoryFormDefinitionVersions where [HFD_HistoryFormDefinitionVersions].[FDV_cId] point to this entity (FK_HFD_HistoryFormDefinitionVersions_FDV_FormDefinitionVersions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<HfdHistoryFormDefinitionVersion> HfdHistoryFormDefinitionVersions { get; set; } // HFD_HistoryFormDefinitionVersions.FK_HFD_HistoryFormDefinitionVersions_FDV_FormDefinitionVersions

        // Foreign keys

        /// <summary>
        /// Parent FodFormDefinition pointed by [FDV_FormDefinitionVersions].([FodCId]) (FK_FDV_FormDefinitionVersions_FOD_FormDefinitions)
        /// </summary>
        [ForeignKey("FodCId")] public virtual FodFormDefinition FodFormDefinition { get; set; } // FK_FDV_FormDefinitionVersions_FOD_FormDefinitions

        public FdvFormDefinitionVersion()
        {
            FstFormSyncTasks = new System.Collections.Generic.List<FstFormSyncTask>();
            HfdHistoryFormDefinitionVersions = new System.Collections.Generic.List<HfdHistoryFormDefinitionVersion>();
        }
    }

}
// </auto-generated>
