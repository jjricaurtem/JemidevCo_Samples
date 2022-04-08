using UnityEngine;
using UnityEngine.UI;

namespace Select3dObject
{
    public class SelectableObjectTextListener : MonoBehaviour
    {
        private Text _textField;

        private void Start()
        {
            _textField = GetComponent<Text>();
        }

        public void ShowSelectedElementInformation(GameObject selectedGameObject)
        {
            _textField.text = "Selected: " + selectedGameObject.name;
        }
    }
}