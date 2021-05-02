﻿using UnityEngine;

public class Player : MonoBehaviour
{
    #region //角色動作
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;
    [Range(0, 200)]
    public float hp = 100;
    [Header("是否在地板上"), Tooltip("儲存角色是否在地板上")]
    public bool isGrounded;
    [Header("子彈"), Tooltip("角色要發射的子彈物件")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("生成子彈的位置")]
    public Transform bulletPoint;
    [Range(0, 5000)]
    public int bulletSpeed = 800;
    [Header("開槍音效"), Tooltip("開槍的聲音")]
    public AudioClip bulletSound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;

    #endregion

    #region 方法

    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        
    }

    ///<summary>跳躍</summary>
    private void Jump()
    {

    }

    ///<summary>開槍</summary>

    private void Fire()
    {
        
    }

    ///<summary>受傷</summary>
    private void Hit(float Damage)
    {
        
    }

    ///<summary>死亡</summary>
    private bool Dead()
    {
        return false;
    }

   
    #endregion
}
