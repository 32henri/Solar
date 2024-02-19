using TARpe22MauiPlanets.Models;

namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name =   "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name =   "Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is sometimes " +
                "called Earth's \"sister\" or \"twin\" planet as it is almost as large " +
                "and has a similar composition. As an interior planet to Earth, Venus " +
                "(like Mercury) appears in Earth's sky never far from the Sun, either as " +
                "morning star or evening star. Aside from the Sun and Moon, Venus is the " +
                "brightest natural object in Earth's sky, capable of casting visible " +
                "shadows on Earth in dark conditions and being visible to the naked eye " +
                "in broad daylight.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/09/Venus.jpg?w=4096&format=jpeg",
                    "https://www.nasa.gov/wp-content/uploads/2023/02/1_venus-corona-1041.jpg?w=4096&format=jpeg",
                    "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJtj54J5oUbL5Qd7k7pCL1x8svYGw_BK_04ug3CF7axoECxVDUCPa_a49rinbSXLhTMAo&usqp=CAU",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name =   "Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the " +
                "only place known in the universe where life has originated and " +
                "found habitability. While Earth may not contain the largest " +
                "volumes of water in the Solar System, only Earth sustains liquid " +
                "surface water, extending over 70.8% of the Earth with its ocean, " +
                "making Earth an ocean world. Earth's polar regions currently " +
                "retain most of all other water with large sheets of ice covering " +
                "ocean and land, dwarfing Earth's groundwater, lakes, rivers and " +
                "atmospheric water.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

            new()
            {
                Name = "  Mars",
                Subtitle = "  The iron planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun – a dusty, " +
                            "cold, desert world with a very thin atmosphere. " +
                            "Mars is also a dynamic planet with seasons, polar " +
                            "ice caps, canyons, extinct volcanoes, and evidence " +
                            "that it was even more active in the past.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = "  Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and " +
                "the largest in the Solar System. It is a gas giant with " +
                "a mass more than two and a half times that of all the " +
                "other planets in the Solar System combined, and slightly " +
                "less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://images.delfi.ee/media-api-image-cropper/v1/54dd75e0-b7dc-11eb-b2a3-a99842433e6e.jpg?noup&w=1200&h=711&ch=0.687&cw=1&cx=0&cy=0.0931&r=16:9",
                    "https://images.newscientist.com/wp-content/uploads/2019/05/21162807/pia21978.jpg?width=800"
                }
            },

            new()
            {
                Name = "  Saturn",
                Subtitle = "  The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/800px-Saturn_during_Equinox.jpg",
                    "https://starwalk.space/gallery/images/saturn-planet-guide/1920x1080.jpg",
                    "https://images.squarespace-cdn.com/content/v1/5fa5ec79661ee904d2973ca0/1678740394793-H2ZM9W2E8WFYUOCVFDHY/saturn.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = "  Uranus",
                Subtitle = "  The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                "It is named after Greek sky deity Uranus (Caelus), who in " +
                "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                "has the third-largest planetary radius and fourth-largest " +
                "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://imageio.forbes.com/specials-images/imageserve/5f91806c76fcfa4a1e885d7c/Uranus-will-this-week-be-easy-to-see-for-one-night-only-just-north-of-a-crescent/960x0.jpg?format=jpg&width=960",
                    "https://hips.hearstapps.com/hmg-prod/images/uranus-1585338466.jpg?resize=640:*",
                    "https://i.guim.co.uk/img/media/cfaf66fa2f6eace8b572cdeec88eb737a220d21d/0_112_4587_2752/master/4587.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=34fcc81f34b0a1f5950f11495b69a439"
                }
            },

            new()
            {
                Name = "  Neptune",
                Subtitle = " The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                "the farthest known planet in the Solar System. It is the " +
                "fourth-largest planet in the Solar System by diameter, the " +
                "third-most-massive planet, and the densest giant planet. " +
                "It is 17 times the mass of Earth, and slightly more " +
                "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/cLrku7C3dzwjtD4vYBYPvH-1200-80.jpg",
                    "https://study.com/cimages/multimages/16/bigblueboi4dcafa81-8718-40a0-a4fb-c84c86495e22.jpg",
                    "https://img-aws.ehowcdn.com/360x267p/s3-us-west-1.amazonaws.com/contentlab.studiod/getty/cf0ffa37c3004b5b8e850c882d4d6d20.jpg"
                }
            },

            new()
            {
                Name = "  Pluto",
                Subtitle = "Fake planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet located in a distant region of our solar system beyond Neptune known as the Kuiper Belt. " +
                "Pluto was long considered our ninth planet, but the International Astronomical Union reclassified Pluto as a dwarf planet in 2006. " +
                "NASA's New Horizons was the first spacecraft to explore Pluto up close, " +
                "flying by the dwarf planet and its moons in 2015. " +
                "It found that Pluto is a complex world with mountains, valleys, plains, " +
                "craters, and apparently even glaciers.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://cdn.uanews.arizona.edu/s3fs-public/styles/uaqs_large/public/story-images/Pluto%20whole%20color.png?itok=ytlG1fwV",
                    "https://cdn.britannica.com/41/202741-050-7AC6775D/Close-up-mountains-plains-spacecraft-Pluto-New-Horizons.jpg",
                    "https://cdn.mos.cms.futurecdn.net/XbGFufdJcjcF9pZtgcRwcZ.jpg"
                }
            },

            new()
            {
                Name = "  Ceres",
                Subtitle = "Culture",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, " +
                "  and it's the only dwarf planet located in the inner solar system. " +
                "  It was the first member of the asteroid belt to be discovered " +
                "  when Giuseppe Piazzi spotted it in 1801." +
                "  When NASA's Dawn arrived in 2015," +
                "  Ceres became the first dwarf planet to be explored by a spacecraft.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://i.natgeofe.com/n/b4a4f4c3-269e-4f37-a94d-45d86cf0cb52/ceres_occatorcrater_square.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/PIA20353_Ceres_Neutron_Counts_Reflect_Hydrogen_Abundance_%28cropped%29.jpg/220px-PIA20353_Ceres_Neutron_Counts_Reflect_Hydrogen_Abundance_%28cropped%29.jpg"
                }
            },
            new()
            {
                Name = "  Haumea",
                Subtitle = "Secret Santa",
                HeroImage = "haumea.png",
                Description = " " +
                "Dwarf planet Haumea was originally designated 2003 EL61 (and nicknamed Santa by one discovery team)." +
                "  Haumea is located in the Kuiper Belt," +
                "  a doughnut-shaped region of icy bodies beyond the orbit of Neptune." +
                "  Haumea is an oval-shaped dwarf planet that is roughly the same size as Pluto." +
                "  It is one of the fastest rotating large objects in our solar system. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Haumea_Rotation.gif/213px-Haumea_Rotation.gif",
                    "https://astrophotographylens.com/cdn/shop/articles/Haumea.jpg?v=1693095371&width=1000",
                    "https://media.istockphoto.com/id/1211739638/photo/haumea-dwarf-planet-rotating-in-the-outer-space-3d-render.jpg?s=612x612&w=0&k=20&c=3bkcnYwR3p70yfaTVNxBMS9AqScR8RGNVsgVBGCZTZ4="
                }
            },

            new()
            {
                Name = "  Makemake",
                Subtitle = "Shiny",
                HeroImage = "makemake.png",
                Description = " " +
                "Dwarf planet Makemake – along with Pluto, Haumea, and Eris" +
                "  is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune." +
                "  Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt" +
                "  as seen from Earth while Pluto is the brightest. " +
                "  It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.\r\n\r\n",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg",
                    "https://media02.stockfood.com/largepreviews/MzkxNTg4NTU5/12631889-Dwarf-Planet-Makemake-Illustration.jpg",
                    "https://lirp.cdn-website.com/b905c406/dms3rep/multi/opt/stock-photo-fictional-makemake-with-stars-photo-realistic-d-planet-1977231464-dd07f30a-640w.jpg"
                }
            },

            new()
            {
                Name = "  Eris",
                Subtitle = "Fake planet",
                HeroImage = "eris.png",
                Description = " " +
                "The discovery of Eris help trigger a debate in the scientific community" +
                "  that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet." +
                "  Pluto, Eris, and other similar objects are now classified as dwarf planets." +
                "  Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, " +
                "  during a Palomar Observatory survey of the outer solar system by Mike Brown",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://i.natgeofe.com/n/495a21cb-c570-43d8-b5f7-3dfbedb91932/42531.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/06/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun-jpeg.webp?w=4096&format=png",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBaUFSIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--1f24a5d7e143ef1d68416edb76a51ec065c1019c/eris_th.jpg?disposition=inline"
                }
            },
    };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var ranomizedPlanets = planets.OrderBy(item => random.Next());

            return ranomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;

    }
}
