using FindMyDogFriends.Data.DbModels;

namespace FindMyDogFriends.Data.Interfaces;

public interface IUser : IAccount
{
    string FirstName { get; set; }
    string LastName { get; set; }
    float GeoLocationLongitude { get; set; }
    float GeoLocationLatitude { get; set; }
    ICollection<Dog> Dogs { get; set; }
}