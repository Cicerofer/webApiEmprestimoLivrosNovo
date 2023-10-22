﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivrosNovo.Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cliCPF")]
        [StringLength(14)]
        public string CliCpf { get; set; }

        [Required]
        [Column("cliNome")]
        [StringLength(200)]
        public string CliNome { get; set; }

        [Required]
        [Column("cliEndereco")]
        [StringLength(200)]
        public string CliEndereco { get; set; }

        [Required]
        [Column("cliCidade")]
        [StringLength(100)]
        public string CliCidade { get; set; }

        [Required]
        [Column("cliBairro")]
        [StringLength(100)]
        public string CliBairro { get; set; }

        [Required]
        [Column("cliNumero")]
        [StringLength(50)]
        public string CliNumero { get; set; }

        [Column("cliTelefoneCelular")]
        [StringLength(14)]
        public string CliTelefoneCelular { get; set; }

        [Column("cliTelefoneFixo")]
        [StringLength(13)]
        public string CliTelefoneFixo { get; set; }

        [InverseProperty("LcelIdClienteNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}

