#pragma checksum "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6758fbf030794256e627b9b47084290d83e51c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MyComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MyComponent/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\_ViewImports.cshtml"
using AspNetCoreBootstrap4Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml"
using AspNetCoreBootstrap4Validation.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6758fbf030794256e627b9b47084290d83e51c2", @"/Views/Shared/Components/MyComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ad144fe1807b0cbccb1f31b3d94a9d37fa1d3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MyComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyComponentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml"
  
    ViewData["Title"] = "View Component";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Result from Component:server</h5>\r\n\r\n<text><em>ScreenWidth: </em>");
#nullable restore
#line 10 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml"
                       Write(Model.ScreenWidth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n\r\n<br />\r\n<text><em>Name:</em> ");
#nullable restore
#line 13 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml"
                Write(Model.StandardValidation.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text><br />\r\n<text><em>IsCool:</em> ");
#nullable restore
#line 14 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml"
                  Write(Model.StandardValidation.IsCool);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text><br />\r\n<text><em>Age: </em>");
#nullable restore
#line 15 "C:\Users\Leo\Dropbox\DEV\DOTNET\CORE\WEB\AspNetCoreBootstrap4Validation-master\AspNetCoreBootstrap4Validation\Views\Shared\Components\MyComponent\Default.cshtml"
               Write(Model.StandardValidation.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text><br />");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyComponentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591