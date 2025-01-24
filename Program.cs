using ARobinsonP2All4OneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
    policy => {
        policy.AllowAnyOrigin()     //allows request from any origin
              .AllowAnyMethod()     //allows any http request (put,get,delete etc.)
              .AllowAnyHeader();    //allows any headers
    });
});

builder.Services.AddCors(options => {
    options.AddPolicy("AllowSome",
    policy => {
        policy.WithOrigins("http://localhost:3000", "http://Example.com")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddScoped<SayHelloServices>();
builder.Services.AddScoped<Add2NumServices>();
builder.Services.AddScoped<GtrThnLessThnServices>();
builder.Services.AddScoped<WakeUpServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<OddEvnServices>();
builder.Services.AddScoped<ReverseCharServices>();
builder.Services.AddScoped<ReverseNumServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<Magic8Services>();
builder.Services.AddScoped<RestaurantServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
