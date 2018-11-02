﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaylistAPI.Data;

namespace PlaylistAPI.Migrations
{
    [DbContext(typeof(MusicLibraryDbContext))]
    [Migration("20181101202259_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlaylistAPI.Models.Playlists", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("PlaylistAPI.Models.Songs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<int>("PlaylistID");

                    b.Property<int?>("PlaylistsID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("PlaylistsID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("PlaylistAPI.Models.Songs", b =>
                {
                    b.HasOne("PlaylistAPI.Models.Playlists")
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistsID");
                });
#pragma warning restore 612, 618
        }
    }
}