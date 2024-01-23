
using Azure;
using HotelsBackend.Data;
using HotelsBackend.Functions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


namespace HotelsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindHotels : ControllerBase
    {
        private readonly IMongoCollection<HotelShortlist> _collection;
        private readonly IMongoCollection<Hotel> _collection2;
        private readonly IMongoCollection<Room> _collection3;
        private readonly IMongoCollection<Review> _collection4;
        private readonly IConfiguration _config;

        public FindHotels(IMongoClient client, IConfiguration config)
        {
            var database = client.GetDatabase("Hotels");
            _collection = database.GetCollection<HotelShortlist>("HotelShortlist");
            _collection2 = database.GetCollection<Hotel>("HotelMain");
            _collection3 = database.GetCollection<Room>("Rooms");
            _collection4 = database.GetCollection<Review>("Reviews");
            _config = config;
        }



        [HttpPost("HotelShortlist")]
        public ActionResult<HotelShortListWithMessage> FindHotelShortlist(Coordinates coordinates)
        {

            double userLat = coordinates.lat;
            double userLon = coordinates.lon;
            Coordinates newCoordinates = coordinates;
            List<HotelShortlist> hotels = new List<HotelShortlist>();
            string message = "Ok";

            var queryableCollection = _collection.AsQueryable();
            int counter = 1;
            bool noResults = true;
            IQueryable<HotelShortlist> querySearching = queryableCollection.AsQueryable().Where(x => false);
                while (noResults)
                {
                    if (querySearching.Count() != 0)
                    {
                        noResults = false;
                        break;
                    }
                    if (counter > 16)
                    {
                        message = "Too Far";
                        noResults = false;
                        counter = 1;
                        userLat = 51.440161724357345;
                        userLon = -0.20516564258860948;
                        newCoordinates.lat = userLat;
                        newCoordinates.lon = userLon;
                    }
                    querySearching = queryableCollection
                    .Where(r => r.Filters.Coordinates.lat > userLat - counter && r.Filters.Coordinates.lat < userLat + counter
                    && r.Filters.Coordinates.lon > userLon - counter && r.Filters.Coordinates.lon < userLon + counter
                    );

                    counter += 2;

                  
                }

                double distanceMin = 1000000000;
                Coordinates coordinates1 = new Coordinates();
                int i = 0;
                foreach (var hotel in querySearching)
                {
                    if (i == 0)
                    {
                        distanceMin = Functions1.CalculateDistance(newCoordinates, hotel.Filters.Coordinates);
                        coordinates1 = hotel.Filters.Coordinates;
                    }
                    double distanceTo = Functions1.CalculateDistance(newCoordinates, hotel.Filters.Coordinates);
                    if (distanceTo < distanceMin)
                    {
                        distanceMin = distanceTo;
                        coordinates1 = hotel.Filters.Coordinates;
                    }
                    i++;
                }


                var queryClosest = queryableCollection
                .Where(r => r.Filters.Coordinates.lat > coordinates1.lat - 1 && r.Filters.Coordinates.lat < coordinates1.lat + 1
                && r.Filters.Coordinates.lon > coordinates1.lon - 1 && r.Filters.Coordinates.lon < coordinates1.lon + 1
                );
                foreach (var hotel in queryClosest)
                {
                    double distanceTo = Functions1.CalculateDistance(coordinates1, hotel.Filters.Coordinates);
                    if (distanceTo < 80)
                    {
                        hotels.Add(hotel);
                    }
                }
            
            if (counter > 7)
            {
                message = "Too Far";
            }


            HotelShortListWithMessage hotelShortListWithMessage = new HotelShortListWithMessage();
            foreach (HotelShortlist hotel in hotels)
            {
                hotel.FrontImage = $"{_config["Azure:BlobStorage:FrontImages"]}/{hotel.FrontImage}";
            }
            hotelShortListWithMessage.hotelShortlist = hotels;
            hotelShortListWithMessage.Message = message;

            return Ok(hotelShortListWithMessage);
        }



        [HttpPost("OverviewPage")]
        public ActionResult<OverviewPageData> FindOverviewPageData(int hotelId)
        {
            OverviewPageData overviewPageData = new OverviewPageData();
            var filter = Builders<Hotel>.Filter
                            .Eq(x => x.HotelId, hotelId);
            var fetchResult = _collection2.Find(filter).ToList();
            if(fetchResult.Count == 0)
            {
                return Ok("Empty");
            }
            Hotel hotel = fetchResult[0];
            hotel.FrontImage = $"{_config["Azure:BlobStorage:FrontImages"]}/{hotel.FrontImage}";
            overviewPageData.Hotel = hotel;



            var filterRoom = Builders<Room>.Filter
                         .Eq(x => x.HotelId, hotelId);
            var results = _collection3.Find(filterRoom).ToList();
            int j = 0;
            List<string> myImages = new List<string>();
            foreach (Room room in results)
            {
                foreach (string image in room.Images)
                {
                    string roomImage = $"{_config["Azure:BlobStorage:RoomImages"]}/{image}";
                    myImages.Add(roomImage);
                }
            }
            overviewPageData.RoomImages = myImages;

            return Ok(overviewPageData);
        }

        [HttpPost("GalleryPage")]
        public ActionResult<List<Room>> FindGalleryPageData(int hotelId)
        {
            var filter = Builders<Room>.Filter
                            .Eq(x => x.HotelId, hotelId);
            var results = _collection3.Find(filter).ToList();
            if (results.Count() == 0) return Ok("no results found");

            int j = 0;
            foreach (Room room in results)
            {
                List<string> myImages = new List<string>();
                foreach (string image in room.Images)
                {
                    string roomImage = $"{_config["Azure:BlobStorage:RoomImages"]}/{image}";
                    myImages.Add(roomImage);
                }
                results[j].Images = myImages;
                j++;
            }
            return Ok(results);
        }

        [HttpPost("Checkout")]
        public ActionResult<CheckoutRoom> FindCheckout(int roomId)
        {
            var filter = Builders<Room>.Filter
                            .Eq(x => x.RoomId, roomId);
            var results = _collection3.Find(filter).ToList();
            if(results.Count == 0)
            {
                return Ok("Empty");
            }
            string image = results[0].Images[0];

            string imageURL = $"{_config["Azure:BlobStorage:RoomImages"]}/{image}";

            CheckoutRoom checkoutRoom = new CheckoutRoom();
            checkoutRoom.Price = results[0].Price;
            checkoutRoom.Image = imageURL;
            return Ok(checkoutRoom);
        }

        [HttpPost("ReviewPage")]
        public ActionResult<ReviewPageData> FindReviewPageData(int hotelId)
        {
            ReviewPageData reviewPageData = new ReviewPageData();

            var filterHotel = Builders<Hotel>.Filter
                        .Eq(x => x.HotelId, hotelId);
            var fetchResult = _collection2.Find(filterHotel).ToList();
            if (fetchResult.Count == 0)
            {
                return Ok("Empty");
            }
            Hotel hotel = fetchResult[0];
            hotel.FrontImage = $"{_config["Azure:BlobStorage:FrontImages"]}/{hotel.FrontImage}";
            reviewPageData.Hotel = hotel;


            var filter = Builders<Review>.Filter
                            .Eq(x => x.HotelId, hotelId);
            var results = _collection4.Find(filter).ToList();
            reviewPageData.Reviews = results;
          

            return Ok(reviewPageData);
        }

    }
}
