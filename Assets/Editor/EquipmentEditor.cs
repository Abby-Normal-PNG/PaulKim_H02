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
                GUILayout.Label("Value");
                equip.value = EditorGUILayout.IntField(equip.value);
            GUILayout.EndVertical();

        GUILayout.EndHorizontal();

        EditorGUILayout.HelpBox("Rarity: Classifies what quality the equipment is." +
            " Name: The equipment's name." +
            " Slot: Where this equipment can be placed." +
            " Value: How much an item is worth or how much attack/defense it gives.", MessageType.Info);
    }
}
