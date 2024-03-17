using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion
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
            builder.Services.AddScoped<UsuarioService>();
            builder.Services.AddScoped<ProductoService>();
            builder.Services.AddScoped<VentaService>();
            builder.Services.AddScoped<ProductoVendidoService>();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyMethod();
                    policy.AllowAnyOrigin();
                    policy.AllowAnyHeader();
                });
            });

            builder.Services.AddDbContext<CoderContext>(options => options.UseSqlServer("Server=.;Database=coderhouse;Trusted_Connection=True;"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors();
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
