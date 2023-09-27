using DataAccess.Data;
using DataAccess.IRepository;
using DataAccess.IRepository.TopWave;
using DataAccess.Mapper;
using DataAccess.Repository;
using DataAccess.Repository.TopWave;
using DataAccess.UnitOfWork;
using DataAccess.UnitOfWork.ClientSutep;
using DataAccess.UnitOfWork.General;
using DataAccess.UnitOfWork.Login;
using DataAccess.UnitOfWork.LogUnitOfWork;
using DataAccess.UnitOfWork.Standerd;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Models.DBModels;
using MyBusiness.Models;
using MyBusinessAPI.Models;
using System.Data;
using System.Reflection;
using System.Text.Json.Serialization;
using Utilities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
// Add services to the container.

ConfigurationManager configuration = builder.Configuration;
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); ;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,
        $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));
});
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1.0", new Info
//    {
//        Title = "My APIs",
//        Version = "v1.0",
//        Description = "REST APIs "
//    });
//    **// Set the comments path for the Swagger JSON and UI.**
//    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//    c.IncludeXmlComments(xmlPath);
//});
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//                .AddEntityFrameworkStores<ApplicationDbContext>();

   
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer("Data Source=198.38.84.196;Initial Catalog=admin_m_lgn_b_dev;User Id=admin_m_mybusiness_b;Password=MB_Mocha!1;TrustServerCertificate=True"));
builder.Services.AddDbContext<admin_m_log_bContext>(options =>
{
    options.UseSqlServer(CommonUtility.SQLConnectionLog);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddDbContext<admin_m_ent_bContext>(options =>
{
    options.UseSqlServer(CommonUtility.SqlConnection);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddDbContext<admin_m_gen_b_devContext>(options =>
{
    options.UseSqlServer(CommonUtility.SQLConnectionGeneral);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddDbContext<admin_m_standard_bContext>(options =>
{
    options.UseSqlServer(CommonUtility.SQLConnectionStanderd);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddDbContext<admin_client_setupContext>(options =>
{
    options.UseSqlServer(CommonUtility.SQLConnectionClientSetup);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddDbContext<admin_m_login_bContext>(options =>
{
    options.UseSqlServer(CommonUtility.SQLConnectionLogin);
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.Configure<EmailOptions>(configuration);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUnitOfWorkStanderd, UnitOfWorkStanderd>();
builder.Services.AddScoped<IUnitOfWorkLog, UnitOfWorkLog>();
builder.Services.AddScoped<ILoginUnitOfWork, LoginUnitOfWork>();
builder.Services.AddScoped<ILoginUserUnitOfWork, LoginUserUnitOfWork>();

builder.Services.AddScoped<IGeneralUnitOfWork, GeneralUnitOfWork>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseRouting();
app.UseCors(builder =>
    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
);
app.UseAuthorization();

app.MapControllers();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "api";
});

app.Run();
