using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    /*  khi khong dung object pool
    [SerializeField] GameObject _cubePrefab;
    // Update is called once per frame
    void Update()
    {
        GameObject newCube = Instantiate(_cubePrefab, transform.position, Quaternion.identity);
    }
    */
    ObjectPooler objectPooler;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;


    }
    private void FixedUpdate()
    {

    }
    public void SpawnerObject()
    {
        //  for (int i = 0; i < 150; i++)
        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);
    }

}
