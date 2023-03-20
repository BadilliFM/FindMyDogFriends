using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.DbModels;

public class User
{
    public int Id { get; set; } //PK
    public string UserName { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public float GeoLocationLatitude { get; set; } //Budumvej: 57.0404
    public float GeoLocationLongitude { get; set; } //Budumvej: 9.995
    public virtual ICollection<Dog> Dogs { get; set; } //Navigation property 1-user-to-Many-dogs
}
