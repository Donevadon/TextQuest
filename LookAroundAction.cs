namespace TestTextQuest
{
    class LookAroundAction : ActionElement
    {
        public override string Text => "Туман, практически ничего не видно, как я здесь оказался?";

        public override string[] TextActions {get;protected set;} = new string[]
        {
            "Назад"
        };

        protected override ActionElement[] actions{get;}

        public LookAroundAction(ActionElement backAction)
        {
            actions = new ActionElement[]
            {
                backAction
            };
        }

    }
}