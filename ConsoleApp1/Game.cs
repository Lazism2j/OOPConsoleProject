using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Game
    {
        // 초기정보
        private static bool gameOver;  
        private static Dictionary<string, Scene> sceneDic;
        private static Scene nowScene;
        // 게임 시작
        public static void Start()
        {
            gameOver = false;
            // 씬들을 딕셔너리로 관리
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Start", new StartScene());
            sceneDic.Add("FrontHome", new FrontHome());



            nowScene = sceneDic["Title"];
        }

        public static void ChangeScene(string sceneName)
        {
            nowScene = sceneDic[sceneName];
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

        }
    }
}
