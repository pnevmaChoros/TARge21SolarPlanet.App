namespace TARge21SolarPlanet.Services
{
    internal static class PlanetsService
    {

        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun. Its orbit around the Sun takes 87.97 Earth days, the shortest of all the Sun's planets. It is named after the Roman god Mercurius (Mercury), god of commerce, messenger of the gods, and mediator between gods and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like Venus, Mercury orbits the Sun within Earth's orbit as an inferior planet; its apparent distance from the Sun as viewed from Earth never exceeds 28°. This proximity to the Sun means the planet can only be seen near the western horizon after sunset or the eastern horizon before sunrise, usually in twilight. At this time, it may appear as a bright star-like object, but is more difficult to observe than Venus. From Earth, the planet telescopically displays the complete range of phases, similar to Venus and the Moon, which recurs over its synodic period of approximately 116 days. Due to its synodic proximity to Earth, Mercury is most often the closest planet to Earth, with Venus periodically taking this role.[18][19]\r\n\r\nMercury rotates in a way that is unique in the Solar System. It is tidally locked with the Sun in a 3:2 spin–orbit resonance,[20] meaning that relative to the fixed stars, it rotates on its axis exactly three times for every two revolutions it makes around the Sun.[a][21] As seen from the Sun, in a frame of reference that rotates with the orbital motion, it appears to rotate only once every two Mercurian years. An observer on Mercury would therefore see only one day every two Mercurian years.\r\n\r\nMercury's axis has the smallest tilt of any of the Solar System's planets (about 1⁄30 degree). Its orbital eccentricity is the largest of all known planets in the Solar System;[b] at perihelion, Mercury's distance from the Sun is only about two-thirds (or 66%) of its distance at aphelion. Mercury's surface appears heavily cratered and is similar in appearance to the Moon's, indicating that it has been geologically inactive for billions of years. Having almost no atmosphere to retain heat, it has surface temperatures that vary diurnally more than on any other planet in the Solar System, ranging from 100 K (−173 °C; −280 °F) at night to 700 K (427 °C; 800 °F) during the day across the equatorial regions.[22] The polar regions are constantly below 180 K (−93 °C; −136 °F). The planet has no natural satellites.\r\n\r\nTwo spacecraft have visited Mercury: Mariner 10 flew by in 1974 and 1975; and MESSENGER, launched in 2004, orbited Mercury over 4,000 times in four years before exhausting its fuel and crashing into the planet's surface on April 30, 2015.[23][24][25] The BepiColombo spacecraft is planned to arrive at Mercury in 2025. ",

                AccentColorStart = Color.FromRgba("#353535"),
                AccentColorEnd = Color.FromRgba("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
				}

			},


			new()
			{
				Name = "Venus",
				Subtitle = "  The pressure cooker",
				HeroImage = "venus.png",
				Description = "Venus is the second planet from the Sun. It is sometimes called Earth's \"sister\" or \"twin\" planet as it is almost as large and has a similar composition. As an interior planet to Earth, Venus (like Mercury) appears in Earth's sky never far from the Sun, either as morning star or evening star. Aside from the Sun and Moon, Venus is the brightest natural object in Earth's sky, capable of casting visible shadows on Earth in dark conditions and being visible to the naked eye in broad daylight.[19][20]\r\n\r\nVenus is the second largest terrestrial object of the Solar System. It has a surface gravity slightly lower than on Earth and has a weak induced magnetosphere. The atmosphere of Venus consists mainly of carbon dioxide, and, at the planet’s surface, is the densest and hottest of the atmospheres of the four terrestrial planets. With an atmospheric pressure at the planet's surface of about 92 times the sea level pressure of Earth and a mean temperature of 737 K (464 °C; 867 °F), the carbon dioxide gas at Venus's surface is a supercritical fluid. Venus is shrouded by an opaque layer of highly reflective clouds of sulfuric acid, making it the planet with the highest albedo in the Solar System. It may have had water oceans in the past,[21][22] but after these evaporated the temperature rose under a runaway greenhouse effect.[23] The possibility of life on Venus has long been a topic of speculation but research has not produced convincing evidence thus far.\r\n\r\nLike Mercury, Venus does not have any moons.[24] Solar days on Venus, with a length of 117 Earth days,[25] are just about half as long as its solar year, orbiting the Sun every 224.7 Earth days.[26] This Venusian daylength is a product of it rotating against its orbital motion, halving its full sidereal rotation period of 243 Earth days, the longest of all the Solar System planets. Venus and Uranus are the only planets with such a retrograde rotation, making the Sun move in their skies from their western horizon to their eastern. The orbit of Venus around the Sun is the closest to Earth's orbit, bringing them closer than any other pair of planets. This occurs during inferior conjunction with a synodic period of 1.6 years. However, Mercury is more frequently the closest to each.\r\n\r\nThe orbits of Venus and Earth result in the lowest gravitational potential difference and lowest delta-v needed to transfer between them than to any other planet. This has made Venus a prime target for early interplanetary exploration. It was the first planet beyond Earth that spacecraft were sent to, starting with Venera 1 in 1961, and the first planet to be reached, impacted and in 1970 successfully landed on by Venera 7. As one of the brightest objects in the sky, Venus has been a major fixture in human culture for as long as records have existed. It has been made sacred to gods of many cultures, gaining its mainly used name from the Roman goddess of love and beauty which it is associated with. Furthermore, Venus has been a prime inspiration for writers, poets and scholars. Venus was the first planet to have its motions plotted across the sky, as early as the second millennium BCE.[27] Plans for better exploration with rovers or atmospheric missions, potentially crewed, at levels with almost Earth-like conditions have been proposed. ",

				AccentColorStart = Color.FromRgba("#A6393B"),
				AccentColorEnd = Color.FromRgba("#D17F21"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
				}

			},


			new()
			{
				Name = "Earth",
				Subtitle = "  The cradle of life",
				HeroImage = "earth.png",
				Description = "Earth is the third planet from the Sun and the only place known in the universe where life has originated and found habitability. While Earth may not contain the largest volumes of water in the Solar System, only Earth sustains liquid surface water, extending over 70.8% of the Earth with its ocean, making Earth an ocean world. Earth's polar regions currently retain most of all other water with large sheets of ice covering ocean and land, dwarfing Earth's groundwater, lakes, rivers and atmospheric water. Land, consisting of continents and islands, extends over 29.2% of the Earth and is widely covered by vegetation. Below Earth's surface material lies Earth's crust consisting of several slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes. Earth's liquid outer core generates a magnetic field that shapes the magnetosphere of Earth, largely deflecting destructive solar winds and cosmic radiation.\r\n\r\nEarth has an atmosphere, which sustains Earth's surface conditions and protects it from most meteoroids and UV-light at entry. It has a composition of primarily nitrogen and oxygen. Water vapor is widely present in the atmosphere, forming clouds that cover most of the planet. The water vapor acts as a greenhouse gas and, together with other greenhouse gases in the atmosphere, particularly carbon dioxide (CO2), creates the conditions for both liquid surface water and water vapour to persist via the capturing of energy from the Sun's light. This process maintains the current average surface temperature of 14.76°C, at which water is liquid under atmospheric pressure. Differences in the amount of captured energy between geographic regions (as with the equatorial region receiving more sunlight than the polar regions) drive atmospheric and ocean currents, producing a global climate system with different climate regions, and a range of weather phenomena such as precipitation, allowing components such as nitrogen to cycle.\r\n\r\nEarth is rounded into an ellipsoid with a circumference of about 40,000 km. It is the densest planet in the Solar System. Of the four rocky planets, it is the largest and most massive. Earth is about eight light-minutes away from the Sun and orbits it, taking a year (about 365.25 days) to complete one revolution. The Earth rotates around its own axis in slightly less than a day (in about 23 hours and 56 minutes). The Earth's axis of rotation is tilted with respect to the perpendicular to its orbital plane around the Sun, producing seasons. Earth is orbited by one permanent natural satellite, the Moon, which orbits Earth at 384,400 km (1.28 light seconds) and is roughly a quarter as wide as Earth. Through tidal locking, the Moon always faces the Earth with the same side, which causes tides, stabilizes Earth's axis, and gradually slows its rotation.\r\n\r\nEarth, like most other bodies in the Solar System, formed 4.5 billion years ago from gas in the early Solar System. During the first billion years of Earth's history, the ocean formed and then life developed within it. Life spread globally and has been altering Earth's atmosphere and surface, leading to the Great Oxidation Event two billion years ago. Humans emerged 300,000 years ago, and have reached a population of 8 billion today. Humans depend on Earth's biosphere and natural resources for their survival, but have increasingly impacted the planet's environment. Humanity's current impact on Earth's climate and biosphere is unsustainable, threatening the livelihood of humans and many other forms of life, causing widespread extinctions.[27] ",

				AccentColorStart = Color.FromRgba("#0e3d68"),
				AccentColorEnd = Color.FromRgba("#2e97c7"),
				Images = new()
				{
						"https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
						"https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
						"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				}

			},

			new()
			{
				Name = " Mars",
				Subtitle = "  The iron planet",
				HeroImage = "mars.png",
				Description = "Mars is the fourth planet from the Sun – a dusty, cold, desert world with a very thin atmosphere. Mars is also a dynamic planet with seasons, polar ice caps, canyons, extinct volcanoes, and evidence that it was even more active in the past.",
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
				Name = " Jupiter",
				Subtitle = "  The gas giant",
				HeroImage = "jupiter.png",
				Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. It is a gas giant with a mass more than two and a half times that of all the other planets in the Solar System combined, and slightly less than one one-thousandth the mass of the Sun.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#cd8026"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
				}
			},

			new()
			{
				Name = " Saturn",
				Subtitle = "  The ring planet",
				HeroImage = "saturn.png",
				Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System, after Jupiter. It is a gas giant with an average radius of about nine and a half times that of Earth. It has only one-eighth the average density of Earth, but is over 95 times more massive.",
				AccentColorStart = Color.FromArgb("#996237"),
				AccentColorEnd = Color.FromArgb("#c6502f"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
				}
			},

			new()
			{
				Name = " Uranus",
				Subtitle = "  The Herschel planet",
				HeroImage = "uranus.png",
				Description = "Uranus is the seventh planet from the Sun. It is named after Greek sky deity Uranus (Caelus), who in Greek mythology is the father of Cronus (Saturn), a grandfather of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus has the third-largest planetary radius and fourth-largest planetary mass in the Solar System.",
				AccentColorStart = Color.FromArgb("#9d4a40"),
				AccentColorEnd = Color.FromArgb("#996237"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
				}
			},

			new()
			{
				Name = " Neptune",
				Subtitle = "  The god of the sea",
				HeroImage = "neptune.png",
				Description = "Neptune is the eighth planet from the Sun and the farthest known planet in the Solar System. It is the fourth-largest planet in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17 times the mass of Earth, and slightly more massive than its near-twin Uranus.",
				AccentColorStart = Color.FromArgb("#0c293d"),
				AccentColorEnd = Color.FromArgb("#26abe0"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
				}
			},
		};


		private static List<Planet> dwarfPlanets = new()
		{
			new()
			{
				Name = "Pluto",
				Subtitle = "  complex world of ice mountains and frozen plains",
				HeroImage = "mercury.png",
				Description = "Pluto is a dwarf planet in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. There may be millions of these icy objects, collectively referred to as Kuiper Belt objects (KBOs) or trans-Neptunian objects (TNOs), in this distant region of our solar system.\r\n\r\nPluto – which is smaller than Earth’s Moon – has a heart-shaped glacier that’s the size of Texas and Oklahoma. This fascinating world has blue skies, spinning moons, mountains as high as the Rockies, and it snows – but the snow is red.\r\n\r\nOn July 14, 2015, NASA’s New Horizons spacecraft made its historic flight through the Pluto system – providing the first close-up images of Pluto and its moons and collecting other data that has transformed our understanding of these mysterious worlds on the solar system’s outer frontier.\r\n\r\nIn the years since that groundbreaking flyby, nearly every conjecture about Pluto possibly being an inert ball of ice has been thrown out the window or flipped on its head.\r\n\r\n“It’s clear to me that the solar system saved the best for last!” said Alan Stern, New Horizons principal investigator from the Southwest Research Institute, Boulder, Colorado. “We could not have explored a more fascinating or scientifically important planet at the edge of our solar system. The New Horizons team worked for 15 years to plan and execute this flyby and Pluto paid us back in spades!” ",
				AccentColorStart = Color.FromArgb("#CAB38A"),
				AccentColorEnd = Color.FromArgb("#C9C8C6"),
				Images = new()
				{

					"https://solarsystem.nasa.gov/internal_resources/6033/plutohero.jpg",
					"https://solarsystem.nasa.gov/internal_resources/127/"
				}

			},

			new()
			{
				Name = "Ceres",
				Subtitle = "   Roman goddess of corn and harvests",
				HeroImage = "mercury.png",
				Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. And when NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to receive a visit from a spacecraft.\r\n\r\nCalled an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006. Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive.\r\n\r\nCeres is named for the Roman goddess of corn and harvests. The word cereal comes from the same name.",
				AccentColorStart = Color.FromArgb("#B6ACA2"),
				AccentColorEnd= Color.FromArgb("#8194D9"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/internal_resources/6031/cereshero.jpg"
				}
				
			},

			new()
			{
				Name = "Makemake",
				Subtitle = "  The Rapanui god of fertility",
				HeroImage = "mercury.png",
				Description = "Along with fellow dwarf planets Pluto, Eris, and Haumea, Makemake is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. Slightly smaller than Pluto, Makemake is the second-brightest object in the Kuiper Belt as seen from Earth (while Pluto is the brightest). It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.\r\n\r\nMakemake holds an important place in the history of solar system studies because it – along with Eris – was one of the objects whose discovery prompted the International Astronomical Union to reconsider the definition of a planet and to create the new group of dwarf planets.\r\n\r\nMakemake was first observed in March 2005 by M.E. Brown, C.A. Trujillo, and D.L. Rabinowitz at the Palomar Observatory. Its unofficial codename was Easterbunny. Before this dwarf planet was confirmed, its provisional name was 2005 FY9. In 2016, NASA’s Hubble Space Telescope spotted a small, dark moon orbiting Makemake.",
				AccentColorStart = Color.FromArgb("#230100"),
				AccentColorEnd= Color.FromArgb("#A20B02"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/internal_resources/162/"
				}

			},

			new()
			{
				Name = "Haumea",
				Subtitle = "  Hawaiian goddess of fertility",
				HeroImage = "mercury.png",
				Description = "Originally designated 2003 EL61 (and nicknamed Santa by one discovery team), Haumea is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. The other known dwarf planets in the Kuiper Belt are Pluto, Eris, and Makemake (dwarf planet Ceres is located in the main asteroid belt between Mars and Jupiter).\r\n\r\nHaumea is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, making this dwarf planet look like a football.\r\n\r\nTwo teams claim credit for discovering Haumea citing evidence from observations made in 2003 and 2004. The International Astronomical Union’s Gazetteer of Planetary Nomenclature lists the discovery location as Sierra Nevada Observatory in Spain on Mar. 7, 2003, but no official discoverer is listed.\r\n\r\nEverything we know about Haumea is from observations with ground-based telescopes from around the world.",
				AccentColorStart = Color.FromArgb("#C0BFC5"),
				AccentColorEnd= Color.FromArgb("#38373D"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/internal_resources/161/"
				}

			},

			new()
			{
				Name = "Eris",
				Subtitle = "   the ancient Greek goddess of discord and strife",
				HeroImage = "mercury.png",
				Description = "Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.\r\n\r\nAt first, Eris appeared to be larger than Pluto. This triggered a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets.\r\n\r\nEris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003 during a Palomar Observatory survey of the outer solar system by Mike Brown, a professor of planetary astronomy at the California Institute of Technology; Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University.",
				AccentColorStart = Color.FromArgb("#851801"),
				AccentColorEnd= Color.FromArgb("#190403"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/internal_resources/165/"
				}

			}

		};
		

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());


            return randomizedPlanets.Take(2).ToList();
        }


        public static List<Planet> GetAllPlanets() => planets;

		public static List<Planet> GetAllDwarfPlanets() => dwarfPlanets;

	}
}
