using UnityEngine;

[RequireComponent( typeof( AdvancedCameraInputHandler ) )]
public class AdvancedFirstPersonState : AdvancedCameraState
{
    [SerializeField]
    private Camera _inputCamera;

    [SerializeField]
    private Transform _transformToFollow;

    private AdvancedCameraInputHandler _inputHandler;

    protected virtual void Awake()
    {
        _inputHandler = GetComponent<AdvancedCameraInputHandler>();

    }

    public override void OnUpdate()
    {
        _inputCamera.transform.position = _transformToFollow.position;
        _inputCamera.transform.localEulerAngles = _inputHandler.GetClampedTargetRotation();

    }

}
