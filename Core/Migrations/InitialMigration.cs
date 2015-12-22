using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Migrations
{
    [Migration(1)]
    public class InitialMigration : Migration
    {
        // migrate --conn "server=.;database=dapper-test;trusted_connection=true;" --provider sqlserver2012 --assembly "core\bin\debug\core.dll" --verbose true
        public override void Up()
        {
            Create.Table("Entity")
                .WithIdColumn()
                .WithColumn("Name")
                    .AsString()
                    .NotNullable();

            Create.Table("NominalLedgerCode")
               .WithIdColumn()
               .WithColumn("Name")
                   .AsString()
                   .NotNullable()
                .WithColumn("Code")
                   .AsString()
                   .NotNullable();

            Create.Table("Journal")
             .WithIdColumn()
             .WithColumn("Name")
                .AsString()
                .NotNullable()
             .WithColumn("JournalStatus")
                 .AsInt16()
                 .NotNullable();

            Create.Table("Adjustment")
                .WithIdColumn()
                .WithColumn("EntityId")
                    .AsInt32()
                    .ForeignKey("Entity", "Id")
                    .NotNullable()
                .WithColumn("NominalLedgerCodeId")
                    .AsInt32()
                    .ForeignKey("NominalLedgerCode", "Id")
                    .NotNullable()
                .WithColumn("Value")
                    .AsDecimal()
                    .NotNullable()
                .WithColumn("JournalId")
                    .AsInt32()
                    .ForeignKey("Journal", "Id")
                    .NotNullable();
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
