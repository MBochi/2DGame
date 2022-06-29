using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{
    public Text counterText;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowKills();
    }
    private void ShowKills(){
        counterText.text = counter.ToString();
    }
    public void AddKill(){
        counter++;
    }
}
