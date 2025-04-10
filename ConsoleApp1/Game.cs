using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Scenes;

namespace ConsoleApp1
{
    public static class Game
    {
        // 초기정보
        public static bool gameOver;  
        private static Dictionary<string, Scene> sceneDic;
        private static Scene nowScene;
        public static Scene prvScene; 
        public static string nowSceneName;
        public static bool IsField;
       
        private static Player player;
        public static Player Player { get { return player; } }
        
        // 게임 시작
        public static void Start()
        {
            gameOver = false;
            // 플레이어 설정
            player = new Player();
            Player.Hp = 10;
            Player.money = 10000;
            Player.bag = new Inventory();
            Player.basket = new Inventory();

            // 씬들을 딕셔너리로 관리
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Start", new StartScene());
            sceneDic.Add("FrontHome", new FrontHome());
            sceneDic.Add("PlayGround", new PlayGround());
            sceneDic.Add("FrontConven", new FrontConvene());
            sceneDic.Add("ConvenStore", new ConvenStore());
            sceneDic.Add("ConvenStand", new ConvenStand());
            sceneDic.Add("FrontMart", new FrontMart());
            sceneDic.Add("Mart", new Mart());
            sceneDic.Add("MeatAndFish", new MeatAndFish());
            sceneDic.Add("Refrigerator", new Refrigerator());
            sceneDic.Add("Vegetable", new Vegetable());
            sceneDic.Add("Home", new Home());



            nowScene = sceneDic["Title"];

          
        }

        public static void ChangeScene(string sceneName)
        {
            
            prvScene = nowScene;
            IsField = sceneDic[sceneName].field;
            nowScene.Exit(IsField);
            nowScene = sceneDic[sceneName];
            nowSceneName = nowScene.name;
            nowScene.Enter();
        }
        // 게임 진행
        public static void Run() 
        {
            while (gameOver == false)
            { 
                Console.Clear();
                nowScene.Render();

                nowScene.Input();

                nowScene.Update();
                nowScene.Next();
            }
        
        }
        // 게임 종료
        public static void End()
        {
            // 체력으로 Clear와 GameOver 구분
            if (player.Hp == 0)
            {
                Console.Clear();
                Console.WriteLine("너무 오래 돌아다녀 그만 지쳐버렸다.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("성공적으로 심부름을 해냈다!!");
            }
        }
    }
}
