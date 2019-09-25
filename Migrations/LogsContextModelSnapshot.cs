﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pruebaMR;

namespace pruebaMR.Migrations
{
    [DbContext(typeof(LogsContext))]
    partial class LogsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("pruebaMR.GeneralLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("GeneralLogs");
                });

            modelBuilder.Entity("pruebaMR.Registro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GeneralLogId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("GeneralLogId");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("pruebaMR.Registro", b =>
                {
                    b.HasOne("pruebaMR.GeneralLog", "GeneralLog")
                        .WithMany("Registros")
                        .HasForeignKey("GeneralLogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
