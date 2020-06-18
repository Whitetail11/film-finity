﻿// <auto-generated />
using System;
using Entities.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(FilmFinityDbContext))]
    partial class FilmFinityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.CelebrityJobTitles", b =>
                {
                    b.Property<int>("CelebrityId")
                        .HasColumnType("int");

                    b.Property<int>("JobTitleId")
                        .HasColumnType("int");

                    b.HasKey("CelebrityId", "JobTitleId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("CelebrityJobTitles");

                    b.HasData(
                        new
                        {
                            CelebrityId = -1,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -2,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -2,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -3,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -3,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -4,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -4,
                            JobTitleId = 2
                        },
                        new
                        {
                            CelebrityId = -4,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -5,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -5,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -6,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -6,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 2
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 3
                        },
                        new
                        {
                            CelebrityId = -7,
                            JobTitleId = 4
                        },
                        new
                        {
                            CelebrityId = -8,
                            JobTitleId = 5
                        },
                        new
                        {
                            CelebrityId = -9,
                            JobTitleId = 6
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 1
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 2
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 3
                        },
                        new
                        {
                            CelebrityId = -10,
                            JobTitleId = 4
                        });
                });

            modelBuilder.Entity("Entities.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountViews")
                        .HasColumnType("int");

                    b.Property<string>("PreviewImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.",
                            CountViews = 233,
                            PreviewImage = "StaticFiles/images/News/1.jfif",
                            PublishTime = new DateTime(2020, 6, 18, 21, 20, 30, 668, DateTimeKind.Local).AddTicks(3052),
                            Title = "Сиквел «Чудо-женщины» перенесли из-за коронавируса"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.",
                            CountViews = 512,
                            PreviewImage = "StaticFiles/images/News/2.jfif",
                            PublishTime = new DateTime(2020, 6, 18, 21, 20, 30, 671, DateTimeKind.Local).AddTicks(8295),
                            Title = "Childish Gambino официально опубликовал новый альбом"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Content = "В Сети появился трейлер второго сезона анимационного сериала DС «Харли Квинн». В центре сюжета вновь окажется Харли Квинн и её команда антигероев. После того, как героиня... расстаётся с Джокером, она становится самостоятельной единицей преступного мира и наводит.Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.",
                            CountViews = 237,
                            PreviewImage = "StaticFiles/images/News/3.jfif",
                            PublishTime = new DateTime(2020, 6, 18, 21, 20, 30, 671, DateTimeKind.Local).AddTicks(8340),
                            Title = "Больше, жестче, грубее: Вышел трейлер второго сезона «Харли Квинн»"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            Content = "«Фильм Про» впервые обнародовал Абсолютный топ продаж российских онлайн-кинотеатров и видеосервисов. В условиях, когда из-за коронавируса домашний просмотр набирает популярность, «Фильм Про» первым среди профессиональных киноизданий ",
                            CountViews = 878,
                            PreviewImage = "StaticFiles/images/News/4.jfif",
                            PublishTime = new DateTime(2020, 6, 18, 21, 20, 30, 671, DateTimeKind.Local).AddTicks(8345),
                            Title = "Фильмы онлайн: Абсолютный топ «Фильм Про»"
                        });
                });

            modelBuilder.Entity("Entities.Models.NewsAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Мария",
                            LastName = "Колосова"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Пабло",
                            LastName = "Мироненко"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Мия",
                            LastName = "Набу"
                        });
                });

            modelBuilder.Entity("Entities.Models.NewsCategories", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "NewsId");

                    b.HasIndex("NewsId");

                    b.ToTable("NewsCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            NewsId = 1
                        },
                        new
                        {
                            CategoryId = 2,
                            NewsId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            NewsId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            NewsId = 3
                        },
                        new
                        {
                            CategoryId = 1,
                            NewsId = 4
                        });
                });

            modelBuilder.Entity("Entities.Models.NewsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Variety"
                        },
                        new
                        {
                            Id = 2,
                            Name = "FilmNews"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Celebrity", b =>
                {
                    b.Property<int>("CelebrityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountViews")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CelebrityId");

                    b.ToTable("Celebrities");

                    b.HasData(
                        new
                        {
                            CelebrityId = -1,
                            CountViews = 134000,
                            FirstName = "Хью",
                            ImageSource = "StaticFiles/images/1.jpg",
                            LastName = "Джекман"
                        },
                        new
                        {
                            CelebrityId = -2,
                            CountViews = 127000,
                            FirstName = "Райан",
                            ImageSource = "StaticFiles/images/2.jpg",
                            LastName = "Рейнольдс"
                        },
                        new
                        {
                            CelebrityId = -3,
                            CountViews = 126000,
                            FirstName = "Роберт",
                            ImageSource = "StaticFiles/images/3.jpg",
                            LastName = "Дауни (младший)"
                        },
                        new
                        {
                            CelebrityId = -4,
                            CountViews = 121000,
                            FirstName = "Уилл",
                            ImageSource = "StaticFiles/images/4.jpg",
                            LastName = "Смит"
                        },
                        new
                        {
                            CelebrityId = -5,
                            CountViews = 120500,
                            FirstName = "Брэд",
                            ImageSource = "StaticFiles/images/5.jpg",
                            LastName = "Питт"
                        },
                        new
                        {
                            CelebrityId = -6,
                            CountViews = 120000,
                            FirstName = "Леонардо",
                            ImageSource = "StaticFiles/images/6.jpg",
                            LastName = "Ди Каприо"
                        },
                        new
                        {
                            CelebrityId = -7,
                            CountViews = 91000,
                            FirstName = "Натали",
                            ImageSource = "StaticFiles/images/7.jpg",
                            LastName = "Портман"
                        },
                        new
                        {
                            CelebrityId = -8,
                            CountViews = 20000,
                            FirstName = "Роджер",
                            ImageSource = "StaticFiles/images/8.jpg",
                            LastName = "Дикинс"
                        },
                        new
                        {
                            CelebrityId = -9,
                            CountViews = 50000,
                            FirstName = "Ханс",
                            ImageSource = "StaticFiles/images/9.png",
                            LastName = "Циммер"
                        },
                        new
                        {
                            CelebrityId = -10,
                            CountViews = 95000,
                            FirstName = "Квентин",
                            ImageSource = "StaticFiles/images/10.jpg",
                            LastName = "Тарантино"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitles");

                    b.HasData(
                        new
                        {
                            JobTitleId = 1,
                            JobName = "актер"
                        },
                        new
                        {
                            JobTitleId = 2,
                            JobName = "режиссер"
                        },
                        new
                        {
                            JobTitleId = 3,
                            JobName = "сценарист"
                        },
                        new
                        {
                            JobTitleId = 4,
                            JobName = "продюсер"
                        },
                        new
                        {
                            JobTitleId = 5,
                            JobName = "оператор"
                        },
                        new
                        {
                            JobTitleId = 6,
                            JobName = "композитор"
                        });
                });

            modelBuilder.Entity("Entities.Models.CelebrityJobTitles", b =>
                {
                    b.HasOne("WebAPI.Models.Celebrity", "Celebrity")
                        .WithMany("CelebrityJobTitles")
                        .HasForeignKey("CelebrityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.JobTitle", "JobTitle")
                        .WithMany("CelebrityJobTitles")
                        .HasForeignKey("JobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.News", b =>
                {
                    b.HasOne("Entities.Models.NewsAuthor", "Author")
                        .WithMany("News")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.NewsCategories", b =>
                {
                    b.HasOne("Entities.Models.NewsCategory", "Category")
                        .WithMany("NewsCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.News", "News")
                        .WithMany("NewsCategories")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
