using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    public LogicScript logic;
    public float upperY = 16f;   // Upper limit for Y position
    public float lowerY = -4.68f;   // Lower limit for Y position
    public int speed = 7;    // Movement speed
    private bool movingUp = true; // Start moving up
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // start position: 138, -4.68, -0.13
        // middle position: 138, 5.06, -0.13
        // top position: 138, 16, -0.13
        // Put stuff here about the projectile spawner
        if (logic.bossHealth == 0){
            Destroy(gameObject);
        }
        if (movingUp)
        {
            // Move up
            transform.position += Vector3.up * speed * Time.deltaTime;

            // Check if we've reached the upper limit
            if (transform.position.y >= upperY)
            {
                transform.position = new Vector3(transform.position.x, upperY, transform.position.z); // Snap to upperY
                movingUp = false; // Switch direction to down
            }
        }
        else
        {
            // Move down
            transform.position += Vector3.down * speed * Time.deltaTime;

            // Check if we've reached the lower limit
            if (transform.position.y <= lowerY)
            {
                transform.position = new Vector3(transform.position.x, lowerY, transform.position.z); // Snap to lowerY
                movingUp = true; // Switch direction to up
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // Detract health here if other is a projectile
        if (other.gameObject.CompareTag("PlayerProjectile")){
            logic.bossTakeDamage();
        }
    }
}
