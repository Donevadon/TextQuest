namespace TestTextQuest
{
    class RoadAction : ActionElement
    {
        public override string Text => "Дорога тянется вдаль, на горизонте видно только одного бродягу";

        public override string[] TextActions {get;protected set;}= new string[]
        {
            "Поговорить с бродягой",
            "Осмотреть окрестности"
        };

        protected override ActionElement[] actions{get;}

        public RoadAction()
        {
            actions = new ActionElement[]
            {
                new TrampAction(this),
                new LookAroundAction(this)
            };
        }
    }
}