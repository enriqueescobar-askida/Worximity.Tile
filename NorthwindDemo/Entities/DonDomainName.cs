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

    // DON_DomainName
    [Table("DON_DomainName", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class DonDomainName
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"DON_lID", Order = 1, TypeName = "int")]
        [Index(@"PK_DON_DomainName", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Don l ID")]
        public int DonLId { get; set; } // DON_lID (Primary key)

        [Column(@"CLI_cID", Order = 2, TypeName = "uniqueidentifier")]
        [Required]
        [Display(Name = "Cli c ID")]
        public System.Guid CliCId { get; set; } // CLI_cID

        [Column(@"DON_cDomainName", Order = 3, TypeName = "nvarchar")]
        [Index(@"IX_DON_DomainNameUnicity", 1, IsUnique = true, IsClustered = false)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Don c domain name")]
        public string DonCDomainName { get; set; } // DON_cDomainName (length: 100)

        // Foreign keys

        /// <summary>
        /// Parent CliClient pointed by [DON_DomainName].([CliCId]) (FK_DON_DomainName_CLI_Clients)
        /// </summary>
        [ForeignKey("CliCId")] public virtual CliClient CliClient { get; set; } // FK_DON_DomainName_CLI_Clients
    }

}
// </auto-generated>
