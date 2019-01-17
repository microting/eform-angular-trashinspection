﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrashInspection.Pn.Infrastructure.Data;

namespace TrashInspection.Pn.Migrations
{
    [DbContext(typeof(TrashInspectionPnDbContext))]
    partial class TrashInspectionPnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.Installation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<string>("Name");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Installations");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.InstallationSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<int>("Installation_Id");

                    b.Property<int>("Sdk_Site_Id");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("InstallationSites");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.InstallationSiteVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<int>("Installation_Id");

                    b.Property<int>("Installation_Site_Id");

                    b.Property<int>("Sdk_Site_Id");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("InstallationSiteVersions");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.InstallationVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<int>("InstallationId");

                    b.Property<string>("Name");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("InstallationVersions");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.TrashInspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Eak_Code");

                    b.Property<int>("Installation_Id");

                    b.Property<bool>("Must_Be_Inspected");

                    b.Property<string>("Producer");

                    b.Property<string>("Registration_Number");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Transporter");

                    b.Property<int>("Trash_Fraction");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<int>("Weighing_Number");

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("TrashInspections");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.TrashInspectionPnSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SelectedeFormId");

                    b.Property<string>("SelectedeFormName");

                    b.HasKey("Id");

                    b.ToTable("TrashInspectionPnSettings");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.TrashInspectionSettingsVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SelectedeFormId");

                    b.Property<string>("SelectedeFormName");

                    b.Property<int>("Trash_Inspection_Id");

                    b.HasKey("Id");

                    b.ToTable("TrashInspectionSettingsVersions");
                });

            modelBuilder.Entity("TrashInspection.Pn.Infrastructure.Data.Entities.TrashInspectionVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Created_By_User_Id");

                    b.Property<DateTime?>("Created_at");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Eak_Code");

                    b.Property<int>("Installation_Id");

                    b.Property<bool>("Must_Be_Inspected");

                    b.Property<string>("Producer");

                    b.Property<string>("Registration_Number");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Transporter");

                    b.Property<int>("Trash_Fraction");

                    b.Property<int>("Trash_Inspction_Id");

                    b.Property<int>("Updated_By_User_Id");

                    b.Property<DateTime?>("Updated_at");

                    b.Property<int>("Version");

                    b.Property<int>("Weighing_Number");

                    b.Property<string>("Workflow_state")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("TrashInspectionVersions");
                });
#pragma warning restore 612, 618
        }
    }
}