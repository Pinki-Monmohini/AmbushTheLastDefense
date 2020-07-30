using UnityEngine;

public class enemyAI : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    [SerializeField]
    private float xSpeed = 5f;
    private float coolDownTime = 2f;
    [SerializeField]
    private float shootingTimer = 2f;

    private bool isPlay = true;

    private void Update()
    {
        if (isPlay)
        {
            Movement();
            Attack();
        }
    }

    private void Movement()
    {
        shootingTimer -= Time.deltaTime;
        transform.Translate(transform.up * xSpeed * Time.deltaTime);
    }

    private void Attack()
    {
        if (shootingTimer <= 0f)
        {
            Destroy(Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity), 5f);
            shootingTimer = coolDownTime;
        }
    }
}
