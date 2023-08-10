public interface IStateMachine<IState>
{
    public void ChangeCurrentState( IState stateToSet );
    public IState GetCurrentState();

}
