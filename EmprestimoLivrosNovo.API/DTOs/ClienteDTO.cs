using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmprestimoLivrosNovo.API.DTOs
{
    public class ClienteDTO
    {
       [IgnoreDataMember]
        public int Id { get; set; }

        [Required]       
        [StringLength(14)]
        [MinLength(11, ErrorMessage = "O CPF deve ter, no m´nimo, 14 caracteres.")]
        public string CliCpf { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "O Nome deve ter, no máximo, 200 caracteres")]
        public string CliNome { get; set; }

        [Required]
        [StringLength(200)]
        public string CliEndereco { get; set; }

        [Required]
        [StringLength(100)]
        public string CliCidade { get; set; }

        [Required]
        [StringLength(100)]
        public string CliBairro { get; set; }

        [Required]
        [StringLength(50)]
        public string CliNumero { get; set; }

        [StringLength(14, ErrorMessage = "O Número de celular deve ter, nomáximo, 14 caracteres.")]
        public string CliTelefoneCelular { get; set; }

        [StringLength(13, ErrorMessage = "O Número de telefone deve ter, no máximo, 13 caracteres.")]
        public string CliTelefoneFixo { get; set; }

    }
}
