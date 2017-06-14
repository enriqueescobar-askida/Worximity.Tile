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


namespace NorthwindDemo.Context
{

    using System.Linq;

    using NorthwindDemo.Entities;
    using NorthwindDemo.Interfaces;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.31.1.0")]
    public class FakeTileboardLocatorContext : ITileboardLocatorContext
    {
        public System.Data.Entity.DbSet<ApiKey> ApiKeys { get; set; }
        public System.Data.Entity.DbSet<ApiRequestLog> ApiRequestLogs { get; set; }
        public System.Data.Entity.DbSet<Application> Applications { get; set; }
        public System.Data.Entity.DbSet<CliClient> CliClients { get; set; }
        public System.Data.Entity.DbSet<Company> Companies { get; set; }
        public System.Data.Entity.DbSet<CseClientSensor> CseClientSensors { get; set; }
        public System.Data.Entity.DbSet<DonDomainName> DonDomainNames { get; set; }
        public System.Data.Entity.DbSet<FdcFormDefinitionVersionClient> FdcFormDefinitionVersionClients { get; set; }
        public System.Data.Entity.DbSet<FdvFormDefinitionVersion> FdvFormDefinitionVersions { get; set; }
        public System.Data.Entity.DbSet<FodFormDefinition> FodFormDefinitions { get; set; }
        public System.Data.Entity.DbSet<FstFormSyncTask> FstFormSyncTasks { get; set; }
        public System.Data.Entity.DbSet<HfdHistoryFormDefinitionVersion> HfdHistoryFormDefinitionVersions { get; set; }
        public System.Data.Entity.DbSet<IpsIpServer> IpsIpServers { get; set; }
        public System.Data.Entity.DbSet<KitTemplate> KitTemplates { get; set; }
        public System.Data.Entity.DbSet<KitTemplateAttribute> KitTemplateAttributes { get; set; }
        public System.Data.Entity.DbSet<KitTemplateMeasureDefinition> KitTemplateMeasureDefinitions { get; set; }
        public System.Data.Entity.DbSet<LoeLogException> LoeLogExceptions { get; set; }
        public System.Data.Entity.DbSet<PrePreference> PrePreferences { get; set; }
        public System.Data.Entity.DbSet<Right> Rights { get; set; }
        public System.Data.Entity.DbSet<RightAction> RightActions { get; set; }
        public System.Data.Entity.DbSet<SerServer> SerServers { get; set; }
        public System.Data.Entity.DbSet<UnoUserNotice> UnoUserNotices { get; set; }
        public System.Data.Entity.DbSet<UserAccount> UserAccounts { get; set; }
        public System.Data.Entity.DbSet<UserAccountClient> UserAccountClients { get; set; }
        public System.Data.Entity.DbSet<UserAccountGroup> UserAccountGroups { get; set; }
        public System.Data.Entity.DbSet<UseUser> UseUsers { get; set; }
        public System.Data.Entity.DbSet<VerVersion> VerVersions { get; set; }

        public FakeTileboardLocatorContext()
        {
            ApiKeys = new FakeDbSet<ApiKey>("ApiKeyId");
            ApiRequestLogs = new FakeDbSet<ApiRequestLog>("ApiRequesLogtId");
            Applications = new FakeDbSet<Application>("ApplicationId");
            CliClients = new FakeDbSet<CliClient>("CliCId");
            Companies = new FakeDbSet<Company>("CompanyId");
            CseClientSensors = new FakeDbSet<CseClientSensor>("CseCId");
            DonDomainNames = new FakeDbSet<DonDomainName>("DonLId");
            FdcFormDefinitionVersionClients = new FakeDbSet<FdcFormDefinitionVersionClient>("FdcIId");
            FdvFormDefinitionVersions = new FakeDbSet<FdvFormDefinitionVersion>("FdvCId");
            FodFormDefinitions = new FakeDbSet<FodFormDefinition>("FodCId");
            FstFormSyncTasks = new FakeDbSet<FstFormSyncTask>("FstIId");
            HfdHistoryFormDefinitionVersions = new FakeDbSet<HfdHistoryFormDefinitionVersion>("HfdINoSeq");
            IpsIpServers = new FakeDbSet<IpsIpServer>("IpsIId");
            KitTemplates = new FakeDbSet<KitTemplate>("KitTemplateId");
            KitTemplateAttributes = new FakeDbSet<KitTemplateAttribute>("KitTemplateAttributeId");
            KitTemplateMeasureDefinitions = new FakeDbSet<KitTemplateMeasureDefinition>("KitTemplateMeasureDefinitionId");
            LoeLogExceptions = new FakeDbSet<LoeLogException>("LoeINoSeq");
            PrePreferences = new FakeDbSet<PrePreference>("PreIId");
            Rights = new FakeDbSet<Right>("RightId");
            RightActions = new FakeDbSet<RightAction>("RightActionId");
            SerServers = new FakeDbSet<SerServer>("SerCId");
            UnoUserNotices = new FakeDbSet<UnoUserNotice>("UnoCId");
            UserAccounts = new FakeDbSet<UserAccount>("UserAccountId");
            UserAccountClients = new FakeDbSet<UserAccountClient>("UserAccountClientId");
            UserAccountGroups = new FakeDbSet<UserAccountGroup>("UserAccountGroupId");
            UseUsers = new FakeDbSet<UseUser>("UseCId");
            VerVersions = new FakeDbSet<VerVersion>("VerCId");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        public System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        public System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public int UseUpdateDev()
        {

            return 0;
        }

        // Table Valued Functions
    }
}
// </auto-generated>