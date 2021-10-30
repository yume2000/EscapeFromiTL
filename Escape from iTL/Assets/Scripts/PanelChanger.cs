using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    //矢印の表示/非表示
    //*SetActive(True/False)
    //一度すべてを非表示にしてから個別設定をする
    //*Panel0～3:下無し(左右あり)
    //*Panel01～33:左右なし(下あり)
    public GameObject RightArrow;
    public GameObject LeftArrow;
    public GameObject BackArrow;

    private void Start()
    {
        //矢印の表示
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        BackArrow.SetActive(false);
        RightArrow.SetActive(true);
        LeftArrow.SetActive(true);
    }

    void HideArrows()
    {
        //矢印の非表示(表示前に必ず行うため、関数でまとめる)
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        BackArrow.SetActive(false);
    }

    //ボタンを押したら移動してパネルを変更する
    //右ボタンを押したらPanel1に移動
    public void OnRightArrow()
    {
        //隣のPanelに移動：PanelParentをx軸方向に-2000
        //(-6000,0)の時、(0.0)に移動する
        Vector2 tmp = transform.localPosition;
        float x = tmp.x;
        if (tmp == new Vector2(-6000, 0))
        {
            transform.localPosition = new Vector2(0, 0);
        }
        else
        {
        transform.localPosition = new Vector2(tmp.x-2000, 0);
        }

        //矢印の表示
        HideArrows();
        RightArrow.SetActive(true);
        LeftArrow.SetActive(true);
    }
    //左ボタンを押したらPanel0に移動
    public void OnLeftArrow()
    {
        //隣のPanelに移動：PanelParentをx軸方向に2000
        //(0.0)の時、(-6000,0)に移動する
        Vector2 tmp = transform.localPosition;
        float x = tmp.x;
        if (tmp == new Vector2(0, 0))
        {
            transform.localPosition = new Vector2(-6000, 0);
        }
        else
        {
            transform.localPosition = new Vector2(tmp.x + 2000, 0);
        }

        //矢印の表示
        HideArrows();
        RightArrow.SetActive(true);
        LeftArrow.SetActive(true);
    }
    public void OnBackArrow()
    {
        //ズームの状態から、y座標は0に戻る
        Vector2 tmp = transform.localPosition;
        float x = tmp.x;
        float y = tmp.y;
        transform.localPosition = new Vector2(tmp.x, tmp.y - tmp.y);

        //矢印の表示
        HideArrows();
        RightArrow.SetActive(true);
        LeftArrow.SetActive(true);
    }
    //panel0を押したらpanel01へ
    public void OnPanelz1()
    {
        Vector2 tmp = transform.localPosition;
        float x = tmp.x;
        float y = tmp.y;
        transform.localPosition = new Vector2(tmp.x, tmp.y + 2000);

        //矢印の表示
        HideArrows();
        BackArrow.SetActive(true);
    }
    //panel0を押したらPanel02へ
    public void OnPanelz2()
    {
        Vector2 tmp = transform.localPosition;
        float x = tmp.x;
        float y = tmp.y;
        transform.localPosition = new Vector2(tmp.x, tmp.y + 4000);

        //矢印の表示
        HideArrows();
        BackArrow.SetActive(true);
    }
    public void OnPanelz3()
    {
        Vector2 tmp = transform.localPosition;
        float x = tmp.x;
        float y = tmp.y;
        transform.localPosition = new Vector2(tmp.x, tmp.y + 6000);

        //矢印の表示
        HideArrows();
        BackArrow.SetActive(true);
    }

    
}
