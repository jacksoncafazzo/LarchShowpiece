using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using LarchProvisionsWebsite.Models;

namespace LarchProvisionsWebsite.Migrations.LarchProvisionsDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160421055549_LinkCustomerOnRegistration")]
    partial class LinkCustomerOnRegistration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LarchProvisionsWebsite.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int>("LarchCustomerId");

                    b.Property<int>("LarchCustomerId1");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

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

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("OrderBy");

                    b.Property<DateTime>("PickupTime");

                    b.Property<string>("Title");

                    b.HasKey("MenuId");

                    b.HasAnnotation("Relational:TableName", "Menus");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LarchCustomerId");

                    b.Property<int>("MenuId");

                    b.Property<int>("RecipeId");

                    b.Property<int>("Servings");

                    b.HasKey("OrderId");

                    b.HasAnnotation("Relational:TableName", "Orders");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("MenuId");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<int>("Servings");

                    b.HasKey("RecipeId");

                    b.HasAnnotation("Relational:TableName", "Recipes");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Ingredient", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Menu", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Order", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("LarchCustomerId")
                        .HasPrincipalKey("LarchCustomerId1");

                    b.HasOne("LarchProvisionsWebsite.Models.Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");

                    b.HasOne("LarchProvisionsWebsite.Models.Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("LarchProvisionsWebsite.Models.Recipe", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LarchProvisionsWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("LarchProvisionsWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
