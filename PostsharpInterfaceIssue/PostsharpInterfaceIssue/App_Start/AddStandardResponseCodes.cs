using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Swashbuckle.Swagger;

namespace PostsharpInterfaceIssue
{
    public class AddStandardResponseCodes : IOperationFilter
    {
        [DummyAspect]
        void IOperationFilter.Apply(Operation operation, DataTypeRegistry dataTypeRegistry, System.Web.Http.Description.ApiDescription apiDescription)
        {
            throw new NotImplementedException();
        }
    }
}