﻿// <auto-generated />
using System;
using IsekaiTechnologies.FacCord.Core.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IsekaiTechnologies.FacCord.Core.DAL.Migrations
{
    [DbContext(typeof(FacCordContext))]
    [Migration("20200917095347_AddPlayerEmoji")]
    partial class AddPlayerEmoji
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Discord.ServerSettings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DiscordServerId")
                        .HasColumnType("bigint");

                    b.Property<string>("ServerPrefix")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServerSettings");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.EmojiLookup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emoji")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("TargetId")
                        .HasColumnType("bigint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmojiLookups");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Equipments.RuptureChemical", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Capacity")
                        .HasColumnType("smallint");

                    b.Property<short>("Count")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("NextRefresh")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("RefreshInterval")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("RuptureChemicals");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.MachineUnit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("MachineId")
                        .HasColumnType("bigint");

                    b.Property<short>("PosX")
                        .HasColumnType("smallint");

                    b.Property<short>("PosY")
                        .HasColumnType("smallint");

                    b.Property<long?>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.HasIndex("WorkshopId");

                    b.ToTable("MachineUnits");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MachineUnit");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.Block", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hardness")
                        .HasColumnType("int");

                    b.Property<bool>("IsSolid")
                        .HasColumnType("bit");

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ReplacementId")
                        .HasColumnType("bigint");

                    b.Property<int>("Toughness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("ReplacementId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.BlockSpawnChance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BlockId")
                        .HasColumnType("bigint");

                    b.Property<double>("Chance")
                        .HasColumnType("float");

                    b.Property<long?>("RegionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("RegionId");

                    b.ToTable("BlockSpawnChances");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.Dimension", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dimensions");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.Region", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("DimensionId")
                        .HasColumnType("bigint");

                    b.Property<string>("IdName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ProfileId")
                        .HasColumnType("bigint");

                    b.Property<short>("RegionLevel")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("DimensionId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DiscordId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SettingsId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.PlayerSettings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlayerSettings");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Profile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CurrentDrillId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CurrentProspectorId")
                        .HasColumnType("bigint");

                    b.Property<int>("Exp")
                        .HasColumnType("int");

                    b.Property<long>("Fund")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastFindMine")
                        .HasColumnType("datetime2");

                    b.Property<short>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("PlayerEmoji")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PlayerId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProfileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("RuptureChemicalId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SelectedRegionId")
                        .HasColumnType("bigint");

                    b.Property<long?>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CurrentDrillId");

                    b.HasIndex("CurrentProspectorId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("RuptureChemicalId");

                    b.HasIndex("SelectedRegionId");

                    b.HasIndex("WorkshopId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Quest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("MininumLevel")
                        .HasColumnType("smallint");

                    b.Property<long?>("ProfileId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProfileId1")
                        .HasColumnType("bigint");

                    b.Property<int>("RewardCoin")
                        .HasColumnType("int");

                    b.Property<int>("RewardExp")
                        .HasColumnType("int");

                    b.Property<long?>("UnlockAfterId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("ProfileId1");

                    b.HasIndex("UnlockAfterId");

                    b.ToTable("Quests");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Recipe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ProcessedById")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProfileId")
                        .HasColumnType("bigint");

                    b.Property<long?>("QuestId")
                        .HasColumnType("bigint");

                    b.Property<string>("RecipeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProcessedById");

                    b.HasIndex("ProfileId");

                    b.HasIndex("QuestId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Shops.Listing", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Limit")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("LimitResetInterval")
                        .HasColumnType("time");

                    b.Property<short>("MinimumLevel")
                        .HasColumnType("smallint");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Listings");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Listing");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Shops.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<long?>("BuyerId")
                        .HasColumnType("bigint");

                    b.Property<long>("Cost")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PurchasedAt")
                        .HasColumnType("datetime2");

                    b.Property<long?>("PurchasedListingId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("PurchasedListingId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Storages.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<long?>("DimensionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("DimensionId");

                    b.ToTable("Items");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Storages.ItemMetas.ItemMeta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemMetas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ItemMeta");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Storages.StorageItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("BlockId")
                        .HasColumnType("bigint");

                    b.Property<long>("Count")
                        .HasColumnType("bigint");

                    b.Property<long?>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ItemMetaId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ListingId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProcessingMachineUnitId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProcessingMachineUnitId1")
                        .HasColumnType("bigint");

                    b.Property<long?>("QuestId")
                        .HasColumnType("bigint");

                    b.Property<long?>("QuestId1")
                        .HasColumnType("bigint");

                    b.Property<long?>("RecipeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("RecipeId1")
                        .HasColumnType("bigint");

                    b.Property<long?>("WorkshopId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BlockId");

                    b.HasIndex("ItemId");

                    b.HasIndex("ItemMetaId");

                    b.HasIndex("ListingId");

                    b.HasIndex("ProcessingMachineUnitId");

                    b.HasIndex("ProcessingMachineUnitId1");

                    b.HasIndex("QuestId");

                    b.HasIndex("QuestId1");

                    b.HasIndex("RecipeId");

                    b.HasIndex("RecipeId1");

                    b.HasIndex("WorkshopId");

                    b.ToTable("StorageItems");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Workshop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CurrentEnergy")
                        .HasColumnType("float");

                    b.Property<long>("CurrentStorageItemCount")
                        .HasColumnType("bigint");

                    b.Property<double>("EnergyCapacity")
                        .HasColumnType("float");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("SizeX")
                        .HasColumnType("int");

                    b.Property<int>("SizeY")
                        .HasColumnType("int");

                    b.Property<long>("StorageCapacity")
                        .HasColumnType("bigint");

                    b.Property<short>("SupportedWeight")
                        .HasColumnType("smallint");

                    b.Property<short>("WeightCapacity")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Workshops");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.ProcessingMachineUnit", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Machines.MachineUnit");

                    b.Property<long>("BufferSize")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProcedureId")
                        .HasColumnType("bigint");

                    b.Property<double>("Progress")
                        .HasColumnType("float");

                    b.HasIndex("ProcedureId");

                    b.HasDiscriminator().HasValue("ProcessingMachineUnit");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Shops.ExclusiveListings", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Shops.Listing");

                    b.Property<DateTime>("OfferEnds")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ProfileId")
                        .HasColumnType("bigint");

                    b.HasIndex("ProfileId");

                    b.HasDiscriminator().HasValue("ExclusiveListings");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Equipments.Drill", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Storages.Item");

                    b.Property<long>("Durability")
                        .HasColumnType("bigint");

                    b.Property<short>("Efficiency")
                        .HasColumnType("smallint");

                    b.Property<short>("Hardness")
                        .HasColumnType("smallint");

                    b.Property<short>("RangeX")
                        .HasColumnType("smallint");

                    b.Property<short>("RangeY")
                        .HasColumnType("smallint");

                    b.HasDiscriminator().HasValue("Drill");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Equipments.Prospector", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Storages.Item");

                    b.Property<short>("MineRichness")
                        .HasColumnType("smallint");

                    b.Property<short>("OreVein")
                        .HasColumnType("smallint");

                    b.Property<short>("RangeX")
                        .HasColumnName("Prospector_RangeX")
                        .HasColumnType("smallint");

                    b.Property<short>("RangeY")
                        .HasColumnName("Prospector_RangeY")
                        .HasColumnType("smallint");

                    b.Property<short>("RegionLevel")
                        .HasColumnType("smallint");

                    b.Property<TimeSpan>("ScanCooldown")
                        .HasColumnType("time");

                    b.HasDiscriminator().HasValue("Prospector");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.Machine", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Storages.Item");

                    b.Property<short>("Height")
                        .HasColumnType("smallint");

                    b.Property<short>("Weight")
                        .HasColumnType("smallint");

                    b.Property<short>("Width")
                        .HasColumnType("smallint");

                    b.HasDiscriminator().HasValue("Machine");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Storages.ItemMetas.DrillItemMeta", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Storages.ItemMetas.ItemMeta");

                    b.Property<long>("Durability")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("DrillItemMeta");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.EnergyProductionMachineUnit", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Machines.ProcessingMachineUnit");

                    b.Property<double>("ProductionRate")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("EnergyProductionMachineUnit");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.StorageMachine", b =>
                {
                    b.HasBaseType("IsekaiTechnologies.FacCord.Core.Models.Machines.Machine");

                    b.Property<long>("Capacity")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("StorageMachine");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.MachineUnit", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Machines.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Workshop", null)
                        .WithMany("Units")
                        .HasForeignKey("WorkshopId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.Block", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Storages.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Block", "Replacement")
                        .WithMany()
                        .HasForeignKey("ReplacementId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.BlockSpawnChance", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Block", "Block")
                        .WithMany()
                        .HasForeignKey("BlockId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Region", null)
                        .WithMany("MaterialDistribution")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Mines.Region", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Dimension", "Dimension")
                        .WithMany("Regions")
                        .HasForeignKey("DimensionId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Profile", null)
                        .WithMany("UnlockedRegions")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Player", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.PlayerSettings", "Settings")
                        .WithMany()
                        .HasForeignKey("SettingsId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Profile", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Storages.StorageItem", "CurrentDrill")
                        .WithMany()
                        .HasForeignKey("CurrentDrillId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Storages.StorageItem", "CurrentProspector")
                        .WithMany()
                        .HasForeignKey("CurrentProspectorId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Player", "Player")
                        .WithMany("Profiles")
                        .HasForeignKey("PlayerId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Equipments.RuptureChemical", "RuptureChemical")
                        .WithMany()
                        .HasForeignKey("RuptureChemicalId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Region", "SelectedRegion")
                        .WithMany()
                        .HasForeignKey("SelectedRegionId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Workshop", "Workshop")
                        .WithMany()
                        .HasForeignKey("WorkshopId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Quest", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Profile", null)
                        .WithMany("AvailableQuests")
                        .HasForeignKey("ProfileId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Profile", null)
                        .WithMany("FinishedQuests")
                        .HasForeignKey("ProfileId1");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Quest", "UnlockAfter")
                        .WithMany()
                        .HasForeignKey("UnlockAfterId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Recipe", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Machines.Machine", "ProcessedBy")
                        .WithMany()
                        .HasForeignKey("ProcessedById");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Profile", null)
                        .WithMany("UnlockedRecipes")
                        .HasForeignKey("ProfileId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Quest", null)
                        .WithMany("RewardRecipes")
                        .HasForeignKey("QuestId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Shops.Transaction", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Profile", "Buyer")
                        .WithMany("PurchaseHistory")
                        .HasForeignKey("BuyerId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Shops.Listing", "PurchasedListing")
                        .WithMany()
                        .HasForeignKey("PurchasedListingId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Storages.Item", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Dimension", null)
                        .WithMany("PossibleResources")
                        .HasForeignKey("DimensionId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Storages.StorageItem", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Mines.Block", null)
                        .WithMany("DropTable")
                        .HasForeignKey("BlockId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Storages.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Storages.ItemMetas.ItemMeta", "ItemMeta")
                        .WithMany()
                        .HasForeignKey("ItemMetaId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Shops.Listing", null)
                        .WithMany("Offerings")
                        .HasForeignKey("ListingId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Machines.ProcessingMachineUnit", null)
                        .WithMany("InputBuffer")
                        .HasForeignKey("ProcessingMachineUnitId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Machines.ProcessingMachineUnit", null)
                        .WithMany("OutputBuffer")
                        .HasForeignKey("ProcessingMachineUnitId1");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Quest", null)
                        .WithMany("RequestedItems")
                        .HasForeignKey("QuestId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Quest", null)
                        .WithMany("RewardItems")
                        .HasForeignKey("QuestId1");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Recipe", null)
                        .WithMany("Inputs")
                        .HasForeignKey("RecipeId");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Recipe", null)
                        .WithMany("Outputs")
                        .HasForeignKey("RecipeId1");

                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Workshop", null)
                        .WithMany("Storage")
                        .HasForeignKey("WorkshopId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Machines.ProcessingMachineUnit", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Recipe", "Procedure")
                        .WithMany()
                        .HasForeignKey("ProcedureId");
                });

            modelBuilder.Entity("IsekaiTechnologies.FacCord.Core.Models.Shops.ExclusiveListings", b =>
                {
                    b.HasOne("IsekaiTechnologies.FacCord.Core.Models.Profile", null)
                        .WithMany("ExclusiveOffers")
                        .HasForeignKey("ProfileId");
                });
#pragma warning restore 612, 618
        }
    }
}
