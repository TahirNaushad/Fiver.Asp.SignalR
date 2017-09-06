using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Fiver.Asp.SignalR
{
    public class Startup
    {
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseFileServer();
        }
    }
}
