using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExplosiveBarrel : MonoBehaviour, IDamageable
{
    public void Abc(int abc)
    {
        Debug.Log("ExplosiveBarrel - interface - IAbcable " + abc);
    }

    public void Damage(float damgeAmount)
    {
        // throw new System.NotImplementedException();
        Debug.Log(" ExplosiveBarrel - " + damgeAmount);
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
