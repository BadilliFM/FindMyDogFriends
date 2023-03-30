using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMyDogFriends.Data.Interfaces;

namespace FindMyDogFriends.Data.DbModels;

public class SuperUser : User, ISuperUser
{
    public string Phone { get; set; }
    public Roles Role { get; set; } //Mihaela = "Admin", Others may = "Dog park CRUD rights", etc.. 
}
