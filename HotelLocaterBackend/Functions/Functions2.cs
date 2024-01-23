using DnsClient;
using HotelsBackend.Data;

namespace HotelsBackend.Functions
{
    public class Functions2
    {
        public static string DescriptionGenerator(string Location, string HotelName, double Rating)
        {
            string[] desc1 =
            {
                "Welcome to",
                "Discover the charm and elegance of",
                "Experience unparalleled luxury at",
                "Discover a haven of luxury at",
                "Step into a world of refined elegance at",
                "Indulge in the epitome of luxury at",
                "Escape to",
                "Discover a sanctuary of sophistication at",
                "Immerse yourself in the pinnacle of luxury at",
                "Find yourself immersed in beauty at",
                "Never will you find somewhere like",
                "Has there ever been a hotel like",
                "Unwind in a haven of tranquility at",
                "Welcome to a world-class destination, welcome to",
                "Immerse yourself in timeless charm at",
                "Welcome to a world of opulence and indulgence at",
                "Experience a seamless blend of luxury and convenience at",
                "Welcome to an oasis of relaxation and serenity at",
                "Indulge in a world of refined taste and impeccable service at",
                "Unveil a tapestry of comfort and luxury at",
                "Discover a hidden paradise of luxury and relaxation at",
                "Experience the perfect fusion of luxury and tranquility at",
                "Welcome to a sanctuary where luxury and serenity converge",
                ""
            };
            string[] desc2 =
            {
                "an exquisite",
                "discover a lavish",
                "indulge in the splendor of a luxurious",
                "embrace the allure of a stylish",
                "a luxurious",
                "a captivating",
                "an unforgettable",
                "a harmoniously designed",
                "a warmly inviting",
                "an architecturally stunning",
                "a classically inspired",
                "a truly enchanting",
                "a stunning",
                "a modern",
            };
            string[] desc3 =
            {
                "Perched in the heart of",
                "Tucked away in the charming streets of",
                "Embraced by the vibrant energy of",
                "Secluded in a peaceful oasis amidst the lively atmosphere of",
                "Set amidst the natural beauty of ",
                "Resting in the heart of",
                "Hidden away in the vibrant heart of",
                "Surrounded by the iconic landmarks of",
                "Positioned in the center of",
                "Sheltered in a tranquil corner of",
                "Set in the heart of",
                "Surrounded by the history and heritage of"
            };
            string[] desc4 =
            {
                "Thoughtfully designed rooms provide a cozy haven for guests seeking comfort and convenience during their stay.",
                "Impeccably furnished accommodations offer a serene escape for travelers in search of relaxation and ease.",
                "Stylishly decorated rooms provide a tranquil sanctuary for guests to unwind and rejuvenate after a day of exploration.",
                "Luxuriously appointed accommodations offer a peaceful retreat for discerning travelers seeking comfort and convenience.",
                "Elegantly designed rooms provide a soothing haven for guests looking for a restful and convenient stay.",
                "Meticulously crafted accommodations offer a comfortable sanctuary for travelers seeking relaxation and ease.",
                "Well-appointed rooms provide a serene and convenient retreat for guests to unwind and recharge during their stay.",
                "Tastefully decorated rooms provide a cozy retreat for guests seeking comfort, relaxation, and easy access to amenities.",
                "Carefully curated accommodations offer a peaceful sanctuary for travelers looking for a comfortable and convenient stay.",
                "Spaciously designed rooms provide a welcoming retreat for guests seeking relaxation and effortless comfort.",
                "Artfully furnished accommodations offer a serene and convenient haven for travelers in search of a peaceful stay.",
                "Comfortably appointed rooms provide a relaxing and convenient retreat for guests to enjoy during their visit.",
                "Elegantly designed rooms provide a serene and inviting retreat for guests seeking comfort and convenience.",
                "Spacious and well-appointed rooms provide a tranquil retreat for guests seeking relaxation and convenience.",
            };
            string[] desc5 =
            {
                "Experience culinary delights at our exquisite on-site restaurant and find relaxation at our rejuvenating spa and fitness center.",
                "Delight your taste buds with our delectable dining options and revive your senses at our state-of-the-art spa and fitness center.",
                "Savor a culinary journey at our renowned on-site restaurant and pamper yourself with rejuvenating treatments at our luxurious spa and fitness center.",
                "Indulge in gastronomic pleasures at our exceptional on-site restaurant and restore your well-being at our rejuvenating spa and fitness center.",
                "Treat yourself to a gourmet experience at our enticing on-site restaurant and recharge your body and mind at our invigorating spa and fitness center.",
                "Enjoy a culinary adventure at our tempting on-site restaurant and unwind in the tranquil ambiance of our spa and fitness center.",
                "Delight in a feast for the senses at our acclaimed on-site restaurant and discover ultimate relaxation at our world-class spa and fitness center.",
                "Relish in exquisite dining options at our on-site restaurant and discover rejuvenation at our luxurious spa and fitness center.",
                "Indulge your palate at our tantalizing on-site restaurant and embark on a wellness journey at our state-of-the-art spa and fitness center.",
                "Immerse yourself in a culinary experience at our exceptional on-site restaurant and revive your body and soul at our rejuvenating spa and fitness center."
            };
            string[] desc6 =
            {
                "Discover the pinnacle of exceptional service and forge unforgettable memories at",
                "Immerse yourself in the epitome of hospitality and embark on a journey of unforgettable moments at",
                "Unwind in the lap of luxury and craft everlasting memories at",
                "Indulge in unparalleled hospitality and make lasting memories at",
                "Experience the pinnacle of gracious service and create cherished memories at",
                "Bask in the epitome of warm hospitality and craft indelible memories at",
                "Immerse yourself in a world of refined luxury and create unforgettable memories at",
                "Enjoy the essence of unparalleled hospitality and weave extraordinary memories at",
                "Discover a sanctuary of exceptional service and make lifelong memories at",
                "Embrace the epitome of personalized care and create treasured memories at"
            };
            int rand1 = Functions1.CalculateRandomPositive(23);
            int rand2 = Functions1.CalculateRandomPositive(14);
            int rand3 = Functions1.CalculateRandomPositive(12);
            int rand4 = Functions1.CalculateRandomPositive(14);
            int rand5 = Functions1.CalculateRandomPositive(10);
            int rand6 = Functions1.CalculateRandomPositive(10);

            string s1 = desc1[rand1];
            string s2 = desc2[rand2];
            string s3 = desc3[rand3];
            string s4 = desc4[rand4];
            string s5 = desc5[rand5];
            string s6 = desc6[rand6];

            string desc = s1 + " " + HotelName + ", " + s2 + " " + Rating + "-star hotel" + " " + s3 + " " + Location + ", " 
                + s4 + " " + s5 + " " + s6 + " " + HotelName + ".";

            return desc;
        }

        public static string ReviewDescriptionGenerator(string HotelName)
        {
            string[] desc1 =
            {
                "I was absolutely blown away by the unparalleled experience I had at",
                "Prepare to have your expectations shattered when you stay at",
                "I was left speechless by the sheer perfection that was delivered at",
                "If you're looking for a hotel that will leave you in awe, look no further than ",
                "Words cannot express the level of excellence I encountered at",
                "Prepare to be amazed by the extraordinary level of service and opulence at",
                "I was left in awe of the exceptional hospitality and attention to detail at",
                "I was left utterly amazed by the remarkable level of hospitality and unwavering attention to detail at",
                "The outstanding hospitality and meticulous attention to every little detail at",
                "I have never had an experience quite like when i visited",
                "Where else will you find a hotel with such excellent service as with",
                "I could not believe the amazing service and hospitality i received at",
                "I was absolutely floored by the unparalleled experience I had at",
                ""

            };
            string[] desc2 =
            {
                "From the moment I arrived, I was greeted with warm smiles and a genuine eagerness to assist me throughout my stay.",
                "The hotel's attention to detail and commitment to customer service truly made my experience unforgettable.",
                "It was incredibly convenient for exploring the city's vibrant culture and immersing myself in the local experience.",
                "The only minor drawback was the occasional traffic noise from the main road, but it didn't significantly impact my overall enjoyment.",
                "The hotel staff deserves special recognition for their outstanding service.",
                "The hotel's facilities were top-notch.",
                "The swimming pool and fitness center were well-maintained and provided a relaxing environment for unwinding.",
                "I indulged in a rejuvenating spa treatment, and the skilled therapists ensured a blissful experience.",
                "The dining experience at Paradise Hotel was a true culinary delight.",
                "The on-site restaurants offered a wide variety of dishes, catering to different palates.",
                "The food was delicious, and the attentive service added to the overall enjoyment.",
                "The resort is nestled in a picturesque location, surrounded by lush greenery and offering breathtaking views of the nearby mountains.",
                "I stayed in one of the deluxe rooms, and it was beautifully decorated, spacious, and immaculately clean.",
                "The swimming pool was pristine, and I enjoyed spending time lounging by the poolside, soaking up the sun.",
                " The spa and wellness center offered a variety of rejuvenating treatments, which were perfect for unwinding after a long day of sightseeing.",
                "The fitness center was well-equipped and maintained, allowing guests to stay active during their stay.",
                "The breakfast buffet offered a wide variety of dishes, catering to different tastes and dietary preferences.",
                "The on-site restaurant served delicious international cuisine, and the attentive staff provided excellent service.",
                "The staff members were warm, friendly, and always ready to assist with any requests or queries.",
                "They were knowledgeable about the local area and offered great recommendations for nearby attractions and activities.",
                "From the front desk to the housekeeping staff, everyone was dedicated to ensuring a pleasant and comfortable stay for the guests.",
                "I stayed in one of the luxurious beachfront villas, and it was an absolute paradise.",
                "The infinity pool, overlooking the ocean, provided a perfect spot to relax and enjoy the stunning views.",
                "The resort also had a beachfront bar where I could unwind while sipping on tropical cocktails and enjoying the sunset.",
                "I had the opportunity to participate in water sports such as snorkeling and kayaking, which allowed me to explore the stunning marine life and crystal-clear waters.",
                "The resort also organized guided tours to nearby attractions, providing a convenient way to experience the local culture and natural beauty of the region.",
                "The menus featured a wide range of traditional dishes prepared with a modern twist, highlighting the freshest local produce and ingredients.",
                "Whether it was Italian pasta, Japanese sushi, or French pastries, the resort's international offerings were executed with precision and finesse, providing a delightful fusion of global flavors.",
                "One of the standout features of the resort's dining experience was its commitment to utilizing locally sourced, organic ingredients.",
                "The interior design was tastefully done, combining modern elements with subtle touches of luxury."
            };
            string[] desc3 =
            {
                "From the stylish furniture to the carefully selected decor, every aspect of the room reflected a harmonious blend of aesthetics and functionality.",
                "The attention to detail in the design created a serene and inviting ambiance that made me feel instantly relaxed.",
                "The rooms were spacious, providing ample space to unwind and move around comfortably.",
                "The furnishings were of the highest quality, including a plush bed with premium bedding, comfortable seating options, and a well-equipped workspace.",
                "The attention to comfort was evident in every aspect of the room's design.",
                "The housekeeping staff paid meticulous attention to detail, ensuring that every corner of the room was spotless.",
                "The linens were fresh and crisp, and the bathroom was immaculately clean.",
                "The Hotel left no stone unturned when it came to providing modern amenities in their rooms.",
                "The room also featured a well-stocked minibar, a coffee maker, and a safe for added convenience and security. These thoughtful amenities enhanced the overall comfort and convenience of my stay.",
                "The technology offerings were impressive, with a large flat-screen TV, high-speed internet access, and convenient USB charging ports.",
                "The bathrooms were spacious, featuring high-quality fixtures and premium toiletries.",
                "The walk-in shower was refreshing, and the bathtub provided a perfect spot to unwind and relax.",
                "The soundproofing was excellent, ensuring a quiet and restful environment for a good night's sleep.",
                "The blackout curtains effectively blocked out any unwanted light, further enhancing the quality of rest.",
                "From zip-lining through the treetops to rock climbing on natural cliffs, adrenaline junkies had plenty of opportunities to get their hearts racing.",
                "The resort also organized guided hiking and mountain biking tours, allowing guests to explore the breathtaking natural landscapes surrounding the property.",
                "Guests could try their hand at surfing, paddleboarding, or kayaking, making the most of the resort's proximity to the ocean.",
                "Snorkeling and scuba diving enthusiasts could explore vibrant coral reefs and encounter fascinating marine life on guided underwater expeditions.",
                "Yoga and meditation classes were available for those seeking inner peace and balance.",
                "The resort organized cultural workshops, where guests could learn traditional crafts, cooking techniques, or even try their hand at indigenous art forms",
                "Guided visits to nearby historical sites and landmarks allowed guests to delve into the rich heritage of the region.",
                "The resort had a dedicated kids' club where young guests could engage in supervised games, crafts, and interactive learning experiences.",
                "Family-friendly excursions, such as nature walks and wildlife encounters, provided opportunities for bonding and creating lasting memories.",
                "One of the highlights of staying at Local Haven Resort was the opportunity to engage with the local community and immerse myself in their culture.",
                "The resort organized cultural activities and events that allowed guests to interact with locals, learn about their traditions, and experience their way of life.",
                "From traditional dance performances to cooking classes, these authentic cultural experiences provided a deeper connection with the destination and its people.",
                "The resort also had a dedicated game room with billiards, table tennis, and various arcade games, ensuring fun for guests of all ages.",
                "The engaging activities and entertainment options ensured that there was never a dull moment at the resort.",
                "The resort's conference rooms were well-equipped with modern audiovisual technology and offered flexible setups to accommodate a variety of event needs.",
            };
            string[] desc4 =
            {
                "In conclusion",
                "Overall",
                "In Summary",
                "To Summarise",
                "Without a Doubt",
                "To sum up",
                "In a nutshell",
                "Ultimately",
                "As a final thought",
                "To round it up",
                "To give a final analysis"
            };
            string[] desc5 =
            {
                ", my stay at",
                ", my experience at",
                ", the time i spent at",
                ", the period i stayed at",
                ", the nights i stayed at",
                ", the duration of my visit at",
                ", the nights i resided at"
            };
            string[] desc6 =
            {
                "was nothing short of exceptional, and i would highly recommend anyone come here",
                "was Truly remarkable",
                "Far surpassed my hopes",
                "was Truly extraordinary",
                "exceeded my wildest dreams and set a new standard for excellence",
                "was an enchanting journey that exceeded my every expectation",
                "was an absolute revelation, surpassing my expectations in every aspect",
                "took my breath away and went above and beyond anything I could have imagined",
                "turned out to be a true gem, far surpassing what I had envisioned",
                "was a delightful surprise, surpassing all expectations I had formed"
            };
            int rand1 = Functions1.CalculateRandomPositive(14);
            int rand2 = Functions1.CalculateRandomPositive(30);
            int rand3 = Functions1.CalculateRandomPositive(29);
            int rand4 = Functions1.CalculateRandomPositive(11);
            int rand5 = Functions1.CalculateRandomPositive(7);
            int rand6 = Functions1.CalculateRandomPositive(10);

            string s1 = desc1[rand1];
            string s2 = desc2[rand2];
            string s3 = desc3[rand3];
            string s4 = desc4[rand4];
            string s5 = desc5[rand5];
            string s6 = desc6[rand6];

            string desc = s1 + " " + HotelName + ". " + s2 + "." + " " + s3 + " " 
               + s4 + s5 + " " + HotelName + " " + s6 + ".";

            return desc;

        }
        public static string NameGenerator()
        {
            string[] names = {
                                "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Mia", "Charlotte", "Amelia", "Harper", "Evelyn",
                                "Abigail", "Emily", "Elizabeth", "Mila", "Ella", "Avery", "Scarlett", "Luna", "Chloe", "Grace",
                                "Penelope", "Layla", "Victoria", "Riley", "Zoey", "Nora", "Lily", "Eleanor", "Hannah", "Lillian",
                                "Addison", "Aubrey", "Ellie", "Stella", "Natalie", "Zoe", "Leah", "Hazel", "Violet", "Aurora",
                                "Savannah", "Audrey", "Brooklyn", "Bella", "Claire", "Skylar", "Lucy", "Paisley", "Everly",
                                "Anna", "Caroline", "Nova", "Genesis", "Emilia", "Kennedy", "Samantha", "Maya", "Willow", "Kinsley",
                                "Naomi", "Aaliyah", "Elena", "Sarah", "Ariana", "Allison", "Gabriella", "Alice", "Madelyn", "Cora",
                                "Ruby", "Eva", "Serenity", "Autumn", "Adeline", "Hailey", "Gianna", "Valentina", "Isla", "Eliana",
                                "Quinn", "Nevaeh", "Ivy", "Sadie", "Piper", "Lydia", "Alexa", "Josephine", "Emery", "Julia",
                                "Liam", "Noah", "Oliver", "Elijah", "William", "James", "Benjamin", "Lucas", "Henry", "Alexander",
                                "Mason", "Michael", "Ethan", "Daniel", "Jacob", "Logan", "Jackson", "Levi", "Sebastian", "Mateo",
                                "Jack", "Owen", "Theodore", "Aiden", "Samuel", "Joseph", "John", "David", "Wyatt", "Matthew",
                                "Luke", "Asher", "Carter", "Julian", "Grayson", "Leo", "Jayden", "Gabriel", "Isaac", "Lincoln",
                                "Anthony", "Hudson", "Dylan", "Ezra", "Thomas", "Charles", "Christopher", "Jaxon", "Maverick",
                                "Josiah", "Isaiah", "Andrew", "Elias", "Joshua", "Nathan", "Caleb", "Ryan", "Adrian", "Miles",
                                "Eli", "Nolan", "Christian", "Aaron", "Cameron", "Blake", "Landon", "Jordan", "Connor", "Santiago",
                                "Jeremiah", "Ezekiel", "Colton", "Amir", "Maxwell", "Ian", "Adam", "Axel", "Eric", "Brody",
                                "Bennett", "Finn", "Declan", "Silas", "Emmett", "Kai", "Rowan", "Everett", "Xavier", "Zachary"
                                };
            string[] surnames = {
                                "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor",
                                "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson",
                                "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King",
                                "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter",
                                "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins",
                                "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey",
                                "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James",
                                "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson",
                                "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler"
                                };
            int rand1 = Functions1.CalculateRandomPositive(175);
            int rand2 = Functions1.CalculateRandomPositive(85);

            string s1 = names[rand1];
            string s2 = surnames[rand2];
            string result = s1 + " " + s2;
            return result;
        }
        public static string ReviewTitleGenerator()
        {
            string[] desc1 =
            {
                "Amazing!",
                "BEST PLACE EVER!",
                "Would definitely come again",
                "Would recommend this hotel to anyone",
                "My favourite Hotel in this area",
                "Staff service was great!",
                "Good value for Money",
                "Exceeded expectations! Would highly recommend.",
                "A truly unforgettable stay.",
                "This hotel is everything you've heard and more.",
                "A perfect place to relax and unwind.",
                "I can't wait to come back here again someday.",
                "This hotel is a hidden gem.",
                "I'm so glad I chose this hotel for my stay.",
                "An amazing hotel experience that I will never forget.",
                "This hotel exceeded all of my expectations.",
                "I would highly recommend this hotel to anyone looking for a great place to stay.",
                "This was the best hotel stay I've ever had.",
                "I'm already planning my next trip back!",
                "The facilities were top-notch and the location was perfect.",
                "The staff went above and beyond to make my stay perfect.",
                "I felt like I was staying in a luxurious spa, not just a hotel.",
                "I would highly recommend this hotel to anyone who wants to feel like royalty"
                
            };
            int rand1 = Functions1.CalculateRandomPositive(23);
            string s1 = desc1[rand1];
            return s1;

        }
        public static string RoomDescriptionGenerator()
        {
            string[] desc1 =
            {
                "Welcome to our luxurious hotel room.",
                "Step into a world of refined elegance as you enter this exquisite hotel room.",
                "Prepare to be enveloped in opulence as you open the door to our lavish hotel room.",
                "Experience the pinnacle of luxury and sophistication as you arrive at our upscale hotel room.",
                "Be greeted by an aura of indulgence as you step foot into our sumptuous hotel room.",
                "Allow us to pamper you in our impeccably designed hotel room, where luxury knows no bounds",
                "Welcome to a haven of tranquility and sophistication, nestled within our meticulously crafted hotel room.",
                "Embrace the comfort of our upscale hotel room, where every detail is curated to provide a truly memorable stay.",
                "Indulge in the splendor of our refined hotel room, designed to exceed even the most discerning guest's expectations.",
                "Prepare to be captivated by the elegance and grandeur that awaits you in our exclusive hotel room.",
                "Enter a world of unparalleled luxury and relaxation as you step into our prestigious hotel room."

            };
            string[] desc2 =
            {
                "From the moment you cross the threshold, you'll be enveloped by a welcoming ambiance that radiates serenity and relaxation.",
                "As you enter, a soothing and inviting atmosphere embraces you, setting the tone for a tranquil and rejuvenating stay.",
                "Prepare to be embraced by a comforting and inviting aura as you step into our hotel room, offering a peaceful haven from the outside world.",
                "Instantly feel at ease as you enter, greeted by an inviting ambiance that invites you to unwind and let the stresses of the day melt away.",
                "The moment you set foot inside, you'll be embraced by an atmosphere that whispers tranquility, creating a sanctuary of calm amidst the bustling world outside.",
                "Let the welcoming embrace of our hotel room wash over you, imbuing the space with a sense of warmth and tranquility that invites complete relaxation.",
                "As you make your way through the door, a gentle and inviting atmosphere greets you, wrapping you in a cocoon of peacefulness and contentment.",
                "Experience the immediate comfort of a space that exudes a warm and inviting ambiance, enveloping you in a sense of tranquility from the very first step.",
                "The moment you enter, you'll be embraced by an inviting and serene atmosphere, a soothing respite that promises a restful and rejuvenating stay.",
                "Prepare to be captivated by the serene and welcoming ambiance that greets you upon arrival, ensuring a blissful experience throughout your stay.",
                "Whether you're traveling solo or with companions, there is ample space to unwind and make yourself at home.",
                "Carefully curated, each piece adds a touch of sophistication and elegance, transforming the space into a gallery-like haven.",
                "Soft, neutral tones dominate the palette, enveloping you in a soothing ambiance that encourages relaxation and peace of mind.",
                "From bedside charging stations to easily accessible power outlets, every detail has been considered to cater to your technological needs.",
                "Pull back the curtains and bask in the glow, or draw them shut for a cozy, private retreat.",
                "From comfortable armchairs to a cozy sofa, each piece invites you to lounge, unwind, and make yourself at home during your stay.",
                "Marble countertops, a spacious vanity, and a rainforest showerhead all come together to create a luxurious and rejuvenating bathing experience.",
                "From spacious wardrobes to discreetly placed drawers, you'll find ample space to store your belongings and keep the room tidy and clutter-free.",
                "From soft, ambient lighting to adjustable reading lamps, you have complete control over the atmosphere, allowing you to create the perfect mood for any occasion.",
                "From smart thermostats that allow you to adjust the temperature with a simple touch to voice-controlled assistants that provide personalized recommendations, technology enhances your comfort and convenience throughout your stay."

            };
            string[] desc3 =
            {
                "Designed with your comfort in mind, the room boasts a spacious layout that allows for easy movement and relaxation.",
                "Indulge your senses as you take in the tasteful artwork that graces the walls of the room.",
                "The color scheme of the room is carefully selected to promote a sense of tranquility and serenity.",
                "Enjoy the convenience of modern amenities thoughtfully integrated into the room's design.",
                "Natural light spills into the room through large windows, illuminating the space and creating an airy, light-filled atmosphere during the day.",
                "Sink into the plushness of the carefully chosen furnishings that adorn the room.",
                "Immerse yourself in a state of pure relaxation as you discover the indulgent bathroom.",
                "Discover the perfect balance of form and function with the room's thoughtfully designed storage solutions.",
                "Embrace the serenity of the room's carefully chosen lighting fixtures.",
                "Enjoy the seamless integration of technology into the room's design.",
                 "Nestled to one side of the room, you'll find a cozy seating area beckoning you to unwind and relax.",
                 "The seating area is carefully designed with your comfort in mind.",
                 "A well-positioned coffee table sits in the center of the seating area, offering a convenient surface for your beverages, snacks, or even a game of cards.",
                 "Adorned with tasteful decor, the seating area is a haven of relaxation and tranquility.",
                 "The seating area provides a welcome respite after a long day of exploring.",
                 "A thoughtfully placed side table within reach of the armchair provides the perfect spot for your favorite book or a refreshing beverage.",
                 "With its inviting ambiance, the seating area is an ideal space for light conversation and connection.",
                 "Take a moment to savor a cup of freshly brewed coffee or tea in the cozy seating area.",
                 "The seating area is designed as a versatile space that can adapt to your needs.",
                 "Enjoy the panoramic view of the cityscape or natural surroundings from the comfort of the seating area."

            };
            string[] desc6 =
            {
               "Sink into the plush armchair, enveloped in its embrace, and let the worries of the day fade away.",
               "The plush armchair invites you to sink into its soft cushions, providing the perfect spot to curl up with a good book or simply take a moment to yourself.",
               "It's the ideal spot to gather and enjoy some quality time with your travel companions.",
               "Soft lighting casts a warm glow, creating an intimate atmosphere where you can unwind and recharge.",
               "Kick off your shoes, sink into the plush armchair, and let your muscles relax as you recount the day's adventures or plan for the next.",
               "Settle in, let the words transport you, and lose yourself in a world of imagination.",
               "Gather with your loved ones, share stories and laughter, and create lasting memories in this comfortable nook.",
               "Let the rich aroma fill the air as you savor each sip, appreciating the quietude and comfort of your surroundings.",
               "Whether you prefer to catch up on work, engage in a creative pursuit, or simply sit back and relax, this area caters to your desires.",
               "Watch as the world unfolds before you, providing a captivating backdrop to your moments of repose."
            };
            string[] desc7 =
            {
                "No matter the purpose of your visit, be it business or pleasure, this hotel room offers an impeccable fusion of comfort and style that will surpass your expectations.",
                "Whether you're traveling for work or leisure, this hotel room is meticulously designed to offer an unparalleled combination of comfort and sophistication, guaranteeing an exceptional stay.",
                "Indulge in the ultimate comfort and style as you step into this hotel room, where every detail has been thoughtfully curated to ensure an unforgettable experience, no matter your purpose of travel.",
                "Whether you're a discerning business traveler or a leisure seeker in need of relaxation, this hotel room seamlessly blends comfort and style, providing an oasis of luxury tailored to your desires.",
                "Designed with both business and leisure travelers in mind, this hotel room presents a harmonious synthesis of comfort and style, creating an inviting space that exceeds expectations.",
                "Embrace a stay that caters to your every need, whether you're traveling for work or pleasure. This hotel room offers an exquisite combination of comfort and style, ensuring a remarkable experience.",
                "Prepare to be captivated by the perfect union of comfort and style found within this hotel room. No matter your purpose of travel, an extraordinary stay awaits you.",
                "This hotel room is meticulously crafted to offer the ideal blend of comfort and style, providing an exceptional retreat that caters to both business and leisure travelers.",
                "Step into a realm of refined elegance where comfort seamlessly intertwines with style. This hotel room is the epitome of luxury, promising an unforgettable experience for all types of travelers.",
                "Whether you're a corporate traveler or seeking a leisurely escape, this hotel room effortlessly combines comfort and style to create an environment that will leave a lasting impression."
            };
            int rand1 = Functions1.CalculateRandomPositive(10);
            int rand2 = Functions1.CalculateRandomPositive(10);
            int rand3 = Functions1.CalculateRandomPositive(10);
            int rand6 = Functions1.CalculateRandomPositive(10);
            int rand7 = Functions1.CalculateRandomPositive(10);


            string s1 = desc1[rand1];
            string s2 = desc2[rand2];
            string s3 = desc3[rand3];
            string s6 = desc6[rand6];
            string s7 = desc7[rand7];

            string desc = s1 + " " + s2 + " " + s3 + " " + s6 + " " + s7;

            return desc;


        }
        public static string RoomTitleGenerator()
        {
            string[] desc1 =
            {
                "Royal Suite",
                "Deluxe Suite",
                "Presidential Suite",
                "Junior Suite",
                "Deluxe Room",
                "Double Deluxe",
                "Penthouse Suite",
                "Premier Junior Suite",
                "Premier Suite",
                "Executive Suite",
                "Business Suite",
                "Superior Triple Suite",


            };
            int rand1 = Functions1.CalculateRandomPositive(12);
            string s1 = desc1[rand1];
            return s1;

        }

        public static string HotelTitleGenerator()
        {

            string[] names = {
                                 "Serenity", "Opulent", "Majestic", "Luxe", "Blissful", "Harmony", "Radiant", "Elysian", "Celestial", "Pinnacle",
                                 "Velvet", "Golden", "Royal", "Aurora", "Regal", "Azure", "Summit", "Utopia", "Lush", "Enchanting", 
                                 "Grandeur", "Luminous", "Crystal", "Tranquil", "Eternal", "Epic", "Ethereal", "Everlasting", "Elegant", 
                                 "Exquisite", "Elite", "Divine", "Dynamic", "Dazzling", "Deluxe", "Decadent", "Captivating", "Cerulean", 
                                 "Calm", "Breathtaking", "Bespoke", "Bliss", "Boutique", "Beloved", "Azure", "Ambiance", "Amber", "Allure", 
                                 "Adorn"

                                 };
            string[] surnames = {
                                 "Haven", "Retreat", "Lodge", "Residence", "Sanctuary", "Mansion", "Villa", "Nest", "Oasis", "Chateau", 
                                 "Manor", "Domain", "Palace", "Estate", "Hideaway", "Palatial", "Citadel", "Citadelle", "Castle", "Asylum", 
                                 "Quarter", "Quarters", "Chamber", "Chambers", "Refuge", "Habitat", "Abode", "Shelter", "Shrine", "Arcadia", 
                                 "Acropolis", "Silo", "Sanctum", "Stronghold", "Serenade", "Emporium", "Paradise", "Hacienda", "Bastion", 
                                 "Nook", "Lair", "Roost", "Meadow", "Vestige", "Vestiges", "Grove", "Ascent", "Falls"
                                };
            int rand1 = Functions1.CalculateRandomPositive(40);
            int rand2 = Functions1.CalculateRandomPositive(40);
            int rand3 = Functions1.CalculateRandomPositive(2);

            string s1 = names[rand1];
            string s2 = surnames[rand2];
            string result = s1 + " " + s2;
            if(rand3 == 0)
            {
                return result;
            }
            else
            {
                return  "The" + result;

            }
        }
    }

}
