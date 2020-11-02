using UnityEngine;

public class SpwanLeaves : MonoBehaviour
{
    public GameObject Leaf;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var go = Instantiate(Leaf, this.transform);
            go.transform.position = new Vector3(go.transform.position.x + Random.Range(-1, 1), go.transform.position.y + Random.Range(1f, 1f), go.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
