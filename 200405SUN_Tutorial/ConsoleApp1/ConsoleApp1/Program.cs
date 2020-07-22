using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)  
            /*
            모든 C# 프로그램은 Main이라는 시작 함수(메소드)를 갖는다.
            Main() 메소드는 임의의 클래스 안에서 존재하며 프로그램 상에서 1개만 있어야 함.
            Main()은 static으로 선언되고, 메소드 인자는 string[] 문자열이다.

            */
        {
            System.Console.WriteLine("Hello World!");
            /*
             System.Console은 .NET Framework 클래스임.
             WriteLine은 화면 상에 데이터를 Console 클래스에 출력하는 메소드이다.
             */
        }
    }
}

//C#의 주석처리는 한 줄인 경우에는 //로 처리한다.
/*
  주석이 여러 줄인 경우에는
  이렇게 앞뒤로 기호를 넣어준다
 */
