using States;

namespace AIActors {
    public class NommerEater : GenericActor{
        protected override void FillValidStatesList() {
            validStates.Add(new LookForTargetState(stateMachine));
            validStates.Add(new ReachTargetState(stateMachine));
            validStates.Add(new ConsumeTargetState(stateMachine));
        }

        protected override void PopulateContext() {
            base.PopulateContext();
            context.aiActor = gameObject;
            context.targetTag = "Nommer";
        }
    }
}
