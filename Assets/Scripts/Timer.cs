using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text display_timer;
    public int time;
    void Start()
    {
        StartCoroutine(updateTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator updateTime(){
        while(time>=0){
            display_timer.text=time.ToString();
            yield return new WaitForSeconds(1f);
            time--;
        }
    }
}
