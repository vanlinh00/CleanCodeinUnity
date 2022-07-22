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
        Debug.Log(" ExplosiveBarrel - " + damgeAmount);
    }

}
