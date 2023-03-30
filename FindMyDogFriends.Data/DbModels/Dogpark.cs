using FindMyDogFriends.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.DbModels;

public class Dogpark : IDogpark
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float GeoLocationLatitude { get; set; } //Budumvej: 57.0404
    public float GeoLocationLongitude { get; set; } //Budumvej: 9.995
    public int CurrentlyPresentUsersCount { get; set; }
    public virtual ICollection<User> CurrentlyPresentUsers { get; set; }
}
