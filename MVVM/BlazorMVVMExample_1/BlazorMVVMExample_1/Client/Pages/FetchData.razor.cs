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