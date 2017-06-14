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

    // UserAccountGroup
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class UserAccountGroup
    {
        public long UserAccountGroupId { get; set; } // UserAccountGroupId (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public bool CreateUserAccountDefault { get; set; } // CreateUserAccountDefault

        // Reverse navigation

        /// <summary>
        /// Child Rights where [Right].[UserAccountGroupId] point to this entity (FK_RIG_Rights_UAG_UserAccountGroups)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Right> Rights { get; set; } // Right.FK_RIG_Rights_UAG_UserAccountGroups
        /// <summary>
        /// Child UserAccounts where [UserAccount].[UserAccountGroupId] point to this entity (FK_USA_UserAccounts_UAG_UserAccountGroups)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<UserAccount> UserAccounts { get; set; } // UserAccount.FK_USA_UserAccounts_UAG_UserAccountGroups

        public UserAccountGroup()
        {
            CreateUserAccountDefault = false;
            Rights = new System.Collections.Generic.List<Right>();
            UserAccounts = new System.Collections.Generic.List<UserAccount>();
        }
    }

}
// </auto-generated>
