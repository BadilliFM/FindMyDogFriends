using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace FindMyDogFriends.App.Pages.Components;

public partial class UserPosition : IAsyncDisposable
{
    [Inject]
    private ILogger<UserPosition> Logger { get; set; } = default!;

    protected override void OnInitialized()
    {
        Logger.LogInformation("UserPosition initialized.");
    }

    public async ValueTask DisposeAsync()
    {
        Logger.LogInformation("UserPosition disposed.");
    }
}

