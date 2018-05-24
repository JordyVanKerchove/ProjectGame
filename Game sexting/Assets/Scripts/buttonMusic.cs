using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMusic : MonoBehaviour {

    private static bool createdButton = false;

    void Awake()
    {
        if (!createdButton)
        {
            // this is the first instance - make it persist
            DontDestroyOnLoad(this.gameObject);
            createdButton = true;
        }
        else
        {
            // this must be a duplicate from a scene reload - DESTROY!
            Destroy(this.gameObject);
        }
    }
}
