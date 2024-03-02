public interface IDependencia2
{
    void DoSomething();
}

public class Dependencia2 : IDependencia2
{
    public void DoSomething()
    {
        Console.WriteLine("¡Hola desde la dependencia 2!");
    }
}

public class MiClase
{
    private readonly IDependencia2 _dependencia2;

    public MiClase(IDependencia2 dependencia2)
    {
        _dependencia2 = dependencia2;
    }

    public void DoSomething()
    {
        _dependencia2.DoSomething();
    }
}

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IDependencia2, Dependencia2>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                var miClase = new MiClase(context.RequestServices.GetRequiredService<IDependencia2>());
                miClase.DoSomething();
            });
        });
    }
}
