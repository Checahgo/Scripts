using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{

    void OnDisable()
    {
        IceBoss iceBoss = new IceBoss();
        FireBoss fireBoss = new FireBoss();

        iceBoss.Shoot();
        fireBoss.Shoot();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
