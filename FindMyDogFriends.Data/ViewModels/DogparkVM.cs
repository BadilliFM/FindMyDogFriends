using FindMyDogFriends.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.ViewModels;

public class DogparkVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GeoLocationLatitude { get; set; } //Budumvej: 57.0404
    public float GeoLocationLongitude { get; set; } //Budumvej: 9.995
    public int CurrentlyPresentUsersCount { get; set; }
    public ICollection<UserVM> CurrentlyPresentUsers { get; set; }
}
