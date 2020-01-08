using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eatprop : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (finish)
        { 
            if (Input.GetKey(key:KeyCode.Escape))
            {
                Application.Quit();
            }    
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Hengyu-Li");
            }
        }
    
    
    
    }
    public int propCount;
    public int propTotal = 10;









    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
