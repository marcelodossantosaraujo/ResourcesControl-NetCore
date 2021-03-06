// <auto-generated />
using APIResources.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIResources.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220405013210_InitialCreation")]
    partial class InitialCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("APIResources.Models.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Onservacao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
