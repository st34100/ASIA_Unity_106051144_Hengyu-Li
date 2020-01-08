using UnityEngine;

public class outdoor : MonoBehaviour
{
    private string name = "出口門";
    private string content = "請找到10個寶箱，左邊的關卡1個，右邊9個";

    [Header("對話")]
    public DialogSystem ds;



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            ds.showdialog(content);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ds.hidedialog();
    }



}
