using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyTarget : MonoBehaviour, IDamageable
{
    public void Abc(int abc)
    {
        Debug.Log("EnemyTarget - interface - IAbcable " + abc);
        // throw new System.NotImplementedException();
    }

    public void Damage(float damgeAmount)
    {
        Debug.Log("EnemyTarget -" + damgeAmount);
        // throw new System.NotImplementedException();
    }

}
