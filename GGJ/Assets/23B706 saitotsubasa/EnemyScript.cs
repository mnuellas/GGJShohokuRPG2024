using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    public GameObject EnemyManager;
    private EnemyManagementScript EnemyManagement;

    //初期HPの計算
    public int StartHealth = 0;
    public int maxHealth = 150;
    //敵の状態設定
    public float LowCorrection = 1.8f;
    public float nomalCorrection = 1.0f;
    public float directCorrection = 2.0f;

    //好み
    public string effectiveAction;
    public string nomalAction;
    public string badAction;

    //画像関連のもの
    public Sprite ClearedSprite;
    private SpriteRenderer image;
    // Start is called before the first frame update
    void Start()
    {
        EnemyManagement = EnemyManager.GetComponent<EnemyManagementScript>();
        //補正値
        EnemyManagement.LowCorrection = LowCorrection;
        EnemyManagement.NomalCorrection = nomalCorrection;
        EnemyManagement.DirectCorrection = directCorrection;
        //初期のヘルス
        EnemyManagement.StartHealth = StartHealth;
        EnemyManagement.maxHealth =maxHealth;
        //好み
        EnemyManagement.effectiveAction = effectiveAction;
        EnemyManagement.nomalAction = nomalAction;
        EnemyManagement.badAction = badAction;

        EnemyManagement.EnemyObject = gameObject;
        //状態
        Debug.Log(LowCorrection+" "+nomalCorrection+" "+directCorrection+effectiveAction+nomalAction+badAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCanvasScript(){
        image = gameObject.GetComponent<SpriteRenderer>();
        image.sprite = ClearedSprite;
    }
}
