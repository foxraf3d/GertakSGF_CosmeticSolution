namespace GertakSGF_CosmeticSolution_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=GertakSGF_EF")
        {
        }

        public virtual DbSet<UsuariosEntity> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuariosEntity>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosEntity>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosEntity>()
                .Property(e => e.Endereco.CEP).IsRequired();

            modelBuilder.Entity<UsuariosEntity>()
                .Property(e => e.Endereco.Complemento)
                .IsUnicode(false);
            

        }
    }
}
