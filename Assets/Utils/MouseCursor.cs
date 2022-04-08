using System;
using UnityEngine;

namespace Utils
{
    public class MouseCursor : MonoBehaviour
    {
        [SerializeField] private Texture2D cursor; 
        private void Update()
        {
            Cursor.SetCursor(cursor, Vector2.zero,  CursorMode.ForceSoftware);
        }
    }
}