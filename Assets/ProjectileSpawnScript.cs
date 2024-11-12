using System.Collections;
using System.Collections.Generic;
using ClearSky;
using UnityEngine;

public class ProjectileSpawnScript : MonoBehaviour
{
    public GameObject projectile;
    public SimplePlayerController spc;

    // Start is called before the first frame update
    void Start()
    {
        spc = GameObject.FindGameObjectWithTag("Player").GetComponent<SimplePlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                spawnPlayerProjectile();
            }
    }

    void spawnPlayerProjectile(){
        projectile.GetComponent<ProjectileMoveScript>().direction = spc.direction;
        Instantiate(projectile, new Vector3(transform.position.x, transform.position.y), transform.rotation);
    }
}
