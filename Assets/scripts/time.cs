using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public float countdown = 5.0f;

    //時間を表示するText型の変数
    public Text timet;

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timet.text = "TIME"+countdown.ToString("f1");

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            timet.text = "TIME:0" ;
            FadeManager.Instance.LoadScene("gameover", 1.0f);
        }
    }


}
