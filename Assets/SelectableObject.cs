using UnityEngine;
using UnityEngine.EventSystems;

namespace Select3dObject
{
    public class SelectableObject : MonoBehaviour, IPointerClickHandler
    {

        public void OnPointerClick(PointerEventData eventData)
        {
            var renderer = GetComponent<Renderer>();
            var color = renderer.material.GetColor("_Color");
            color = color == Color.white ? Color.red : Color.white;
            renderer.material.SetColor("_Color", color);
        }
    }
}