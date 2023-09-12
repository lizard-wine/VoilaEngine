using VoilaEngine;

public class CameraBehaviour : MonoBehaviour
{   

    public CameraBehaviour(GameObject parent): base(parent){}

    public GameObject target{ get; set; }
    public Transform transform;

    public override void Awake(){
        transform = Parent.GetComponent<Transform>();
    }
    public override void LateUpdate(){
        transform.position = target.transform.position;
    }
}
