namespace NidecLocationVisualize.Api.API.Configs
{
	using Application.Common.Behaviors;
	//using Application.Features.Queries.Divisions;
	//using Infrastructure.GrpcClient.ProtosFile;
	using Infrastructure.Models;
	using MediatR;
	using Microsoft.AspNetCore.Authentication.JwtBearer;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.IdentityModel.Tokens;
	using NidecHLMS.API.Configs;
	using System.Text;

	/// <summary>
	/// Defines the <see cref="ConfigService" />
	/// </summary>
	public static class ConfigService
	{
		/// <summary>
		/// The AddJwtAuthentication
		/// </summary>
		/// <param name="services">The services<see cref="IServiceCollection"/></param>
		/// <param name="configuration">The configuration<see cref="IConfiguration"/></param>
		public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
		{
			var jwt = configuration.GetSection("JwtOptions").Get<JwtOption>();

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(options =>
				{
					options.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuer = true,
						ValidIssuer = jwt.Issuer,
						ValidateAudience = true,
						ValidAudience = jwt.Audience,
						ValidateLifetime = true,
						ValidateIssuerSigningKey = true,
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey)),
						ClockSkew = TimeSpan.Zero
					};
					options.Events = new JwtBearerEvents
					{
						OnAuthenticationFailed = context =>
						{
							Console.WriteLine("JWT ERROR: " + context.Exception);
							return Task.CompletedTask;
						}
					};
				});
		}

		/// <summary>
		/// The AddApiVersioningServices
		/// </summary>
		/// <param name="builder">The builder<see cref="IHostApplicationBuilder"/></param>
		public static void AddApiVersioningServices(this IHostApplicationBuilder builder)
		{
			builder.Services.AddApiVersioning(options =>
			{
				options.AssumeDefaultVersionWhenUnspecified = true; //This ensures if client doesn't specify an API version. The default version should be considered. 
				options.DefaultApiVersion = new Asp.Versioning.ApiVersion(1); //This we set the default API version
				options.ReportApiVersions = true; //The allow the API Version information to be reported in the client  in the response header. This will be useful for the client to understand the version of the API they are interacting with.

				//------------------------------------------------//
				//options.ApiVersionReader = ApiVersionReader.Combine(
				//    new QueryStringApiVersionReader("api-version"),
				//    new HeaderApiVersionReader("x-api-version"),
				//    new MediaTypeApiVersionReader()); //This says how the API version should be read from the client's request, 3 options are enabled 1.Querystring, 2.Header, 3.MediaType. 
				//"api-version", "X-Version" and "ver" are parameter name to be set with version number in client before request the endpoints.
			}).AddApiExplorer(options =>
			{
				options.GroupNameFormat = "'v'VVV"; //The say our format of our version number “‘v’major[.minor][-status]”
				options.SubstituteApiVersionInUrl = true; //This will help us to resolve the ambiguity when there is a routing conflict due to routing template one or more end points are same.
			});
		}

		/// <summary>
		/// The AddSwaggerServices
		/// </summary>
		/// <param name="builder">The builder<see cref="IHostApplicationBuilder"/></param>
		public static void AddSwaggerServices(this IHostApplicationBuilder builder)
		{
			builder.Services.AddSwaggerGen();
			builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
		}

		/// <summary>
		/// The AddCorsPolicy
		/// </summary>
		/// <param name="builder">The builder<see cref="IHostApplicationBuilder"/></param>
		public static void AddCorsPolicy(this IHostApplicationBuilder builder)
		{
			builder.Services.AddCors(options =>
			{
				options.AddPolicy("AllowAll",
					policy => policy
						.AllowAnyMethod()
						.AllowAnyHeader()
						.AllowCredentials()
						.SetIsOriginAllowed(_ => true) // hoặc .WithOrigins("http://localhost:4200")
				);
			});
		}

		/// <summary>
		/// Adds the handle exception validate
		/// </summary>
		/// <param name="builder">The builder<see cref="IHostApplicationBuilder"/></param>
		public static void AddHandleExceptionValidate(this IHostApplicationBuilder builder)
		{
			builder.Services.Configure<ApiBehaviorOptions>(options =>
			{
				options.InvalidModelStateResponseFactory = context =>
				{
					var errors = context.ModelState
						.Where(x => x.Value.Errors.Count > 0)
						.ToDictionary(
							k => k.Key,
							v => v.Value.Errors.Select(e => e.ErrorMessage).ToArray()
						);

					var response = new
					{
						success = false,
						status = 400,
						title = "Validation Failed",
						details = errors
					};

					return new BadRequestObjectResult(response);
				};
			});
		}

		/// <summary>
		/// The AddMediatRConfig
		/// </summary>
		/// <param name="builder">The builder<see cref="IHostApplicationBuilder"/></param>
		//public static void AddMediatRConfig(this IHostApplicationBuilder builder)
		//{
		//	builder.Services.AddMediatR(
		//		typeof(Program).Assembly,
		//		typeof(FilterDivisionHandle).Assembly
		//	);

		//	builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehavior<,>));

		//}

		//public static void AddGrpcClientService(this IHostApplicationBuilder builder)
		//{
		//	var grpcServerUrl = builder.Configuration["GrpcSettings:IdmServiceUrl"]
		//						 ?? throw new Exception("Not found GRPC Setting");

		//	builder.Services.AddGrpcClient<ServiceGetUser.ServiceGetUserClient>(options =>
		//	{
		//		options.Address = new Uri(grpcServerUrl);
		//	})
		//	.ConfigureChannel(options =>
		//	{
		//		options.MaxReceiveMessageSize = 5 * 1024 * 1024;
		//		options.MaxSendMessageSize = 2 * 1024 * 1024;
		//	})
		//	.ConfigurePrimaryHttpMessageHandler(() =>
		//	{
		//		var handler = new HttpClientHandler();
		//		handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
		//		return handler;
		//	});
		//}

	}
}
