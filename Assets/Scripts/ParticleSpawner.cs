using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject[] _particlePrefabs;
    [HideInInspector] public int _currentParticleIndex = 0;

    public void SpawnCurrentParticle()
    {
        SpawnParticleIndex(_currentParticleIndex);
    }

    public void SpawnRandomParticle()
    {
        int randIndex = Random.Range(0, _particlePrefabs.Length);
        _currentParticleIndex = randIndex;
        SpawnParticleIndex(_currentParticleIndex);
    }

    private void SpawnParticleIndex(int i)
    {
        if(_particlePrefabs[i] != null)
        {
            Instantiate(_particlePrefabs[i], gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
