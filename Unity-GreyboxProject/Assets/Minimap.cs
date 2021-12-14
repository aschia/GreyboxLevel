using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    public Transform player;
    public static int keysToCollect = 3;
    public Text keyText;

    // Start is called before the first frame update
    void Start()
    {
        keysToCollect = GameObject.FindGameObjectsWithTag("Key").Length;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = player.position;
        newPos.y = transform.position.y;
        transform.position = newPos;

        keyText.text = "Keys Remaining: " + keysToCollect;
    }

    /*public static void UpdateUI()
    {
        keyText.text = "Keys Remaining: "+keysToCollect;
    }*/
}
