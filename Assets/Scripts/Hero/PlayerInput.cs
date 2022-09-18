using UnityEngine;

namespace Hero
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private Joystick _joystick;

        public Vector3 Axis => new(_joystick.Direction.x, 0, _joystick.Direction.y);
    }
}