using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GertakSGF_CosmeticSolution_Data
{
    public class UsuariosData : DbContext
    {
        public UsuariosData()
            : base("name=GertakSGF_EF")
        {

        }

        public virtual DbSet<UsuariosEntity> usuarios { get; set; }

        public void InserirUsuario(UsuariosEntity user)
        {
            using (var context )
            {
                try
                {

                }
                catch (Exception e)
                {

                    usuarios.Rol;
                }
            }

        }
    }
}
