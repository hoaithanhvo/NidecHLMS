using Asp.Versioning.ApiExplorer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text;

namespace NidecHLMS.API.Configs
{
	public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
	{
		/// <summary>
		/// Defines the _provider
		/// </summary>
		private readonly IApiVersionDescriptionProvider _provider;

		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigureSwaggerOptions"/> class.
		/// </summary>
		/// <param name="provider">The <see cref="IApiVersionDescriptionProvider">provider</see> used to generate Swagger documents</param>
		public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider) => this._provider = provider;

		/// <inheritdoc />

		/// <summary>
		/// The Configure
		/// </summary>
		/// <param name="options">The options<see cref="SwaggerGenOptions"/></param>
		public void Configure(SwaggerGenOptions options)
		{
			// Add JWT auth config
			options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
			{
				Name = "Authorization",
				Type = SecuritySchemeType.Http,
				Scheme = "bearer",
				BearerFormat = "JWT",
				In = ParameterLocation.Header,
				Description = "Bearer {your token}"
			});

			options.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Type = ReferenceType.SecurityScheme,
							Id = JwtBearerDefaults.AuthenticationScheme
						}
					},
					new string[] {}
				}
			});

			// Generate docs for each version
			foreach(var description in _provider.ApiVersionDescriptions)
			{
				options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
			}
		}

		/// <summary>
		/// Configure Swagger Options. Inherited from the Interface
		/// </summary>
		/// <param name="name"></param>
		/// <param name="options"></param>
		public void Configure(string name, SwaggerGenOptions options)
		{
			Configure(options);
		}

		/// <summary>
		/// The CreateInfoForApiVersion
		/// </summary>
		/// <param name="description">The description<see cref="ApiVersionDescription"/></param>
		/// <returns>The <see cref="OpenApiInfo"/></returns>
		private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
		{
			var text = new StringBuilder("Api versioning.");
			var info = new OpenApiInfo()
			{
				Title = "NIDEC HLMS PROJECT",
				Version = description.ApiVersion.ToString(),
				Contact = new OpenApiContact() { Name = "HLMS", Email = "NCVH-SYSTEM@nidec.com" },
				License = new OpenApiLicense() { Name = "Nidec", Url = new Uri("") }
			};

			if(description.IsDeprecated)
			{
				text.Append(" This API version has been deprecated.");
			}

			text.Append("<h4>Additional Information</h4>");
			info.Description = text.ToString();

			return info;
		}
	}
}
