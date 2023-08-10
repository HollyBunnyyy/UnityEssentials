using UnityEngine;

public class CameraScreenFitter : MonoBehaviour
{
    [SerializeField]
    private Camera _inputCamera;

    [SerializeField]
    private Rect _cameraBounds = new Rect( 0.0f, 0.0f, 32.0f, 16.0f );

    private float _screenRatio;
    private float _targetRatio;

    /// <summary>
    /// Resizes the camera's orthographic frustrum to fit to the given width and height.
    /// </summary>
    public void FitToScreen( float width, float height )
    {
        _screenRatio = (float)Screen.width / (float)Screen.height;
        _targetRatio = width / height;

        _inputCamera.orthographicSize = height / 2.0f * ( _screenRatio <= _targetRatio ? _targetRatio / _screenRatio : 1.0f );

    }

    protected virtual void Awake()
    {
        FitToScreen( _cameraBounds.width, _cameraBounds.height );

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
