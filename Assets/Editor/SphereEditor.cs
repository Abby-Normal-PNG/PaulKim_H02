using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Sphere))]
public class SphereEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Sphere sphere = (Sphere)target;

        sphere.baseSize = EditorGUILayout.Slider("Size", sphere.baseSize, .1f, 4f);

        sphere.transform.localScale = Vector3.one * sphere.baseSize;
    }
}
