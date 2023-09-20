namespace Endpoints
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

            app.UseAuthorization();

            var summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

            app.MapGet("/Get", (HttpContext httpContext) =>
            {
                return "Hola Mundo";
            });

            app.MapPost("/Post", (LoginDto login) =>
            {
                return login;
            });

            app.MapPut("/Put", (LoginDto login) =>
            {
                return login;
            });

            app.MapDelete("/Delete", (int id) =>
            {
                return id;
            });


            app.Run();
        }
    }
}