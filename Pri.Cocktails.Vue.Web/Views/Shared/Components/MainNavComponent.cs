using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pri.Cocktails.Vue.Web.ViewModels.Components.menu;
using Microsoft.AspNetCore.Http;

namespace Pri.Cocktails.Vue.Web.Views.Shared.Components
{
    [ViewComponent(Name = "MainNavComponent")]
    public class MainNavComponent : ViewComponent
    {
        private IEnumerable<AdminSubMenuLinksVm> AdminSubMenuItems { get; set; }
        private IEnumerable<UserSubMenuLinksVm> UserSubMenuItems { get; set; }
        private IEnumerable<MainMenuLinksVm> MainMenuItems { get; set; }
        private IEnumerable<LoginSubMenu> LoginSubMenu { get; set; }

        private List<BaseMenuLinkVm> MenuItems { get; set; }
        private string role;


        public async Task<IViewComponentResult> InvokeAsync()
        {
            foreach (var lnk in MenuItems)
            {
                if (this.RouteData.Values["controller"].ToString().ToLower() == lnk.Controller.ToLower() &&
                    this.RouteData.Values["action"].ToString().ToLower() == lnk.Action.ToLower())
                {
                    lnk.IsActive = true;
                }
            }

            NavigationVm menu = new NavigationVm
            {
                MainMenu = MainMenuItems,
                UserSubMenu = UserSubMenuItems,
                AdminSubMenu = AdminSubMenuItems,
                LoginSubMenu = LoginSubMenu,
                Role = role
            };

            return await Task.FromResult<IViewComponentResult>(View(menu));
        }

        public MainNavComponent(IHttpContextAccessor cookie)
        {
            
            role = cookie.HttpContext.Request.Cookies.Where(x => x.Key == "role").Select(x => x.Value).FirstOrDefault();
            UserSubMenuItems = new List<UserSubMenuLinksVm>
            {
                new UserSubMenuLinksVm
                {
                    IconHTML="fas fa-cocktail me-1",Controller = "Cocktails",Action ="CocktailsOfUserIndex",Text="My cocktails"
                },
                new UserSubMenuLinksVm
                {
                    IconHTML="fas fa-lemon me-1",Controller = "Ingredients",Action ="IngredientsFromUserIndex",Text="My ingredients"
                },             

            };
            AdminSubMenuItems = new List<AdminSubMenuLinksVm>
            {                
                new AdminSubMenuLinksVm
                {
                    IconHTML="fas fa-glass-martini me-1",Controller = "GlassTypes",Action ="Index",Text="GlassTypes"
                },
                new AdminSubMenuLinksVm
                {
                    IconHTML="fas fa-blender me-1",Controller = "Tools",Action ="Index",Text="Tools"
                },
                new AdminSubMenuLinksVm
                {
                   IconHTML="fas fa-file me-1",Controller = "Categories",Action ="Index",Text="Categories"
                }

            };

            MainMenuItems = new List<MainMenuLinksVm>
            {
                new MainMenuLinksVm
                {
                    IconHTML="fas fa-home me-1",Controller = "Home",Action ="Index",Text="Home"
                },
                new MainMenuLinksVm
                {
                    IconHTML="fas fa-lemon me-1",Controller = "Ingredients",Action ="Index",Text="Ingredients"
                },
                new MainMenuLinksVm
                {
                    IconHTML="fas fa-cocktail me-1",Controller = "Cocktails",Action ="Index",Text="Cocktails"
                }


            };

            LoginSubMenu = new List<LoginSubMenu>
            {
                new LoginSubMenu
                {
                    Controller = "Account",Action ="Login",Text="Login"
                },
                new LoginSubMenu
                {
                    Controller = "Account",Action ="Register",Text="Register"
                },


            };
            MenuItems = new List<BaseMenuLinkVm>();
            MenuItems.AddRange(UserSubMenuItems);
            MenuItems.AddRange(AdminSubMenuItems);
            MenuItems.AddRange(MainMenuItems);
            MenuItems.AddRange(LoginSubMenu);
        }
    }
    
}


