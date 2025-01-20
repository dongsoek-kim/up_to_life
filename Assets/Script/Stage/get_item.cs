using UnityEngine;

public class get_item : MonoBehaviour
{
    int hp;
    void Update()
    {
        hp = Gamemanager.instance.ch_happiness;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "item")
        {
            int item_num = collision.gameObject.GetComponent<Item_sprite>().item_num;
            Gamemanager.instance.Get_item(item_num);
            Destroy(collision.gameObject);
        }
    }
}
