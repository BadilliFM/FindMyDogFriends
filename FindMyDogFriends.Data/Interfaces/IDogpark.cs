using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.Interfaces;

public interface IDogpark
{
    int Id { get; set; }
    string Name { get; set; }
    float GeoLocationLatitude { get; set; } //Budumvej: 57.0404
    float GeoLocationLongitude { get; set; } //Budumvej: 9.995
}
