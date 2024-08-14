using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game2D : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float BulletSpeed = 5;
    public float rotationSpeed = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            Bullet.GetComponent<Rigidbody2D>().velocity = BulletSpawnPoint.up * BulletSpeed;
        }
    }
    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = transform.eulerAngles;
        rotation.z -= mouseX * rotationSpeed; // Use z-axis for 2D rotation
        transform.eulerAngles = rotation;
    }
}



