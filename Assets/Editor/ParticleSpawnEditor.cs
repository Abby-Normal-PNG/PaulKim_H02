using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ParticleSpawner))]
public class ParticleSpawnEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ParticleSpawner spawn = (ParticleSpawner)target;

        GUILayout.Label("Current Particle Index");
        spawn._currentParticleIndex = EditorGUILayout.IntSlider(spawn._currentParticleIndex, 0, spawn._particlePrefabs.Length - 1);

        GUILayout.BeginHorizontal();

            if (GUILayout.Button("Spawn Current Particle"))
            {
                spawn.SpawnCurrentParticle();
            }

            if (GUILayout.Button("Spawn Random Particle"))
            {
                spawn.SpawnRandomParticle();
            }

        GUILayout.EndHorizontal();
    }
}
