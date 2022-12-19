using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using YoutubeManTours.Model;
using Type = YoutubeManTours.Model.Type;

namespace YoutubeManTours.Database
{
    public class DatabaseManager
    {
        public static DatabaseManager shared = new DatabaseManager();

        public DemoToursEntities entities = new DemoToursEntities();

        //MARK: Auth
        public User getUser(string email, string password)
        {
            return entities.Users.Where(u => u.email == email && u.password == password).FirstOrDefault();
        }

        //MARK: Tours
        public List<Tour> GetTours()
        {
            return entities.Tours.OrderBy(tour => tour.Name).ToList();
        }

        public List<Type> GetToursType()
        {
            List<Type> types = new List<Type>
            {
                new Type { Name = "Все типы" }
            };
            List<Type> defaultTypes = entities.Types.OrderBy(type => type.Name).ToList();
            types.AddRange(defaultTypes);
            return types;
        }

        public List<Tour> getToursByType(string type)
        {
            return GetTours().SelectMany(t => t.Types, (tour, typ) => new { tour, typ })
                                                            .Where(result => result.typ.Name == type)
                                                            .Select(result => result.tour).ToList();
        }

        public List<Tour> searchTourByName(List<Tour> inList, string byName)
        {
            return inList.OrderBy(t => t.Name).Where(t => t.Name.ToLower().Contains(byName.ToLower())).ToList();
        }

        public List<Tour> getActualTours(List<Tour> inList)
        {
            return inList.OrderBy(t => t.Name).Where(t => t.IsActual).ToList();
        }


        //MARK: Hotels
        public List<Hotel> getHotels()
        {
            return entities.Hotels.OrderBy(hotel => hotel.Name).ToList();
        }

        public List<Hotel> getCountriesByPage(int page)
        {
            return getHotels().Skip((page - 1) * 10).Take(10).ToList();
        }

        public List<Country> getCountries()
        {
            return entities.Countries.OrderBy(country => country.Name).ToList();
        }

        public void addHotelToDB(string name, int stars, string description, Country county)
        {
            Hotel newHotel = new Hotel
            {
                Name = name,
                CountOfStars = stars,
                Description = description,
                Country = county
            };

            entities.Hotels.AddObject(newHotel);
            entities.SaveChanges();
        }

        public void updateHotel(Hotel hotel, string name, int stars, string description, Country country)
        {
            hotel.Name = name;
            hotel.CountOfStars = stars;
            hotel.Description = description;
            hotel.Country = country;

            entities.SaveChanges();
        }
    }

}
