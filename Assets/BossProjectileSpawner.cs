using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectileSpawner : MonoBehaviour
{
    public GameObject projectile;
    public int spawnRate = 1;
    private float timer = 0;
    public float delayBetweenProjectiles = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else {
            StartCoroutine(spawnBossProjectile());
            timer = 0;
        }
    }

    public IEnumerator spawnBossProjectile(){
        for (int i = 0; i < 3; i++){
            Instantiate(projectile, new Vector3(transform.position.x, transform.position.y), transform.rotation);
            yield return new WaitForSeconds(delayBetweenProjectiles);
        }
    }
}
