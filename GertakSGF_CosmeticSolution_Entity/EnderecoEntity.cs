using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GertakSGF_CosmeticSolution_Entity
{

    public class EnderecoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string RuaAvenidaEstrada { get; set; }
    }
}
