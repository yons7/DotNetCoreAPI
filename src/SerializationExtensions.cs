using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Diagnostics.CodeAnalysis;

namespace DotNetCoreAPI
{
#pragma warning disable S1200
    /// <summary>
    /// SerializationExtensions
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal static class SerializationExtensions
    {
        internal static IMvcCoreBuilder AddCustomSerialization(this IMvcCoreBuilder builder)
        {
            builder.AddNewtonsoftJson(UpdateMvcNewtonsoftJsonOptions);

            return builder;
        }

        private static void UpdateMvcNewtonsoftJsonOptions(MvcNewtonsoftJsonOptions options)
        {
            var settings = options.SerializerSettings;
            settings.ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(true, false),
            };

            // Output enumeration values as strings in JSON.
            settings.Converters.Add(new StringEnumConverter());
            // Parse dates as DateTimeOffset values by default. You should prefer using DateTimeOffset over
            // DateTime everywhere. Not doing so can cause problems with time-zones.
            settings.DateParseHandling = DateParseHandling.DateTimeOffset;
            // Do not indent JSON output.
            settings.Formatting = Formatting.None;

            settings.NullValueHandling = NullValueHandling.Ignore;
        }
    }
#pragma warning restore S1200
}
