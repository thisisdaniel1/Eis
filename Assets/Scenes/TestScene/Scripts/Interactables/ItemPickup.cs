using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public bool isHealth;
    public bool isArmor;
    public bool isAmmo;

    public int amount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            if (isHealth){
                other.GetComponent<PlayerHealth>().GiveHealth(amount, this.gameObject);
                //other.GetComponent<PhotonView>().RPC("GiveHealth", RpcTarget.All, amount, this.gameObject);
            }
            if (isArmor){
                other.GetComponent<PlayerHealth>().GiveArmor(amount, this.gameObject);
                //other.GetComponent<PhotonView>().RPC("GiveArmor", RpcTarget.All, amount, this.gameObject);
            }
            if (isAmmo){
                other.GetComponentInChildren<WeaponBox>().GiveAmmo(amount, this.gameObject);
            }
        }
    }
}
