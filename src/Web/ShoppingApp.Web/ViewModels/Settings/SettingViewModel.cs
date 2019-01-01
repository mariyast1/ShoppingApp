namespace ShoppingApp.Web.ViewModels.Settings
{
    using ShoppingApp.Data.Models;
    using ShoppingApp.Services.Mapping;

    public class SettingViewModel : IMapFrom<Setting>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
