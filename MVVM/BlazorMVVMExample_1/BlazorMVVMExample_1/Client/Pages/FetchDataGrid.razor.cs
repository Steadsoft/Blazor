namespace BlazorMVVMExample_1.Client.Pages
{
    public partial class FetchDataGrid
    {
        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetModelDataAsync();
        }
    }
}