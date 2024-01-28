using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftScript : MonoBehaviour
{
    public GameObject EnemyManager;
    private EnemyManagementScript EnemyManagement;
    public string Gift1 = null;

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
        Debug.Log("GiftAttack");
        EnemyManagement.HealthCalculation(Damage,"Gift");
    }
}
