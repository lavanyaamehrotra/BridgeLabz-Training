using System.Text;
using FundooNotesApp.ReminderService.Data;
using FundooNotesApp.ReminderService.Helpers;
using FundooNotesApp.ReminderService.Interfaces;
using FundooNotesApp.ReminderService.Repositories;
using FundooNotesApp.ReminderService.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ReminderDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FundooDbConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()
    ));

builder.Services.AddScoped<IReminderRL, ReminderRL>();
builder.Services.AddScoped<IReminderBL, ReminderBL>();
builder.Services.AddHttpClient();

builder.Services.AddSingleton(new EmailSender(
    builder.Configuration["SmtpSettings:Host"]!,
    int.Parse(builder.Configuration["SmtpSettings:Port"]!),
    builder.Configuration["SmtpSettings:SenderEmail"]!,
    builder.Configuration["SmtpSettings:SenderPassword"]!,
    builder.Configuration["SmtpSettings:SenderName"]!
));

builder.Services.AddHostedService<ReminderScannerService>();

string jwtSecretKey = builder.Configuration["JwtSettings:SecretKey"]!;
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
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Fundoo Reminder & Notification Service API", Version = "v1" });

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

try
{
    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<ReminderDbContext>();
        context.Database.EnsureCreated();
    }
}
catch
{
    // Transient database creation handler
}

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
