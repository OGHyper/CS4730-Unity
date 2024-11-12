using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjMoveScript : MonoBehaviour
{
    public float moveSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Terrain")){
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }
}
