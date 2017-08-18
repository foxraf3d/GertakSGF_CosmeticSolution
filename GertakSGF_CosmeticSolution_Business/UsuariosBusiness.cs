using GertakSGF_CosmeticSolution_Data;
using GertakSGF_CosmeticSolution_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GertakSGF_CosmeticSolution_Business
{
    public class UsuariosBusiness
    {
        public int InserirUsuario(UsuariosEntity usuario)
        {
            return new UsuariosData().InserirUsuario(usuario);
        }
    }
}
