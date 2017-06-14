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

    // CLI_Clients
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class CliClientConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CliClient>
    {
        public CliClientConfiguration()
            : this("dbo")
        {
        }

        public CliClientConfiguration(string schema)
        {
            ToTable("CLI_Clients", schema);
            HasKey(x => x.CliCId);

            Property(x => x.CliCId).HasColumnName(@"CLI_cID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CliDtCreated).HasColumnName(@"CLI_dtCreated").HasColumnType("datetime").IsRequired();
            Property(x => x.CliDtLastModified).HasColumnName(@"CLI_dtLastModified").HasColumnType("datetime").IsRequired();
            Property(x => x.CliDtDeleted).HasColumnName(@"CLI_dtDeleted").HasColumnType("datetime").IsOptional();
            Property(x => x.CliCName).HasColumnName(@"CLI_cName").HasColumnType("nvarchar").IsRequired().HasMaxLength(80);
            Property(x => x.CliCPrefix).HasColumnName(@"CLI_cPrefix").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.CliCMainUrl).HasColumnName(@"CLI_cMainUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCFormsUrl).HasColumnName(@"CLI_cFormsUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCSignalrUrl).HasColumnName(@"CLI_cSignalrUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCFtpUrl).HasColumnName(@"CLI_cFtpUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCExternMainUrl).HasColumnName(@"CLI_cExternMainUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCExternFormsUrl).HasColumnName(@"CLI_cExternFormsUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCExternSignalrUrl).HasColumnName(@"CLI_cExternSignalrUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliCExternFtpUrl).HasColumnName(@"CLI_cExternFtpUrl").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CliBEnabled).HasColumnName(@"CLI_bEnabled").HasColumnType("bit").IsRequired();
            Property(x => x.CliBSensorEnabled).HasColumnName(@"CLI_bSensorEnabled").HasColumnType("bit").IsOptional();
            Property(x => x.SerCId).HasColumnName(@"SER_cID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.CliBFormSync).HasColumnName(@"CLI_bFormSync").HasColumnType("bit").IsRequired();
            Property(x => x.CliBAzureMigrated).HasColumnName(@"CLI_bAzureMigrated").HasColumnType("bit").IsRequired();
            Property(x => x.CliBIsDev).HasColumnName(@"CLI_bIsDev").HasColumnType("bit").IsRequired();
            Property(x => x.CliBAllowPasswordMsgRecoveryNotFound).HasColumnName(@"CLI_bAllowPasswordMsgRecoveryNotFound").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.SerServer).WithMany(b => b.CliClients).HasForeignKey(c => c.SerCId).WillCascadeOnDelete(false); // FK_CLI_Clients_SER_Servers
        }
    }

}
// </auto-generated>
