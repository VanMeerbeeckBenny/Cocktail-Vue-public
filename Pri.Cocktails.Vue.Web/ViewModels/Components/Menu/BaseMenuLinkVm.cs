namespace Pri.Cocktails.Vue.Web.ViewModels.Components.menu
{
    public class BaseMenuLinkVm
    {
        public string Text { get; set; }
        public string IconHTML { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool IsActive { get; set; }
    }
}
