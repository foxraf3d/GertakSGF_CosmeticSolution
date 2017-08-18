using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GertakSGF_CosmeticSolution_Entity
{
    public class UsuariosEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public object Foto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public EnderecoEntity Endereco { get; set; }
        public string Telefone { get; set; }
        public string TituloEleitor { get; set; }
        public int PISPasep { get; set; }
        public string NomeDaMae { get; set; }
    }
   
}
