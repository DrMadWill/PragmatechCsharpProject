# Api 

## Controller
> Hər controllerin başinda `[ApiController]``[Route("[controller]")]` yazılmalıdır. Və Controllerlər `ControllerBase` Clasından törəyir.


## Startup 
```cs
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers()
        .AddNewtonsoftJson(options =>
        //Microsoft.AspNetCore.Mvc.NewtonsoftJson
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("Default"));
        });
    }
```


