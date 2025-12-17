using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("UI設定")]
    [SerializeField] private Text scoreText; // 数字を表示するテキストをドラッグ&ドロップ

    private int score = 0; // 現在の数値

    void Start()
    {
        // ゲーム開始時に表示をリセット（0を表示）
        UpdateScoreText();
    }

    // Addボタンが押された時の処理
    public void OnAddButtonClicked()
    {
        score++; // 数値を1増やす
        UpdateScoreText(); // UIを更新
    }

    // タイトルへ戻るボタンが押された時の処理
    public void OnReturnTitleButtonClicked()
    {
        SceneManager.LoadScene("Title");
    }

    // テキスト表示を更新する関数
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
        else
        {
            Debug.LogWarning("Score Textが割り当てられていません！");
        }
    }
}