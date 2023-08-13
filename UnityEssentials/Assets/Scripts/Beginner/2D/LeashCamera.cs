using UnityEngine;

/// <summary>
/// Leash style camera, inspired by Synthetik and Streets of Rogue!
/// </summary>
public class LeashCamera : MonoBehaviour
{
    public float ViewRange = 5.0f;
    public float CameraSmoothing = 4.0f;

    [SerializeField]
    private Camera _inputCamera;

    [SerializeField]
    private Transform _transformToFollow;

    private float _targetDistanceDelta;
    private Vector3 _mousePosition;
    private Vector3 _targetPosition;
    private Vector3 _smoothedFinalPosition;

    protected virtual void Update()
    {
        _mousePosition = _inputCamera.ScreenToWorldPoint( Input.mousePosition );

        // Dividing by two is only done because it puts the camera BETWEEN the two positions, instead of at the very end of the ViewRange. 
        _targetPosition = ( _mousePosition - _transformToFollow.position ) / 2.0f;

        // Stops the camera from shooting off once it starts moving as it's anchored to the player's position.
        _targetDistanceDelta = Vector3.Distance( _mousePosition, _transformToFollow.position );

        // I found this little part online somewhere years ago, works super good at clamping the distance of the camera.
        if( _targetDistanceDelta > ViewRange )
        {
            // Clamps the camera's distance to the desired ViewRange by basically subtracting the delta of the distance from it.
            _targetPosition *= ViewRange / _targetDistanceDelta;

        }

        // Simple little smoothing lerp to make it not feel as crazy fast.
        _smoothedFinalPosition = Vector3.Lerp( transform.position, _transformToFollow.position + _targetPosition, CameraSmoothing * Time.deltaTime );
        _smoothedFinalPosition.z = _inputCamera.transform.position.z;

        transform.position = _smoothedFinalPosition;

    }


}
