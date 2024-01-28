using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManagementScript : MonoBehaviour
{
    //sliderを受け取る
    public Slider HealthSlider;

    //補正値
    public float LowCorrection;
    public float NomalCorrection;
    public float DirectCorrection;

    //初期HP諸々
    public int StartHealth;
    public int maxHealth;
    private float NowHealth;

    //好み
    public string effectiveAction;
    public string nomalAction;
    public string badAction;

    //子オブジェクト
    public GameObject EnemyObject;
    private EnemyScript enemyscript;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Proparty"+LowCorrection+" "+NomalCorrection+" "+DirectCorrection+" "+effectiveAction +nomalAction+ badAction +" " +maxHealth + " " +StartHealth);
        HealthSlider.value = (float)StartHealth/(float)maxHealth;;
        NowHealth=StartHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthSlider.value = (float)NowHealth/(float)maxHealth;;

        //ここで負けた時と買った時の処理をしたい
        if(NowHealth >= maxHealth){
            Debug.Log("YOU WIN!");
            Win();
        }else if(NowHealth<=0){
            Lose();
        }
    }

    public void HealthCalculation(float nomalDamage,string proparty){
        Debug.Log("EnemyAttack");
        //ジョーク編
        if(proparty == "Joke" ){
            if(proparty == effectiveAction){
                Debug.Log("JokeGood");
                HiPointAttack(nomalDamage);
            }else if(proparty == nomalAction){
                Debug.Log("JokeNomal");
                NomalPointAttack(nomalDamage);
            }else if(proparty == badAction){
                Debug.Log("JokeOut");
                OutPointAttack(nomalDamage);
            }
        //ダンス編
        }else if(proparty == "Dance"){
            Debug.Log("Attack2Dance");
            if(proparty == effectiveAction){
                Debug.Log("DanceGood");
                HiPointAttack(nomalDamage);
            }else if(proparty == nomalAction){
                Debug.Log("DanceNomal");
                NomalPointAttack(nomalDamage);
            }else if(proparty == badAction){
                Debug.Log("DanceOut");
                OutPointAttack(nomalDamage);
            }
        //変顔編
        }else if(proparty == "FunnyFace"){
            Debug.Log("FunnyFace2Attack");
            if(proparty == effectiveAction){
                Debug.Log("FunnyFaceGood");
                HiPointAttack(nomalDamage);
            }else if(proparty == nomalAction){
                Debug.Log("FunnyFaceNomal");
                NomalPointAttack(nomalDamage);
            }else if(proparty == badAction){
                Debug.Log("FunnyFaceOut");
                OutPointAttack(nomalDamage);
            }
        //ギフト編
        }else if(proparty == "Gift"){
            Debug.Log("Gift2Attack");
            if(proparty == effectiveAction){
                Debug.Log("GiftGood");
                HiPointAttack(nomalDamage);
            }else if(proparty == nomalAction){
                Debug.Log("GiftNomal");
                NomalPointAttack(nomalDamage);
            }else if(proparty == badAction){
                Debug.Log("GiftOut");
                OutPointAttack(nomalDamage);
            }
        }else{
            //どれにも当てはまらない時の処理
            //「何かするとしたら興味がないようだ」とかでいいと思う
        }
    }

    private void HiPointAttack(float nomalDamage){
        float AttackDamage;
        AttackDamage = nomalDamage * DirectCorrection;
        NowHealth=NowHealth+ AttackDamage;
        Debug.Log("HiPointAttack");
    }

    private void NomalPointAttack(float nomalDamage){
        float AttackDamage;
        AttackDamage = nomalDamage * NomalCorrection;
        NowHealth = NowHealth + AttackDamage;
        Debug.Log("NomalPointAttack");
    }

    private void OutPointAttack(float nomalDamage){
        float AttackDamage;
        AttackDamage = nomalDamage * LowCorrection;
        NowHealth = NowHealth + AttackDamage;
        Debug.Log("badPointAttack");
        Debug.Log("LowCorrection"+LowCorrection);
        Debug.Log("nomalDamage："+nomalDamage);
        Debug.Log("AttackDamage："+AttackDamage);
        Debug.Log("NowHealth："+NowHealth);
    }

    private void Win(){
        //勝った時に画像を変更する
        enemyscript = EnemyObject.GetComponent<EnemyScript>();
        enemyscript.ChangeImageScript();
    }

    private void Lose(){

    }
}
