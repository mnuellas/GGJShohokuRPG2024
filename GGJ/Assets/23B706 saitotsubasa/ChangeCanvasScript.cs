using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanvasScript : MonoBehaviour
{
    public GameObject WillCangeCanvas;
    private GameObject parentCanvas;
    // Start is called before the first frame update
    void Start()
    {
        parentCanvas = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("ItemSelectScreen!");
        WillCangeCanvas.SetActive(true);
        parentCanvas.SetActive(false);
        
    }
}
