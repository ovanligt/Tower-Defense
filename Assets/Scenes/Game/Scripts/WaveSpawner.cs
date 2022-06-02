using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Text CountIndex;

    [SerializeField] private Transform _pointOfSpawn;
    [SerializeField] private float _timeBetweensWaves = 4f;
    [SerializeField] private Transform _enemyPrefab;
    private float _countDown = 2f;
    private int _waveIndex = 1;

    private void Update() 
    {
        if (_countDown <= 0f)
        {
            StartCoroutine(SpawnWave());
            _countDown = _timeBetweensWaves;

        }
        _countDown -= Time.deltaTime;
        CountIndex.text = Mathf.Round(_countDown).ToString();
    }

    IEnumerator SpawnWave()
    {
        for (int i = 0; i < _waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        _waveIndex ++;
    } 

    private void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, _pointOfSpawn.position , _pointOfSpawn.rotation); 
    }


}
