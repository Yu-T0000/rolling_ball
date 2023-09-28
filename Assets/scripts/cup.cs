using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cup : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(-1.5f, 1.5f, 1.5f);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            GameObject scoreTextGo = GameObject.Find("scoretext");

            //メッセージを送信する
            scoreTextGo.SendMessage("OnScore", 1);
            Destroy(gameObject);
            
        }
    }
}
