using FindMyDogFriends.Data.Interfaces;
namespace FindMyDogFriends.Data.DbModels;

abstract public class Account : IAccount
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}