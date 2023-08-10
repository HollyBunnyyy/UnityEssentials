using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public InputBindings InputBindings { get; private set; }

    [SerializeField]
    private InputSettings _inputSettings;

    public Mouse CurrentMouse       => Mouse.current;
    public Gamepad CurrentGamepad   => Gamepad.current;
    public Vector3 MousePosition    => CurrentMouse.position.ReadValue();
    public Vector3 MouseDelta       => CurrentMouse.delta.ReadValue() * _inputSettings.MouseScaling;
    public Vector3 GamepadRS        => CurrentGamepad != null ? CurrentGamepad.rightStick.ReadValue() * _inputSettings.GamepadScaling : Vector3.zero;
    public Vector3 GamepadLS        => CurrentGamepad != null ? CurrentGamepad.leftStick.ReadValue() * _inputSettings.GamepadScaling : Vector3.zero;

    public Vector3 WASDAxis { get; private set; }

    void Awake()
    {
        InputBindings = new InputBindings();

        InputBindings.Keyboard.WASDMovement.performed += context => WASDAxis = InputBindings.Keyboard.WASDMovement.ReadValue<Vector3>();
        InputBindings.Keyboard.WASDMovement.canceled  += context => WASDAxis = Vector3.zero;

    }

    void OnEnable()
    {
        InputBindings.Keyboard.Enable();

    }

    void OnDisable()
    {
        InputBindings.Keyboard.Disable();

    }

}
