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

    // UserAccountClient
    [Table("UserAccountClient", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class UserAccountClient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"UserAccountClientId", Order = 1, TypeName = "bigint")]
        [Index(@"PK_UAC_UserAccountClients", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "User account client ID")]
        public long UserAccountClientId { get; set; } // UserAccountClientId (Primary key)

        [Column(@"UserAccountId", Order = 2, TypeName = "bigint")]
        [Index(@"IX_UAC_USA_iID", 1, IsUnique = false, IsClustered = false)]
        [Required]
        [Display(Name = "User account ID")]
        public long UserAccountId { get; set; } // UserAccountId

        [Column(@"CLI_cID", Order = 3, TypeName = "uniqueidentifier")]
        [Required]
        [Display(Name = "Cli c ID")]
        public System.Guid CliCId { get; set; } // CLI_cID

        [Column(@"DatabaseOwner", Order = 4, TypeName = "bit")]
        [Required]
        [Display(Name = "Database owner")]
        public bool DatabaseOwner { get; set; } // DatabaseOwner

        // Foreign keys

        /// <summary>
        /// Parent CliClient pointed by [UserAccountClient].([CliCId]) (FK_UAC_UserAccountClients_CLI_Clients)
        /// </summary>
        [ForeignKey("CliCId")] public virtual CliClient CliClient { get; set; } // FK_UAC_UserAccountClients_CLI_Clients
        /// <summary>
        /// Parent UserAccount pointed by [UserAccountClient].([UserAccountId]) (FK_UAC_UserAccountClients_USA_UserAccounts)
        /// </summary>
        [ForeignKey("UserAccountId")] public virtual UserAccount UserAccount { get; set; } // FK_UAC_UserAccountClients_USA_UserAccounts

        public UserAccountClient()
        {
            DatabaseOwner = false;
        }
    }

}
// </auto-generated>
