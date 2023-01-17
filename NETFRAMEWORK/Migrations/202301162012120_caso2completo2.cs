namespace NETFRAMEWORK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class caso2completo2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Materias", newName: "Materia");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Materia", newName: "Materias");
        }
    }
}
