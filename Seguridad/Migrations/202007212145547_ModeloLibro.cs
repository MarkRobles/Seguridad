namespace Seguridad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloLibro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        tittle = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Libro");
        }
    }
}
