#pragma checksum "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe9eada9cb9f308a51d31a0a0ac89b1f9603579"
// <auto-generated/>
#pragma warning disable 1591
namespace EC1._44CharacterGenerator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using EC1._44CharacterGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\_Imports.razor"
using EC1._44CharacterGenerator.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width: 200px;");
            __builder.AddAttribute(3, "class", "dropdown-wrapper");
            __builder.OpenComponent<EC1._44CharacterGenerator.Shared.DropdownMenu>(4);
            __builder.AddAttribute(5, "Label", "Rulesets");
            __builder.AddAttribute(6, "Elements", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<EC1._44CharacterGenerator.Shared.DropdownItem>>(
#nullable restore
#line 7 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\Pages\Index.razor"
                                             _rulesets

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Code\Repos\Blazor\EC1.44CharacterGenerator\Pages\Index.razor"
       
	List<DropdownItem> _rulesets = new List<DropdownItem>()
	{
		new DropdownItem("Eclipse Phase 1"),
		new DropdownItem("Eclipse Phase 1.44")
	};

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
