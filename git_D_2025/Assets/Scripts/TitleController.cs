using UnityEngine;
using UnityEngine.SceneManagement; // シーン遷移に必須

public class TitleController : MonoBehaviour
{
    // Startボタンが押された時の処理
    public void OnStartButtonClicked()
    {
        // メインシーンをロードする
        SceneManager.LoadScene("main");
    }

    // Exitボタンが押された時の処理
    public void OnExitButtonClicked()
    {
        // エディタ上での実行を停止（テスト用）
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            // ビルド後のアプリを終了
            Application.Quit();
        #endif
    }
}