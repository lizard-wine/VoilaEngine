using System;
using System.Collections.Generic;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using VoilaEngine;

namespace VoilaEngine{
    public class SpriteRenderer : ComponentBase{
        Texture texture;
        Sprite sprite;

        public SpriteRenderer(string path){
            texture = new Texture(path);
            sprite = new Sprite(texture);            
        }

        public void Update(RenderWindow scene, Transform transform){
            sprite.Position = new Vector2f((float)transform.position.x, (float)transform.position.y);
            scene.Draw(sprite);
        }
    }
}