using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.DbModels;

public class Dog
{
    public int Id { get; set; } //PK
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Breed { get; set; }
    public DateTime Birthday { get; set; }
    public int UserId { get; set; } //FK dog's user ID of the owner.
    public virtual User User { get; set; } //Navigation property 1-dog-may-have-1-user (owner).
}
