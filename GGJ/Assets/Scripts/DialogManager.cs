using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] GameObject dialogBox;
    [SerializeField] Text text;
    [SerializeField] int lettersPerSecond = 0.2f;

    public void ShowDialog()
    {
        dialogBox.SetActive(true);
    }

    public HideDialog()
    {
        dialogBox.SetActive(false);
    }

    public IEnumerator TypeDialog(string line)
    {
        text.text = "";
        foreach (var letter in line.ToCharArray()) {
            text.text += letter;
            yield return WaitForSeconds(1f / lettersPerSecond);
        }
    }
}
