using SpaceX.Models.DTO.User;

namespace SpaceX.Services
{
    public interface IAuthService
    {
        Task<UserModel> AuthenticateAsync(UserLogin userLogin);
        Task<string> GenerateToken(UserModel user);
    }
}
