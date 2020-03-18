using ReactiveUI;

namespace ReactiveUIViewHostVerticalStretch
{
    public class ItemViewModel : ReactiveObject
    {
        public ItemViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}