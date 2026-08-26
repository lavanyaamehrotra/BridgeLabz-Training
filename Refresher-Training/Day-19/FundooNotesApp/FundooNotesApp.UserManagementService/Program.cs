using System.Text;
using FundooNotesApp.UserManagementService.Helpers;
using FundooNotesApp.UserManagementService.Interfaces;
using FundooNotesApp.UserManagementService.Services;
using FundooNotesApp.UserManagementService.Data;
using FundooNotesApp.UserManagementService.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserDbConnection")));

builder.Services.AddScoped<IUserRL, UserRL>();
builder.Services.AddScoped<IUserBL, UserBL>();

builder.Services.AddSingleton(new RedisCacheHelper(
    builder.Configuration["RedisSettings:ConnectionString"]!
));

string jwtSecretKey = builder.Configuration["JwtSettings:SecretKey"]!;
builder.Services.AddSingleton(new JwtTokenHelper(jwtSecretKey));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecretKey))
    };
});

builder.Services.AddAuthorization();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "User Management Service API", Version = "v1" });

   options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
{
    Description = "Enter: Bearer {your JWT token}",
    Name = "Authorization",
    In = ParameterLocation.Header,
    Type = SecuritySchemeType.Http,
    Scheme = "Bearer",
    BearerFormat = "JWT"
});
options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
{
    { new OpenApiSecuritySchemeReference("Bearer", document), new List<string>() }
});
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
