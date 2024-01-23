using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace HotelsBackend.Data
{
    public class Hotel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int HotelId { get; set; }
        public string? HotelTitle { get; set; }
        public string? HotelDescription { get; set; }
        public string? HotelLocation { get; set; }
        public Rating Rating { get; set; }
        public string FrontImage { get; set; }

    }
    
    public class Rating
    {
        public double AverageRating { get; set; }
        public double Cleanliness { get; set; }
        public double StaffService { get; set; }
        public double ValueForMoney { get; set; }
    }
}
