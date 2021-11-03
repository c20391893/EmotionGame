using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundText : MonoBehaviour
{
    public GameManager gm;

    public Text roundText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roundText.text = gm.round.ToString();
    }
}
