﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ver4_biblTeo;

namespace ver4_biblTeo.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ver4_biblTeo.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataImprumutare")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detalii")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsteImprumutata")
                        .HasColumnType("bit");

                    b.Property<int?>("SeAflaLaID")
                        .HasColumnType("int");

                    b.Property<string>("Titlu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("returnare")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("SeAflaLaID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ver4_biblTeo.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ver4_biblTeo.DataStuff.BookClient", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.HasKey("BookID", "ClientID");

                    b.ToTable("BookClient");
                });

            modelBuilder.Entity("ver4_biblTeo.Book", b =>
                {
                    b.HasOne("ver4_biblTeo.Client", "SeAflaLa")
                        .WithMany()
                        .HasForeignKey("SeAflaLaID");
                });
#pragma warning restore 612, 618
        }
    }
}
