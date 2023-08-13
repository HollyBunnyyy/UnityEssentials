using UnityEngine;

/// <summary>
/// Constrains the camera within a bounding box.
/// </summary>
public class CameraConstrainer : MonoBehaviour
{
    [SerializeField]
    private Camera _inputCamera;

    [SerializeField]
    private Rect _cameraBounds;

    private Vector3 _clampedViewportPosition;
    private Vector3 _clampedViewportSize;
    private Vector3 _viewportFrustrum;

    protected virtual void Update()
    {
        _viewportFrustrum.y = _inputCamera.orthographicSize * 2.0f;
        _viewportFrustrum.x = _viewportFrustrum.y * _inputCamera.aspect;

    }

    protected virtual void LateUpdate()
    {
        _clampedViewportSize.x = Mathf.Max( ( _cameraBounds.width  - _viewportFrustrum.x  ) / 2.0f ) + _cameraBounds.x;
        _clampedViewportSize.y = Mathf.Max( ( _cameraBounds.height - _viewportFrustrum.y  ) / 2.0f ) + _cameraBounds.y;

        _clampedViewportPosition.x = Mathf.Clamp( _inputCamera.transform.position.x, -_clampedViewportSize.x, _clampedViewportSize.x );
        _clampedViewportPosition.y = Mathf.Clamp( _inputCamera.transform.position.y, -_clampedViewportSize.y, _clampedViewportSize.y );
        _clampedViewportPosition.z = _inputCamera.transform.position.z;

        _inputCamera.transform.position = _clampedViewportPosition;

    }

    protected virtual void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(
            new Vector3( _cameraBounds.x, _cameraBounds.y ),
            new Vector3( _cameraBounds.width, _cameraBounds.height )

        );
    }

}
