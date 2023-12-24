using HotelListing.DTOs.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDTO apiUserDTO);
        Task<AuthResponseDTO> Login(LoginDTO loginDTO);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDTO> VerifyRefreshToken(AuthResponseDTO authResponseDTO);

    }
}
