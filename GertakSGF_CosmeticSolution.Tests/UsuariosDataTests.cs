using Microsoft.VisualStudio.TestTools.UnitTesting;
using GertakSGF_CosmeticSolution_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GertakSGF_CosmeticSolution_Data.Tests
{
    [TestClass()]
    public class UsuariosDataTests
    {
        [TestMethod()]
        public void InserirUsuarioTest()
        {
            UsuariosData target = new UsuariosData();

            UsuariosEntity usuario = new UsuariosEntity();
            usuario.CPF = 29095561827;
            usuario.Data_De_Nascimento = DateTime.Parse("12/09/1980");
            usuario.Email = "teste@teste.com.br";
            usuario.Endereco = new Endereco();
            usuario.Endereco.CEP = 09080-000;
            usuario.Endereco.Complemento = null;
            usuario.Foto = null;
            usuario.Nome = "FoxRaf3d";
            usuario.Nome_Da_Mae = "liriliriliri";
            usuario.PIS_PASEP = 012022020;
            usuario.RG = 2634520010;
            usuario.Telefone = "25621956";
            usuario.Titulo_De_Eleitor = 121344480;

            target.InserirUsuario(usuario);


        }
    }
}