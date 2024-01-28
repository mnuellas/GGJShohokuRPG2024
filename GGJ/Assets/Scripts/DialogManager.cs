using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
    [SerializeField] GameObject dialogBox;
    [SerializeField] GameObject MCSprite;
    [SerializeField] GameObject Kamisprite;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] float lettersPerSecond = 0.2f;

    public event Action onShowDialog;
    public event Action onHideDialog;
    public static DialogManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    bool isTyping;
    int currentLine = 0;
    Dialog dialog;
    bool[] turn;
    public void HandleUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Z) && !isTyping)
        {
            ++currentLine;
            if (currentLine < dialog.Lines.Count)
            {
                StartCoroutine(TypeDialog(dialog.Lines[currentLine], turn[currentLine]));
            } else
            {
                HideDialog();
            }
        }
    }

    public IEnumerator ShowDialog(Dialog dialog, bool[] turn)
    {
        yield return new WaitForEndOfFrame();
        onShowDialog?.Invoke();
        dialogBox.SetActive(true);
        MCSprite.SetActive(true);
        Kamisprite.SetActive(true);

        this.dialog = dialog;
        this.turn = turn;
        StartCoroutine(TypeDialog(dialog.Lines[0], turn[0]));
    }

    public void HideDialog()
    {
        currentLine = 0;
        dialogBox.SetActive(false);
        onHideDialog?.Invoke();
        SceneManager.LoadScene(2);
    }

    public IEnumerator TypeDialog(string line, bool turn)
    {
        if(turn) {
            MCSprite.GetComponent<Image>().color = new Color32(82, 83, 84, 255);
            Kamisprite.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        } else {
            Kamisprite.GetComponent<Image>().color = new Color32(82, 83, 84, 255);
            MCSprite.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        isTyping = true;
        text.text = "";
        foreach (var letter in line.ToCharArray()) {
            text.text += letter;
            yield return new WaitForSeconds(1f / lettersPerSecond);
        }
        isTyping = false;
    }
}
