using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class kelincikejar : MonoBehaviour {

    public GameObject target;
    public float ratio = 0.05f;
	// Use this for initialization

    public bool isDead;
    public GameObject restartText;

	
	void Start () {
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("ldg");
            
        }
       // anim = GetComponent<Animator>();
      //  rb = GetComponent<Rigidbody2D>();
       
	}
    //IEnumerator ImmuneTime()
    //{
    //    yield return new WaitForSeconds(immuneTime);
    //    isImmune = false;

    // //   anim.SetBool("Immune", false);
    //}
        
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, ratio);
        //SceneManager.LoadScene("misigagal");
        if (isDead == true) {

        //    restartText.SetActive(true);
            SceneManager.LoadScene("misigagal");
		
                        //if (Input.GetButtonDown ("Restart"))
                        //        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			
			
                        //return;
			
				}

	}
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "ldg" && !isDead)
        {
          //  rb.velocity = Vector2.zero;
           // lives = 0;
            StartCoroutine("ImmuneTime");
          //  anim.SetBool("Dies", true);
           // rb.AddForce(new Vector2(0, 500));
            isDead = true;


        }
        else if (other.tag == "ldg")
        {
           // lives--;
          //  anim.SetBool("Immune", true);
          //  StartCoroutine("ImmuneTime");
         //   isImmune = true;
        }

    }



    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "ldg" && !isDead )
        {
           // rb.velocity = Vector2.zero;
           // lives = 0;
       //     anim.SetBool("Dies", true);
        //    rb.AddForce(new Vector2(0, 500));
            isDead = true;


        }
        else if (other.gameObject.tag == "ldg")
        {
         //   lives--;
         //   anim.SetBool("Immune", true);
         //   isImmune = true;
        }

    }





    void OnCollisionEnter2D(Collision2D other)
    {
      //  outsideForce = false;


       // if (other.gameObject.tag == "Platform")
         //   BaseSpeed = other.gameObject.GetComponent<Rigidbody2D>().velocity.x;


    }

}

