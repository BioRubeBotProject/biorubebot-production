using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_Receptor_Script : MonoBehaviour {

    public GameObject _ActiveRightReceptor;



	private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ECP")
        {
            Debug.Log(string.Format("Entered OnTriggerEnter2D yayayayayaya!!!!"));
            ExternalReceptorProperties objProps = (ExternalReceptorProperties)this.GetComponent("ExternalReceptorProperties");
            objProps.isActive = false;
            other.GetComponent<ExtraCellularProperties>().changeState(false);
            other.GetComponent<Rigidbody2D>().isKinematic = true;
            StartCoroutine(transformReceptor(other));
        }
    }

    private IEnumerator transformReceptor(Collider2D other)
    {
        yield return new WaitForSeconds(2);
        GameObject NewReceptor = (GameObject)Instantiate(_ActiveRightReceptor, transform.position, transform.rotation);
        GameObject.Find("EventSystem").GetComponent<ObjectCollection>().Add(NewReceptor);
        this.gameObject.SetActive(false);
    }
}
