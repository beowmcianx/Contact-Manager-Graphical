using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Contact_Manager_Graphical.Models;

public partial class ContactmanagerContext : DbContext
{
    public ContactmanagerContext()
    {
    }

    public ContactmanagerContext(DbContextOptions<ContactmanagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\LAPTOP-880CN29C\\SQLEXPRESS;Database=ContactManager;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__Contact__024E7A86CEAAA81C");

            entity.ToTable("Contact");

            entity.HasIndex(e => e.Email, "UQ__Contact__AB6E6164EC0149B6").IsUnique();

            entity.HasIndex(e => e.PhoneNum, "UQ__Contact__E592CEB3A9D9A62A").IsUnique();

            entity.Property(e => e.ContactId).HasColumnName("contact_id");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.PhoneNum).HasColumnName("phone_num");

            entity.HasOne(d => d.Person).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Contact__person___4D94879B");

            entity.HasMany(d => d.Tags).WithMany(p => p.Contacts)
                .UsingEntity<Dictionary<string, object>>(
                    "ContactTag",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Contact_T__tag_i__534D60F1"),
                    l => l.HasOne<Contact>().WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Contact_T__conta__52593CB8"),
                    j =>
                    {
                        j.HasKey("ContactId", "TagId").HasName("PK__Contact___766710ADBBD49996");
                        j.ToTable("Contact_Tags");
                        j.IndexerProperty<int>("ContactId").HasColumnName("contact_id");
                        j.IndexerProperty<int>("TagId").HasColumnName("tag_id");
                    });
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Person__543848DFCC7912C5");

            entity.ToTable("Person");

            entity.Property(e => e.PersonId).HasColumnName("person_id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .HasColumnName("address");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.SecondName)
                .HasMaxLength(50)
                .HasColumnName("second_name");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__Tags__4296A2B6D7B934DD");

            entity.Property(e => e.TagId).HasColumnName("tag_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
