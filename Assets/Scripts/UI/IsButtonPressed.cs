using UnityEngine;
using UnityEngine.EventSystems;

namespace Platformer.UI
{
    public class IsButtonPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public bool Pressed { get; private set; } = false;

        private void OnEnable()
        {
            Pressed = false;
        }

        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
            Pressed = true;
        }

        void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
        {
            Pressed = false;
        }
    }
}