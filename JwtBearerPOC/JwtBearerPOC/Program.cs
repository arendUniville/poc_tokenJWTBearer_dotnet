using JwtBearerPOC.Model;
using JwtBearerPOC.Services.TokenServ;





var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<TokenService>();



var app = builder.Build();



app.MapGet("/", (TokenService service) 
    => service.Generate(
        new User(
            new Guid(), 
            "i.arend@gmail.com", 
            "Arend123@", 
            new [] 
            {
                "student", "premium"
            }
            )));



app.Run();





















/*
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
*/

