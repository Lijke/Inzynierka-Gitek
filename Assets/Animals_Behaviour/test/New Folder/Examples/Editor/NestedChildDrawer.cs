using UnityEngine;
using UnityEditor;

namespace ZeroVector.Common.Reorderable.Editor {
    [CustomPropertyDrawer(typeof(NestedExample.NestedChildCustomDrawer))]
    public class NestedChildDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            var r1 = position;
            r1.width = 20;

            var r2 = position;
            r2.xMin = r1.xMax + 10;

            EditorGUI.BeginProperty(position, label, property);

            EditorGUI.PropertyField(r1, property.FindPropertyRelative("myBool"), GUIContent.none);
            EditorGUI.PropertyField(r2, property.FindPropertyRelative("myGameObject"), GUIContent.none);

            EditorGUI.EndProperty();
        }
    }
}