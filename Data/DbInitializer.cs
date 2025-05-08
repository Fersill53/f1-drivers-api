using F1DriversApi.Models;

namespace F1DriversApi.Data

    {
        public class DbInitializer
        {
            public static void Initialize(AppDbContext context)
            {

                context.Database.EnsureCreated();

                if (context.Drivers.Any())
                {
                    context.Drivers.RemoveRange(context.Drivers);
                    context.SaveChanges();
                }
                    
                
                var drivers = new Driver[]    
                {
                    new Driver { 
                        Id = 1, 
                        CarNumber = 1, 
                        Name = "Max Verstappen", 
                        Team = "Red Bull Racing", 
                        Country = "Netherlands", 
                        Points = 575,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684240/new-official-driver-portraits-for-2024-v0-ewp9tf9lyljc1_wnevtg.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722388/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F1696c7f2-68b7-4c95-a1da-4eee18b28726_1920x1080_iziav8.jpg"
                        },

                    new Driver { 
                        Id = 2, 
                        CarNumber = 11, 
                        Name = "Sergio Perez", 
                        Team = "Red Bull Racing", 
                        Country = "Mexico", 
                        Points = 285,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684269/new-official-driver-portraits-for-2024-v0-kvi5xnhryljc1_ev6d63.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722388/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F1696c7f2-68b7-4c95-a1da-4eee18b28726_1920x1080_iziav8.jpg"
                        },

                    new Driver { 
                        Id = 3, 
                        CarNumber = 16, 
                        Name = "Charles Leclerc", 
                        Team = "Ferrari", 
                        Country = "Monaco", 
                        Points = 206,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684296/new-official-driver-portraits-for-2024-v0-h98uws9lyljc1_mjqktj.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722355/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F21fba559-d080-4da7-b80b-1285231f3591_4000x2250_qyhzmi.jpg"
                        },

                    new Driver { 
                        Id = 4, 
                        CarNumber = 55, 
                        Name = "Carlos Sainz", 
                        Team = "Ferrari", 
                        Country = "Spain", 
                        Points = 200,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684305/new-official-driver-portraits-for-2024-v0-6mhjar9lyljc1_lskltk.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722355/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F21fba559-d080-4da7-b80b-1285231f3591_4000x2250_qyhzmi.jpg"
                        },

                    new Driver { 
                        Id = 5, 
                        CarNumber = 63, 
                        Name = "George Russell", 
                        Team = "Mercedes", 
                        Country = "UK", 
                        Points = 175,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684288/new-official-driver-portraits-for-2024-v0-1e7jwkdbyljc1_oz6nhi.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722371/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2Fa4733728-f3b8-47ec-899e-693c16903faa_2000x2500_axhtp6.jpg"
                        },

                    new Driver { 
                        Id = 6, 
                        CarNumber = 44, 
                        Name = "Lewis Hamilton", 
                        Team = "Mercedes", 
                        Country = "UK", 
                        Points = 234,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684279/new-official-driver-portraits-for-2024-v0-df3obmdbyljc1_fbcqy3.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722371/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2Fa4733728-f3b8-47ec-899e-693c16903faa_2000x2500_axhtp6.jpg"
                        },

                    new Driver { 
                        Id = 7, 
                        CarNumber = 4, 
                        Name = "Lando Norris", 
                        Team = "McLaren", 
                        Country = "UK", 
                        Points = 205,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684316/new-official-driver-portraits-for-2024-v0-jl8pmdz9zljc1_tbnjb6.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722199/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F6505b767-c2be-4b9e-a5f3-45fc1ad48b72_3276x4096_ktok8k.jpg"
                        },

                    new Driver { 
                        Id = 8, 
                        CarNumber = 81, 
                        Name = "Oscar Piastri", 
                        Team = "McLaren", 
                        Country = "Australia", 
                        Points = 97,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684324/new-official-driver-portraits-for-2024-v0-ghzl28z9zljc1_cdrbtf.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722199/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F6505b767-c2be-4b9e-a5f3-45fc1ad48b72_3276x4096_ktok8k.jpg"
                        },

                    new Driver { 
                        Id = 9, 
                        CarNumber = 14, 
                        Name = "Fernando Alonso", 
                        Team = "Aston Martin", 
                        Country = "Spain", 
                        Points = 132,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684332/new-official-driver-portraits-for-2024-v0-sg7159z9zljc1_zkox1g.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722336/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F4dc481f7-69bb-49e7-a59a-a1669b4de96a_1200x675_a3gnqa.jpg"
                        },

                    new Driver { 
                        Id = 10, 
                        CarNumber = 18, 
                        Name = "Lance Stroll", 
                        Team = "Aston Martin", 
                        Country = "Canada", 
                        Points = 74,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684342/new-official-driver-portraits-for-2024-v0-aewbr6yezljc1_wxpzt2.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722336/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F4dc481f7-69bb-49e7-a59a-a1669b4de96a_1200x675_a3gnqa.jpg"
                        },

                    new Driver { 
                        Id = 11, 
                        CarNumber = 31, 
                        Name = "Esteban Ocon", 
                        Team = "Alpine", 
                        Country = "France", 
                        Points = 58,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684359/new-official-driver-portraits-for-2024-v0-p1010bz9zljc1_tp2laa.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722305/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2Fda6bfa7b-5646-49cb-ae19-80e7545d3892_1440x1800_efz10t.jpg"
                        },

                    new Driver { 
                        Id = 12, 
                        CarNumber = 10, 
                        Name = "Pierre Gasly", 
                        Team = "Alpine", 
                        Country = "France", 
                        Points = 62,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684352/new-official-driver-portraits-for-2024-v0-je0nnbz9zljc1_qsjgk3.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722305/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2Fda6bfa7b-5646-49cb-ae19-80e7545d3892_1440x1800_efz10t.jpg"
                        },

                    new Driver { 
                        Id = 13, 
                        CarNumber = 20, 
                        Name = "Kevin Magnussen", 
                        Team = "Haas", 
                        Country = "Denmark", 
                        Points =14,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684434/new-official-driver-portraits-for-2024-v0-bj52zn9lyljc1_cams29.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722235/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2Fde7c60aa-d7be-40bf-8aa8-ba8906a967ac_1500x1500_ppp8wy.jpg"
                        },

                    new Driver { 
                        Id = 14, 
                        CarNumber = 27, 
                        Name = "Nico Hulkenberg", 
                        Team = "Haas", 
                        Country = "Germany", 
                        Points = 18,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684426/new-official-driver-portraits-for-2024-v0-pjm9wnhryljc1_t4kx6a.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722235/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2Fde7c60aa-d7be-40bf-8aa8-ba8906a967ac_1500x1500_ppp8wy.jpg"
                        },

                    new Driver { 
                        Id = 15, 
                        CarNumber = 24, 
                        Name = "Zhou Guanyu", 
                        Team = "Stake F1", 
                        Country = "China", 
                        Points = 6,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684853/zhou_ntfger.png",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722280/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F916f237f-6c21-4ffe-a77f-13198b3712e2_2560x1440_x8uc6u.jpg"
                        },

                    new Driver { 
                        Id = 16, 
                        CarNumber = 77,
                         Name = "Valtieri Bottas", 
                         Team = "Stake F1", 
                         Country = "Finland", 
                         Points = 10,
                         DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684805/bottas_iztrtv.png",
                         CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722280/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F916f237f-6c21-4ffe-a77f-13198b3712e2_2560x1440_x8uc6u.jpg"
                         },

                    new Driver { 
                        Id = 17, 
                        CarNumber = 22, 
                        Name = "Yuki Tsunoda", 
                        Team = "RB", 
                        Country = "Japan", 
                        Points = 45,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684393/new-official-driver-portraits-for-2024-v0-c9u2so9lyljc1_n7ku5j.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722321/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F89e8585a-c07f-446c-8244-6c27d17a2768_1000x563_finlzl.jpg"
                        },

                    new Driver { 
                        Id = 18, 
                        CarNumber = 3,
                         Name = "Daniel Ricciardo", 
                         Team = "RB", 
                         Country = "Australia", 
                         Points = 20,
                         DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684401/new-official-driver-portraits-for-2024-v0-wdglem9lyljc1_vg2dro.jpg",
                         CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722321/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F89e8585a-c07f-446c-8244-6c27d17a2768_1000x563_finlzl.jpg"
                         },

                    new Driver { 
                        Id = 19, 
                        CarNumber = 2, 
                        Name = "Logan Sargent", 
                        Team = "Williams", 
                        Country = "USA", 
                        Points = 1,
                        DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684382/new-official-driver-portraits-for-2024-v0-zuuvjldbyljc1_usw4sk.jpg",
                        CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722249/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F206745d4-8b46-43df-a7dc-b8150d13ec2b_1000x667_st8dep.jpg"
                        },

                    new Driver { 
                        Id = 20, 
                        CarNumber = 23,
                         Name = "Alexander Albon", 
                         Team = "Williams", 
                         Country = "Thailand", 
                         Points = 15,
                         DriverPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746684368/new-official-driver-portraits-for-2024-v0-o0t2zldbyljc1_hap0xg.jpg",
                         CarPhotoUrl = "https://res.cloudinary.com/dk3sjxwul/image/upload/v1746722249/https_3A_2F_2Fsubstack-post-media.s3.amazonaws.com_2Fpublic_2Fimages_2F206745d4-8b46-43df-a7dc-b8150d13ec2b_1000x667_st8dep.jpg"
                         }
                };

                context.Drivers.AddRange(drivers);
                context.SaveChanges();     

            }
        }
    }