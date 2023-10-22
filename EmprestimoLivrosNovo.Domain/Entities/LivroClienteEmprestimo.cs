﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmprestimoLivrosNovo.Domain.Entities
{
    [Table("Livro_Cliente_Emprestimo")]
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        public int? LcelIdCliente { get; set; }

        public int? LclIdLivro { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? LcelDataEmprestimo { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? LcelDataEntrega { get; set; }

        public bool? LcelEntregue { get; set; }

        [ForeignKey("LcelIdCliente")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Cliente LcelIdClienteNavigation { get; set; }

        [ForeignKey("LclIdLivro")]
        [InverseProperty("LivroClienteEmprestimo")]
        public virtual Livro LclIdLivroNavigation { get; set; }
    }
}
