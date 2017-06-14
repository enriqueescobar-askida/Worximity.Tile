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


namespace NorthwindDemo
{

    // ApiKey
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ApiKey
    {
        public long ApiKeyId { get; set; } // ApiKeyId (Primary key)
        public string Key { get; set; } // Key (length: 50)
        public System.DateTime LastLogin { get; set; } // LastLogin
        public long ApplicationId { get; set; } // ApplicationId
        public long? UserAccountId { get; set; } // UserAccountId
        public System.Guid? UseCId { get; set; } // USE_cID

        // Foreign keys

        /// <summary>
        /// Parent Application pointed by [ApiKey].([ApplicationId]) (FK_AKE_ApiKeys_APP_Applications)
        /// </summary>
        public virtual Application Application { get; set; } // FK_AKE_ApiKeys_APP_Applications
        /// <summary>
        /// Parent UserAccount pointed by [ApiKey].([UserAccountId]) (FK_AKE_ApiKeys_USA_UserAccounts1)
        /// </summary>
        public virtual UserAccount UserAccount { get; set; } // FK_AKE_ApiKeys_USA_UserAccounts1
        /// <summary>
        /// Parent UseUser pointed by [ApiKey].([UseCId]) (FK_ApiKey_USE_Users)
        /// </summary>
        public virtual UseUser UseUser { get; set; } // FK_ApiKey_USE_Users
    }

}
// </auto-generated>