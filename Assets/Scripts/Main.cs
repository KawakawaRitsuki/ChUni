using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public GameObject prefab;
    public float interval = 1;
    float timer = 0;
    int i = 0;

    private void Start()
    {
        FileLoader fl = new FileLoader("");
    }

    void Update()
    {
        timer -= Time.deltaTime; //タイマーを減らす
        if (timer < 0)
        { //タイマーがゼロより小さくなったら
            Spawn(); // Spawnメソッドを呼ぶ
            timer = interval; // タイマーをリセットする
        }
    }
    // 敵を生成するメソッド
    void Spawn()
    {
        GameObject red = Instantiate(prefab,transform.position,transform.rotation);
        Red r = red.GetComponent<Red>();
        r.Create(4,4);
        i++;
        if(i == 15) { i = 0; }
    }
}
