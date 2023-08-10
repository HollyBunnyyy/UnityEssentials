using UnityEngine;

// Basically the same as the first person camera controller, but take a look at how we set the position with an offset.
public class BeginnerThirdPersonCameraController : MonoBehaviour
{
    [SerializeField]
    private Camera _inputCamera;

    [SerializeField]
    [Tooltip( "This is usually the transform associated with the 'eyes' of the player." )]
    private Transform _transformToFollow;

    [SerializeField]
    private Vector3 _cameraOffset = new Vector3( 0.0f, 0.0f, -5.0f );

    [SerializeField]
    private float _mouseSensitivity = 2.0f;

    [SerializeField]
    private float minYAxisValue = -89.0f;

    [SerializeField]
    private float maxYAxisValue = 89.0f;

    private Vector3 _mouseAxisDelta;
    private Vector3 _targetCameraRotation;

    protected virtual void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    protected virtual void Update()
    {
        // Getting the raw value of the axis rather than the smoothed value gives us a lot more of a responsive feel.
        _mouseAxisDelta.x = Input.GetAxisRaw( "Mouse X" );
        _mouseAxisDelta.y = Input.GetAxisRaw( "Mouse Y" );

        _targetCameraRotation.x += _mouseAxisDelta.x * _mouseSensitivity;
        _targetCameraRotation.y -= _mouseAxisDelta.y * _mouseSensitivity;

        // Clamping the y angle is super important so our camera doesn't flip when looking too far up or down.
        _targetCameraRotation.y = Mathf.Clamp( _targetCameraRotation.y, minYAxisValue, maxYAxisValue );

        // This transforms our given Vector3 rotation to a usable Quaternion rotation for the camera.
        // Quaternion.Euler's arguments are NOT the same as that of a Vector3( x, y, z ) - instead it's ( y, x, z )
        _inputCamera.transform.localRotation = Quaternion.Euler( _targetCameraRotation.y, _targetCameraRotation.x, 0.0f );

        // Handy little algorithm used to rotate around something, we should calculate and update our rotation first as...
        // ...the new specified position's accuracy is based on current up to date rotation of the camera. 
        _inputCamera.transform.position = _inputCamera.transform.rotation * _cameraOffset + _transformToFollow.position;

    }
}
