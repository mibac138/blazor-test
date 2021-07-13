// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Test.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\a825104\RiderProjects\Test\Test.Web\_Imports.razor"
using Test.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a825104\RiderProjects\Test\Test.Web\Pages\Index.razor"
using Test.Web.Infrastructure.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\a825104\RiderProjects\Test\Test.Web\Pages\Index.razor"
using HtmlAgilityPack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\a825104\RiderProjects\Test\Test.Web\Pages\Index.razor"
using MoreLinq.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\a825104\RiderProjects\Test\Test.Web\Pages\Index.razor"
       

    private string text = "";
    private bool error = false;
    private string? message = null;

    [Inject]
    public ITargetsPropertiesCacheService Props { get; set; }

    private void Validate()
    {
        var html = new HtmlDocument();
        try
        {
            html.LoadHtml(text);
            var allowedNames = Props.GetTargetProperties().ToList();
            foreach (var node in html.DocumentNode.SelectNodes("//input[@type='text']"))
            {
                var name = node.GetAttributeValue("name", null);
                if (name != null && !allowedNames.Contains(name))
                {
                    error = true;
                    var id = string.IsNullOrEmpty(node.Id) ? "<none>" : node.Id;
                    message = $"Input with id `{id}` has invalid name: `{name}`.";
                    var sugg = FindClosestLevenshtein(name, allowedNames);
                    if (sugg != null)
                    {
                        message += $" Did you mean `{sugg}`?";
                    }
                    return;
                }
            }
            error = false;
            message = "Good job";
        }
        catch (Exception e)
        {
            error = true;
            message = $"Failed to parse HTML: {e}";
        }
    }

    private static string? FindClosestLevenshtein(string toFind, IEnumerable<string> available)
    {
        var match = available
            .Select(name => (name, LevenshteinDistance(name, toFind)))
            .MinBy(tuple => tuple.Item2)
            .FirstOrDefault();
        if (match.Item2 /* distance */ > 6)
        {
            // If the closest match and actual values differ by more than 6 characters, don't emit the suggestion
            return null;
        }
        
        return match == default ? null : match.name;
    }

    private static int LevenshteinDistance(string s, string t)
    {
        int n = s.Length;
        int m = t.Length;
        int[,] d = new int[n + 1, m + 1];
        if (n == 0)
        {
            return m;
        }
        if (m == 0)
        {
            return n;
        }
        for (int i = 0; i <= n; d[i, 0] = i++) ;
        for (int j = 0; j <= m; d[0, j] = j++) ;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                d[i, j] = Math.Min(
                    Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                    d[i - 1, j - 1] + cost);
            }
        }
        return d[n, m];
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
