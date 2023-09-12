using System;
using System.Collections.Generic;
using VoilaEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;


namespace VoilaEngine
{
    public class GameObject{

        public Transform transform {get; set;}
        private Dictionary<Type, List<ComponentBase>> components = new Dictionary<Type, List<ComponentBase>>();

        public T GetComponent<T>() where T : ComponentBase
        {
            Type componentType = typeof(T);
            if (components.ContainsKey(componentType) && components[componentType].Count > 0)
            {
                return components[componentType][0] as T;
            }
            return null;
        }

        public List<T> GetComponents<T>() where T : ComponentBase
        {
            Type componentType = typeof(T);
            if (components.ContainsKey(componentType))
            {
                return components[componentType].Cast<T>().ToList();
            }
            return new List<T>();
        }

        public void AddComponent<T>(T component) where T : ComponentBase
        {
            Type componentType = typeof(T);
            if (!components.ContainsKey(componentType))
            {
                components.Add(componentType, new List<ComponentBase>());
            }
            components[componentType].Add(component);
        }

        public GameObject(){
            transform = new Transform();
            AddComponent<Transform>(transform);
        }
        public virtual void Awake(){
            foreach(MonoBehaviour script in GetComponents<MonoBehaviour>()){
                script.Awake();
            }
        }
        public virtual void Start(RenderWindow scene){
            foreach(MonoBehaviour script in GetComponents<MonoBehaviour>()){
                script.Start();
            }
            if(GetComponent<SpriteRenderer>() != null){
                GetComponent<SpriteRenderer>()?.Update(scene, transform);
            }
        }
        public virtual void Update(RenderWindow scene){
            if(GetComponent<SpriteRenderer>() != null){
                GetComponent<SpriteRenderer>()?.Update(scene, transform);
            }
            foreach(MonoBehaviour script in GetComponents<MonoBehaviour>()){
                script.Update();
            }
        }
        public virtual void LateUpdate(RenderWindow scene){
            foreach(MonoBehaviour script in GetComponents<MonoBehaviour>()){
                script.LateUpdate();
            }
        }
    }
}