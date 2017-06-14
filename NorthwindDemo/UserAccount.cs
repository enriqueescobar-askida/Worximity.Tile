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

    // UserAccount
    [Table("UserAccount", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class UserAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"UserAccountId", Order = 1, TypeName = "bigint")]
        [Index(@"PK_UserAccount_UserAccountid", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "User account ID")]
        public long UserAccountId { get; set; } // UserAccountId (Primary key)

        [Column(@"Created", Order = 2, TypeName = "datetime")]
        [Required]
        [Display(Name = "Created")]
        public System.DateTime Created { get; set; } // Created

        [Column(@"LastModified", Order = 3, TypeName = "datetime")]
        [Required]
        [Display(Name = "Last modified")]
        public System.DateTime LastModified { get; set; } // LastModified

        [Column(@"Deleted", Order = 4, TypeName = "datetime")]
        [Index(@"IX_UserAccount_EmailUnicity", 2, IsUnique = true, IsClustered = false)]
        [Display(Name = "Deleted")]
        public System.DateTime? Deleted { get; set; } // Deleted

        [Column(@"Email", Order = 5, TypeName = "nvarchar")]
        [Index(@"IX_UserAccount_EmailUnicity", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [MaxLength(100)]
        [StringLength(100)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // Email (length: 100)

        [Column(@"Password", Order = 6, TypeName = "nvarchar")]
        [MaxLength(250)]
        [StringLength(250)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } // Password (length: 250)

        [Column(@"MustChangePassword", Order = 7, TypeName = "bit")]
        [Required]
        [Display(Name = "Must change password")]
        public bool MustChangePassword { get; set; } // MustChangePassword

        [Column(@"FirstName", Order = 8, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 100)

        [Column(@"LastName", Order = 9, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 100)

        [Column(@"PhoneNumber", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; } // PhoneNumber (length: 50)

        [Column(@"Address", Order = 11, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string Address { get; set; } // Address (length: 100)

        [Column(@"City", Order = 12, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 100)

        [Column(@"State", Order = 13, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "State")]
        public string State { get; set; } // State (length: 100)

        [Column(@"Country", Order = 14, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Country")]
        public string Country { get; set; } // Country (length: 100)

        [Column(@"PostalCode", Order = 15, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (length: 50)

        [Column(@"EmailRegistrationToken", Order = 16, TypeName = "uniqueidentifier")]
        [Index(@"IX_UserAccounts_EmailRegistrationToken", 1, IsUnique = false, IsClustered = false)]
        [Display(Name = "Email registration token")]
        public System.Guid? EmailRegistrationToken { get; set; } // EmailRegistrationToken

        [Column(@"ForgottenPasswordToken", Order = 17, TypeName = "uniqueidentifier")]
        [Display(Name = "Forgotten password token")]
        public System.Guid? ForgottenPasswordToken { get; set; } // ForgottenPasswordToken

        [Column(@"ForgottenPasswordCreatedDate", Order = 18, TypeName = "datetime")]
        [Display(Name = "Forgotten password created date")]
        public System.DateTime? ForgottenPasswordCreatedDate { get; set; } // ForgottenPasswordCreatedDate

        [Column(@"EmailRegistered", Order = 19, TypeName = "bit")]
        [Required]
        [Display(Name = "Email registered")]
        public bool EmailRegistered { get; set; } // EmailRegistered

        [Column(@"SystemUser", Order = 20, TypeName = "bit")]
        [Required]
        [Display(Name = "System user")]
        public bool SystemUser { get; set; } // SystemUser

        [Column(@"Active", Order = 21, TypeName = "bit")]
        [Required]
        [Display(Name = "Active")]
        public bool Active { get; set; } // Active

        [Column(@"CompanyId", Order = 22, TypeName = "bigint")]
        [Display(Name = "Company ID")]
        public long? CompanyId { get; set; } // CompanyId

        [Column(@"UserAccountGroupId", Order = 23, TypeName = "bigint")]
        [Display(Name = "User account group ID")]
        public long? UserAccountGroupId { get; set; } // UserAccountGroupId

        [Column(@"TempPassword", Order = 24, TypeName = "nvarchar")]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Temp password")]
        public string TempPassword { get; set; } // TempPassword (length: 250)

        [Column(@"IsDev", Order = 25, TypeName = "bit")]
        [Required]
        [Display(Name = "Is dev")]
        public bool IsDev { get; set; } // IsDev

        [Column(@"ResetCache", Order = 26, TypeName = "bit")]
        [Required]
        [Display(Name = "Reset cache")]
        public bool ResetCache { get; set; } // ResetCache

        [Column(@"UploadFormImages", Order = 27, TypeName = "bit")]
        [Required]
        [Display(Name = "Upload form images")]
        public bool UploadFormImages { get; set; } // UploadFormImages

        [Column(@"CanImpersonate", Order = 28, TypeName = "bit")]
        [Required]
        [Display(Name = "Can impersonate")]
        public bool CanImpersonate { get; set; } // CanImpersonate

        // Reverse navigation

        /// <summary>
        /// Child ApiKeys where [ApiKey].[UserAccountId] point to this entity (FK_AKE_ApiKeys_USA_UserAccounts1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ApiKey> ApiKeys { get; set; } // ApiKey.FK_AKE_ApiKeys_USA_UserAccounts1
        /// <summary>
        /// Child ApiRequestLogs where [ApiRequestLog].[UserAccountId] point to this entity (FK_ApiRequest_UserAccount)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ApiRequestLog> ApiRequestLogs { get; set; } // ApiRequestLog.FK_ApiRequest_UserAccount
        /// <summary>
        /// Child UserAccountClients where [UserAccountClient].[UserAccountId] point to this entity (FK_UAC_UserAccountClients_USA_UserAccounts)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UserAccountClient> UserAccountClients { get; set; } // UserAccountClient.FK_UAC_UserAccountClients_USA_UserAccounts

        // Foreign keys

        /// <summary>
        /// Parent Company pointed by [UserAccount].([CompanyId]) (FK_USA_UserAccounts_USC_Company)
        /// </summary>
        [ForeignKey("CompanyId")] public virtual Company Company { get; set; } // FK_USA_UserAccounts_USC_Company
        /// <summary>
        /// Parent UserAccountGroup pointed by [UserAccount].([UserAccountGroupId]) (FK_USA_UserAccounts_UAG_UserAccountGroups)
        /// </summary>
        [ForeignKey("UserAccountGroupId")] public virtual UserAccountGroup UserAccountGroup { get; set; } // FK_USA_UserAccounts_UAG_UserAccountGroups

        public UserAccount()
        {
            MustChangePassword = true;
            EmailRegistered = false;
            SystemUser = false;
            Active = true;
            IsDev = false;
            ResetCache = false;
            UploadFormImages = false;
            CanImpersonate = false;
            ApiKeys = new System.Collections.Generic.List<ApiKey>();
            ApiRequestLogs = new System.Collections.Generic.List<ApiRequestLog>();
            UserAccountClients = new System.Collections.Generic.List<UserAccountClient>();
        }
    }

}
// </auto-generated>
