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

    // FOD_FormDefinitions
    [Table("FOD_FormDefinitions", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FodFormDefinition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FOD_cID", Order = 1, TypeName = "uniqueidentifier")]
        [Index(@"PK_FOD_FormDefinitions", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Fod c ID")]
        public System.Guid FodCId { get; set; } // FOD_cID (Primary key)

        [Column(@"FOD_dtCreated", Order = 2, TypeName = "datetime")]
        [Required]
        [Display(Name = "Fod dt created")]
        public System.DateTime FodDtCreated { get; set; } // FOD_dtCreated

        [Column(@"FOD_dtLastModified", Order = 3, TypeName = "datetime")]
        [Required]
        [Display(Name = "Fod dt last modified")]
        public System.DateTime FodDtLastModified { get; set; } // FOD_dtLastModified

        [Column(@"FOD_dtDeleted", Order = 4, TypeName = "datetime")]
        [Display(Name = "Fod dt deleted")]
        public System.DateTime? FodDtDeleted { get; set; } // FOD_dtDeleted

        [Column(@"FOD_cName", Order = 5, TypeName = "nvarchar")]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Fod c name")]
        public string FodCName { get; set; } // FOD_cName (length: 100)

        [Column(@"FOD_cDescription", Order = 6, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Fod c description")]
        public string FodCDescription { get; set; } // FOD_cDescription (length: 100)

        [Column(@"FOD_bResultByUser", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Fod b result by user")]
        public bool FodBResultByUser { get; set; } // FOD_bResultByUser

        [Column(@"FOD_bSubmittedResultByUser", Order = 8, TypeName = "bit")]
        [Required]
        [Display(Name = "Fod b submitted result by user")]
        public bool FodBSubmittedResultByUser { get; set; } // FOD_bSubmittedResultByUser

        // Reverse navigation

        /// <summary>
        /// Child FdcFormDefinitionVersionClients where [FDC_FormDefinitionVersionClients].[FOD_cID] point to this entity (FK_FDC_FormDefinitionVersionClients_FOD_FormDefinitions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FdcFormDefinitionVersionClient> FdcFormDefinitionVersionClients { get; set; } // FDC_FormDefinitionVersionClients.FK_FDC_FormDefinitionVersionClients_FOD_FormDefinitions
        /// <summary>
        /// Child FdvFormDefinitionVersions where [FDV_FormDefinitionVersions].[FOD_cID] point to this entity (FK_FDV_FormDefinitionVersions_FOD_FormDefinitions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FdvFormDefinitionVersion> FdvFormDefinitionVersions { get; set; } // FDV_FormDefinitionVersions.FK_FDV_FormDefinitionVersions_FOD_FormDefinitions
        /// <summary>
        /// Child FstFormSyncTasks where [FST_FormSyncTasks].[FOD_cID] point to this entity (FK_FST_FormSyncTasks_FOD_FormDefinitions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FstFormSyncTask> FstFormSyncTasks { get; set; } // FST_FormSyncTasks.FK_FST_FormSyncTasks_FOD_FormDefinitions
        /// <summary>
        /// Child KitTemplateMeasureDefinitions where [KitTemplateMeasureDefinition].[FOD_cID] point to this entity (FK_KitTemplateMeasureDefinition_FOD_FormDefinitions)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<KitTemplateMeasureDefinition> KitTemplateMeasureDefinitions { get; set; } // KitTemplateMeasureDefinition.FK_KitTemplateMeasureDefinition_FOD_FormDefinitions

        public FodFormDefinition()
        {
            FodBResultByUser = false;
            FodBSubmittedResultByUser = false;
            FdcFormDefinitionVersionClients = new System.Collections.Generic.List<FdcFormDefinitionVersionClient>();
            FdvFormDefinitionVersions = new System.Collections.Generic.List<FdvFormDefinitionVersion>();
            FstFormSyncTasks = new System.Collections.Generic.List<FstFormSyncTask>();
            KitTemplateMeasureDefinitions = new System.Collections.Generic.List<KitTemplateMeasureDefinition>();
        }
    }

}
// </auto-generated>