namespace TestTextQuest
{
    class TrampAction : ActionElement
    {
        public override string Text => isActive ? "Держи 50 модет и медальон" : "...";
        private bool isActive = true;

        public TrampAction(ActionElement backAction)
        {
            actions = new ActionElement[]
            {
                backAction
            };
            TextActions = new string[]
            {
                "Взять"
            };
        }
        
        public override string[] TextActions{get;protected set;}

        protected override ActionElement[] actions{get;}

        protected override void Execute()
        {
            if(isActive)
            {
                isActive = false;
                Player.AddMoney(50);
                Player.TakeItem(new Medallion());
                TextActions = new string[]
                {
                    "Назад"
                };
            }
        }
    }
}