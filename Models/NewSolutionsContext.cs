using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Core_NewSolutions.ViewModel;
using Core_NewSolutions.Models;

#nullable disable

namespace Core_NewSolutions.Models
{
    public partial class NewSolutionsContext : IdentityDbContext<ApplicationUser>
    {
        public NewSolutionsContext()
        {
        }

        public NewSolutionsContext(DbContextOptions<NewSolutionsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutSection1> AboutSection1s { get; set; }
        public virtual DbSet<AboutSection2> AboutSection2s { get; set; }
        public virtual DbSet<AboutSection3> AboutSection3s { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientImgUrl> ClientImgUrls { get; set; }
        public virtual DbSet<ClientsSection1> ClientsSection1s { get; set; }
        public virtual DbSet<ContactsSection1> ContactsSection1s { get; set; }
        public virtual DbSet<ContactsSocialMedium> ContactsSocialMedia { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeImgUrl> EmployeeImgUrls { get; set; }
        public virtual DbSet<HomeSection1> HomeSection1s { get; set; }
        public virtual DbSet<HomeSection2> HomeSection2s { get; set; }
        public virtual DbSet<HomeSection3> HomeSection3s { get; set; }
        public virtual DbSet<HomeSection4> HomeSection4s { get; set; }
        public virtual DbSet<HomeSection4Card1> HomeSection4Card1s { get; set; }
        public virtual DbSet<HomeSection4Card2> HomeSection4Card2s { get; set; }
        public virtual DbSet<HomeSection4Card3> HomeSection4Card3s { get; set; }
        public virtual DbSet<HomeSection5> HomeSection5s { get; set; }
        public virtual DbSet<HomeSection6> HomeSection6s { get; set; }
        public virtual DbSet<HomeSection7> HomeSection7s { get; set; }
        public virtual DbSet<HomeSection7Slider1> HomeSection7Slider1s { get; set; }
        public virtual DbSet<HomeSection7Slider2> HomeSection7Slider2s { get; set; }
        public virtual DbSet<ProjectImgUrl> ProjectImgUrls { get; set; }
        public virtual DbSet<ProjectsSection1> ProjectsSection1s { get; set; }
        public virtual DbSet<UploadProject> UploadProjects { get; set; }
        public virtual DbSet<Blogs> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=NewSolutions;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<AboutSection1>(entity =>
            {
                entity.ToTable("about_section1", "about");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1).HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2).HasColumnName("big_title2");

                entity.Property(e => e.DetailsBold).HasColumnName("details_bold");

                entity.Property(e => e.DetailsRegular).HasColumnName("details_regular");

                entity.Property(e => e.SmallTitle).HasColumnName("small_title");

                entity.Property(e => e.VideoLink).HasColumnName("video_link");
            });

            modelBuilder.Entity<AboutSection2>(entity =>
            {
                entity.ToTable("about_section2", "about");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.SmallTitle1)
                    .HasColumnName("small_title1");

                entity.Property(e => e.SmallTitle2)
                    .HasColumnName("small_title2");
            });

            modelBuilder.Entity<AboutSection3>(entity =>
            {
                entity.ToTable("about_section3", "about");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients", "clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FacebookUrl)
                    .HasColumnName("facebook_url");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.InstegramUrl)
                    .HasColumnName("instegram_url");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("job_title");

                entity.Property(e => e.LinkedInUrl)
                    .HasColumnName("linked_in_url");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.TwitterUrl)
                    .HasColumnName("twitter_url");
            });

            modelBuilder.Entity<ClientImgUrl>(entity =>
            {
                entity.ToTable("Client_Img_Url", "clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<ClientsSection1>(entity =>
            {
                entity.ToTable("clients_section1", "clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<ContactsSection1>(entity =>
            {
                entity.ToTable("contacts_section1", "contacts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.Email)
                    .HasColumnName("email");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<ContactsSocialMedium>(entity =>
            {
                entity.ToTable("contacts_social_media", "contacts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TwitterUrl)
                    .HasColumnName("twitter_url");

                entity.Property(e => e.FacebookUrl)
                    .HasColumnName("facebook_url");

                entity.Property(e => e.LinkedInUrl)
                    .HasColumnName("linked_in_url");

                entity.Property(e => e.InstegramUrl)
                    .HasColumnName("instegram_url");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FacebookUrl)
                    .HasColumnName("facebook_url");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.InstegramUrl)
                    .HasColumnName("instegram_url");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("job_title");

                entity.Property(e => e.LinkedInUrl)
                    .HasColumnName("linked_in_url");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.TwitterUrl)
                    .HasColumnName("twitter_url");
            });

            modelBuilder.Entity<EmployeeImgUrl>(entity =>
            {
                entity.ToTable("Employee_Img_Url");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<HomeSection1>(entity =>
            {
                entity.ToTable("home_section1", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection2>(entity =>
            {
                entity.ToTable("home_section2", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection3>(entity =>
            {
                entity.ToTable("home_section3", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveClients).HasColumnName("active_clients");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.GloriousYears).HasColumnName("glorious_years");

                entity.Property(e => e.ProjectsDone).HasColumnName("projects_done");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");

                entity.Property(e => e.TeamAdvisors).HasColumnName("team_advisors");
            });

            modelBuilder.Entity<HomeSection4>(entity =>
            {
                entity.ToTable("home_section4", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection4Card1>(entity =>
            {
                entity.ToTable("home_section4_card1", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardDetails).HasColumnName("card_details");

                entity.Property(e => e.CardFooter1)
                    .HasColumnName("card_footer1");

                entity.Property(e => e.CardFooter2)
                    .HasColumnName("card_footer2");

                entity.Property(e => e.CardFooter3)
                    .HasColumnName("card_footer3");

                entity.Property(e => e.CardTitle)
                    .HasColumnName("card_title");
            });

            modelBuilder.Entity<HomeSection4Card2>(entity =>
            {
                entity.ToTable("home_section4_card2", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardDetails).HasColumnName("card_details");

                entity.Property(e => e.CardFooter1)
                    .HasColumnName("card_footer1");

                entity.Property(e => e.CardFooter2)
                    .HasColumnName("card_footer2");

                entity.Property(e => e.CardFooter3)
                    .HasColumnName("card_footer3");

                entity.Property(e => e.CardTitle)
                    .HasColumnName("card_title");
            });

            modelBuilder.Entity<HomeSection4Card3>(entity =>
            {
                entity.ToTable("home_section4_card3", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardDetails).HasColumnName("card_details");

                entity.Property(e => e.CardFooter1)
                    .HasColumnName("card_footer1");

                entity.Property(e => e.CardFooter2)
                    .HasColumnName("card_footer2");

                entity.Property(e => e.CardFooter3)
                    .HasColumnName("card_footer3");

                entity.Property(e => e.CardTitle)
                    .HasColumnName("card_title");
            });

            modelBuilder.Entity<HomeSection5>(entity =>
            {
                entity.ToTable("home_section5", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection6>(entity =>
            {
                entity.ToTable("home_section6", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection7>(entity =>
            {
                entity.ToTable("home_section7", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection7Slider1>(entity =>
            {
                entity.ToTable("home_section7_slider1", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle)
                    .HasColumnName("big_title");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<HomeSection7Slider2>(entity =>
            {
                entity.ToTable("home_section7_slider2", "home");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle)
                    .HasColumnName("big_title");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<ProjectImgUrl>(entity =>
            {
                entity.ToTable("Project_Img_Url", "projects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<ProjectsSection1>(entity =>
            {
                entity.ToTable("projects_section1", "projects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle1)
                    .HasColumnName("big_title1");

                entity.Property(e => e.BigTitle2)
                    .HasColumnName("big_title2");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_title");
            });

            modelBuilder.Entity<UploadProject>(entity =>
            {
                entity.ToTable("upload_project", "projects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BigTitle)
                    .HasColumnName("big_Title");

                entity.Property(e => e.Category)
                    .HasColumnName("category");

                entity.Property(e => e.ImageUrl).HasColumnName("image_url");

                entity.Property(e => e.SmallTitle)
                    .HasColumnName("small_Title");
            });

            //OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
