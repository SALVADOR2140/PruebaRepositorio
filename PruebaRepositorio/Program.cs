
namespace PruebaRepositorio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            /* lo mejor es quitar las llaves que tambien rodean a los usos de swagger , app.UseSwagger y app.UseSwaggerUI para un 
               codigo mas limpio y es una buena practica tener swagger en todos los entornos */

            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}


            //nos quedaria asi , sin las llaves y sin el if
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
