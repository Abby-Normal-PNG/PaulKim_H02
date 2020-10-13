using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ParticleSpawner))]
public class ParticleSpawnEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ParticleSpawner spawn = (ParticleSpawner)target;

        EditorGUILayout.HelpBox("Spawns particle effects at the GameObject's current position." +
            " Can spawn either random particles or the particle specified by the slider.", MessageType.Info);

        //GUILayout.Label("Current Particle Index");
        spawn._currentParticleIndex = EditorGUILayout.IntSlider(spawn._currentParticleIndex, 0, spawn._particlePrefabs.Length - 1);
        GUILayout.Label("Current Particle: " + spawn._particlePrefabs[spawn._currentParticleIndex].name);

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
