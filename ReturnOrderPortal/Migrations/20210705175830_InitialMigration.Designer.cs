﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReturnOrderPortal.DataContext;

namespace ReturnOrderPortal.Migrations
{
    [DbContext(typeof(ProcessContext))]
    [Migration("20210705175830_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReturnOrderPortal.Models.ProcessResponse", b =>
                {
                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfDelivery")
                        .HasColumnType("datetime2");

                    b.Property<double>("PackagingandDeliveryCharge")
                        .HasColumnType("float");

                    b.Property<double>("ProcessingCharge")
                        .HasColumnType("float");

                    b.HasKey("RequestId");

                    b.ToTable("ProcessData");
                });
#pragma warning restore 612, 618
        }
    }
}
