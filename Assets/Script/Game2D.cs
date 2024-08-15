using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game2D : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float BulletSpeed = 5f;
    public float rotationSpeed = 5f;
    public float moveSpeed = 3f; 

    void Update()
    {
        // Bullet spawning
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = BulletSpawnPoint.up * BulletSpeed;
            // Instantiate is the clone creater from the scratch by using the prefabs as a input
            // GetComponent <...> mean it select a component for a specific action to ur game
        }

        // Player Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        

        Vector3 newPosition = transform.position;
        newPosition.x += horizontalInput * moveSpeed * Time.deltaTime;
        newPosition.y += verticalInput * moveSpeed * Time.deltaTime;
        transform.position = newPosition;
        // newPosition.x mean the player mve along xaxis(horizontal) and same for y
        // Move the player in x-axis and y-asix

        // Mouse Rotation
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 rotation = transform.eulerAngles;
        rotation.z -= mouseX * rotationSpeed; // z-axis
        transform.eulerAngles = rotation;
        // mouse x is the element that refers the mouse hovering left to right
        // eulurAngle is the element used for mouse (when u want use mouse it is important) it is used for any axis(x,y & z) 
    }
}
