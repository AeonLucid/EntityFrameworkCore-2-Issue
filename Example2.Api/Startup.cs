using Example2.DatabaseStandard;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Example2.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

//            services.AddDbContextPool<DatabaseContext>(
//                builder => builder.UseSqlite("Data Source=:memory:;Version=3;New=True;",
//                    optionsBuilder => optionsBuilder.MigrationsAssembly("Example2.Api"))
//            );

            services.AddDbContextPool<DatabaseContext>(
                builder => builder.UseSqlite("Data Source=:memory:;Version=3;New=True;",
                    optionsBuilder => optionsBuilder.MigrationsAssembly("Example2.Api"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
