using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class dusmanScript : MonoBehaviour
{
    public Transform player;
    NavMeshAgent mesh;
    public Transform zombi;
    public GameObject playerr;

    public float can = 100.0f;
    public GameObject failPanel;
    public GameObject succsessPanel;

    public UnityEngine.UI.Image canBari;
    public float guncelCan = 100.0f;
    public float sayac;

    // Start is called before the first frame update
    void Start()
    {
         mesh = GetComponent<NavMeshAgent>();
        Time.timeScale = 1f;
        
        
    }

    public void reload_btn()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        //Time.timeScale = 1.0f;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="playerr")
        {
            
           failPanel.SetActive(true);
            guncelCan -= 100f * Time.deltaTime;
            Time.timeScale = 0.0f;

        }
    }


    // Update is called once per frame
    void Update()
    {
        



        mesh.destination = player.position;

        if((player.position - zombi.position).magnitude<6)
        {
            Debug.Log("--can");

            guncelCan -= 15f*Time.deltaTime;
            canBari.fillAmount = guncelCan / can;
        }
        //zombi ve playerin pozisyon yakınlıklarını birbirinin farkını alıp yakınlığını kontrol ediyor
        if ((player.position - zombi.position).magnitude > 6)

        {

            guncelCan += 20f * Time.deltaTime;
            canBari.fillAmount = guncelCan / can;
            Debug.Log("++can");
        }
        
        if(guncelCan<=0)
        {
            failPanel.SetActive(true);
            //Time.timeScale = 0.0f;
        }
        //zamanı kontrol ediyor
        sayac += Time.deltaTime;
        if (sayac >= 20)
        {

            if (guncelCan >= 100)
            {
                Time.timeScale = 0.0f;
                succsessPanel.SetActive(true);
            }

        }

        //10saniye olup olmadığını kontrol ediyor
        if (sayac >= 60)
        {

            if (guncelCan >= 100)
            {
                Time.timeScale = 0.0f;
                succsessPanel.SetActive(true);
            }

        }




    }
}
