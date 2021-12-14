using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Transform.Rotate()
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Minimap.keysToCollect--;
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        transform.Rotate(0, 0, 60 * Time.deltaTime);
    }
}
