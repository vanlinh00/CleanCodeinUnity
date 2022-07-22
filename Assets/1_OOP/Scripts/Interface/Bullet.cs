using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        IDamageable damageObject = other.gameObject.GetComponent<IDamageable>();
        if (damageObject != null)
        {
            damageObject.Damage(1.0f);
            damageObject.Abc(10000);
        }
    }

}
