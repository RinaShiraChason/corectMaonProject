using System;
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
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PlacementOfATeacher> PlacementOfATeachers { get; set; }
        public virtual DbSet<TeacherAndManager> TeacherAndManagers { get; set; }
        public virtual DbSet<TypeClass> TypeClasses { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-FKUPS69\\SQLEXPRESS;Initial Catalog=newMaon;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<ActivityUpdate>(entity =>
            {
                entity.HasKey(e => e.IdActivityUpdate)
                    .HasName("PK__Activity__BF62B0120F430C85");

                entity.ToTable("Activity_Update");

                entity.Property(e => e.IdActivityUpdate).HasColumnName("id_Activity_Update");

                entity.Property(e => e.Calendar)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("calendar");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DailyActivity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Daily_Activity");

                entity.Property(e => e.LostSabbath)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("lost_sabbath");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.WeeklyColumn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("weekly_column");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ActivityUpdates)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Activity___class__6B24EA82");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.ActivityUpdates)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Activity___teach__6C190EBB");
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("classes");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.KindOfClassId).HasColumnName("kindOfClass_id");
            });

            modelBuilder.Entity<DayCare>(entity =>
            {
                entity.HasKey(e => e.IdDayCare)
                    .HasName("PK__day_care__3DDF0F6C2DFCB989");

                entity.ToTable("day_care");

                entity.Property(e => e.IdDayCare).HasColumnName("id_day_care");

                entity.Property(e => e.AboutDayCare)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("about_day_care");

                entity.Property(e => e.DressDayCare)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dress_day_care");

                entity.Property(e => e.NameDayCare)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("name_day_care");

                entity.Property(e => e.NumClasses).HasColumnName("num_classes");
            });

            modelBuilder.Entity<Kid>(entity =>
            {
                entity.HasKey(e => e.TzKids)
                    .HasName("PK__kids__FB5DFF00013EE552");

                entity.ToTable("kids");

                entity.Property(e => e.TzKids).HasColumnName("tz_kids");

                entity.Property(e => e.AgeKids)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("age_kids");

                entity.Property(e => e.AttendanceId).HasColumnName("attendance_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DateBorn)
                    .HasColumnType("date")
                    .HasColumnName("date_born");

                entity.Property(e => e.NameKids)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("name_kids");

                entity.Property(e => e.ParentsId).HasColumnName("parents_id");

                entity.HasOne(d => d.Attendance)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.AttendanceId)
                    .HasConstraintName("FK__kids__attendance__628FA481");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__kids__class_id__60A75C0F");

                entity.HasOne(d => d.Parents)
                    .WithMany(p => p.Kids)
                    .HasForeignKey(d => d.ParentsId)
                    .HasConstraintName("FK__kids__parents_id__619B8048");
            });

            modelBuilder.Entity<KidsAttendance>(entity =>
            {
                entity.HasKey(e => e.AttendanceId)
                    .HasName("PK__kids_att__20D6A96841C11ED2");

                entity.ToTable("kids_attendance");

                entity.Property(e => e.AttendanceId).HasColumnName("attendance_id");

                entity.Property(e => e.Check).HasColumnName("check_");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("date")
                    .HasColumnName("currentDate");

                entity.Property(e => e.KidId).HasColumnName("kid_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.ParentsId)
                    .HasName("PK__parents__5234F2D4EE33DA1B");

                entity.ToTable("parents");

                entity.Property(e => e.ParentsId).HasColumnName("parents_id");

                entity.Property(e => e.ParentsTz).HasColumnName("parents_tz");

                entity.Property(e => e.PersonTz).HasColumnName("person_tz");

                entity.HasOne(d => d.PersonTzNavigation)
                    .WithMany(p => p.Parents)
                    .HasForeignKey(d => d.PersonTz)
                    .HasConstraintName("FK__parents__person___5DCAEF64");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PersonTz)
                    .HasName("PK__person__54384119BEE1AB93");

                entity.ToTable("person");

                entity.Property(e => e.PersonTz).HasColumnName("person_tz");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("person_name");

                entity.Property(e => e.PhoneNamber1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("phone_namber1");

                entity.Property(e => e.PhoneNamber2)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("phone_namber2");
            });

            modelBuilder.Entity<PlacementOfATeacher>(entity =>
            {
                entity.HasKey(e => e.IdPlacementOfATeacher)
                    .HasName("PK__placemen__EC1AB144B1E88409");

                entity.ToTable("placement_of_a_teacher");

                entity.Property(e => e.IdPlacementOfATeacher).HasColumnName("id_placement_of_a_teacher");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.DateShifts)
                    .HasColumnType("date")
                    .HasColumnName("date_shifts");

                entity.Property(e => e.Shifts)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("shifts");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.PlacementOfATeachers)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__placement__class__6754599E");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.PlacementOfATeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__placement__teach__68487DD7");
            });

            modelBuilder.Entity<TeacherAndManager>(entity =>
            {
                entity.HasKey(e => e.TeacherId)
                    .HasName("PK__teacherA__03AE777E2AD54AB3");

                entity.ToTable("teacherAndManager");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.PersonTz).HasColumnName("person_tz");

                entity.Property(e => e.TeacherTz).HasColumnName("teacher_tz");

                entity.HasOne(d => d.PersonTzNavigation)
                    .WithMany(p => p.TeacherAndManagers)
                    .HasForeignKey(d => d.PersonTz)
                    .HasConstraintName("FK__teacherAn__perso__5629CD9C");
            });

            modelBuilder.Entity<TypeClass>(entity =>
            {
                entity.HasKey(e => e.IdTypeClass)
                    .HasName("PK__type_cla__D21A678A5C59ED67");

                entity.ToTable("type_class");

                entity.Property(e => e.IdTypeClass).HasColumnName("id_type_class");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.TypeClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_class_name");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TypeClasses)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__type_clas__class__5165187F");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.HasKey(e => e.IdTypeEmp)
                    .HasName("PK__type_emp__B3A8697D630008FA");

                entity.ToTable("type_employee");

                entity.Property(e => e.IdTypeEmp).HasColumnName("id_type_emp");

                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.Property(e => e.TypeEmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_emp_name");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TypeEmployees)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__type_empl__teach__59063A47");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
