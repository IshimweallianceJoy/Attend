using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.Identity;
using Domain.Entities;
namespace Infrastructure.DependencyInjection
{
     public static class ServiceContainer
    {
               public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
        
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("attendcon"))
            );

             services.AddAuthenticationService(configuration);
            services.AddScoped<IStudent, StudentRepository>();
            
            services.AddScoped<IClass, ClassRepository>();
            
            services.AddScoped<IClassStudent, ClassStudentRepository>();
            services.AddScoped<IFaculity, FaculityRepository>();
            services.AddScoped<IEducationLevel, EducationLevelRepository>();
            services.AddScoped<IAttendence, AttendenceRepository>();
            services.AddScoped<IStudentAttendence, StudentAttendenceRepository>();
            services.AddScoped<IIdentity, IdentityRepository>();
            return services;
        }
    }
}