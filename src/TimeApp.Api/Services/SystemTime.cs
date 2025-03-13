using TimeApp.Api.Model;

namespace TimeApp.Api.Services;

public interface ITimeOnly
{
     TimeSpan UtcNow { get; }
}







