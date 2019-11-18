using UnityEngine;

public class chicken : MonoBehaviour
{
    //小雞速度，跳高，對話內容，下蛋
    [Header("速度"), Range(0.01f, 100f)]
    public float speed = 1f;
    [Header("跳高"), Range(1, 100)]
    public int jump = 10;
    [Header("對話內容")]
    public string tlack = "咕咕咕咕";
    [Header("是否下蛋")]
    private bool egg;

    //開始動作
        private void Start()
    {
        print("遊戲開始!!");
    }
    private void Update()
    {
        print("咕咕咕咕~~");
    }
}
