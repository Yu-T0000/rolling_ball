using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour
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

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("ball")) {
            Destroy(gameObject);
            FadeManager.Instance.LoadScene("clear", 1.0f);
        }
    }
}
