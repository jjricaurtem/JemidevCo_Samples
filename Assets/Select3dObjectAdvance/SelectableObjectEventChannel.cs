using UnityEngine;
using UnityEngine.Events;

namespace Select3dObjectAdvance
{
    [CreateAssetMenu(fileName = "SelectableObjectEventChannelSo",
        menuName = "MyGame/Select3dObject/SelectableObjectEventChannel", order = 0)]
    public class SelectableObjectEventChannel : ScriptableObject
    {
        public UnityAction<SelectableObject> OnSelectObject;

        public void RaiseEvent(SelectableObject objectSelected)
        {
            OnSelectObject?.Invoke(objectSelected);
        }
    }
}