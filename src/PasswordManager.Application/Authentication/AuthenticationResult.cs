using PasswordManager.Domain.Entities;

namespace PasswordManager.Application.Authentication;

public record AuthenticationResult(User User, string Token);