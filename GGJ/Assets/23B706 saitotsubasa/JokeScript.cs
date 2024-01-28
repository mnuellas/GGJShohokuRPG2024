using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JokeScript : MonoBehaviour
{
    public GameObject EnemyManager;
    private EnemyManagementScript EnemyManagement;
    public string joke1 = null;

    public float Damage;
    // Start is called before the first frame update
    void Start()
    {
        EnemyManagement = EnemyManager.GetComponent<EnemyManagementScript>();
    }

    // Update is called once per frame
    void Update(){

    }

    public void OnClick(){
        EnemyManagement.HealthCalculation(Damage,"Joke");
        Debug.Log("JokeAttack");
    }
}
