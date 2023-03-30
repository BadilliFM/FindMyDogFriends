using FindMyDogFriends.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.DbModels;

public class Technician : Account
{
    public string Phone { get; set; }
    public Roles Role { get; set; } //Mihaela = "Admin", Others may = "Dog park CRUD rights", etc..
    public string Area {get;set;} 
}
