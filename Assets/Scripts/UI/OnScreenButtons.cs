using UnityEngine;

namespace Platformer.UI
{
    public class OnScreenButtons : MonoBehaviour
    {
        private IsButtonPressed _left;
        private IsButtonPressed _right;
        private IsButtonPressed _jump;
        
        public bool IsLeftPressed => _left.Pressed;
        public bool IsRightPressed => _right.Pressed;
        public bool IsJumpPressed => _jump.Pressed;

        public float OnScreenAxis => IsRightPressed ? 1 : (IsLeftPressed ? -1 : 0);

        void Start()
        {
            _left = transform.Find("Left").GetComponent<IsButtonPressed>();
            _right = transform.Find("Right").GetComponent<IsButtonPressed>();
            _jump = transform.Find("Jump").GetComponent<IsButtonPressed>();
        }
    }

}
