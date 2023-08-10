using UnityEngine;

public class AdvancedCameraInputHandler : MonoBehaviour
{
    [SerializeField]
    private InputHandler _inputHandler;

    [SerializeField]
    private float _mouseSensitivity = 2.0f;

    private Vector3 _scaledMouseDelta;
    private Vector3 _targetCameraRotation;

    protected virtual void Update()
    {
        _scaledMouseDelta = _inputHandler.MouseDelta * _mouseSensitivity;

    }

    /// <summary>
    /// Returns the mouse delta with the y axis clamped between minYAngle and maxYAngle.
    /// </summary>
    public Vector3 GetClampedTargetRotation( float minYAngle = -89.0f, float maxYAngle = 89.0f )
    {
        _targetCameraRotation.x = Mathf.Clamp( _targetCameraRotation.x - _scaledMouseDelta.y, minYAngle, maxYAngle );
        _targetCameraRotation.y += _scaledMouseDelta.x;

        return _targetCameraRotation;

    }


}
