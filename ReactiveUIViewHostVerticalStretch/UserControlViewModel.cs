using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ReactiveUIViewHostVerticalStretch
{
    public class UserControlViewModel : ReactiveObject
    {
        private readonly ICollection<ItemViewModel> items = new Collection<ItemViewModel>();

        public ICollection<ItemViewModel> Items => items;

        public UserControlViewModel(int itemsCount = 10)
        {
            Enumerable
                .Range(0, itemsCount)
                .ToList()
                .ForEach(count => items.Add(new ItemViewModel($"Long item text to show vertical scrolling works {count}")));
        }
    }
}