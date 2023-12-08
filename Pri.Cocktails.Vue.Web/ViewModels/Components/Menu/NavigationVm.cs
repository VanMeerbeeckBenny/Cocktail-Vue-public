using System.Collections.Generic;

namespace Pri.Cocktails.Vue.Web.ViewModels.Components.menu
{
    public class NavigationVm
    {
        public IEnumerable<BaseMenuLinkVm> AdminSubMenu { get; set; }
        public IEnumerable<BaseMenuLinkVm> UserSubMenu { get; set; }
        public IEnumerable<BaseMenuLinkVm> MainMenu { get; set; }
        public IEnumerable<BaseMenuLinkVm> LoginSubMenu { get; set; }       
        public string Role { get; set; }

    }
}
