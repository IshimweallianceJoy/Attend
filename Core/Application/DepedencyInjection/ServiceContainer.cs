
using Microsoft.Extensions.DependencyInjection;
using Application.Services.StudentServices;
using Application.Services.ClassServices;
using Application.Services.IdentityServices;
using Application.Services.AttendenceServices;
using Application.Services.StudentAttendenceServices;
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
            services.AddScoped<IClassStudentService, ClassStudentService>();
            services.AddScoped<IAttendenceService, AttendenceService>();
            services.AddScoped<IStudentAttendenceService, StudentAttendenceService>();
            services.AddScoped<IFaculityService, FaculityService>();
            services.AddScoped<IEducationLevelService, EducationLevelService>();
            services.AddScoped<IIdentityService, IdentityService>();

            
            return services;
        }
    }
}