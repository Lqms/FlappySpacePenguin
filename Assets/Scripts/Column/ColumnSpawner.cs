using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    [SerializeField] private Column _columnPrefab;
    [SerializeField] private float _timeBetweenSpawn = 2;
    [SerializeField] private float _offsetY = 2;
    [SerializeField] private float _speed = 4;

    private WaitForSeconds _spawnDelay;

    private void Start()
    {
        _spawnDelay = new WaitForSeconds(_timeBetweenSpawn);

        StartCoroutine(Spawning());
    }

    private IEnumerator Spawning()
    {
        while (true)
        {
            yield return _spawnDelay;

            var column = Instantiate(_columnPrefab, transform.position + new Vector3(0, Random.Range(-_offsetY, _offsetY)), Quaternion.identity);
            column.Init(_speed);
        }
    }
}
