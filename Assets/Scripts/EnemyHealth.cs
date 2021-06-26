using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject effectPrefab1;
    [SerializeField]
    private GameObject effectPrefab2;
    public int PlayerHP;
    public Slider HPSlider;
    // Start is called before the first frame update
    void Start()
    {
        HPSlider.value = PlayerHP;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")

        {
            PlayerHP -= 1;


            // ★追加
            HPSlider.value = PlayerHP;

            //Destroy(gameObject);

            if (PlayerHP > 0)
            {
                GameObject effect1 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);

            }
            else
            {
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);



                this.gameObject.SetActive(false);
            }
        }
    }

    
}
