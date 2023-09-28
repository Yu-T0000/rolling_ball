using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour

{
   
    int score = 0;


    void OnScore(int num)
    {
        //scoreに受け取った値を追加する
        score += num;

        //Textコンポーネントを取得する
        Text scoretext = gameObject.GetComponent<Text>();

        //scoreをテキストとして表示する
        scoretext.text = "SCORE:" + score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
