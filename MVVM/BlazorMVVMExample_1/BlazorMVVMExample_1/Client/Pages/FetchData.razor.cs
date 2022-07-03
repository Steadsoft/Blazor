using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using BlazorMVVMExample_1.Client;
using BlazorMVVMExample_1.Client.Shared;
using BlazorMVVMExample_1.Shared;
using BlazorMVVMExample_1.Client.ViewModels;

namespace BlazorMVVMExample_1.Client.Pages
{
    public partial class FetchData
    {
        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetModelDataAsync();
        }
    }
}