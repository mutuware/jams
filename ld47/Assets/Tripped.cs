using UnityEngine;

public class Tripped : MonoBehaviour
{
    public GameObject Leaves;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static int leafIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (leafIndex < Leaves.transform.childCount)
            {
                Leaves.transform.GetChild(leafIndex).gameObject.GetComponent<Rigidbody>().useGravity = true;
                leafIndex++;
            }
        }
    }
}
