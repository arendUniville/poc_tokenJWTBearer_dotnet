using JwtBearerPOC.Services.TokenServ;





var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<TokenService>();



var app = builder.Build();



app.MapGet("/", (TokenService service) => service.Generate(null));



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

