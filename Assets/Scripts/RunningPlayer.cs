using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningPlayer : MonoBehaviour
{
    public Animator ani;
    public bool isRight = true;
    private Rigidbody2D rb;
    private bool isGround;
    public GameObject PSBrick;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            isRight = true;
            ani.SetBool("isRunning", true);
            transform.Translate(Time.deltaTime * 4,0,0);
            Vector2 scale = transform.localScale;
            scale.x *= scale.x > 0 ? 1 : -1;
            transform.localScale = scale;
        }else if (Input.GetKey(KeyCode.LeftArrow)) {
            isRight = false;
            ani.SetBool("isRunning", true);
            transform.Translate(-Time.deltaTime * 4,0,0);
            Vector2 scale = transform.localScale;
            scale.x *= scale.x > 0 ? -1 : 1;
            transform.localScale = scale;
        }else {
            ani.SetBool("isRunning", false);
            ani.Play("IdlePlayer");
        }

        if (isGround) {

        if (Input.GetKey(KeyCode.Space)) {
            GameController.instance.jumpSound.Play();
            if (isRight) {
                //transform.Translate(0,Time.deltaTime * 10,0);
                rb.AddForce(new Vector2(0, 350));
                Vector2 scale = transform.localScale;
                scale.x *= scale.x > 0 ? 1 : -1;
                transform.localScale = scale;
            }else {
                //transform.Translate(0,Time.deltaTime * 10,0);
                rb.AddForce(new Vector2(0, 350));
                Vector2 scale = transform.localScale;
                scale.x *= scale.x > 0 ? -1 : 1;
                transform.localScale = scale;
            }
            isGround = false;
        }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Ground") {
            isGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "TopMushroom") {
            var name = collision.attachedRigidbody.name;
            Destroy(GameObject.Find(name));
            GameController.instance.killSound.Play();
        }
        if (collision.gameObject.tag == "LeftMushroom") {
            Time.timeScale = 0; // stop scane
            ani.SetBool("isDie", true);
            ani.Play("DiePlayer");
            GameController.instance.check(true);
        }
        if (collision.gameObject.tag == "Obstacle") {
            Time.timeScale = 0; // stop scane
            ani.SetBool("isDie", true);
            ani.Play("DiePlayer");
            GameController.instance.check(true);
        }
        if (collision.gameObject.tag == "Door") {
            Instantiate(PSBrick,
                collision.gameObject.transform.position,
                collision.gameObject.transform.localRotation);
        }
    }

}
