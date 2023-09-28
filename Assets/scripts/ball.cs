using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = GameObject.Find("ball").transform.position;
        y = tmp.y;
        if (y < -3f)
        {

            FadeManager.Instance.LoadScene("gameover", 1.0f);
        }
    }

    
}
