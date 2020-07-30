using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    public float spawnInterval = .5f;
    public float autoDestroy = 10f;
    private float timer;

    private void Start()
    {
        timer = spawnInterval;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            int rand = Random.Range(0, spawnPoints.Length);
            Destroy(Instantiate(enemyPrefab,spawnPoints[rand].position, spawnPoints[rand].rotation), autoDestroy);
            timer = spawnInterval;
        }
    }
}
