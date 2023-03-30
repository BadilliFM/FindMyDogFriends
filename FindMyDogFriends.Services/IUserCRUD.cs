using FindMyDogFriends.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Services;

public interface IUserCRUD
{
    List<User> GetUserList();

    User GetUserDetailsById(int userId);

    User SaveUser(User userModel);


    User DeleteUser(int userId);
}
