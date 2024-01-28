using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    public GameObject EnemyManager;
    private EnemyManagementScript EnemyManagement;
    public string Dance1 = null;

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
        Debug.Log("DanceAttack");
        EnemyManagement.HealthCalculation(Damage,"Dance");
    }
}
