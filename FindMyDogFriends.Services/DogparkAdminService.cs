using FindMyDogFriends.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Services;

public class DogparkAdminService : DogparkService, IDogparkAdminService
{
    public Task<DogparkVM> SaveDogparkById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<DogparkVM> DeleteDogparkById(int Id)
    {
        throw new NotImplementedException();
    }
}
