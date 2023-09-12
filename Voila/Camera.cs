using VoilaEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace VoilaEngine
{
    public class Camera : GameObject{
        protected Scene _scene;
        protected View _view;
        public Camera(Scene scene, int width, int height){
            _scene = scene;
            _view = new View(new FloatRect((float)transform.position.x, (float)transform.position.y, width, height));
        }
        public override void LateUpdate(RenderWindow scene){
            base.LateUpdate(scene);
            _scene.SetView(_view);
            _view.Center = new Vector2f((float)transform.position.x, (float)transform.position.y);
        }
    }
}