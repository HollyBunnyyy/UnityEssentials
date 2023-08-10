using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum CameraStates
{
    PERSPECTIVE_FIRSTPERSON,
    PERSPECTIVE_THIRDPERSON

}

// This is the combination of the first and third person camera controller that supports...
// ...dynamic switching between the two behaviours - similar to an ElderScrolls-style camera!
public class BeginnerDynamicCameraController : MonoBehaviour
{
    [SerializeField]
    private BeginnerFirstPersonCameraController _firstPersonCameraController;

    [SerializeField]
    private BeginnerThirdPersonCameraController _thirdPersonCameraController;

    [SerializeField]
    private CameraStates _currentCameraPerspective;

    private bool _isFirstPerson;

    protected virtual void Update()
    {
        switch( _currentCameraPerspective )
        {
            case CameraStates.PERSPECTIVE_FIRSTPERSON:
                _isFirstPerson = true;
                break;

            case CameraStates.PERSPECTIVE_THIRDPERSON:
                _isFirstPerson = false;
                break;
        
        }

        // _isFirstPerson = _currentCameraPerspective == CameraStates.PERSPECTIVE_FIRSTPERSON ? true : false;
        // ^^^ This single-line ternary operator could also be used in place of the code above if you'd like.
        // or even a simple if-else statement, whatever is more readable for you!

        _firstPersonCameraController.enabled = _isFirstPerson;
        _thirdPersonCameraController.enabled = !_isFirstPerson;

    }

    /// <summary>
    /// Sets the desired camera state to either first or third person.
    /// </summary>
    public void SwitchCameraState( CameraStates desiredCameraState )
    {
        _currentCameraPerspective = desiredCameraState;

    }

}
