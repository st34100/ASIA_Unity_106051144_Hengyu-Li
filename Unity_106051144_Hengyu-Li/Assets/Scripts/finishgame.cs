using UnityEngine;
using UnityEngine.SceneManagement;


public class finishgame : eat
{
    [Header("結束提示")]
    public GameObject objfin;

    private void OnTriggerEnter(Collider other)
    {

        if (eat.finish == true)
        {
            objfin.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {

        objfin.SetActive(false);

    }

    private void Update()
    {
        Gameover();
    }


    private void Gameover()
    {
        if (eat.finish)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("遊戲場景");
            }
        }
    }

}
