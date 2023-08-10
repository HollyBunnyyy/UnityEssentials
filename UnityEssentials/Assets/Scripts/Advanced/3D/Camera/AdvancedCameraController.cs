using UnityEngine;

// Basically a wrapper class that simply inherits the state machine.
public class AdvancedCameraController : AdvancedCameraStateMachine
{
    protected virtual void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

}
