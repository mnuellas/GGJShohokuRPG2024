using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeScript : MonoBehaviour
{
    
    //ボタンが押された時に呼ばれる関数
    public void OnClick()
    {
        Debug.Log("Escape!");
        SceneManager.LoadScene(1);
    }
}
