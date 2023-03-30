using FindMyDogFriends.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.ViewModels;

public class UserVM 
{
    public UserVM(string firstname, string lastname)
    {
        this.FirstName = firstname;
        this.LastName = lastname;

    }
    public int Id { get; set; } //PK
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public string FullName()
    {
        string fullname = String.Format(FirstName, " ", LastName);
        return fullname;
    }
    public float GeoLocationLatitude { get; set; } //Budumvej: 57.0404
    public float GeoLocationLongitude { get; set; } //Budumvej: 9.995
    public ICollection<DogVM> Dogs { get; set; } //Navigation property
}
