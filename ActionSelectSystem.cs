using System.Collections;

namespace TestTextQuest
{
    class ActionSelectSystem : ISelectAction
    {
        private Room room;
        public string Text => room.Text;
        private int index = -1;

        public object Current => room.TextActions[index];

        public ActionSelectSystem(Room startRoom)
        {
            room = startRoom;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if(index < room.CountActions -1)
            {   
                index++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Select(int v)
        {
            if(v > room.CountActions - 1) throw new System.Exception("Неверно введено значение");
            room = room.SelectAction(v);
        }
    }
}