using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyDogFriends.Data.ViewModels;

public class MainResponseModel
{
    public bool IsSuccess { get; set; }
    public string ErrorMessage { get; set; }
    public object Content { get; set; }
}
