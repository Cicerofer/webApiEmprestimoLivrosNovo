﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivrosNovo.API.Models
{
    public partial class ControleEmprestimoLivroContext : DbContext
    {
        public ControleEmprestimoLivroContext()
        {
        }

        public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Livro> Livro { get; set; }

        public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
            {
                entity.HasOne(d => d.LcelIdClienteNavigation)
                .WithMany(p => p.LivroClienteEmprestimo)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Cliente");

                entity.HasOne(d => d.LclIdLivroNavigation)
                .WithMany(p => p.LivroClienteEmprestimo)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Livro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

