#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/InjectWithSemicolon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a53bde02f202036e674a23018e04268a3a844bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_InjectWithSemicolon), @"mvc.1.0.view", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/InjectWithSemicolon.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a53bde02f202036e674a23018e04268a3a844bb", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/InjectWithSemicolon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/InjectWithSemicolon.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_InjectWithSemicolon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyService<MyModel> Html2 { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyApp MyPropertyName2 { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyService<MyModel> Html { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public MyApp MyPropertyName { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
    }
}
#pragma warning restore 1591