// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_Project.StudentDbcontext;

#nullable disable

namespace StudentProject.Migrations
{
    [DbContext(typeof(studentDbcontext))]
    partial class studentDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Student_Project.Models.Domain.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentId"));

                    b.Property<long>("rollno")
                        .HasColumnType("bigint");

                    b.Property<string>("section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studentClass")
                        .HasColumnType("int");

                    b.Property<string>("studentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("year_of_enrollment")
                        .HasColumnType("int");

                    b.HasKey("studentId");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
