// using System.Collections;
// using UnityEngine;
// using UnityEngine.UI;

// /**
//  * フィールドオブジェクトの基本処理
//  */
// public abstract class FieldObjectBase : MonoBehaviour
// {

//     // Unityのインスペクタ(UI上)で、前項でつくったオブジェクトをバインドする。
//     // （次項 : インスペクタでscriptを追加して、設定をする で説明）
//     public Canvas window;
//     public Text target;

//     // 接触判定
//     private bool isContacted = false;
//     private IEnumerator coroutine;


//     // colliderをもつオブジェクトの領域に入ったとき(下記で説明1)
//     private void OnTriggerEnter2D(Collider2D collider) {
//         isContacted = collider.gameObject.tag.Equals("Player");
//     }

//     // colliderをもつオブジェクトの領域外にでたとき(下記で説明1)
//     private void OnTriggerExit2D(Collider2D collider) {
//         isContacted = !collider.gameObject.tag.Equals("Player");
//     }

//     private void FixedUpdate() {
//         if (isContacted && coroutine == null && Input.GetButton("Submit") && Input.anyKeyDown) {
//             coroutine = CreateCoroutine();
//             // コルーチンの起動(下記説明2)
//             StartCoroutine(coroutine);
//         }
//     }

//     /**
//      * リアクション用コルーチン(下記で説明2)
//      */
//     private IEnumerator CreateCoroutine() {
//         // window起動
//         window.gameObject.SetActive(true);

//         // 抽象メソッド呼び出し 詳細は子クラスで実装
//         yield return OnAction();

//         // window終了
//         this.target.text = "";
//         this.window.gameObject.SetActive(false);

//         StopCoroutine(coroutine);
//         coroutine = null;
//     }

//     protected abstract IEnumerator OnAction();

//     /**
//      * メッセージを表示する
//      */
//     protected void showMessage(string message) {
//         this.target.text = message;
//     }
// }
