﻿// <auto-generated />
using System;
using Cemidex_BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cemidex_BD.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("Cemidex_BD.Models.Administrador", b =>
                {
                    b.Property<int>("IDAdministrador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<bool>("gerente")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDAdministrador");

                    b.ToTable("Administradores");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Anuidade", b =>
                {
                    b.Property<int>("IDAnuidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDVenda")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDAnuidade");

                    b.HasIndex("IDVenda");

                    b.ToTable("Anuidades");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Exumacao", b =>
                {
                    b.Property<int>("IDExumacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDAdministrador")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("IDExumacao");

                    b.HasIndex("IDAdministrador");

                    b.ToTable("Exumacaos");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Falecido", b =>
                {
                    b.Property<int>("IDFalecido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CertidaoObito")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataObito")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistroObito")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TempoEnterro")
                        .HasColumnType("TEXT");

                    b.HasKey("IDFalecido");

                    b.ToTable("Falecidos");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Jazigo", b =>
                {
                    b.Property<int>("IDJazigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDLocal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumEspacos")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDJazigo");

                    b.HasIndex("IDLocal");

                    b.ToTable("Jazigos");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Localizacao", b =>
                {
                    b.Property<int>("IDLocal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.HasKey("IDLocal");

                    b.ToTable("Localizacaos");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Memorial", b =>
                {
                    b.Property<int>("IDMemorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<int>("IDFalecido")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDMemorial");

                    b.HasIndex("IDFalecido");

                    b.ToTable("Memorials");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Mensalidade", b =>
                {
                    b.Property<int>("IDMensalidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDPlano")
                        .HasColumnType("INTEGER");

                    b.Property<double>("valor")
                        .HasColumnType("REAL");

                    b.HasKey("IDMensalidade");

                    b.HasIndex("IDPlano");

                    b.ToTable("Mensalidades");
                });

            modelBuilder.Entity("Cemidex_BD.Models.PlanoFunebre", b =>
                {
                    b.Property<int>("IDPlano")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("IDPlano");

                    b.ToTable("PlanoFunebres");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Requerente", b =>
                {
                    b.Property<int>("IdRequerente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<int>("IdPlano")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.HasKey("IdRequerente");

                    b.HasIndex("IdPlano");

                    b.ToTable("Requerentes");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Sepultamento", b =>
                {
                    b.Property<int>("IDSepultamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("IDFalecido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDJazigo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDRequerente")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDSepultamento");

                    b.HasIndex("IDFalecido");

                    b.HasIndex("IDJazigo");

                    b.HasIndex("IDRequerente");

                    b.ToTable("Sepultamentos");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Transferencia", b =>
                {
                    b.Property<int>("IDTransferencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDAdm")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDJazigo1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDJazigo2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IDS")
                        .HasColumnType("TEXT");

                    b.Property<int>("IDSepultamento")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.HasKey("IDTransferencia");

                    b.HasIndex("IDAdm");

                    b.HasIndex("IDJazigo1");

                    b.HasIndex("IDJazigo2");

                    b.HasIndex("IDSepultamento");

                    b.ToTable("Transferencias");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Venda", b =>
                {
                    b.Property<int>("IDVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDJazigo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDRequerente")
                        .HasColumnType("INTEGER");

                    b.Property<double>("valor")
                        .HasColumnType("REAL");

                    b.HasKey("IDVenda");

                    b.HasIndex("IDJazigo");

                    b.HasIndex("IDRequerente");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Anuidade", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("IDVenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Exumacao", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Administrador", "Administrador")
                        .WithMany()
                        .HasForeignKey("IDAdministrador")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrador");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Jazigo", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("IDLocal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localizacao");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Memorial", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Falecido", "Falecido")
                        .WithMany()
                        .HasForeignKey("IDFalecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Falecido");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Mensalidade", b =>
                {
                    b.HasOne("Cemidex_BD.Models.PlanoFunebre", "PlanoFunebre")
                        .WithMany()
                        .HasForeignKey("IDPlano")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanoFunebre");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Requerente", b =>
                {
                    b.HasOne("Cemidex_BD.Models.PlanoFunebre", "PlanoFunebre")
                        .WithMany()
                        .HasForeignKey("IdPlano")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanoFunebre");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Sepultamento", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Falecido", "Falecido")
                        .WithMany()
                        .HasForeignKey("IDFalecido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cemidex_BD.Models.Jazigo", "Jazigo")
                        .WithMany()
                        .HasForeignKey("IDJazigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cemidex_BD.Models.Requerente", "Requerente")
                        .WithMany()
                        .HasForeignKey("IDRequerente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Falecido");

                    b.Navigation("Jazigo");

                    b.Navigation("Requerente");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Transferencia", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Administrador", "Administrador")
                        .WithMany()
                        .HasForeignKey("IDAdm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cemidex_BD.Models.Jazigo", "Jazigo")
                        .WithMany()
                        .HasForeignKey("IDJazigo1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cemidex_BD.Models.Jazigo", "Jazigo1")
                        .WithMany()
                        .HasForeignKey("IDJazigo2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cemidex_BD.Models.Sepultamento", "Sepultamento")
                        .WithMany()
                        .HasForeignKey("IDSepultamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Administrador");

                    b.Navigation("Jazigo");

                    b.Navigation("Jazigo1");

                    b.Navigation("Sepultamento");
                });

            modelBuilder.Entity("Cemidex_BD.Models.Venda", b =>
                {
                    b.HasOne("Cemidex_BD.Models.Jazigo", "Jazigo")
                        .WithMany()
                        .HasForeignKey("IDJazigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cemidex_BD.Models.Requerente", "Requerente")
                        .WithMany()
                        .HasForeignKey("IDRequerente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jazigo");

                    b.Navigation("Requerente");
                });
#pragma warning restore 612, 618
        }
    }
}
