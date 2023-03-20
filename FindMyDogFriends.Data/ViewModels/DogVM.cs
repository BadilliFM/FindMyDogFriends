using FindMyDogFriends.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.ViewModels;

public class DogVM
{
    public int Id { get; set; } //PK
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Breed { get; set; }
    public DateTime Birthday { get; set; }
    public int UserId { get; set; } //FK dog's user ID of the owner.
    public User User { get; set; } //Navigation property 1-dog-may-have-1-user (owner).
}
