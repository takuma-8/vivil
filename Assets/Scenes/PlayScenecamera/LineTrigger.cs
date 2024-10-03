using UnityEngine;

public class LineTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // プレイヤーのタグを確認
        if (other.CompareTag("Player"))
        {
            // プレイヤーが触れた時の処理
            Debug.Log("プレイヤーがラインに触れました。");
            

            // 他の処理をここに追加
        }
    }
}