using BaseLibrary.DTOs;
using System.Threading.Tasks;
using System.Linq;
using BaseLibrary.Responses;


namespace ServerLibrary.Repositories.Contracts;

public interface IUserAccount
{
  Task<GeneralResponse> CreateAsync(Register user);
  Task<LoginResponse> SignInAsync(Login user);

  Task<LoginResponse> RefreshTokenAsync(RefreshToken token);
}