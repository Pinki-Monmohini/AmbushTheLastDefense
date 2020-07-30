using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    [SerializeField]
    private float xSpeed = 5f;
    private float coolDownTime = .2f;
    private float shootingTimer = 0f;

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
        float x = Input.GetAxis("Horizontal") * xSpeed;
        transform.Translate(transform.right * x * Time.deltaTime);
    }

    private void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(shootingTimer <= 0f)
            {
                Destroy(Instantiate(bulletPrefab, bulletSpawnPoint.position,Quaternion.identity),5f);
                shootingTimer = coolDownTime;
            }
        }
    }
}
