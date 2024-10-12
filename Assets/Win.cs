using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public static int count = 121;
    public Text wintext;
    void Start()
    {
        count = 121;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0) {
            wintext.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
}
