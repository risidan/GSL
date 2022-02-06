﻿// <auto-generated />
using System;
using GSL.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GSL.Infra.Data.Migrations
{
    [DbContext(typeof(GSLContext))]
    [Migration("20220206030836_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GSL.Domain.Entidades.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Colaborador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataDemissao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NumeroCtps")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ColaboradorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EnderecoPrincipal")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Fornecedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("InscricaoEstadual")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("InscricaoMunicipal")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeContato")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("TipoPessoa")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Telefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ColaboradorId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Ddd")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Ddi")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("TelefonePrincipal")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)")
                        .HasColumnName("Id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ColaboradorId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("FornecedorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("ColaboradorId")
                        .IsUnique();

                    b.HasIndex("FornecedorId")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Endereco", b =>
                {
                    b.HasOne("GSL.Domain.Entidades.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("GSL.Domain.Entidades.Colaborador", "Colaborador")
                        .WithMany("Enderecos")
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("GSL.Domain.Entidades.Fornecedor", "Fornecedor")
                        .WithMany("Enderecos")
                        .HasForeignKey("FornecedorId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Telefone", b =>
                {
                    b.HasOne("GSL.Domain.Entidades.Cliente", "Cliente")
                        .WithMany("Telefones")
                        .HasForeignKey("ClienteId");

                    b.HasOne("GSL.Domain.Entidades.Colaborador", "Colaborador")
                        .WithMany("Telefones")
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("GSL.Domain.Entidades.Fornecedor", "Fornecedor")
                        .WithMany("Telefones")
                        .HasForeignKey("FornecedorId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Usuario", b =>
                {
                    b.HasOne("GSL.Domain.Entidades.Cliente", "Cliente")
                        .WithOne("Usuario")
                        .HasForeignKey("GSL.Domain.Entidades.Usuario", "ClienteId");

                    b.HasOne("GSL.Domain.Entidades.Colaborador", "Colaborador")
                        .WithOne("Usuario")
                        .HasForeignKey("GSL.Domain.Entidades.Usuario", "ColaboradorId");

                    b.HasOne("GSL.Domain.Entidades.Fornecedor", "Fornecedor")
                        .WithOne("Usuario")
                        .HasForeignKey("GSL.Domain.Entidades.Usuario", "FornecedorId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Cliente", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Telefones");

                    b.Navigation("Usuario")
                        .IsRequired();
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Colaborador", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Telefones");

                    b.Navigation("Usuario")
                        .IsRequired();
                });

            modelBuilder.Entity("GSL.Domain.Entidades.Fornecedor", b =>
                {
                    b.Navigation("Enderecos");

                    b.Navigation("Telefones");

                    b.Navigation("Usuario")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}