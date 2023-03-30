using FindMyDogFriends.Data.DbModels;
using FindMyDogFriends.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.ViewModels;

public class SuperUserVM : UserVM
{
    public SuperUserVM(string firstname, string lastname) : base(firstname, lastname)
    {
    }

    public int Id { get; set; }
    public string UserName { get; set; }
    public string Phone { get; set; }
    public Roles Role { get; set; } //Mihaela = "Admin", Others may = "Dog park CRUD rights", etc..
}
