using UnityEngine;
using UnityEngine.UI;

public class eat : MonoBehaviour
{
    [Header("寶箱數量")]
    public Text textcount;
    [Header("勝利提示")]
    public GameObject obj;
    public GameObject objdoor;

    static public bool finish;
    public int propcount;
    public int proptotal = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "寶箱")
        {
            Destroy(collision.gameObject);

            propcount++;
            textcount.text = "寶箱" + propcount + "/10";




            if (propcount == proptotal)
            {
                finish = true;
                obj.SetActive(true);
                Destroy(objdoor);
            }
        }
    }


    private void OnCollisionExit(Collision collision)
    {
        obj.SetActive(false);
    }
}
