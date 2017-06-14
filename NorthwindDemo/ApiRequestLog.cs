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

    // ApiRequestLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class ApiRequestLog
    {
        public long ApiRequesLogtId { get; set; } // ApiRequesLogtId (Primary key)
        public long UserAccountId { get; set; } // UserAccountId
        public System.DateTime DateCreated { get; set; } // DateCreated
        public string Verb { get; set; } // Verb (length: 50)
        public string Source { get; set; } // Source (length: 200)
        public string Destination { get; set; } // Destination (length: 200)

        // Foreign keys

        /// <summary>
        /// Parent UserAccount pointed by [ApiRequestLog].([UserAccountId]) (FK_ApiRequest_UserAccount)
        /// </summary>
        public virtual UserAccount UserAccount { get; set; } // FK_ApiRequest_UserAccount
    }

}
// </auto-generated>