using System;
using System.Collections;
using System.Collections.Generic;
using VoilaEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace VoilaEngine{
    public class Scene{
        public RenderWindow scene;
        private List<GameObject> sceneObjects;
        private Clock clock;
        public Scene(int width, int height, string title){
            if(width < 0 || height < 0){
                throw new ArgumentException();
            }
            scene = new RenderWindow(new VideoMode((uint)width, (uint)height), title);
            sceneObjects = new List<GameObject>();
            clock = new Clock();
        }

        public void Add(GameObject gameObject){
            sceneObjects.Add(gameObject);
        }

        public void SetView(View view){
            scene.SetView(view);
        }

        public void SetFrameRate(int frameRate){
            scene.SetFramerateLimit((uint)frameRate);
        }

        public void Start(){
            scene.Closed += (sender, e) => scene.Close();

            // Execute all awake events
            foreach(GameObject gameObject in sceneObjects){
                gameObject.Awake();
            }

            // Execute all start events
            if(scene.IsOpen){
                scene.DispatchEvents();
                scene.Clear();
                foreach(GameObject gameObject in sceneObjects){
                    gameObject.Start(scene);
                }
                scene.Display();
            }

            while(scene.IsOpen){
                scene.DispatchEvents();
                scene.Clear();
                Time.deltaTime = clock.Restart().AsSeconds();
                // Execute all update events
                foreach(GameObject gameObject in sceneObjects){
                    gameObject.Update(scene);
                }
                foreach(GameObject gameObject in sceneObjects){
                    gameObject.LateUpdate(scene);
                }
                
                scene.Display();
            }
        }
    }
}
