using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChageScript : MonoBehaviour
{
    public Sprite ClearedSprite;
    public string imageName;
    private SpriteRenderer image;
    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        image.sprite = ClearedSprite;
    }
}
