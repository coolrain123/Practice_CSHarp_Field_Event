using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    [Header("移動速度"), Range(0.00001f, 3f)]
    public float speed = 0.1f;
    [Header("跳躍高度"), Range(1, 10)]
    public int count = 5;

    [Header("對話內容")]
    public string talk ;

    [Header("是否取得雞蛋")]
    public bool 是;

    // Start is called before the first frame update
    void Start()
    {
        print("Start!!!");

        print(talk);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
