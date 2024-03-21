using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 첫 번째 C# 프로그램 실행
            Console.WriteLine("Hello World?! 안녕 세상아!");

            // 변수 선언 및 사용
            string aFriend = "Bill";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            aFriend = "Maira";
            Console.WriteLine(aFriend);

            Console.WriteLine("Hello " + aFriend);

            // 문자열 보간
            Console.WriteLine($"Hello {aFriend}");

            // 더 많은 문자열 작업
            // Trim
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // 바꾸기
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // 검색 문자열
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // 과제
            /*문자열 내 하위 문자열을 검색하는 두 개의 유사한 메서드 StartsWith 및 EndsWith가 있습니다.이러한 메서드는 문자열의 시작;
            또는 끝 부분에 있는 하위 문자열을 찾습니다.이전 샘플을 수정하여 Contains 대신 StartsWith 및 EndsWith를 사용해 보세요. 
            문자열의 시작 부분에서 “You” 또는 “goodbye”를 검색합니다. 문자열 끝 부분에서 “hello” 또는 “goodbye”를 검색합니다.*/

            songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

        }
    }
}
