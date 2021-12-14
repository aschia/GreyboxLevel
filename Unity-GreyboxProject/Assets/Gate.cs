using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TryDelete", 0f,0.5f);
    }

    // Update is called once per frame
    /*void OnCollisionEnter(Collider other)
    {
        if (other.tag == "Player" && Minimap.keysToCollect <= 0)
        {
            Destroy(this.gameObject);
        }   
    }*/
    void TryDelete()
    {
        if (Minimap.keysToCollect <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
