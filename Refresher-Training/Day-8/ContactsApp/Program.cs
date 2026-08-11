using ContactsApp.Database;
using ContactsApp.Models;
using ContactsApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DbConnection>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();

var app = builder.Build();

app.MapGet("/", () => "Contacts Minimal API");

app.MapGet("/contacts", (IContactRepository repo) =>
{
    return Results.Ok(repo.GetAll());
});

app.MapGet("/contacts/{id:int}", (int id, IContactRepository repo) =>
{
    var contact = repo.GetById(id);

    return contact is null
        ? Results.NotFound()
        : Results.Ok(contact);
});

app.MapPost("/contacts", (Contact contact, IContactRepository repo) =>
{
    repo.Add(contact);

    return Results.Created("/contacts", contact);
});

app.MapPut("/contacts/{id:int}", (int id, Contact contact, IContactRepository repo) =>
{
    contact.Id = id;

    repo.Update(contact);

    return Results.Ok("Contact Updated");
});

app.MapDelete("/contacts/{id:int}", (int id, IContactRepository repo) =>
{
    repo.Delete(id);

    return Results.Ok("Contact Deleted");
});

app.Run();