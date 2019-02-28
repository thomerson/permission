using FluentMigrator;
using System;

namespace Thomerson.Migrator
{
    /// <summary>
    /// 20190301 version 1.0
    /// </summary>
    [Migration(20190301)]
    public class RoleMigrator : Migration
    {
        public override void Down()
        {
            Delete.Table("Orders_test");
        }

        public override void Up()
        {
            Create.Table("Orders_test")
                 .WithColumn("ID").AsInt32().Identity().PrimaryKey("id_pk").Indexed("Orders_Pk_ID")
                 .WithColumn("CustomerID").AsString().ForeignKey("Customers", "CustomerID").NotNullable()
                 .WithColumn("DisCount").AsDecimal().WithDefaultValue(0)
                 .WithColumn("OrderDate").AsDateTime().WithDefault(SystemMethods.CurrentDateTime);
        }
    }
}
