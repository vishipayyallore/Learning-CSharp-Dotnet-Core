using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using hwsqlite.Sample;

namespace hwsqlite.Migrations
{
    [DbContext(typeof(eCommerceDbContext))]
    [Migration("20160519143301_hwsqliteMigration1")]
    partial class hwsqliteMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20896");

            modelBuilder.Entity("hwsqlite.Sample.Product", b =>
                {
                    b.Property<string>("Id");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
        }
    }
}
