﻿using Domain.Exceptions;
using Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Model.Entities.Users;
using Model.Entities.Users.Models;

namespace WebGui.Services;

public class UserService {
    private readonly CustomAuthStateProvider _authenticationStateProvider;

    private readonly IUserRepository _userRepository;

    public UserService(AuthenticationStateProvider authenticationStateProvider, IUserRepository userRepository) {
        _authenticationStateProvider = authenticationStateProvider
                                           as CustomAuthStateProvider ??
                                       throw new NullReferenceException(
                                           "I Guess you forgot to add the CustomAuthStateProvider to the Dependency Injection container");
        _userRepository = userRepository;
    }

    public User? CurrentUser => _authenticationStateProvider.CurrentUser;

    public void RegisterMethodForLoginStateChangeEvent(Func<bool> method) {
        _authenticationStateProvider.LoginStateChanged += method;
    }

    public Task<AuthenticationState> GetAuthenticationStateAsync() =>
        _authenticationStateProvider.GetAuthenticationStateAsync();

    public async Task<bool> IsAuthenticated() {
        var identity = await _authenticationStateProvider.GetAuthenticationStateAsync();
        return identity.User.Identity is { IsAuthenticated: true };
    }

    public async Task<bool> HasRole(string role) {
        var identity = await _authenticationStateProvider.GetAuthenticationStateAsync();
        return identity.User.IsInRole(role);
    }

    public async Task RegisterAsync(User user, CancellationToken ct = default) {
        // check for unique stuff
        var userExists = await _userRepository.FindByUsernameAsync(user.UserName, ct);
        if (userExists != null)
            throw new DuplicateUserNameException();

        user.PasswordHash = User.HashPassword(user.LoginPassword);
        await _userRepository.CreateAsync(user);
    }

    public async Task LoginAsync(LoginModel loginModel, CancellationToken ct = default) {
        var user = await _userRepository.AuthorizeAsync(loginModel, ct);
        if (user is null)
            throw new LoginException();

        await _authenticationStateProvider.Login(user);
    }

    public async Task LogoutAsync() {
        await _authenticationStateProvider.Logout();
    }
}