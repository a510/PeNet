﻿using System.Windows.Controls;

namespace PEditor
{
    class MyTreeViewItem<T> : TreeViewItem
        where T : class
    {
        public T MyItem = null;

        public MyTreeViewItem(T item)
        {
            MyItem = item;
        }
    }
}
