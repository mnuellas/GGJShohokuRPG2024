using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationController : MonoBehaviour, Interactable
{
    [SerializeField] Dialog dialog;
    [SerializeField] bool[] turn;
    public void Interact() {
        StartCoroutine(DialogManager.Instance.ShowDialog(dialog, turn));
    }
}
