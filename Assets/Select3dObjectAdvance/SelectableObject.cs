using Select3dObject;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Select3dObjectAdvance
{
    public class SelectableObject : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private string customAttribute;
        [SerializeField] private SelectableObjectEventChannel selectableObjectEventChannel;


        public void OnPointerClick(PointerEventData eventData)
        {
            selectableObjectEventChannel.RaiseEvent(this);
        }

        public void DoSomething()
        {
            Debug.Log("My custom attribute is " + customAttribute);
        }
    }
}