using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour
{
    public GameObject target; // 追蹤的目標（在Unity中拖曳指定）
    private Vector3 offset; // 與目標的座標差異


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 遊戲執行時，一直將自己座標設為：目標座標 + 差異數
        transform.position = target.transform.position + offset;
    }
}
