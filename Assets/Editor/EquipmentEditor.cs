using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Equipment))]
public class EquipmentEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Equipment equip = (Equipment)target;
        
        GUILayout.BeginHorizontal();
        //Four segments laid out horizontally, with each field and label paired and stacked vertically

            GUILayout.BeginVertical();
                GUILayout.Label("Rarity");
                equip.rarity = (Rarity)EditorGUILayout.EnumFlagsField(equip.rarity);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Name");
                equip.itemName = EditorGUILayout.TextField(equip.itemName);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Slot");
                equip.slot = (Slot)EditorGUILayout.EnumFlagsField(equip.slot);
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
                GUILayout.Label("Name");
                equip.value = EditorGUILayout.IntField(equip.value);
            GUILayout.EndVertical();

        GUILayout.EndHorizontal();
    }
}
