using Domain.Handler.Implementation;
using Domain.Handler.Interfaces;
using Domain.Repositories.Implementation;
using Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Model.Configuration;
using MudBlazor.Services;
using WebGui;
using WebGui.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<PlaybookContext>(
    options => options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"), 
        new MySqlServerVersion(new Version(8,0,26))
    ).UseLoggerFactory(new NullLoggerFactory())
    //.UseLoggerFactory(new NullLoggerFactory()) is to remove mysql query logging
);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IStorySectionRepository, StorySectionRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();
builder.Services.AddScoped<ISectionHistoryRepository, SectionHistoryRepository>();
builder.Services.AddScoped<IPlayedBookRepository, PlayedBookRepository>();
builder.Services.AddScoped<IAbilityRepository, AbilityRepository>();

builder.Services.AddScoped<SessionService>();

builder.Services.AddScoped<IThemeHandler, ThemeHandler>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();
builder.Services.AddScoped<IUserRoleClaimRepository, UserRoleClaimRepository>();

builder.Services.AddMudServices();
builder.Services.AddLogging();

builder.Services.AddScoped<CircuitHandler, CircuitTracker>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();