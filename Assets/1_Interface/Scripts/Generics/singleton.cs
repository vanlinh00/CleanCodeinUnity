using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class singleton<T> : MonoBehaviour where T : singleton<T>
{
    public static T Instance;
    protected virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this as T;
        Debug.Log("this in the singleton awake");
        DontDestroyOnLoad(this);
    }
}
