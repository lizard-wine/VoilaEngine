using System;
using System.Collections.Generic;
using VoilaEngine;

namespace VoilaEngine{
    public class Transform : ComponentBase{
        public Vector2 position { get; set; }
        public Vector2 scale { get; set; }
        public Vector3 rotation { get; set; }
        public Transform(){
            position = new Vector2(0,0);
            scale = new Vector2(1,1);
            rotation = new Vector3(0,0,0);
        }
    }
}