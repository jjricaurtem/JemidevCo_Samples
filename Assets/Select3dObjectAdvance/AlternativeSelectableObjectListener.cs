using UnityEngine;

namespace Select3dObjectAdvance
{
    public class AlternativeSelectableObjectListener : MonoBehaviour
    {
        [SerializeField] private SelectableObjectEventChannel selectableObjectEventChannel;

        private void OnEnable()
        {
            selectableObjectEventChannel.OnSelectObject += OnSelectObject;
        }

        private void OnDisable()
        {
            selectableObjectEventChannel.OnSelectObject -= OnSelectObject;
        }

        private static void OnSelectObject(SelectableObject selectableObject)
        {
            selectableObject.DoSomething();
        }
    }
}