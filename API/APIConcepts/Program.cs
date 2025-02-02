
using APIConcepts.Services;
using APIConcepts.Services.TransientScopedSingleton;

namespace APIConcepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Register the ProductService with the dependency injection container
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IMessageService, MessageService>();

            builder.Services.AddTransient<ITransientService, OperationService>();
            builder.Services.AddScoped<IScopedService, OperationService>();
            builder.Services.AddSingleton<ISingletonService, OperationService>();

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
