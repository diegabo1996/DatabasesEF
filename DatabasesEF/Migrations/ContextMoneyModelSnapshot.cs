﻿// <auto-generated />
using System;
using DatabasesEF.ControlDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabasesEF.Migrations
{
    [DbContext(typeof(ContextMoney))]
    partial class ContextMoneyModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DatabasesEF.Models.MoneyControl", b =>
                {
                    b.Property<Guid>("IdTransaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<double>("AmountTransaction")
                        .HasColumnType("float");

                    b.Property<double>("BalanceTransaction")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Details")
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("IncomeTransaction")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TransactionDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTransaction");

                    b.ToTable("RegistryMoneyControl");
                });
#pragma warning restore 612, 618
        }
    }
}