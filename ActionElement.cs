using System;

namespace TestTextQuest
{
    public abstract class ActionElement
    {
        public abstract string Text{get;}
        public abstract string[] TextActions{get;protected set;}
        protected abstract ActionElement[] actions{get;}
        public int CountActions => actions.Length;
        public ActionElement ExecuteAction(int v)
        {
            Execute();
            return actions[v];
        }

        protected virtual void Execute(){}
    }
}