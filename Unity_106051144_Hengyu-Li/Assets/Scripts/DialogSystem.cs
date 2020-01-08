using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Text textcontent;
    public CanvasGroup uigroup;


    /// <summary>
    /// 顯示對話框，並更新內容
    /// </summary>
    /// <param name="getcontent">取得內容</param>
    public void showdialog(string getcontent)
    {
        uigroup.alpha = 1;

        textcontent.text = getcontent;
    }

    public void hidedialog()
    {
        uigroup.alpha = 0;


    }
}
