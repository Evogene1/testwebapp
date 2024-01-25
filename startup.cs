using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
 
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Не требуется конфигурация сервисов для статического веб-приложения.
    }
 
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
 
        app.UseDefaultFiles();
        app.UseStaticFiles();
    }
}