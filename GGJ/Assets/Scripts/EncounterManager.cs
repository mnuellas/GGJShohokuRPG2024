using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterManager : MonoBehaviour
{
    public event Action onShowDialog;
    public event Action onHideDialog;
    [SerializeField] CharacterMove playerController;
    [SerializeField] GameObject ambiance;

    public Sprite eclair1;
    public Sprite eclair2;
    public Sprite temple;

    public GameObject player;
    public AudioClip kamiClip;

    
    public static EncounterManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        onShowDialog.Invoke();
        player.GetComponent<AudioSource>().clip = kamiClip;
        player.GetComponent<AudioSource>().Play();
        playerController._animator.SetBool("isMoving", false);
        StartCoroutine(Flash());
    }

    private IEnumerator Flash() {
        ambiance.GetComponent<SpriteRenderer>().sprite = eclair1;
        yield return new WaitForSeconds(1f);
        ambiance.GetComponent<SpriteRenderer>().sprite = eclair2;
        yield return new WaitForSeconds(1f);
        ambiance.GetComponent<SpriteRenderer>().sprite = temple;
        yield return new WaitForSeconds(1f);
        onHideDialog.Invoke();
    }

    
    // Start is called before the first frame update
}
