﻿using MobileCRM.Cells;
using Xamarin.Forms;
using MobileCRM.Views.Base;
using MobileCRM.Statics;

namespace MobileCRM.Views.Products
{
    public class CategoryListView : BaseNonPersistentSelectedItemListView
    {
        public CategoryListView()
        {
            ItemTemplate = new DataTemplate(typeof(CategoryListItemCell));
            HasUnevenRows = false;
            RowHeight = (int)Sizes.LargeRowHeight;
            SeparatorVisibility = SeparatorVisibility.Default;
            SeparatorColor = Palette._013;
        }
    }
}


