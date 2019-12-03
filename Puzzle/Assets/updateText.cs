using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updateText : MonoBehaviour
{
    private TextMeshProUGUI txt;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = num.ToString();
        num ++;
    }
}
