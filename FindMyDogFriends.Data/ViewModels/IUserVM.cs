namespace FindMyDogFriends.Data.ViewModels
{
    public interface IUserVM
    {
        ICollection<DogVM> Dogs { get; set; }
        string FirstName { get; set; }
        float GeoLocationLatitude { get; set; }
        float GeoLocationLongitude { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string UserName { get; set; }
    }
}