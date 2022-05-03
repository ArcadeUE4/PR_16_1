using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PR_16_1.Models;

namespace PR_16_1
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            string con = "Server=(localdb)\\mssqllocaldb;Database=friendsdb1;Trusted_Connection=True;";
            // ������������� �������� ������
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(con));

            services.AddControllers(); // ���������� ����������� ��� �������������
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // ���������� ������������� �� �����������
            });
        }


    }
}