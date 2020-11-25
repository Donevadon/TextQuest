using System.Collections;

namespace TestTextQuest
{
    public interface ISelectAction : IEnumerable,IEnumerator
    {
        string Text { get; }

        void Select(int v);
    }
}