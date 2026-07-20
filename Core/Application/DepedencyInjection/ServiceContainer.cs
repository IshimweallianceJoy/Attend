
using Microsoft.Extensions.DependencyInjection;
using Application.Services.StudentServices;
using Application.Services.ClassServices;
using Application.Services.AttendenceServices;
using Application.Services.ClassStudentServices;
using Application.Services.FaculityServices;
using Application.Services.EducationLevelServices;
using Domain.Entities;
namespace Application.DependencyInjection
{
    public static class ServiceContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IClassService, ClassService>();
            services.AddScoped<IAttendenceService, AttendenceService>();
            services.AddScoped<IFaculityService, FaculityService>();
           
            services.AddScoped<IEducationLevelService, EducationLevelService>();

            
            return services;
        }
    }
}