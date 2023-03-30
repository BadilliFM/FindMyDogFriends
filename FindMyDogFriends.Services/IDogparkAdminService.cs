using FindMyDogFriends.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Services;

public interface IDogparkAdminService 
{
    Task<DogparkVM> SaveDogparkById(int Id);
    Task<DogparkVM> DeleteDogparkById(int Id);
}
