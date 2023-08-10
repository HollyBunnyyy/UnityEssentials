using UnityEngine;

[RequireComponent( typeof( AdvancedCameraInputHandler ) )]
public class AdvancedThirdPersonState : AdvancedCameraState
{
    [SerializeField]
    private Camera _inputCamera;

    [SerializeField]
    private Transform _transformToFollow;

    [SerializeField]
    private Vector3 _cameraOffset = new Vector3( 0.0f, 0.0f, -5.0f );

    private AdvancedCameraInputHandler _inputHandler;

    protected virtual void Awake()
    {
        _inputHandler = GetComponent<AdvancedCameraInputHandler>();

    }

    public override void OnUpdate()
    {
        _inputCamera.transform.localEulerAngles = _inputHandler.GetClampedTargetRotation();
        _inputCamera.transform.position = _inputCamera.transform.rotation * _cameraOffset + _transformToFollow.position;

    }
}
