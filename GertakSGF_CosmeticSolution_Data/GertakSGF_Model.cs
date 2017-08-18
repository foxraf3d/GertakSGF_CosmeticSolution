namespace GertakSGF_CosmeticSolution_Data
{
    using GertakSGF_CosmeticSolution_Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GertakSGF_Model : DbContext
    {
        // Your context has been configured to use a 'GertakSGF_Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GertakSGF_CosmeticSolution_Data.GertakSGF_Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GertakSGF_Model' 
        // connection string in the application configuration file.
        public GertakSGF_Model()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<UsuariosEntity> Usuarios { get; set; }

    }

}