using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using LarchProvisionsWebsite.Models;

namespace LarchProvisionsWebsite.Migrations.LarchProvisionsDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160421023007_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<string>("Name");

                    b.Property<int>("RecipeId");

                    b.Property<string>("Source");

                    b.Property<string>("Unit");

                    b.HasKey("IngredientId");

                    b.HasAnnotation("Relational:TableName", "Ingredients");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("OrderBy");

                    b.Property<DateTime>("PickupTime");

                    b.Property<int?>("RecipeRecipeId");

                    b.Property<string>("Title");

                    b.HasKey("MenuId");

                    b.HasAnnotation("Relational:TableName", "Menus");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<int>("Servings");

                    b.HasKey("RecipeId");

                    b.HasAnnotation("Relational:TableName", "Recipes");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Ingredient", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Menu", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeRecipeId");
                });
        }
    }
}
