using System.Web.Http;
using PostsharpInterfaceIssue;
using Swashbuckle.Application;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace PostsharpInterfaceIssue
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            Swashbuckle.Bootstrapper.Init(GlobalConfiguration.Configuration);

            // NOTE: If you want to customize the generated swagger or UI, use SwaggerSpecConfig and/or SwaggerUiConfig here ...

            SwaggerSpecConfig.Customize(c =>
            {
                c.OperationFilter<AddStandardResponseCodes>();
            });
        }
    }
}