//using System;
//using static System.Console;
////사용한다. 메모리를 할당해서 System 네임스페이스에 있는 Console 이란 메서드를
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06_17CSharp //네임스페이스 클래스를 담는 공간
//{
//    internal class MainApp //클래스 관련된 변수와 메서드를 묶은것
//    {
//        //메인 메서드(함수) : 메서드란 특정기능르 갖고 있는 공간
//        // 메인 메서드는 프로그램을 시작하는 기능을 갖고 있는 메서드
//        static void Main(string[] args) // 프로그램 진입점 시작점
//        {
//            #region 저번시간 복습 연결자에 대한 내용과 종류
//            //cw tab
//            //WriteLine("이름 : {0} 나이 : {1}","kim",33);
//            //WriteLine($"이름 : {"Kim"} 나이 : {33}");
//            //WriteLine("이름 : " + "Kim " + "나이 : " + 33);
//            #endregion
//            #region C#기초 이스케이프 시퀀스 
//            //WriteLine("Hi~~\t Hello");
//            //WriteLine("하하 \n 하 '\' 하하하 '\' 하하 하");
//            #endregion
//            #region 변수에 대하여
//            //선언과 동시에 초기화
//            int num1 = 20, num2 = 50;
//            WriteLine($"{ num1}, {num2}");
//            //int n1, n2; //변수 선언만 했다.
//            //Write("정수 두개 입력 : ");
//            //n1 = int.Parse(ReadLine()); //입력 값으로 초기화
//            //n2 = int.Parse(ReadLine());
//            //WriteLine($"n1 : {n1} n2 : {n2}");
//            //Write("실수 두개 입력 : ");
//            //float fnum1 = float.Parse(ReadLine());
//            //float fnum2 = float.Parse(ReadLine());
//            //WriteLine($"실수 두개 출력 : {fnum1}, {fnum2}");
//            double dnum1 = 2.00026789d , dnum2 = 3.1515234567123d ;
//            WriteLine($"{dnum1},{dnum2}");
//            float fnum1 = 3.141512345f, fnum2 = 1.23456789123456f;
//            WriteLine($"{fnum1}, {fnum2}");
//            decimal dmnum1 = 12.0000000000000000000123456789m;
//            WriteLine($"{dmnum1}");
//            #endregion
//        }
//    }
//}
