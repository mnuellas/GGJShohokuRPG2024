using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour {

    //Use this for initialization
    void Start () {

        //画面遷移してもオブジェクトが壊れないようにする
             DontDestroyOnLoad (this);
    }
} 