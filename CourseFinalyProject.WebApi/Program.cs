using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Core.Utilities.Security.Encryption;
using Core.Utilities.IoC;
using Autofac.Core;
using Core.Extensions;
using Core.DependencyResolvers;
using System.Text;
using CourseFinalyProject.Business.DependncyResolvers.Autofac;
using CourseFinalyProject.Business.Mapping;

namespace CourseFinalyProject.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region MyRegion
            //    var builder = WebApplication.CreateBuilder(args);
            //    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            //    builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            //    {
            //        builder.RegisterModule(new AutofacBusinessModule());
            //    });
            //    builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));
            //    var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            //    builder.Services.AddAuthentication(options =>
            //    {
            //        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    })
            //        .AddJwtBearer(options =>
            //        {
            //            options.TokenValidationParameters = new TokenValidationParameters
            //            {
            //                ValidateIssuer = true,
            //                ValidateAudience = true,
            //                ValidateLifetime = true,
            //                ValidateIssuerSigningKey = true,
            //                ValidIssuer = tokenOptions.Issuer,
            //                ValidAudience = tokenOptions.Audience,
            //                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
            //            };
            //        });
            //    builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
            //    builder.Services.AddAuthorization();
            //    builder.Services.AddControllers();
            //    builder.Services.AddEndpointsApiExplorer();
            //    builder.Services.AddSwaggerGen();
            //    var app = builder.Build();
            //    if (app.Environment.IsDevelopment())
            //    {
            //        app.UseSwagger();
            //        app.UseSwaggerUI();
            //    }

            //    app.UseHttpsRedirection();
            //    app.UseAuthentication();

            //    app.UseAuthorization();

            //    app.MapControllers();

            //    app.Run(); 
            #endregion
            var builder = WebApplication.CreateBuilder(args);

            // Autofac konfiqurasiyas?
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacBusinessModule());
            });
            //builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(typeof(GeneralMapping));
            // TokenOptions konfiqurasiyas?
            builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));
            var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            // Auth konfiqurasiyas?
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = tokenOptions.Issuer,
                    ValidAudience = tokenOptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
                };
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("http://localhost:3000") // frontend ünvanı
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });
            // Servisl?r
            builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
            builder.Services.AddAuthorization();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Middleware
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}
