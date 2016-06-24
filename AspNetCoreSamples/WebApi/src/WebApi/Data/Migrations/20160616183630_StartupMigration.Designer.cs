using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApi.Data;

namespace webapi.Data.Migrations
{
    [DbContext(typeof(UnitOfWork))]
    [Migration("20160616183630_StartupMigration")]
    partial class StartupMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 50);

                    b.Property<DateTime>("UploadDate");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 150);

                    b.HasKey("Id");

                    b.ToTable("Images");
                });
        }
    }
}
