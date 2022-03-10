using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.models
{
    public partial class newMaonContext : DbContext
    {
        public newMaonContext()
        {
        }

        public newMaonContext(DbContextOptions<newMaonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityUpdate> ActivityUpdates { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<DayCare> DayCares { get; set; }
        public virtual DbSet<Kid> Kids { get; set; }
        public virtual DbSet<KidsAttendance> KidsAttendances { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PlacementOfATeacher> PlacementOfATeachers { get; set; }
        public virtual DbSet<RecoverLosts> RecoverLosts { get; set; }
        public virtual DbSet<TypeClass> TypeClasses { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<ExternalData> ExternalData { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ILY9E484-TP\\SQLEXPRESS;Initial Catalog=NewMaonProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


                //
                //        optionsBuilder.UseSqlServer("Data Source=ILY9E484-TP;Initial Catalog=newMaon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<ActivityUpdate>(entity =>
            {
                entity.HasKey(e => e.IdActivityUpdate)
                    .HasName("PK__Activity__BF62B0120F430C85");
                entity.ToTable("ActivityUpdate");
                entity.Property(e => e.IdActivityUpdate).HasColumnName("IdActivityUpdate");


                //         entity.Property(e => e.IdActivityUpdate).HasColumnName("IdActivityUpdate");

                entity.Property(e => e.DailyActivitySubject)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DailyActivitySubject");

                entity.Property(e => e.DailyActivityDate)
              .HasColumnType("datetime")
              .HasColumnName("DailyActivityDate");


                entity.Property(e => e.DailyActivityInfo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DailyActivityInfo");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherId");
                entity.Property(e => e.ClassId).HasColumnName("ClassId");


                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ActivityUpdates)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Activity___class__6B24EA82");

                entity.HasOne(d => d.UserTeacher)
                    .WithMany(p => p.ActivityUpdates)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Activity___teacher__6C190EBB");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK__Classes__BF62B0120F430C85");
                entity.ToTable("Classes");

                entity.Property(e => e.ClassId).HasColumnName("ClassId");
                entity.Property(e => e.ClassTypeId).HasColumnName("ClassTypeId");

                entity.Property(e => e.ClassName)
                  .IsRequired()
                  .HasMaxLength(1000)
                  .IsUnicode(false)
                  .HasColumnName("ClassName");


                entity.HasOne(d => d.TypeClass)
                 .WithMany(p => p.Class)
                 .HasForeignKey(d => d.ClassTypeId)
                 .HasConstraintName("FK__class_type__6C190EBB");
            });

            modelBuilder.Entity<DayCare>(entity =>
            {
                entity.HasKey(e => e.IdDayCare)
                    .HasName("PK__day_care__3DDF0F6C2DFCB989");

                entity.ToTable("DayCare");

                entity.Property(e => e.IdDayCare).HasColumnName("IdDayCare");
                entity.Property(e => e.KidId).HasColumnName("KidId");



                entity.Property(e => e.DateCare)
                    .HasColumnType("datetime")
                    .HasColumnName("DateCare");


                entity.Property(e => e.BehaviorDayCare)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("BehaviorDayCare");

                entity.Property(e => e.DressDayCare)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("DressDayCare");

                entity.Property(e => e.CommentDayCare)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CommentDayCare");
                entity.Property(e => e.FoodDayCare)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("FoodDayCare");

                entity.Property(e => e.SleepDayCare)
           .IsRequired()
           .HasMaxLength(1000)
           .IsUnicode(false)
           .HasColumnName("SleepDayCare");


                entity.HasOne(d => d.Kid)
              .WithMany(p => p.DayCare)
              .HasForeignKey(d => d.KidId)
              .HasConstraintName("FK__Activity___KidId__6C190EBB");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__message__3DDF0F6C2DFCB989");

                entity.ToTable("Messages");

                entity.Property(e => e.MessageId).HasColumnName("MessageId");

                entity.Property(e => e.MessageContent)
                    .IsRequired()
                    .HasMaxLength(10000)
                    .IsUnicode(false)
                    .HasColumnName("MessageContent");

                entity.Property(e => e.MessageDateTime).HasColumnType("datetime")
                    .HasColumnName("MessageDateTime");


                entity.Property(e => e.KidId).HasColumnName("KidId");

                entity.Property(e => e.UserFromId).HasColumnName("UserFromId");
                entity.Property(e => e.UserToId).HasColumnName("UserToId");

                entity.HasOne(d => d.Kid)
              .WithMany(p => p.Messages)
              .HasForeignKey(d => d.KidId)
              .HasConstraintName("FK__Activity___Kid_message__6C190EBB");

                entity.HasOne(d => d.UserFrom)
         .WithMany(p => p.MessagesFrom)
         .HasForeignKey(d => d.UserFromId).OnDelete(DeleteBehavior.NoAction)
         .HasConstraintName("FK__Activity___userfrom__6C190EBB");

                entity.HasOne(d => d.UserTo)
      .WithMany(p => p.MessagesTo)
      .HasForeignKey(d => d.UserToId).OnDelete(DeleteBehavior.NoAction)
      .HasConstraintName("FK__Activity___userto__6C190EBC");
            });

            modelBuilder.Entity<Kid>(entity =>
            {
                entity.HasKey(e => e.KidId)
                    .HasName("PK__kids__FB5DFF00013EE552");

                entity.ToTable("Kids");

                entity.Property(e => e.KidId).HasColumnName("KidId");

                entity.Property(e => e.NameKids)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NameKids");

                entity.Property(e => e.AgeKids).HasColumnType("float").HasColumnName("AgeKid");

                entity.Property(e => e.ClassId).HasColumnName("ClassId");

                entity.Property(e => e.DateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("DateBorn");

                entity.Property(e => e.NameKids)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("NameKid");


                entity.Property(e => e.TzKid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TzKid");

                entity.Property(e => e.ParentId).HasColumnName("ParentId");



                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__kids__class_id__60A75C0F");

                entity.HasOne(d => d.UserParent)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__kids__parents_id__619B8048");
            });

            modelBuilder.Entity<KidsAttendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK__kids_att__20D6A96841C11ED2");

                entity.ToTable("KidsAttendance");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceId");

                entity.Property(e => e.IsArrived).HasDefaultValue(true).HasColumnName("IsArrived");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CurrentDate");

                entity.Property(e => e.KidId).HasColumnName("KidId");

                entity.HasOne(d => d.Kid)
                          .WithMany(p => p.KidsAttendance)
                          .HasForeignKey(d => d.KidId)
                          .HasConstraintName("FK__kids__attendance__619B8048");
            });

            modelBuilder.Entity<RecoverLosts>(entity =>
            {
                entity.HasKey(e => e.RecoverLostsId)
                    .HasName("PK__rec__5234F2D4EE33DA1B");

                entity.ToTable("RecoverLosts");

                entity.Property(e => e.RecoverLostsId).HasColumnName("RecoverLostsId");

                entity.Property(e => e.RecoverLostsDate).HasColumnType("datetime").HasColumnName("RecoverLostsDate");
                entity.Property(e => e.RecoverLostsImage)
                  .IsRequired()
                  .HasMaxLength(200)
                  .IsUnicode(false)
                  .HasColumnName("RecoverLostsImage");

                entity.Property(e => e.RecoverLostsInfo)
               .IsRequired()
               .HasMaxLength(1000)
               .IsUnicode(false)
               .HasColumnName("RecoverLostsInfo");

                entity.Property(e => e.IdUser).HasColumnName("IdUser");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RecoverLosts)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__rec__user___5DCAEF64");
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PK__image__5234F2D4EE33DA1B");

                entity.ToTable("Images");

                entity.Property(e => e.ImageId).HasColumnName("ImageId");

                entity.Property(e => e.ImageDate).HasColumnType("datetime").HasColumnName("ImageDate");
                entity.Property(e => e.ImageTitle)
                  .IsRequired()
                  .HasMaxLength(200)
                  .IsUnicode(false)
                  .HasColumnName("ImageTitle");

                entity.Property(e => e.ImageData)
               .IsRequired()
               .HasMaxLength(1000)
               .IsUnicode(false)
               .HasColumnName("ImageData");

                entity.Property(e => e.ImageURL)
           .IsRequired()
           .HasMaxLength(200)
           .IsUnicode(false)
           .HasColumnName("ImageURL");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherId");

                entity.HasOne(d => d.UserTeacher)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__images__user___5DCAEF64");


                entity.Property(e => e.ClassId).HasColumnName("ClassId");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__images__class___5DCAEF64");
            });

            modelBuilder.Entity<ExternalData>(entity =>
            {
                entity.HasKey(e => e.ExternalDataId)
                    .HasName("PK__externaldata__5234F2D4EE33DA1B");

                entity.ToTable("ExternalData");

                entity.Property(e => e.ExternalDataId).HasColumnName("ExternalDataId");

                entity.Property(e => e.ExternalDataDate).HasColumnType("datetime").HasColumnName("ExternalDataDate");
                entity.Property(e => e.ExternalDataLink)
                  .IsRequired()
                  .HasMaxLength(200)
                  .IsUnicode(false)
                  .HasColumnName("ExternalDataLink");

                entity.Property(e => e.ExternalDataTitle)
               .IsRequired()
               .HasMaxLength(200)
               .IsUnicode(false)
               .HasColumnName("ExternalDataTitle");



                entity.Property(e => e.TeacherId).HasColumnName("TeacherId");

                entity.HasOne(d => d.UserTeacher)
                    .WithMany(p => p.ExternalData)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__ext__user___5DCAEF64");


                entity.Property(e => e.ClassId).HasColumnName("ClassId");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ExternalData)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__ext__class___5DCAEF64");
            });


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__user__54384119BEE1AB93");

                entity.ToTable("Users");
                entity.Property(e => e.UserId).HasColumnName("UserId");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeId");
                entity.Property(e => e.Password)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("Password");
                entity.Property(e => e.UserTz)
                 .IsRequired()
                 .HasMaxLength(10)
                 .IsUnicode(false)
                 .HasColumnName("UserTz");
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserName");

                entity.Property(e => e.PhoneNamber1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PhoneNamber1");

                entity.Property(e => e.PhoneNamber2)
                    .IsRequired(false)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PhoneNamber2");

                entity.Property(e => e.ClassId).HasColumnName("ClassId");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeacherUsers)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__exte__class___5DCAEF64");

            });

            modelBuilder.Entity<PlacementOfATeacher>(entity =>
            {
                entity.HasKey(e => e.IdPlacementOfATeacher)
                    .HasName("PK__placemen__EC1AB144B1E88409");

                entity.ToTable("PlacementOfATeacher");

                entity.Property(e => e.IdPlacementOfATeacher).HasColumnName("IdPlacementOfATeacher");

                entity.Property(e => e.DayInWeek1M).HasColumnName("DayInWeek1M");
                entity.Property(e => e.DayInWeek1A).HasColumnName("DayInWeek1A");

                entity.Property(e => e.DayInWeek2M).HasColumnName("DayInWeek2M");

                entity.Property(e => e.DayInWeek2A).HasColumnName("DayInWeek2A");

                entity.Property(e => e.DayInWeek3M).HasColumnName("DayInWeek3M");
                entity.Property(e => e.DayInWeek3A).HasColumnName("DayInWeek3A");
                entity.Property(e => e.DayInWeek4M).HasColumnName("DayInWeek4M");
                entity.Property(e => e.DayInWeek4A).HasColumnName("DayInWeek4A");
                entity.Property(e => e.DayInWeek5M).HasColumnName("DayInWeek5M");
                entity.Property(e => e.DayInWeek5A).HasColumnName("DayInWeek5A");
                entity.Property(e => e.DayInWeek6M).HasColumnName("DayInWeek6M");



                entity.Property(e => e.TeacherId)
                  .HasColumnName("TeacherId");




                entity.HasOne(d => d.UserTeacher)
                    .WithMany(p => p.PlacementOfATeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__placement__teach__68487DD7");
            });


            modelBuilder.Entity<TypeClass>(entity =>
            {
                entity.HasKey(e => e.IdTypeClass)
                    .HasName("PK__type_cla__D21A678A5C59ED67");

                entity.ToTable("TypeClass");

                entity.Property(e => e.IdTypeClass).HasColumnName("IdTypeClass");


                entity.Property(e => e.TypeClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TypeClassName");


            });



            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
