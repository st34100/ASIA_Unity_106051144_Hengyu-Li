using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("動畫參數")]
    public string parRun = "跑步開關";
    public string parJump = "跳躍開關";
    public string parAttack = "攻擊觸發";
    public string parDamage = "受傷觸發";
    public string parDeath = "死亡開關";
    [Header("道具")]
    public int countNeed = 10;
    public int countCurrent;
    [Header("數值")]
    public bool isDead;
    [Range(0, 500)]
    public float hp = 100;
    #endregion
    public Animator ani;

    #region 方法區域
    //開始後執行
    private void Start()
    {

    }

    /// <summary>
    /// 跑步
    /// </summary>
    public void Run()
    {
        // print(Input.GetAxis("Horizontal")); //水平 A左-1  D右1 沒按0
        // print(Input.GetAxis("Vertical")); //垂直 W前1  S後-1 沒按0

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetBool("跳躍開關", true);
        }
        else
        {
            ani.SetBool("跳躍開關", false);
        }
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ani.SetTrigger("攻擊觸發");
        }
    }
    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收傷害值</param>
    public void Damage(float damage)
    {

    }
    /// <summary>
    /// 死亡
    /// </summary>
    public void Death()
    {

    }
    /// <summary>
    /// 吃道具
    /// </summary>
    public void EatProp()
    {

    }
    /// <summary>
    /// 過關
    /// </summary>
    public void Pass()
    {

    }

    //每秒60次
    private void Update()
    {
        Run();
        Jump();
       


    }
    #endregion




}