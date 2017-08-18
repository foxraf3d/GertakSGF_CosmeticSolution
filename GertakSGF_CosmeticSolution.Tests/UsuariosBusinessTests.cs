using Microsoft.VisualStudio.TestTools.UnitTesting;
using GertakSGF_CosmeticSolution_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GertakSGF_CosmeticSolution_Entity;

namespace GertakSGF_CosmeticSolution_Business.Tests
{
    [TestClass()]
    public class UsuariosBusinessTests
    {
        [TestMethod()]
        public void InserirUsuariosTest()
        {
            //Arrange
            UsuariosBusiness target = new UsuariosBusiness();

            UsuariosEntity user = new UsuariosEntity();
            user.CPF = "99999999999";
            user.DataNascimento = DateTime.Parse("12/10/1980");
            user.Email = "teste@teste.com";
            user.Endereco = new EnderecoEntity();
            user.Endereco.CEP = "00000-000";
            user.Endereco.Complemento = null;
            user.Foto = null;
            user.Nome = "FoxRaf3d";
            user.NomeDaMae = "Teste";
            user.PISPasep = 01561136516;
            user.RG = "999999999";
            user.Telefone = "9999-9999";
            user.TituloEleitor = "999999";

            //Act
            int actual = target.InserirUsuario(user);

            //Assert
            Assert.IsNotNull(actual);

        }
    }
}