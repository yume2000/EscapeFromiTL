using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTL : MonoBehaviour
{
    //i・T・Lを持っていればiTLが壁にくっつき、PCが使えるようになる
    //タイミング：iTLが普段ある壁をクリックしたとき ボタンのOnClickで実装
    public void OnThis()
    {
        //条件：PlayerがiTLのすべてのパーツを持っている：if文で実装
        bool hasItem = true;
        if (hasItem == true){
            //処理：消える
            gameObject.SetActive(false);
        }
    }
}
