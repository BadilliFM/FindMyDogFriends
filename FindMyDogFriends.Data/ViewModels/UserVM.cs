using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.ViewModels;

public class UserVM
{
    public int Id { get; set; } //PK
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public float GeoLocationLatitude { get; set; } //Budumvej: 57.0404
    public float GeoLocationLongitude { get; set; } //Budumvej: 9.995
    public ICollection<DogVM> Dogs { get; set; } //Navigation property
}
