using System;
using VoilaEngine;

public class Program{
    public static void Main(){
        Scene scene = new Scene(1200,720, "Voila Exmaple");
        Camera camera = new Camera(scene, 1200, 720);
        CameraBehaviour cameraBehaviour = new CameraBehaviour(camera);
        GameObject player = new GameObject();
        player.AddComponent(new SpriteRenderer("Assets/Vash.png"));
        PlayerController playerController = new PlayerController(player);
        cameraBehaviour.target = player;

        scene.Add(camera);
        scene.Add(player);
        scene.SetFrameRate(60);
        scene.Start();
    }
}