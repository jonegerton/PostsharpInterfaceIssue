PostsharpInterfaceIssue
=======================

Postsharp Interface Issue reproduction




Versions used:
* VS2013 Update 3.
* Postsharp v4.0.34.0.
* Swashbuckle v4.1.0.


Steps Taken: 

1: Start a new WebApi project. Select Empty project, and include web-api references.

2: Add postsharp to the project

3: Add swashbuckle from Nuget 

    install-package Swashbuckle
    
4: Add a new empty custom aspect based on `OnMethodBoundaryAspect`:

    public class DummyAspect : OnMethodBoundaryAspect
    {
    }
    
5: Add an implementation of `Swashbuckle.Swagger.IOperationFilter`, and add the aspect to the `Apply` method:

    public class AddStandardResponseCodes : IOperationFilter
    {
        [DummyAspect]
        void IOperationFilter.Apply(Operation operation, DataTypeRegistry dataTypeRegistry, System.Web.Http.Description.ApiDescription apiDescription)
        {
            throw new NotImplementedException();
        }
    }
    
6: Build:

The following error occurs:

> Unhandled exception (4.0.34.0, 32 bit, CLR 4.5, Release): PostSharp.Sdk.CodeModel.BindingException: Error while loading the type "PostsharpInterfaceIssue.AddStandardResponseCodes, PostsharpInterfaceIssue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null": System.TypeLoadException: Signature of the body and declaration in a method implementation do not match.  Type: 'PostsharpInterfaceIssue.AddStandardResponseCodes'.  Assembly: 'PostsharpInterfaceIssue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.


The full dump of the error is in the error.txt file in this repo
