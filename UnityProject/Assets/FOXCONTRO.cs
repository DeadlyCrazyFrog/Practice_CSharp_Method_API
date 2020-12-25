using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOXCONTRO : MonoBehaviour
{
    public SpriteRenderer sr;
    public Rigidbody2D rig;
    [Header("移動速度"), Range(0f, 50f)]
    public float speed = 30f;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //試作跳躍s
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            rig.AddForce(transform.up * 20, ForceMode2D.Impulse);

        }
    }
    void FixedUpdate()
    {
        移動();
    }
    void 移動()
    {
        float dir = Input.GetAxisRaw("Horizontal");
        rig.AddForce(new Vector2(dir * speed, 0));
        //BOOL值判斷
        sr.flipX = (dir < 0);


    }
}


