using FindMyDogFriends.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Services;

public interface IDogparkService
{
    Task<List<DogparkVM>> GetAllDogparks();
    Task<DogparkVM> GetDogparkById(int Id);
}
