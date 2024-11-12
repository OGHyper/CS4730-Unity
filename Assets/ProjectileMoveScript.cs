using System.Collections;
using System.Collections.Generic;
using ClearSky;
using UnityEngine;

public class ProjectileMoveScript : MonoBehaviour
{
    public float moveSpeed;
    public int direction;
    public float deadzone = 160;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("direction: " + direction);
        transform.position += Vector3.right * direction * moveSpeed * Time.deltaTime;
        if (transform.position.x > deadzone){
            // Debug.Log("Projectile Deleted");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Terrain")){
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Boss")){
            Destroy(gameObject);
        }
    }
}
