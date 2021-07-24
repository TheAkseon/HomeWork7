using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _template;
    private float _time;
    private int _nextSpawn;
    [SerializeField] private Transform[] _spawnPoints;
    private int _randomObjects;
    private Transform _randomPoint;

    
    private void Update()
    {
        _time += Time.deltaTime;
        if(_time - _nextSpawn > 0)
        {
            _nextSpawn = _nextSpawn + 2;
            _randomPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
            _randomObjects = Random.Range(0, _template.Length);
            Instantiate(_template[_randomObjects], _randomPoint.position, Quaternion.identity);
        }
    }
}
