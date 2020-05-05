using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawnInterval = 2f;
    public int CountEnemies = 5;

    private bool _enterTrigger = false;
    private float _timer;
    private void OnTriggerEnter(Collider other)
    {
        _enterTrigger = true;
    }
    private void Update()
    {
        _timer -= Time.deltaTime;
        if ((_timer < 0) && (CountEnemies > 0) && (_enterTrigger))
        {
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
            CountDecrease();
            _timer = SpawnInterval;
        }
    }
    private void CountDecrease()
    {
        CountEnemies--;
    }
}
