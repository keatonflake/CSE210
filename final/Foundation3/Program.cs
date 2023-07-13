using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> randomEmails = new List<string>()
        {
            "Alice@gmail.com", "Bo@gmail.com", "Charlie@gmail.com", "David@gmail.com", "Emma@gmail.com","Frank@gmail.com", "Grace@gmail.com", "Henry@gmail.com", "Isabella@gmail.com", "Jack@gmail.com","Katherine@gmail.com", "Liam@gmail.com", "Mia@gmail.com", "Noah@gmail.com", "Olivia@gmail.com","Peter@gmail.com", "Quinn@gmail.com", "Ruby@gmail.com", "Samuel@gmail.com", "Taylor@gmail.com","Ursula@gmail.com", "Victor@gmail.com", "Willow@gmail.com", "Xavier@gmail.com", "Yara@gmail.com", "Zoe@gmail.com"
        };

        List<string> randomStreetNames = new List<string>()
        {
            "123 W. Main Street", "123 W. Oak Avenue", "123 W. Elm Street", "123 W. Cedar Lane","123 W. Maple Road", "123 W. Pine Street", "123 W. Birch Lane", "123 W. Willow Avenue","123 W. Spruce Court", "123 W. Hickory Lane", "123 W. Cypress Road", "123 W. Sycamore Street"
        };
        List<string> randomCities = new List<string>
        {
            "New York", "Los Angeles", "Chicago", "Houston","Phoenix","Philadelphia","San Antonio","San Diego","Dallas","San Jose","Austin","Jacksonville","San Francisco","Columbus","Fort Worth","Indianapolis","Charlotte","Seattle","Denver","Washington, D.C."
        };
        List<string> randomStates = new List<string>
        {
            "Alabama","Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawaii","Idaho", "Illinois","Indiana","Iowa","Kansas","Kentucky","Louisiana","Maine","Maryland","Massachusetts","Michigan","Minnesota","Mississippi","Missouri","Montana","Nebraska",
        };
        List<string> randomProvances = new List<string>
        {
            "12345","67890","54321","98765","13579","86420","24680","97531","46802","80246","13579","24680","98765","54321","46802","80246","97531","86420","12345","67890"
        };
        List<string> RandomCountries = new List<string>
        {
            "United States","China","India","Brazil","Russia","Japan","Germany","United Kingdom","France","Italy","Canada","South Korea","Australia","Spain","Mexico","Indonesia","Netherlands","Saudi Arabia","Switzerland","Sweden"
        };
        List<string> randomForecast = new List<string>
        {
            "Sunny","Partly Cloudy","Cloudy","Rainy","Thunderstorms","Snowy","Windy","Foggy","Hazy","Clear skies","Overcast","Misty","Showers","Scattered Clouds","Heavy rain","Light rain","Hot and humid","Cold and breezy","Thick fog","Blizzard"
        };
        List<string> randomNames = new List<string>
        {
            "Emma","Liam","Olivia","Noah","Ava","Isabella","Sophia","Mia","Charlotte","Amelia","Harper","Evelyn","Abigail","Emily","Elizabeth","Mila","Ella","Avery","Sofia","Camila","James","John","Robert","Michael","William","David","Joseph","Charles","Thomas","Daniel"
        };
        List<string> randomDescriptions = new List<string>
        {
            "A thrilling concert featuring popular bands",
            "A captivating art exhibition showcasing local talent",
            "A charity run to support a good cause",
            "A fun-filled family picnic in the park",
            "An interactive workshop on digital marketing",
            "A lively street festival with food and music",
            "A thought-provoking panel discussion on climate change",
            "An exciting sports tournament with top athletes",
            "A mesmerizing dance performance by world-renowned dancers",
            "A gourmet food tasting event featuring local delicacies",
            "A comedy show guaranteed to make you laugh",
            "A science fair showcasing innovative projects",
            "A film screening of award-winning documentaries",
            "A technology conference with expert speakers",
            "A cultural celebration of music, dance, and traditions",
            "A professional networking event for entrepreneurs",
            "A thrilling adventure race for outdoor enthusiasts",
            "A theater production of a classic play",
            "A fashion show unveiling the latest designs",
            "A book reading and signing by a bestselling author"
        };
        List<string> randomTitles = new List<string>
        {
            "Summer Music Festival",
            "Art Exhibition Gala",
            "Charity Gala Dinner",
            "Family Fun Day",
            "Digital Marketing Masterclass",
            "Street Food Festival",
            "Climate Change Symposium",
            "Sports Extravaganza",
            "Dance Spectacular",
            "Gourmet Food Tasting",
            "Comedy Night",
            "Science Fair Showcase",
            "Award-Winning Film Screening",
            "Technology Summit",
            "Cultural Music and Dance Festival",
            "Entrepreneur Networking Mixer",
            "Adventure Race Challenge",
            "Classic Play Revival",
            "Fashion Show Premiere",
            "Book Launch and Signing"
        };
        List<Event> _events = new List<Event>();
        int receptionCount = 0;
        while (receptionCount <= 3)
        {
            Reception newReception = new Reception();

            int RSVPCount = 0;
            while (RSVPCount <= 20)
            {
                newReception.SetEmail(randomEmails[GetRandomNumber(0, 20)]);
                RSVPCount++;
            }
            newReception.SetTitle(randomTitles[GetRandomNumber(0, 20)]);
            newReception.SetDescription(randomDescriptions[GetRandomNumber(0, 20)]);
            newReception.SetDate("07/13/2023");
            newReception.SetTime("7:00pm");
            Address newAddress = new Address();
            newAddress.SetStreetAddress(randomStreetNames[GetRandomNumber(0, 12)]);
            newAddress.SetCity(randomCities[GetRandomNumber(0, 20)]);
            newAddress.SetState(randomStates[GetRandomNumber(0, 23)]);
            newAddress.SetProvance(randomProvances[GetRandomNumber(0, 20)]);
            newAddress.SetCountry(RandomCountries[GetRandomNumber(0, 20)]);
            newReception.SetAddress(newAddress);
            _events.Add(newReception);
            receptionCount++;
        }

        int lectureCount = 0;
        while (lectureCount <= 3)
        {
            Lecture newLecture = new Lecture();

            newLecture.SetSpeaker(randomNames[GetRandomNumber(0, 20)]);
            newLecture.SetMaxCapacity(GetRandomNumber(100, 1000));
            newLecture.SetTitle(randomTitles[GetRandomNumber(0, 20)]);
            newLecture.SetDescription(randomDescriptions[GetRandomNumber(0, 20)]);
            newLecture.SetDate("07/13/2023");
            newLecture.SetTime("7:00pm");
            Address newAddress = new Address();
            newAddress.SetStreetAddress(randomStreetNames[GetRandomNumber(0, 12)]);
            newAddress.SetCity(randomCities[GetRandomNumber(0, 20)]);
            newAddress.SetState(randomStates[GetRandomNumber(0, 23)]);
            newAddress.SetProvance(randomProvances[GetRandomNumber(0, 20)]);
            newAddress.SetCountry(RandomCountries[GetRandomNumber(0, 20)]);
            newLecture.SetAddress(newAddress);
            _events.Add(newLecture);
            lectureCount++;
        }
        int outdoorCount = 0;
        while (outdoorCount <= 3)
        {
            OutdoorGathering newOutdoorGathering = new OutdoorGathering();

            newOutdoorGathering.SetForecast(randomForecast[GetRandomNumber(0,20)]);
            newOutdoorGathering.SetTitle(randomTitles[GetRandomNumber(0, 20)]);
            newOutdoorGathering.SetDescription(randomDescriptions[GetRandomNumber(0, 20)]);
            newOutdoorGathering.SetDate("07/13/2023");
            newOutdoorGathering.SetTime("7:00pm");
            Address newAddress = new Address();
            newAddress.SetStreetAddress(randomStreetNames[GetRandomNumber(0, 12)]);
            newAddress.SetCity(randomCities[GetRandomNumber(0, 20)]);
            newAddress.SetState(randomStates[GetRandomNumber(0, 23)]);
            newAddress.SetProvance(randomProvances[GetRandomNumber(0, 20)]);
            newAddress.SetCountry(RandomCountries[GetRandomNumber(0, 20)]);
            newOutdoorGathering.SetAddress(newAddress);
            _events.Add(newOutdoorGathering);
            outdoorCount++;
        }

        int GetRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

         foreach(Event i in _events)
        {
            Console.WriteLine();
            Console.WriteLine("****************************************");
            i.GetShortDescription();
            Console.WriteLine();
            i.GetFullDetails();
        }
    }
}