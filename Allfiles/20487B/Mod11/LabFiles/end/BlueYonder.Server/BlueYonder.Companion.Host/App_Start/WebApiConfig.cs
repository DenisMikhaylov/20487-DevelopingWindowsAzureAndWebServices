using BlueYonder.Companion.Controllers;
using BlueYonder.Companion.Controllers.Formatters;
using BlueYonder.Companion.Host.Authentication;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Thinktecture.IdentityModel.Tokens.Http;

namespace BlueYonder.Companion.Host
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.DependencyResolver = new BlueYonderResolver();

            config.Formatters.Add(new AtomFormatter());

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
         
            AuthenticationConfiguration authenticationConfig = AuthenticationConfig.CreateConfiguration();

            config.Routes.MapHttpRoute(
                name: "callback",
                routeTemplate: "FederationCallback",
                defaults: new { Controller = "FederationCallback" });

            config.Routes.MapHttpRoute(
                name: "LocationWeatherApi",
                routeTemplate: "locations/{locationId}/weather",
                defaults: new
                {
                    controller = "locations",
                    action = "GetWeather"
                },
                constraints: new
                {
                    httpMethod = new HttpMethodConstraint(HttpMethod.Get)
                }
            );

            config.Routes.MapHttpRoute(
                name: "TravelerReservationsApi",
                routeTemplate: "travelers/{travelerId}/reservations",
                defaults: new
                {
                    controller = "reservations",
                    id = RouteParameter.Optional
                },
                constraints: null,
                handler: new AuthenticationHandler(authenticationConfig, GlobalConfiguration.Configuration));

            config.Routes.MapHttpRoute(
               name: "ReservationsApi",
               routeTemplate: "Reservations/{id}",
               defaults: new
               {
                   controller = "Reservations",
                   action = "GetReservation"
               },
               constraints: new
               {
                   httpMethod = new HttpMethodConstraint(HttpMethod.Get)
               },
               handler: new AuthenticationHandler(authenticationConfig, GlobalConfiguration.Configuration)
           );

            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional },
                    constraints: null,
                    handler: new AuthenticationHandler(authenticationConfig, GlobalConfiguration.Configuration));

            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(
                new StringEnumConverter());
        }
    }
}
