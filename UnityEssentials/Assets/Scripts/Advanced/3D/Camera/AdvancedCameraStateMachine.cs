using UnityEngine;

// Simple implementation of a fixed state machine.
public class AdvancedCameraStateMachine : MonoBehaviour, IStateMachine<AdvancedCameraState>
{
    [SerializeField]
    [Tooltip( "The current state of the camera, can be updated at runtime." )]
    private AdvancedCameraState _currentCameraState;

    protected virtual void Update()
    {
        _currentCameraState.OnUpdate();

    }

    /// <summary>
    /// Updates the current state of the camera to the new given state.
    /// </summary>
    public void ChangeCurrentState( AdvancedCameraState newStateToSet )
    {
        if( _currentCameraState == newStateToSet )
        {
            return;

        }

        _currentCameraState = newStateToSet;

    }

    /// <summary>
    /// Returns the current state of the camera.
    /// </summary>
    public AdvancedCameraState GetCurrentState()
    {
        return _currentCameraState;

    }

}
