using FoodDelivery.Application.Common.Errors;
using FoodDelivery.Application.Common.Interfaces.Authentication;
using FoodDelivery.Application.Common.Interfaces.Persistence;
using FoodDelivery.Domain.Entities;
using OneOf;

namespace FoodDelivery.Application.Services.Authentication;

public class AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository) : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator = jwtTokenGenerator;
    private readonly IUserRepository _userRepository = userRepository;

    public OneOf<AuthenticationResult, DuplicateEmailError> Register(string firstName, string lastName, string email, string password)
    {
        //Validate the user doen't exists
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            return new DuplicateEmailError();
        }

        //Create user (unique id)
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);
        
        //Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthenticationResult(
            user,
            token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        //Validate the user exists
        if (_userRepository.GetUserByEmail(email) is not User user)
            throw new Exception("User with given email does not exist");

        //Validate the password is correct
        if (user.Password != password)
            throw new Exception("Invalid password");

        //Create JWT token
        var token = _jwtTokenGenerator.GenerateToken(user);
                
        return new AuthenticationResult(
            
            user,
            token);
    }
}