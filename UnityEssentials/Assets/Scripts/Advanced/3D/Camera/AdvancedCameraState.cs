using UnityEngine;

// I Like making states monobehaviours as they can have all of their own unique Update and Awake loops...
// ...yet also be able to selectively send info to the state machine through OnCameraUpdate().

// This also allows individual states to implement and expose their own inspector elements, for instance...
// ...ThirdPersonState exposes a cameraOffset, yet the firstPersonState doesn't as it has no need.

public abstract class AdvancedCameraState : MonoBehaviour, IState<AdvancedCameraState>
{
    public abstract void OnUpdate();

}
