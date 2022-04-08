using UnityEngine;
using UnityEngine.EventSystems;

namespace Select3dObject
{
    public class SelectableObject : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private SelectableObjectTextListener selectableObjectListener; 

        public void OnPointerClick(PointerEventData eventData)
        {
            selectableObjectListener.ShowSelectedElementInformation(gameObject);
        }
    }
}