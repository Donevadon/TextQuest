using System;

namespace TestTextQuest
{
    public abstract class Room
    {
        private ActionElement selectedAction{get;set;}
        public int CountActions => selectedAction.CountActions;
        public string Text => selectedAction.Text;

        public string[] TextActions => selectedAction.TextActions;

        public Room(ActionElement startAction)
        {
            selectedAction = startAction;
        }
        internal Room SelectAction(int v)
        {
            selectedAction = selectedAction.ExecuteAction(v);
            return this;
        }
    }
}