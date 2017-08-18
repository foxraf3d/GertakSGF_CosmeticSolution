using GertakSGF_CosmeticSolution_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GertakSGF_CosmeticSolution_Data
{
    public class UsuariosData
    {
        public int InserirUsuario(UsuariosEntity usuario)
        {
            using (var ctx = new GertakSGF_Model1())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
                return usuario.Id;
            }
        }
    }
}
