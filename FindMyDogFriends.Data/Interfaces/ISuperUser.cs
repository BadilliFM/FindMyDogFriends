using FindMyDogFriends.Data.DbModels;

namespace FindMyDogFriends.Data.Interfaces;

public interface ISuperUser : IUser
{
    string Phone { get; set; }
    Roles Role { get; set; }
}