﻿using Orchard.Localization;
using Orchard.Security;
using Orchard.UI.Navigation;

namespace UpgradeTo14 {
    public class AdminMenu : INavigationProvider {
        public Localizer T { get; set; }

        public string MenuName {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder) {
            builder
                .Add(T("Migrate to 1.4"), "0", menu => menu.Action("Index", "Route", new { area = "UpgradeTo14" })
                    .Add(T("Migrate Routes"), "0", item => item.Action("Index", "Route", new { area = "UpgradeTo14" }).LocalNav().Permission(StandardPermissions.SiteOwner))
                    .Add(T("Migrate Fields"), "0", item => item.Action("Index", "Field", new { area = "UpgradeTo14" }).LocalNav().Permission(StandardPermissions.SiteOwner))
                );
        }
    }
}
