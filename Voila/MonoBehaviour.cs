using System;
using System.Collections.Generic;
using VoilaEngine;

namespace VoilaEngine{
    public class MonoBehaviour : ComponentBase{
        public GameObject Parent;
        public MonoBehaviour(GameObject parent){
            Parent = parent;
            parent.AddComponent<MonoBehaviour>(this);
        }

        public virtual void Awake(){
            
        }
        public virtual void Start(){
            
        }
        public virtual void Update(){

        }
        public virtual void LateUpdate(){

        }

    }
}