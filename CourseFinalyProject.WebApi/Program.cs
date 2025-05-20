using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Utilities.IoC;
using Core.Utilities.Security.Encryption;
using Core.Utilities.Security.JWT;
using CourseFinalyProject.Business.DependncyResolvers.Autofac;
using CourseFinalyProject.Business.Mapping;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;

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
            //    var tokenOptions = builder.Configuration.GetSection("TokenOptions").GetAsync<TokenOptions>();
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
            #region Evvelki
            //        var builder = WebApplication.CreateBuilder(args);

            //        // Autofac konfiqurasiyas?
            //        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            //        builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            //        {
            //            builder.RegisterModule(new AutofacBusinessModule());
            //        });
            //        //builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //        builder.Services.AddAutoMapper(typeof(GeneralMapping).Assembly);
            //        // TokenOptions konfiqurasiyas?
            //        builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));
            //        var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

            //        // Auth konfiqurasiyas?
            //        builder.Services.AddAuthentication(options =>
            //        {
            //            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //        })
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
            //        builder.Services.AddCors(options =>
            //        {
            //            options.AddPolicy("AllowFrontend", policy =>
            //            {
            //                policy.WithOrigins("http://localhost:3000") // frontend ünvanı
            //                      .AllowAnyHeader()
            //                      .AllowAnyMethod();
            //            });
            //        });
            //        builder.Services.AddSwaggerGen(c =>
            //        {
            //            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //            {
            //                Name = "Authorization",
            //                Type = SecuritySchemeType.ApiKey,
            //                Scheme = "Bearer",
            //                BearerFormat = "JWT",
            //                In = ParameterLocation.Header,
            //                Description = "JWT Token daxil edin: Bearer {token}"
            //            });

            //            // Security requirement - Swagger sorğularına token əlavə olunmasını tələb edir
            //            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            //{
            //    {
            //        new OpenApiSecurityScheme
            //        {
            //            Reference = new OpenApiReference
            //            {
            //                Type = ReferenceType.SecurityScheme,
            //                Id = "Bearer"
            //            }
            //        },
            //        new string[] {}
            //    }
            //});
            //        });

            //        // Servisl?r
            //        builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
            //        builder.Services.AddAuthorization();
            //        builder.Services.AddControllers();
            //        builder.Services.AddEndpointsApiExplorer();
            //        builder.Services.AddSwaggerGen();

            //        // Middleware
            //        var app = builder.Build();

            //        if (app.Environment.IsDevelopment())
            //        {
            //            app.UseSwagger();
            //            app.UseSwaggerUI();
            //        }

            //        app.UseHttpsRedirection();
            //        app.UseAuthentication();
            //        app.UseAuthorization();

            //        app.MapControllers();

            //        app.Run();
            #endregion



            var builder = WebApplication.CreateBuilder(args);
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule(new AutofacBusinessModule());
            });
            builder.Services.AddAutoMapper(typeof(GeneralMapping).Assembly);
            builder.Services.Configure<TokenOptions>(builder.Configuration.GetSection("TokenOptions"));
            var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)

                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = context =>
                        {
                            Console.WriteLine("Token true");
                            return Task.CompletedTask;
                        },
                        OnAuthenticationFailed = context =>
                        {
                            Console.WriteLine($"Authentication error: {context.Exception.Message}");
                            return Task.CompletedTask;
                        },
                        OnChallenge = context =>
                        {
                            Console.WriteLine($" Challenge error: {context.Error}, {context.ErrorDescription}");
                            return Task.CompletedTask;
                        }
                    };
                });

            builder.Services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Token daxil edin: Bearer {token}"
                });

                // Security requirement - Swagger sorğularına token əlavə olunmasını tələb edir
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
    });
            });

            builder.Services.AddDependencyResolvers(new ICoreModule[] { new CoreModule() });
            builder.Services.AddAuthorization();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseRouting();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}
