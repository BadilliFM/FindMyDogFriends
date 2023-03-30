using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.Interfaces;

public interface IAccount
{
    int Id { get; set; }
    string UserName { get; set; }
    string Password { get; set; }
}
