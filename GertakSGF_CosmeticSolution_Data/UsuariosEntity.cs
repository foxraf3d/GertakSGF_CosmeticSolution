namespace GertakSGF_CosmeticSolution_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_gertak.usuarios")]
    public partial class UsuariosEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(45)]
        public string Email { get; set; }

        [Column(TypeName = "tinyblob")]
        public byte[] Foto { get; set; }

        public DateTime Data_De_Nascimento { get; set; }

        public int? CPF { get; set; }

        public int? RG { get; set; }

        [Required]
        [StringLength(200)]
        public Endereco Endereco { get; set; }

        public short Telefone { get; set; }

        public int? Titulo_De_Eleitor { get; set; }

        public int? PIS_PASEP { get; set; }

        public int Nome_Da_Mae { get; set; }
    }

    public class Endereco
    {
        public int Numero;

        [StringLength(50)]
        public string Complemento;

        public short CEP;
    }
}
