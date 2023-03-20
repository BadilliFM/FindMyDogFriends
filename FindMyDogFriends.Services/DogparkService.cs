using FindMyDogFriends.Data.ViewModels;
using Newtonsoft.Json;

namespace FindMyDogFriends.Services;

public class DogparkService : IDogparkService
{
    private string _baseUrl = "https://localhost:7136";

    public async Task<List<DogparkVM>> GetAllDogparks()
    {
        var returnResponse = new List<DogparkVM>();
        try
        {
            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}/Dogpark/GetAllDogparks";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserilizeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserilizeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<List<DogparkVM>>(deserilizeResponse.Content.ToString());
                    }
                }
            }
        }
        catch (Exception ex)
        {
            string msg = ex.Message;
        }
        return returnResponse;

    }

    public async Task<DogparkVM> GetDogparkById(int Id)
    {
        var returnResponse = new DogparkVM();
        try
        {
            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}/Dogpark/GetDogparkById/{Id}";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserilizeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserilizeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<DogparkVM>(deserilizeResponse.Content.ToString());
                    }
                }
            }
        }
        catch (Exception ex)
        {
            string msg = ex.Message;
        }
        return returnResponse;

    }
}
