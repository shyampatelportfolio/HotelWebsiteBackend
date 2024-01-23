using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace HotelsBackend.Data
{
    public class HotelShortlist
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public int HotelId { get; set; }
        public string? HotelTitle { get; set; }
        public string? HotelDescription { get; set; }
        public string? HotelLocation { get; set; }
        public HotelFilter Filters { get; set; }
        public string FrontImage { get; set; }
    }
    public class HotelFilter
    {
        public FilterBools Bools { get; set; }
        public FilterQuantities Quantities { get; set; }
        public Coordinates Coordinates { get; set; }
    }
    public class FilterBools
    {
        public BoolsAmenities Amenities { get; set; }
        public BoolsTravellerExperiences TravellerExperiences { get; set; }
        public BoolsMisc Misc { get; set; }
    }
    public class FilterQuantities
    {
        public double Rating { get; set; }
        public double Price { get; set; }
    }


    public class BoolsAmenities
    {
        public bool Kitchen { get; set; }
        public bool Washing { get; set; }
        public bool Restaurant { get; set; }
        public bool Gym { get; set; }
        public bool Wifi { get; set; }
        public bool Parking { get; set; }

    }
    public class BoolsTravellerExperiences
    {
        public bool Lgbtq { get; set; }
        public bool BusinessFriendly { get; set; }
        public bool FamilyFriendly { get; set; }
    }
    public class BoolsMisc
    {
        public bool InstantBook { get; set; }
        public bool SelfCheckIn { get; set; }
        public bool SuperHost { get; set; }
    }
}
