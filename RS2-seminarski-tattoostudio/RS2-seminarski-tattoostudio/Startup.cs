using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using RS2_seminarski_tattoostudio.Configuration;
using RS2_seminarski_tattoostudio.Database;
using RS2_seminarski_tattoostudio.Filters;
using RS2_seminarski_tattoostudio.Services;
using System;
using System.Text;

namespace RS2_seminarski_tattoostudio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });

            services.AddSwaggerGen();

            services.AddDbContext<TattooStudioRSIIContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.Configure<AppSettings>(Configuration.GetSection(nameof(AppSettings)));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    var config = Configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();

                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ClockSkew = TimeSpan.Zero,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.Secret)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = ctx =>
                        {
                            if (ctx.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                ctx.Response.Headers.Add("Token-Expired", "true");
                            }
                            ctx.Response.Headers["Content-Type"] = "application/json";
                            ctx.Response.StatusCode = StatusCodes.Status401Unauthorized;
                            ctx.Fail("Expired token");
                            return ctx.Response.WriteAsync(JsonConvert.SerializeObject(new { message = "Unauthorized" }));
                        }
                    };
                });

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<IUposlenikService, UposlenikService>();
            services.AddScoped<IReadService<TattooStudio.Model.Spol, object>, BaseReadService<TattooStudio.Model.Spol, Spol, object>>();
            services.AddScoped<IReadService<TattooStudio.Model.Zanimanje, object>, BaseReadService<TattooStudio.Model.Zanimanje, Zanimanje, object>>();
            services.AddScoped<IReadService<TattooStudio.Model.TipProizvodum, object>, BaseReadService<TattooStudio.Model.TipProizvodum, TipProizvodum, object>>();
            services.AddScoped<IProizvodService, ProizvodService>();
            services.AddScoped<IIzvjestajService, IzvjestajService>();
            services.AddScoped<IObavijestService, ObavijestService>();
            services.AddScoped<IReadService<TattooStudio.Model.TipTermina, object>, BaseReadService<TattooStudio.Model.TipTermina, TipTermina, object>>();
            services.AddScoped<IStavkePortfoliumService, StavkePortfoliumService>();
            services.AddScoped<ITerminService, TerminService>();
            services.AddScoped<IPortfolioService, PortfolioService>();
            services.AddScoped<IStavkeNarudzbeService, StavkeNarudzbeService>();
            services.AddScoped<INarudzbaService, NarudzbaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
}
