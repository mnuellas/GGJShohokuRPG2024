using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] CharacterMove playerController;
    GameState state;

    private void Start() {
        
        DialogManager.Instance.onShowDialog += () => {
            state = GameState.Dialog;
        };
        DialogManager.Instance.onHideDialog += () => {
            state = GameState.FreeRoam;
        };
        EncounterManager.Instance.onShowDialog += () => {
            state = GameState.Dialog;
        };
        EncounterManager.Instance.onHideDialog += () => {
            state = GameState.FreeRoam;
        };
    }

    private void Update() {
        if (state == GameState.FreeRoam)
        {
            playerController.HandleUpdate();
        } else if (state == GameState.Dialog) {
            DialogManager.Instance.HandleUpdate();
        }
    }

}
