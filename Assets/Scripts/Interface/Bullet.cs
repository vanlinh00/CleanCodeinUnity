using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Vertical");

    }
    private void OnMouseDrag()
    {
        Debug.LogError("OnMouseDrag_Object");
    }

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
