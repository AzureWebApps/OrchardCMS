﻿using Orchard.ContentManagement;

namespace Orchard.Core.Common.ViewModels {
    public class ItemReferenceContentFieldDisplayViewModel {
        private ContentItem _item;

        public ContentItem Item {
            get { return _item; }
            set { _item = value; }
        }
    }
}