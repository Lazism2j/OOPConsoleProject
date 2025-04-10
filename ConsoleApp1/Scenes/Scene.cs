using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Scene
    {
        public string name;
        public bool field = true;
        // 씬 그리기
        public abstract void Render();
        // 입력 받기
        protected ConsoleKey input;
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        // 입력 결과
        public abstract void Update();
        // 씬 변경 혹은 게임오버
        public abstract void Next();
        
        // 씬 진입 시 설정
        public virtual void Enter() { }
        // 씬 탈출 시 설정
        public virtual void Exit(bool IsField) { }
    }
}
